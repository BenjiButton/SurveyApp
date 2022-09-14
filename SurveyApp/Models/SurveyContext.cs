using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyApp.Model {
    /// <summary>
    /// This class defines the DbContext for the EntityFramework and identifies child tables
    /// </summary>
    public class SurveyContext : DbContext {
        public DbSet<SurveyAnswer> SurveyAnswers { get; set; }
    }
}
