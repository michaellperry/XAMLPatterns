using System;
using System.Collections.Generic;
using XAMLPatterns.DesignModeViewModels.ViewModels;

namespace XAMLPatterns.DesignModeViewModels.DataSources
{
    public class DesignModeDataSource
    {
        //
        // XAML Patterns (5.5):
        //
        // Return a view model populated with design-mode data.
        //
        public TrackViewModel Track
        {
            get
            {
                return new TrackViewModel
                {
                    Name = "Web",
                    Sessions = new List<SessionHeaderViewModel>
                    {
                        new SessionHeaderViewModel
                        {
                            Title = "Touchy Browser Applications",
                            Speaker = "Eric Sowell",
                            Room = "The Papasan",
                            Time = new DateTime(2013, 3, 15, 9, 0, 0)
                        },
                        new SessionHeaderViewModel
                        {
                            Title = "$('#code').explode(); - Using AngularJS to Write Dynamic Single Page Applications",
                            Speaker = "Jim Lavin",
                            Room = "The Citrus Cilantro Candle",
                            Time = new DateTime(2013, 3, 15, 10, 30, 0)
                        },
                        new SessionHeaderViewModel
                        {
                            Title = "Getting Started with ASP.NET MVC4",
                            Speaker = "Rob Vettor",
                            Room = "The Papasan",
                            Time = new DateTime(2013, 3, 15, 10, 30, 0)
                        },
                        new SessionHeaderViewModel
                        {
                            Title = "ASP.NET Webforms 4.5: Rumors of My Death Have Been Greatly Exaggerated",
                            Speaker = "Brian Sullivan",
                            Room = "The Papasan",
                            Time = new DateTime(2013, 3, 15, 13, 0, 0)
                        },
                    }
                };
            }
        }
    }
}
