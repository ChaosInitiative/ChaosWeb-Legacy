using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using ChaosInitiative.Web.Shared;

namespace ChaosInitiative.Web.ControlPanel.Model
{
    [Table("Features")]
    public class Feature
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Required]
        public FeatureType Type { get; set; }
        public bool Completed { get; set; }
        public List<Issue> RelatedIssues { get; set; } = new List<Issue>();
        public List<ReleaseFeatures> ReleaseFeatures { get; set; }

        [NotMapped]
        public List<Release> Releases => ReleaseFeatures.Select(rf => rf.Release).ToList();
        
        public IEnumerable<Issue> GetSharedRelatedIssues(Feature feature)
        {
            return RelatedIssues.Intersect(feature.RelatedIssues);
        }
        
        public bool IsSharingRelatedIssues(Feature feature)
        {
            return !GetSharedRelatedIssues(feature).IsEmpty();
        }
    }

    public class FeatureSameRelatedIssuesException : Exception
    {
        public IEnumerable<Issue> SharedIssues { get; set; }
        
        public FeatureSameRelatedIssuesException(IEnumerable<Issue> sharedIssues)
        {
            this.SharedIssues = sharedIssues;
        }

    }
}