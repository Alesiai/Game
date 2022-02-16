using System;
using System.Linq;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.Entity.Infrastructure;
using System.Data.Entity;
using API.Entities;
using System.Collections.Generic;

namespace API.Data
{
    public class GetAllData
    {
        public static List<GoalsInStadium> GetData(DataContext context){
        var to_del = context.GoalsInStadia.Where(x => x.Id != null);
        context.GoalsInStadia.RemoveRange(to_del);

        var goalsInStadium = new List<GoalsInStadium>();
        
        var list = context.Games.Join(context.Goals,
            p=>p.Id,
            n=>n.matchid,
            (p,n)=>new
            {
                Stadium = p.stadium,
                Id = n.Id
            }
        ).GroupBy(info => info.Stadium)
                        .Select(group => new { 
                             Stadium = group.Key, 
                             Count = group.Count() 
                        });

        foreach (var item in list)
        {
            GoalsInStadium goal = new GoalsInStadium();
            goal.stadium = item.Stadium;
            goal.Count = item.Count;
            context.GoalsInStadia.Add(goal);
        }
        
        context.SaveChangesAsync();

        return(context.GoalsInStadia.ToList());
        }
    }
}