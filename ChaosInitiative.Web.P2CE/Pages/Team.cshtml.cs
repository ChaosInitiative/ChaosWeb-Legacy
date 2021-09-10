using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ChaosInitiative.Web.P2CE.Pages
{
    public class TeamModel : PageModel
    {

        public List<TeamMember> TeamMembers { get; set; }

        public Dictionary<string, string> Contributors { get; set; }

        public TeamModel()
        {
            // TODO: Integrate team member list into backend
            TeamMembers = new List<TeamMember>
            {
                new TeamMember
                {
                    UserName = "CitadelCore",
                    Roles = new []
                    {
                        "Project Founder", 
                        "Infrastructure Maintainer", 
                        "Core Chaos Engine Maintainer"
                    },
                    SocialMediaServices = new Dictionary<SocialMediaService, string>
                    {
                        {
                            SocialMediaService.Discord, "Alex Zero#0001"
                        },
                        {
                            SocialMediaService.GitHub, "https://github.com/citadelcore"
                        },
                        {
                            SocialMediaService.Twitter, "https://twitter.com/fabric_operator"
                        }
                    }
                },
                new TeamMember
                {
                    UserName = "JJI77",
                    Roles = new []
                    {
                        "Lead Programmer",
                        "Linux Port Maintainer",
                        "Core Chaos Engine Maintainer"
                    },
                    SocialMediaServices = new Dictionary<SocialMediaService, string>
                    {
                        {
                            SocialMediaService.Discord, "JJl77#6673"
                        },
                        {
                            SocialMediaService.GitHub, "https://github.com/jjl772"
                        },
                        {
                            SocialMediaService.Twitter, "https://twitter.com/jlorelli77"
                        }
                    }
                },
                new TeamMember
                {
                    UserName = "Ossy Flawol",
                    Roles = new []
                    {
                        "Lead Gameplay/Campaign Designer",
                        "Mapper",
                        "𝓘𝓭𝓮𝓪𝓼 𝓖𝓾𝔂"
                    },
                    SocialMediaServices = new Dictionary<SocialMediaService, string>
                    {
                        {
                            SocialMediaService.Discord, "Ossy Flawol#3580"
                        },
                        {
                            SocialMediaService.Twitter, "https://twitter.com/OssyFlawol"
                        }
                    }
                },
                new TeamMember
                {
                    UserName = "EchoesForeAndAft",
                    Roles = new []
                    {
                        "Programmer",
                        "Graphics Programming"
                        // another role for echoes?
                    },
                    SocialMediaServices = new Dictionary<SocialMediaService, string>
                    {
                        {
                            SocialMediaService.Discord, "EchoesForeAndAft#8982"
                        },
                        {
                            SocialMediaService.GitHub, "https://github.com/EchoesForeAndAft"
                        }
                    }
                },
                new TeamMember
                {
                    UserName = "Blenderiste09",
                    Roles = new []
                    {
                        "Programmer",
                        "Speedrun Feature Support",
                        "Quality of Life"
                    },
                    SocialMediaServices = new Dictionary<SocialMediaService, string>
                    {
                        {
                            SocialMediaService.Discord, "Blenderiste09#8595"
                        },
                        {
                            SocialMediaService.GitHub, "https://github.com/Blenderiste09"
                        },
                        {
                            SocialMediaService.YouTube, "https://www.youtube.com/channel/UCLs0a4Fi1d6AXDxcCaLZpAw"
                        },
                        {
                            SocialMediaService.Steam, "https://steamcommunity.com/profiles/76561198251755710"
                        }
                    }
                },
                new TeamMember
                {
                    UserName = "mlugg",
                    Roles = new []
                    {
                        "Programmer",
                        "Linux Port Developer",
                        "Speedrun Feature Support"
                    },
                    SocialMediaServices = new Dictionary<SocialMediaService, string>
                    {
                        {
                            SocialMediaService.Discord, "mlugg#6618"
                        },
                        {
                            SocialMediaService.GitHub, "https://github.com/mlugg"
                        },
                        {
                            SocialMediaService.Twitter, "https://twitter.com/matthew_lugg"
                        }
                    }
                },
                new TeamMember
                {
                    UserName = "BonnyAnimations",
                    Roles = new []
                    {
                        "Animator",
                        "3D Artist"
                    },
                    SocialMediaServices = new Dictionary<SocialMediaService, string>
                    {
                        {
                            SocialMediaService.Discord, "Bon#6445"
                        },
                        {
                            SocialMediaService.YouTube, "https://youtube.com/channel/UCRWXDDaEdCb6T0hG12uXT8w"
                        },
                        {
                            SocialMediaService.DeviantArt, "https://www.deviantart.com/bonnyanimations"
                        },
                        {
                            SocialMediaService.Reddit, "https://www.reddit.com/u/BonnyGaming"
                        },
                        {
                            SocialMediaService.Twitter, "https://twitter.com/BonnyTweets?s=09"
                        },
                        {
                            SocialMediaService.Instagram, "https://www.instagram.com/bonnyanimations"
                        }
                    }
                },
                new TeamMember
                {
                    UserName = "craftablescience",
                    Roles = new []
                    {
                        "Web Developer",
                        "UI/UX Designer",
                        "Open Source Tools Developer"
                    },
                    SocialMediaServices = new Dictionary<SocialMediaService, string>
                    {
                        {
                            SocialMediaService.Discord, "craftablescience#6001"
                        },
                        {
                            SocialMediaService.GitHub, "https://github.com/craftablescience"
                        },
                        {
                            SocialMediaService.YouTube, "https://www.youtube.com/channel/UC-w_GVUnPT9LuSm5z9eLbbQ"
                        },
                        {
                            SocialMediaService.Twitter, "https://twitter.com/craftablscience"
                        },
                        {
                            SocialMediaService.Instagram, "https://www.instagram.com/craftablescience/"
                        },
                        {
                            SocialMediaService.Steam, "https://steamcommunity.com/id/craftablescience/"
                        }
                    }
                },
                new TeamMember
                {
                    UserName = "MysticalAce",
                    Roles = new []
                    {
                        "Level Design",
                        "Public Relations"
                    },
                    SocialMediaServices = new Dictionary<SocialMediaService, string>
                    {
                        {
                            SocialMediaService.Discord, "Mystical Λce#3820"
                        },
                        {
                            SocialMediaService.GitHub, "https://github.com/Mystical-Ace"
                        }
                    }
                },
                new TeamMember
                {
                    UserName = "Permatemp",
                    Roles = new []
                    {
                        "UI/UX Designer"
                    },
                    SocialMediaServices = new Dictionary<SocialMediaService, string>
                    {
                        {
                            SocialMediaService.Discord, "Permatemp#6669"
                        },
                        {
                            SocialMediaService.GitHub, "https://github.com/Permatemp"
                        }
                    }
                },
                new TeamMember
                {
                    UserName = "BenVlodgi",
                    Roles = new []
                    {
                        "Programmer",
                        "Spirit Animal"
                    },
                    SocialMediaServices = new Dictionary<SocialMediaService, string>
                    {
                        {
                            SocialMediaService.Discord, "BenVlodgi#0001"
                        }
                    }
                },
                new TeamMember
                {
                    UserName = "Luke18033",
                    Roles = new []
                    {
                        "Scripting Support",
                        "GitHub Moderator"
                    },
                    SocialMediaServices = new Dictionary<SocialMediaService, string>
                    {
                        {
                            SocialMediaService.Discord, "Luke18033#2342"
                        },
                        {
                            SocialMediaService.GitHub, "https://github.com/Luke18033"
                        }
                    }
                },
                new TeamMember
                {
                    UserName = "ThePiGuy24",
                    Roles = new []
                    {
                        "Infrastructure Support",
                        "Systems Administration"
                    },
                    SocialMediaServices = new Dictionary<SocialMediaService, string>
                    {
                        {
                            SocialMediaService.Discord, "ThePiGuy24#0369"
                        },
                        {
                            SocialMediaService.GitHub, "https://github.com/ThePiGuy24"
                        }
                    }
                },
                new TeamMember
                {
                    UserName = "_distrilul",
                    Roles = new []
                    {
                        "GitHub Moderator",
                        "Discord Community Manager"
                    },
                    SocialMediaServices = new Dictionary<SocialMediaService, string>
                    {
                        {
                            SocialMediaService.Discord, "_distrilul#3755"
                        },
                        {
                            SocialMediaService.GitHub, "https://github.com/distributivgesetz"
                        }
                    }
                }
            };

            Contributors = new Dictionary<string, string>
            {
                {
                    "Wii2", "Graphics Asset Creation"
                },
                {
                    "Josepezdj", "3D Modelling"
                },
                {
                    "Sonop", "3D Modelling"
                }
            };
        }
        
        public void OnGet()
        {
            
        }
    }

    public class TeamMember
    {
        public string UserName { get; set; }
        public string[] Roles { get; set; }
        public Dictionary<SocialMediaService, string> SocialMediaServices { get; set; }
    }

    public enum SocialMediaService
    {
        Discord,
        GitHub,
        Twitter,
        Reddit,
        Instagram,
        Steam,
        YouTube,
        DeviantArt // it's here for a good reason I promise
    }
}