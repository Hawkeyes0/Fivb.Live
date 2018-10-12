using FivbLive.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace FivbLive.Service
{
    class LivesService
    {
        public static LivesService Me { get; set; } = new LivesService();

        private const string BaseUrl = "http://japan2018.fivb.com";
        private const string ApiUrl = "/en/api/volley/matches/WWCH2018/en/user/lives";
        private readonly WebClient _client = new WebClient();

        private const string TestData =
                @"[{""TeamA"":{""Code"":""JPN"",""Name"":""Japan"",""Url"":""/en/competition/teams/jpn-japan"",""flagUrl"":""/-/media/flags/flag_jpn.png?h=60&thn=0&w=60&hash=8C9430CE54136E660DFBD2FB8BC5726C""},""TeamB"":{""Code"":""BRA"",""Name"":""Brazil"",""Url"":""/en/competition/teams/bra-brazil"",""flagUrl"":""/-/media/flags/flag_bra.png?h=60&thn=0&w=60&hash=767D30FB1B78163C945545850DF8F724""},""Status"":""Live"",""Url"":""/en/schedule/9241-japan-brazil/match"",""City"":""Nagoya"",""CountryName"":""Japan"",""Round"":{""Name"":""Pool E""},""Id"":9241,""MatchPointsA"":2,""MatchPointsB"":0,""TotalPointsA"":76,""TotalPointsB"":65,""Hours"":1,""Gender"":""Women"",""Minutes"":""38"",""Sets"":[{""Number"":1,""PointsA"":25,""PointsB"":23,""Hours"":0,""Minutes"":""35""},{""Number"":2,""PointsA"":25,""PointsB"":16,""Hours"":0,""Minutes"":""28""},{""Number"":3,""PointsA"":26,""PointsB"":26,""Hours"":0,""Minutes"":""35""}],""LiveStreamUri"":""https://welcome.volleyballworld.tv/""},{""TeamA"":{""Code"":""CHN"",""Name"":""China"",""Url"":""/en/competition/teams/chn-china"",""flagUrl"":""/-/media/flags/flag_chn.png?h=60&thn=0&w=60&hash=9CA00272EB5465FCE60315D18BA1065A""},""TeamB"":{""Code"":""RUS"",""Name"":""Russia"",""Url"":""/en/competition/teams/rus-russia"",""flagUrl"":""/-/media/flags/flag_rus.png?h=60&thn=0&w=60&hash=E6D2354B644B6D8C45BFA358D36FCAFE""},""Status"":""Live"",""Url"":""/en/schedule/9242-china-russia/match"",""City"":""Osaka"",""CountryName"":""Japan"",""Round"":{""Name"":""Pool F""},""Id"":9242,""MatchPointsA"":2,""MatchPointsB"":1,""TotalPointsA"":81,""TotalPointsB"":76,""Hours"":1,""Gender"":""Women"",""Minutes"":""39"",""Sets"":[{""Number"":1,""PointsA"":25,""PointsB"":22,""Hours"":0,""Minutes"":""30""},{""Number"":2,""PointsA"":21,""PointsB"":25,""Hours"":0,""Minutes"":""29""},{""Number"":3,""PointsA"":25,""PointsB"":23,""Hours"":0,""Minutes"":""31""},{""Number"":4,""PointsA"":10,""PointsB"":6,""Hours"":0,""Minutes"":""09""},{""Number"":5,""PointsA"":10,""PointsB"":6,""Hours"":0,""Minutes"":""09""}],""LiveStreamUri"":""https://welcome.volleyballworld.tv/""}]"
            ;

        public List<Match> GetLives()
        {
            //HttpClient client = new HttpClient();
            //string json = await client.GetStringAsync(BaseUrl + ApiUrl);
            //string json = _client.DownloadString(BaseUrl + ApiUrl);
            return JsonConvert.DeserializeObject<List<Match>>(TestData);
        }
    }
}
