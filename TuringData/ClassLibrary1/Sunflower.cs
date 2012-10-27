using System;
using System.Collections.Generic;
using System.Text;

namespace Turing.Data
{
    public class Sunflower
    {
        public Sunflower()
        {
            WhenPlanted = new DateTime(1752, 01, 01);
            WhenPicked = new DateTime(1752, 01, 01);
            Grow = new Cultivate();
            Planted = new Cultivate();
            SeedName = "";
            Postcode = "";
            Country = "";
            LeafDirection = "";
            PlantSize = "";

        }
        /// <summary>
        ///  <remarks>Corresponds to ID in Excel</remarks>
        /// </summary>
        public int PKey
        {
            get;
            set;
        }
        /// <summary>
        ///  <remarks>Corresponds to Flower name (named by grower) in Excel</remarks>
        /// </summary>
        public string FlowerName
        {
            get;
            set;
        }
        /// <summary>
        ///  <remarks>Corresponds to When planted in Excel</remarks>
        /// </summary>
        public DateTime WhenPlanted
        {
            get;
            set;
        }
        /// <summary>
        ///  <remarks>Corresponds to Sunflower seed name in Excel</remarks>
        /// </summary>
        public string SeedName
        {
            get;
            set;
        }
        /// <summary>
        ///  <remarks>Corresponds to Planted postcode name in Excel</remarks>
        /// </summary>
        public string Postcode
        {
            get;
            set;
        }
        /// <summary>
        ///  <remarks>Corresponds to Planted.* name in Excel</remarks>
        /// </summary>
        public Cultivate Planted
        {
            get;
            set;
        }
        /// <summary>
        ///  <remarks>Corresponds to Grow.* name in Excel</remarks>
        /// </summary>
        public Cultivate Grow
        {
            get;
            set;
        }
        /// <summary>
        ///  <remarks>Corresponds to no. of heads in Excel</remarks>
        /// </summary>
        public int NoOfHeads
        {
            get;
            set;
        }
        /// <summary>
        ///  <remarks>Corresponds to WhenPicked in Excel</remarks>
        /// </summary>
        public DateTime WhenPicked
        {
            get;
            set;
        }
        /// <summary>
        ///  <remarks>Corresponds to Bract count in Excel</remarks>
        /// </summary>
        public int BractCount
        {
            get;
            set;
        }
        /// <summary>
        ///  <remarks>Corresponds to Height in Excel</remarks>
        /// </summary>
        public decimal Height
        {
            get;
            set;
        }
        /// <summary>
        ///  <remarks>Corresponds to Head Diameter in Excel</remarks>
        /// </summary>
        public decimal HeadDiameter
        {
            get;
            set;
        }
        /// <summary>
        ///  <remarks>Corresponds to Spiral Count A in Excel</remarks>
        /// </summary>
        public int SpiralCountA
        {
            get;
            set;
        }
        /// <summary>
        ///  <remarks>Corresponds to Spiral Count B in Excel</remarks>
        /// </summary>
        public int SpiralCountB
        {
            get;
            set;
        }
        /// <summary>
        ///  <remarks>Corresponds to Leaf Direction in Excel</remarks>
        /// </summary>
        public string LeafDirection
        {
            get;
            set;
        }
        /// <summary>
        ///  <remarks>Corresponds to Plant Size in Excel</remarks>
        /// </summary>
        public string PlantSize
        {
            get;
            set;
        }
        /// <summary>
        ///  <remarks>Corresponds to Country in Excel</remarks>
        /// </summary>
        public string Country
        {
            get;
            set;
        }
        /// <summary>
        ///  <remarks>Contains longitude</remarks>
        /// </summary>
        public double Longitude
        {
            get;
            set;
        }
        /// <summary>
        ///  <remarks>Contains Latiude</remarks>
        /// </summary>
        public double Latitude
        {
            get;
            set;
        }
    }
}
