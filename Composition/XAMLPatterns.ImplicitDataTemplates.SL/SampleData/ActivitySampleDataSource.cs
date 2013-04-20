using System;
using System.Collections.Generic;
using XAMLPatterns.ImplicitDataTemplates.SL.Models;

namespace XAMLPatterns.ImplicitDataTemplates.SL.SampleData
{
    public class ActivitySampleDataSource
    {
        private IEnumerable<Activity> _activities = new List<Activity>
        {
            new RecruitingActivity
            {
                Date = new DateTime(2013, 4, 16),
                Description = "Phone screen",
                Candidate = "Jane Smith"
            },
            new RecruitingActivity
            {
                Date = new DateTime(2013, 4, 14),
                Description = "In person interview",
                Candidate = "George Martin"
            },
            new UserGroupActivity
            {
                Date = new DateTime(2013, 4, 6),
                Description = "Speaking",
                UserGroup = "Dallas XAML"
            },
            new BusinessDevelopmentActivity
            {
                Date = new DateTime(2013, 4, 2),
                Description = "Lunch and Learn",
                Prospect = "Acme Hosting"
            }
        };

        public IEnumerable<Activity> Activities
        {
            get { return _activities; }
        }
    }
}
