using System;
using System.Collections.Generic;
using System.Text;

namespace Turing.Data
{
    public class Cultivate
    {
        public Cultivate()
        {
            this.Direction = "";
            this.Container = "";
            this.Location = "";
        }
        /// <summary>
        ///  <remarks>Corresponds to ID in Excel</remarks>
        /// </summary>
        /// <summary>
        ///  <remarks>Corresponds to location name in Excel</remarks>
        /// </summary>
        public string Location
        {
            get;
            set;
        }
        /// <summary>
        ///  <remarks>Corresponds to Container name in Excel</remarks>
        /// </summary>
        public string Container
        {
            get;
            set;
        }
        /// <summary>
        ///  <remarks>Corresponds to direction name in Excel</remarks>
        /// </summary>
        public string Direction
        {
            get;
            set;
        }
    }       
}
