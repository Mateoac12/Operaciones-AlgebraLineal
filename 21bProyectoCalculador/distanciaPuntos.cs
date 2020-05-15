using System;
using System.Collections.Generic;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace _21bProyectoCalculador
{
    class distanciaPuntos
    {
        private double x, y, z, k;
        
        public distanciaPuntos(double x, double y)
        {
            this.x = x;

            this.y = y;
        }

        public distanciaPuntos(double x, double y, double z)
        {
            this.x = x;

            this.y = y;

            this.z = z;
        }

        public distanciaPuntos(double x, double y, double z, double k)
        {
            this.x = x;

            this.y = y;

            this.z = z;

            this.k = k;
        }

        public double DistanciaDosPuntosPlano(distanciaPuntos dosPuntos)
        {
            double xDist = this.x - dosPuntos.x;

            double yDist = this.y - dosPuntos.y;

            double resultado = Math.Sqrt(Math.Pow(xDist, 2) + Math.Pow(yDist, 2));

            return resultado;
        }

        public double DistanciaDosPuntosEspacio(distanciaPuntos dosPuntos)
        {
            double xDist = this.x - dosPuntos.x;

            double yDist = this.y - dosPuntos.y;

            double zDist = this.z - dosPuntos.z;

            double resultado = Math.Sqrt(Math.Pow(xDist, 2) + Math.Pow(yDist, 2) + Math.Pow(zDist, 2));

            return resultado;
        }
    }
}
