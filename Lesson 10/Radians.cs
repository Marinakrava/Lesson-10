using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10
{
    class Radians
    {
        int gradus;
        int min;
        int sec;

        public int Gradus
        {
            get
            {
                return gradus;
            }
            set
            {
                if (value < 0)
                {
                    gradus = 0;
                }
                else if (value > 360)
                {
                    gradus = 360;
                }
                else
                {
                    {
                        gradus = value;
                    }
                }
            }
        }
        public int Min
        {
            get
            {
                return min;
            }
            set
            {
                if (value < 0)
                {
                    min = 0;
                }
                else if (value > 60)
                {
                    min = 60;
                }
                else
                {
                    {
                        min = value;
                    }
                }
            }
        }
        public int Sec
        {
            get
            {
                return sec;
            }
            set
            {
                if (value < 0)
                {
                    sec = 0;
                }
                else if (value > 60)
                {
                    sec = 60;
                }
                else
                {
                    {
                        sec = value;
                    }
                }
            }
        }

        public Radians(int gradus, int min, int sec)
        {
            this.Gradus = gradus;
            this.Min = min;
            this.Sec = sec;
        }

        public double ToRadians()
        {
            return (gradus + min / 60.0 + sec / 3600.0) * (Math.PI) / 180;
        }
    }
}
