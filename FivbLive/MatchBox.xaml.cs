using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using FivbLive.Models;
using FivbLive.Service;

namespace FivbLive
{
    /// <summary>
    /// MatchBox.xaml 的交互逻辑
    /// </summary>
    public partial class MatchBox : UserControl
    {
        private static readonly Thickness SetMargin = new Thickness(6,0,6,0);
        private static readonly FontFamily SetFont = new FontFamily("Segoe UI");

        public MatchBox()
        {
            InitializeComponent();
        }

        public int Id => Match.Id;

        public static readonly DependencyProperty MatchProperty = DependencyProperty.Register(
            "Match", typeof(Match), typeof(MatchBox), new PropertyMetadata(default(Match)));

        public Match Match
        {
            get => (Match) GetValue(MatchProperty);
            set => SetValue(MatchProperty, value);
        }
    }
}
