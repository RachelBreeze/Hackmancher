using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Turing.Data
{

    public class SunflowerCollection: System.Collections.CollectionBase
    {
        private enum CellContents
        {
            ID=0,
            FlowerName=1,
            WhenPlanted=2,
            SeedName=3,
            Postcode=4,
            PlantedLocation=5,
            PlantedContainer=6,
            PlantedDirection=7,
            GrowLocation=8,
            GrowContainer=9,
            NoOfHeads=10,
            WhenPicked=11,
            BractCount=12,
            Height=13,
            HeadDiamter=14,
            SpiralCountA=15,
            SpiralCountB=16,
            LeafDirection=17,
            PlantSize=18,
            Country=19
        }
        public void Add(Sunflower Sunflower)
        {
            List.Add(Sunflower);
        }
        public Sunflower Item(int Index)
        {
            return (Sunflower)List[Index];
        }
        public SunflowerCollection()
        {
            ReadSunflowers();
        }
        public void ReadSunflowers()
        {
            StreamReader Reader;    // reads the raw data
            string Line;           // line in raw data
            Sunflower Sunflower;    // Populated sunflower data adding
            int CellCount;          // Count of cell 
            CellContents CellContent;  // Contents of cell working with
            int IntResult;          // Result of tryparse integer
            decimal DecResult;      // Result of tryparse decimal
            DateTime DateResult;    // Result of tryparse date
            //
            Reader=new StreamReader("C:\\Turing Sunflower raw data.csv");
            // Ignore first line
            Reader.ReadLine();
            //
            // Now read raw sunflower data
            while (!Reader.EndOfStream)
            {
                Line=Reader.ReadLine();
                Sunflower = new Sunflower();
                CellCount=0;
                foreach (string Cell in Line.Split(','))
                {
                    CellContent=(CellContents)CellCount;
                    switch (CellContent)
                    {
                        case CellContents.BractCount:
                            int.TryParse(Cell,out IntResult);
                            Sunflower.BractCount = IntResult;
                            break;
                        case CellContents.Country:
                            Sunflower.Country = Cell;
                            break;
                        case CellContents.FlowerName:
                            Sunflower.FlowerName = Cell;
                            break;
                        case CellContents.GrowContainer:
                            Sunflower.Grow.Container = Cell;
                            break;
                        case CellContents.GrowLocation:
                            Sunflower.Grow.Location = Cell;
                            break;
                        case CellContents.HeadDiamter:
                            decimal.TryParse(Cell, out DecResult);
                            Sunflower.HeadDiameter = DecResult;
                            break;
                        case CellContents.Height:
                            decimal.TryParse(Cell, out DecResult);
                            Sunflower.Height = DecResult;
                            break;
                        case CellContents.ID:
                            int.TryParse(Cell, out IntResult);
                            Sunflower.PKey = IntResult;
                            break;
                        case CellContents.LeafDirection:
                            Sunflower.LeafDirection = Cell;
                            break;
                        case CellContents.NoOfHeads:
                            int.TryParse(Cell, out IntResult);
                            Sunflower.NoOfHeads = IntResult;
                            break;
                        case CellContents.PlantedContainer:
                            Sunflower.Planted.Container = Cell;
                            break;
                        case CellContents.PlantedDirection:
                            Sunflower.Planted.Direction = Cell;
                            break;
                        case CellContents.PlantedLocation:
                            Sunflower.Planted.Location = Cell;
                            break;
                        case CellContents.PlantSize:
                            Sunflower.PlantSize = Cell;
                            break;
                        case CellContents.Postcode:
                            Sunflower.Postcode = Cell;
                            break;
                        case CellContents.SeedName:
                            Sunflower.SeedName = Cell;
                            break;
                        case CellContents.SpiralCountA:
                            int.TryParse(Cell, out IntResult);
                            Sunflower.SpiralCountA = IntResult;
                            break;
                        case CellContents.SpiralCountB:
                            int.TryParse(Cell, out IntResult);
                            Sunflower.SpiralCountB = IntResult;
                            break;
                        case CellContents.WhenPicked:
                            DateTime.TryParse(Cell,out DateResult);
                            Sunflower.WhenPicked = DateResult;
                            break;
                        case CellContents.WhenPlanted:
                            DateTime.TryParse(Cell, out DateResult);
                            Sunflower.WhenPlanted = DateResult;
                            break;
                    }
                    CellCount+=1;
                }
                Add(Sunflower);
            }
        }
    }
}
