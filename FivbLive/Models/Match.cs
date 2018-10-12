using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;

namespace FivbLive.Models
{
    public class Match : DependencyObject
    {
        public static readonly DependencyProperty TeamAProperty = DependencyProperty.Register(
            "TeamA", typeof(Team), typeof(Match), new PropertyMetadata(default(Team)));

        public Team TeamA
        {
            get => (Team)GetValue(TeamAProperty);
            set => SetValue(TeamAProperty, value);
        }

        public static readonly DependencyProperty TeamBProperty = DependencyProperty.Register(
            "TeamB", typeof(Team), typeof(Match), new PropertyMetadata(default(Team)));

        public Team TeamB
        {
            get => (Team)GetValue(TeamBProperty);
            set => SetValue(TeamBProperty, value);
        }

        public static readonly DependencyProperty StatusProperty = DependencyProperty.Register(
            "Status", typeof(string), typeof(Match), new PropertyMetadata(default(string)));

        public string Status
        {
            get => (string)GetValue(StatusProperty);
            set => SetValue(StatusProperty, value);
        }

        public static readonly DependencyProperty CityProperty = DependencyProperty.Register(
            "City", typeof(string), typeof(Match), new PropertyMetadata(default(string)));

        public string City
        {
            get => (string)GetValue(CityProperty);
            set => SetValue(CityProperty, value);
        }

        public static readonly DependencyProperty CountryNameProperty = DependencyProperty.Register(
            "CountryName", typeof(string), typeof(Match), new PropertyMetadata(default(string)));

        public string CountryName
        {
            get => (string)GetValue(CountryNameProperty);
            set => SetValue(CountryNameProperty, value);
        }

        public static readonly DependencyProperty RoundProperty = DependencyProperty.Register(
            "Round", typeof(Round), typeof(Match), new PropertyMetadata(default(Round)));

        public Round Round
        {
            get => (Round)GetValue(RoundProperty);
            set => SetValue(RoundProperty, value);
        }

        public static readonly DependencyProperty IdProperty = DependencyProperty.Register(
            "Id", typeof(int), typeof(Match), new PropertyMetadata(default(int)));

        public int Id
        {
            get => (int)GetValue(IdProperty);
            set => SetValue(IdProperty, value);
        }

        public static readonly DependencyProperty MatchPointsAProperty = DependencyProperty.Register(
            "MatchPointsA", typeof(int), typeof(Match), new PropertyMetadata(default(int)));

        public int MatchPointsA
        {
            get => (int)GetValue(MatchPointsAProperty);
            set => SetValue(MatchPointsAProperty, value);
        }

        public static readonly DependencyProperty MatchPointsBProperty = DependencyProperty.Register(
            "MatchPointsB", typeof(int), typeof(Match), new PropertyMetadata(default(int)));

        public int MatchPointsB
        {
            get => (int)GetValue(MatchPointsBProperty);
            set => SetValue(MatchPointsBProperty, value);
        }

        public static readonly DependencyProperty HoursProperty = DependencyProperty.Register(
            "Hours", typeof(int), typeof(Match), new PropertyMetadata(default(int)));

        public int Hours
        {
            get => (int)GetValue(HoursProperty);
            set => SetValue(HoursProperty, value);
        }

        public static readonly DependencyProperty MinutesProperty = DependencyProperty.Register(
            "Minutes", typeof(string), typeof(Match), new PropertyMetadata(default(string)));

        public string Minutes
        {
            get => (string)GetValue(MinutesProperty);
            set => SetValue(MinutesProperty, value);
        }

        public static readonly DependencyProperty SetsProperty = DependencyProperty.Register(
            "Sets", typeof(ObservableCollection<Set>), typeof(Match), new PropertyMetadata(default(List<Set>)));

        public ObservableCollection<Set> Sets
        {
            get => (ObservableCollection<Set>)GetValue(SetsProperty);
            set => SetValue(SetsProperty, value);
        }
    }

    public class Team : DependencyObject
    {
        public static readonly DependencyProperty CodeProperty = DependencyProperty.Register(
            "Code", typeof(string), typeof(Team), new PropertyMetadata(default(string)));

        public string Code
        {
            get => (string)GetValue(CodeProperty);
            set => SetValue(CodeProperty, value);
        }

        public static readonly DependencyProperty NameProperty = DependencyProperty.Register(
            "Name", typeof(string), typeof(Team), new PropertyMetadata(default(string)));

        public string Name
        {
            get => (string)GetValue(NameProperty);
            set => SetValue(NameProperty, value);
        }

        public static readonly DependencyProperty FlagUrlProperty = DependencyProperty.Register(
            "FlagUrl", typeof(string), typeof(Team), new PropertyMetadata(default(string)));

        [JsonProperty("flagUrl")]
        public string FlagUrl
        {
            get => (string)GetValue(FlagUrlProperty);
            set => SetValue(FlagUrlProperty, value);
        }
    }

    public class Round : DependencyObject
    {
        public static readonly DependencyProperty NameProperty = DependencyProperty.Register(
            "Name", typeof(string), typeof(Round), new PropertyMetadata(default(string)));

        public string Name
        {
            get => (string) GetValue(NameProperty);
            set => SetValue(NameProperty, value);
        }
    }

    public class Set : DependencyObject
    {
        public static readonly DependencyProperty NumberProperty = DependencyProperty.Register(
            "Number", typeof(int), typeof(Set), new PropertyMetadata(default(int)));

        public int Number
        {
            get => (int) GetValue(NumberProperty);
            set => SetValue(NumberProperty, value);
        }

        public static readonly DependencyProperty PointsAProperty = DependencyProperty.Register(
            "PointsA", typeof(int), typeof(Set), new PropertyMetadata(default(int)));

        public int PointsA
        {
            get => (int) GetValue(PointsAProperty);
            set => SetValue(PointsAProperty, value);
        }

        public static readonly DependencyProperty PointsBProperty = DependencyProperty.Register(
            "PointsB", typeof(int), typeof(Set), new PropertyMetadata(default(int)));

        public int PointsB
        {
            get => (int) GetValue(PointsBProperty);
            set => SetValue(PointsBProperty, value);
        }

        public static readonly DependencyProperty HoursProperty = DependencyProperty.Register(
            "Hours", typeof(int), typeof(Set), new PropertyMetadata(default(int)));

        public int Hours
        {
            get => (int) GetValue(HoursProperty);
            set => SetValue(HoursProperty, value);
        }

        public static readonly DependencyProperty MinutesProperty = DependencyProperty.Register(
            "Minutes", typeof(string), typeof(Set), new PropertyMetadata(default(string)));

        public string Minutes
        {
            get => (string) GetValue(MinutesProperty);
            set => SetValue(MinutesProperty, value);
        }

        public string GetSetPoints() => $"{PointsA} - {PointsB}";

        public string GetTime() => $"Set {Number}: {Hours}h {Minutes}m";
    }
}
