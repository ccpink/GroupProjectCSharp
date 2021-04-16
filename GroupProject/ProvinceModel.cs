using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media;

namespace GroupProject
{


    //public class CountryModel
    //{
    //    public int confirmed { get; set; }
    //    public int recovered { get; set; }
    //    public int deaths { get; set; }
    //    public string country { get; set; }
    //    public int population { get; set; }
    //    public int sq_km_area { get; set; }
    //    public string life_expectancy { get; set; }
    //    public object elevation_in_meters { get; set; }
    //    public string continent { get; set; }
    //    public string abbreviation { get; set; }
    //    public string location { get; set; }
    //    public int iso { get; set; }
    //    public string capital_city { get; set; }
    //    public string lat { get; set; }
    //    public string @long { get; set; }
    //    public string updated { get; set; }
    //}

    //public class Afghanistan
    //{
    //    public CountryModel All { get; set; }
    //}

    //public class Root
    //{
    //    public Afghanistan Afghanistan { get; set; }
    //}








    public class ProvinceModel
    {


        public string province { get; set; }
        public long  activeCases { get; set; }
        public long cumulativeCases { get; set; }
        public long cumulativeDeaths { get; set; }
        public long cumulativeVaccine { get; set; }
        public long cumulativeRecovered { get; set; }
        public long cumulativeTesting { get; set; }
        public ImageSource provinceFlag { get; set; }



            public ProvinceModel(string province, long activeCases, long cumulativeCases, long cumulativeDeaths, long cumulativeVaccine, long cumulativeRecovered, long cumulativeTesting)
            {
                this.province = province;
                this.activeCases = activeCases;
                this.cumulativeCases = cumulativeCases;
                this.cumulativeDeaths = cumulativeDeaths;
                this.cumulativeVaccine = cumulativeVaccine;
                this.cumulativeRecovered = cumulativeRecovered;
                this.cumulativeTesting = cumulativeTesting;
                this.provinceFlag = provFlag;

            }



        }



        //public int active_cases { get; set; }
        //public int active_cases_change { get; set; }
        //public object avaccine { get; set; }
        //public int cases { get; set; }
        //public object cumulative_avaccine { get; set; }
        //public int cumulative_cases { get; set; }
        //public object cumulative_cvaccine { get; set; }
        //public double cumulative_deaths { get; set; }
        //public object cumulative_dvaccine { get; set; }
        //public double cumulative_recovered { get; set; }
        //public double cumulative_testing { get; set; }
        //public object cvaccine { get; set; }
        //public string date { get; set; }
        //public double deaths { get; set; }
        //public object dvaccine { get; set; }
        //public string province { get; set; }
        //public double recovered { get; set; }
        //public double testing { get; set; }
        //public string testing_info { get; set; }
    }

    //public class Root
    //{
    //    public List<CountryModel> countries { get; set; }
    //}



