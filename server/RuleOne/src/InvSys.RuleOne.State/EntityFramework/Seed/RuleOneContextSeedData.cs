﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InvSys.RuleOne.Core.Models;
using InvSys.RuleOne.Core.Models.Management;
using InvSys.RuleOne.Core.Models.Moats;

namespace InvSys.RuleOne.State.EntityFramework.Seed
{
    public class RuleOneContextSeedData
    {
        private readonly RuleOneContext _db;

        public RuleOneContextSeedData(RuleOneContext financialsContext)
        {
            _db = financialsContext;
        }

        public async Task EnsureSeedData()
        {
            if (!_db.Ratings.Any())
            {
                var ratings = new List<Rating>
                {
                    new Rating
                    {
                        CompanySymbol = "MENT",
                        Date = DateTime.Now.AddDays(-1),
                        IsWonderful = true
                    },
                    new Rating
                    {
                        CompanySymbol = "MENT",
                        Date = DateTime.Now,
                        IsWonderful = false
                    },
                    new Rating
                    {
                        CompanySymbol = "EPAM",
                        Date = DateTime.Now.AddDays(-1),
                        IsWonderful = false
                    },
                    new Rating
                    {
                        CompanySymbol = "EPAM",
                        Date = DateTime.Now,
                        IsWonderful = true
                    },
                    //
                    new Rating
                    {
                        CompanySymbol = "XXII",
                        Date = DateTime.Now,
                        IsWonderful = true
                    },
                    new Rating
                    {
                        CompanySymbol = "DDD",
                        Date = DateTime.Now,
                        IsWonderful = false
                    }
                };

                _db.Ratings.AddRange(ratings);
                await _db.SaveChangesAsync();
            }
            if (!_db.FiveMoats.Any())
            {
                var fiveMoats = new List<FiveMoats>
                {
                    new FiveMoats
                    {
                        CompanySymbol = "XXII",
                        Brand = true,
                        Secret = true
                    },
                    new FiveMoats
                    {
                        CompanySymbol = "DDD",
                        Switching = true
                    }
                };

                _db.FiveMoats.AddRange(fiveMoats);
                await _db.SaveChangesAsync();
            }
            if (!_db.Leaders.Any())
            {
                var leaders = new List<Leader>
                {
                    new Leader
                    {
                        CompanySymbol = "XXII",
                        Name = "Bill Gates",
                        Avatar = "https://pbs.twimg.com/profile_images/558109954561679360/j1f9DiJi.jpeg",
                        Position = "CEO",
                        IsLevelFiveLeader = true,
                        LeadershipExamples = new List<LeadershipExample>
                        {
                            new LeadershipExample
                            {
                                Content = "He said something that confirms that he is a level five leader.",
                                IsPositive = true,
                                Reference = @"Quote source, <a href=""http:\\www.google.com"">Quote Source<a>, Where, 2015"
                            },
                            new LeadershipExample
                            {
                                Content = "He said something that bad. Something that...bla bla bla",
                                IsPositive = false,
                                Reference = @"Something, <a href=""http:\\www.google.com"">Quote Source<a>, Lorem, 2000"
                            }
                        }
                    },
                    new Leader
                    {
                        CompanySymbol = "XXII",
                        Name = "Jeffrey Skilling",
                        Avatar = "https://upload.wikimedia.org/wikipedia/commons/5/57/Jeffrey_Skilling_mug_shot.jpg",
                        Position = "CEO",
                        IsLevelFiveLeader = false,
                        LeadershipExamples = new List<LeadershipExample>
                        {
                            new LeadershipExample
                            {
                                Content = "He said something that confirms that he is a level five leader.",
                                IsPositive = true,
                                Reference = @"Quote source, <a href=""http:\\www.google.com"">Quote Source<a>, Where, 2015"
                            },
                            new LeadershipExample
                            {
                                Content = "He said something that bad. Something that...bla bla bla",
                                IsPositive = false,
                                Reference = @"Something, <a href=""http:\\www.google.com"">Quote Source<a>, Lorem, 2000"
                            }
                        }
                    },
                };

                _db.Leaders.AddRange(leaders);
                await _db.SaveChangesAsync();
            }
            if (!_db.Meanings.Any())
            {
                var meanings = new List<Meaning>
                {
                    new Meaning
                    {
                        CompanySymbol = "XXII",
                        UserId = new Guid("c6c746fd-e2da-4f3b-8417-6b7716421133"),
                        Whole = true,
                        Understand = true,
                        Passion = true,
                        Talent = false,
                        Money = true
                    }
                };

                _db.Meanings.AddRange(meanings);
                await _db.SaveChangesAsync();
            }
        }
    }
}
