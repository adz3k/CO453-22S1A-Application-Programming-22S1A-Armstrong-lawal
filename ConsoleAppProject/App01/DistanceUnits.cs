using System.ComponentModel.DataAnnotations;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// List of units used to measure distance
    /// </summary>
    public enum DistanceUnits
    {
        [Display(Name = "No unit")]
        NoUnit,
        Feet = 1, 
        Metres,
        Kilometres,
        Miles
    }
}

