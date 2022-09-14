using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyApp.Model {
    /// <summary>
    /// This model defines how the survey responses are persisted by EntityFramework
    /// </summary>
    public class SurveyAnswer {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [DisplayName("Language")]
        public string FavouriteProgrammingLanguage { get; set; }
    }
}
