using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenCaseWork.Constituents.Models
{
    public class ConstituentDemographics
    {
        public bool LivingAlone { get; set; }
        public bool LivesInNursingHome { get; set; }
        public bool FrailDisabled { get; set; }
        public bool LimitedEnglish { get; set; }
        public bool CaseWorkerRisk { get; set; }
        public bool Homeless { get; set; }
        public bool FemaleHeadedHousehold { get; set; }
        public bool Pet { get; set; }
    }
}
