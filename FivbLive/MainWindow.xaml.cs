using FivbLive.Models;
using FivbLive.Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Threading;

namespace FivbLive
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer _timer;
        private static readonly Thickness SetMargin = new Thickness(0, 6, 0, 6);

        public static readonly DependencyProperty MatchesProperty = DependencyProperty.Register(
            "Matches", typeof(ObservableCollection<Match>), typeof(MainWindow), new PropertyMetadata(default(ObservableCollection<Match>)));

        public ObservableCollection<Match> Matches
        {
            get => (ObservableCollection<Match>) GetValue(MatchesProperty);
            set => SetValue(MatchesProperty, value);
        }

        public MainWindow()
        {
            Matches = new ObservableCollection<Match>();
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _timer_Tick(null, null);
            _timer = new DispatcherTimer();
            _timer.Tick += _timer_Tick;
            _timer.Interval = new TimeSpan(0, 0, 15);
            _timer.Start();
        }

        private void _timer_Tick(object sender, EventArgs e)
        {
            List<Match> matches = LivesService.Me.GetLives();
            var except = Matches.Except(matches, new MatchComparer());
            foreach (Match item in except)
            {
                Matches.Remove(item);
            }
            foreach (Match match in Matches)
            {
                Match newer = matches.Find(i => i.Id == match.Id);
                match.MatchPointsA = newer.MatchPointsA;
                match.MatchPointsB = newer.MatchPointsB;
                match.Hours = newer.Hours;
                match.Minutes = newer.Minutes;
                foreach (Set item in newer.Sets)
                {
                    try
                    {
                        Set old = match.Sets[item.Number - 1];
                        old.PointsA = item.PointsA;
                        old.PointsB = item.PointsB;
                        old.Hours = item.Hours;
                        old.Minutes = item.Minutes;
                    }
                    catch
                    {
                        match.Sets.Add(item);
                    }
                }
            }
            except = matches.Except(Matches, new MatchComparer());
            foreach (Match item in except)
            {
                Matches.Add(item);
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _timer?.Stop();
        }
    }
}
