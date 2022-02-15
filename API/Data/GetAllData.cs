using System;
using System.Linq;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.Entity.Infrastructure;
using System.Data.Entity;
using API.Entities;

namespace API.Data
{
    public class GetAllData
    {
        public static List<GoalsInStadium> GetData(DataContext context){
           var games = context.Games.ToList();
           var goals = context.Goals.ToList();

            var listOfStadiums = games.GroupBy(game => game.stadium);
            var goalsInStadium = new List<GoalsInStadium>();

            foreach(var item in listOfStadiums){
                var memberGoalsInStadium = new GoalsInStadium();
                memberGoalsInStadium.stadium = item.Key;
                goalsInStadium.Add(memberGoalsInStadium);
            }

            foreach(var member in goalsInStadium){
                foreach(var game in games){
                    if(member.stadium == game.stadium){
                        var searchCount = goals.Where(x => x.matchid == game.Id).Count();
                        member.Count += searchCount;
                    }
                }
            }

            return(goalsInStadium);
        }
    }
}