using System;

namespace XAMLPatterns.ShadowTypes.DataSources
{
    public class DesignModeDataSource
    {
        //
        // XAML Patterns (5.7):
        //
        // Create anonymous-typed objects with the same
        // properties as the real view model.
        //
        public object Track
        {
            get
            {
                return new
                {
                    Name = "Web",
                    Sessions = new object[]
                    {
                        new
                        {
                            Title = "Real-Time Web Programming with SignalR",
                            Speaker = "Brian Sullivan",
                            Room = "Room: The Papasan",
                            Time = new DateTime(2013, 3, 15, 16, 0, 0),
                        },
                        new
                        {
                            Title = "Touchy Browser Applications",
                            Speaker = "Eric Sowell",
                            Room = "Room: The Papasan",
                            Time = new DateTime(2013, 3, 15, 9, 0, 0),
                        },
                        new
                        {
                            Title = "Getting Started with ASP.NET MVC4",
                            Speaker = "Rob Vettor",
                            Room = "Room: The Papasan",
                            Time = new DateTime(2013, 3, 15, 10, 30, 0),
                        }
                    }
                };
            }
        }

        public object Session
        {
            get
            {
                return new
                {
                    Title = "Real-Time Web Programming with SignalR",
                    Speaker = "Brian Sullivan",
                    SpeakerImage = new Uri("http://cowtowncodecamp.azurewebsites.net/media/4468/BrianSullivan.jpg", UriKind.Absolute),
                    Room = "Room: The Papasan",
                    Time = new DateTime(2013, 3, 15, 16, 0, 0),
                    Description =
                        "Web programming has always been a one-way conversation; " +
                        "a client calls a server and the server sends a response. " +
                        "But what if you could go the other direction? What if your " +
                        "server could call your client directly? No more inefficient " +
                        "polling. No more waiting for the next server poll to get your " +
                        "data; the server sends it as soon as it has it. Using a " +
                        "variety of techniques behind the scenes to smooth over the " +
                        "rough edges of dealing with variously capable browsers and " +
                        "web servers, SignalR makes real-time client-server communication " +
                        "ridiculously easy. Come see how this new library opens up a ton " +
                        "of possibilities for interactive and collaborative web " +
                        "applications."
                };
            }
        }
    }
}
