﻿using System;

namespace ExportPhotos.Objects
{
    public class Imagen
    {
        String ruta;
        String orden;

        public string Ruta
        {
            get
            {
                return ruta;
            }

            set
            {
                ruta = value;
            }
        }

        public string Orden
        {
            get
            {
                return orden;
            }

            set
            {
                orden = value;
            }
        }
    }
}
