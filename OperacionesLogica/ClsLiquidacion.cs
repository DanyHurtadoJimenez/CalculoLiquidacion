using System;

namespace OperacionesLogica
{
    public class ClsLiquidacion
    {
        //*******************ATRIBUTOS***********************

        private double cesantia;
        private double vacaciones;
        private double preaviso;
        private double aguinaldo;
        private double salarioPromedio;

        //***************************************************



        //*******************CONSTRUTOR**********************

        public ClsLiquidacion() {
            cesantia = 0;
            vacaciones = 0;
            preaviso = 0;
            aguinaldo = 0;
            salarioPromedio = 0;
        }

        //***************************************************


        //*******************METODOS*************************

        public double CalcDiasXAniosLaborados(int cantidadAniosL) {

            double diasLaborados;

            switch (cantidadAniosL)
            {
                case 1:
                    diasLaborados = 19.5;
                    break;
                case 2:
                    diasLaborados = 20;
                    break;
                case 3:
                    diasLaborados = 20.5;
                    break;
                case 4:
                    diasLaborados = 21;
                    break;
                case 5:
                    diasLaborados = 21.24;
                    break;
                case 6:
                    diasLaborados = 21.5;
                    break;
                case 7:
                    diasLaborados = 22;
                    break;
                case 8:
                    diasLaborados = 22;
                    break;
                case 9:
                    diasLaborados = 22;
                    break;
                case 10:
                    diasLaborados = 21.5;
                    break;
                case 11:
                    diasLaborados = 21;
                    break;
                case 12:
                    diasLaborados = 20.5;
                    break;
                default:
                    diasLaborados = 20;
                    break;
            }

            return diasLaborados;

        }

        public double CalculoCesantia(int cantidadAnios) { //calcula la cesantia

            double diasLaborados = CalcDiasXAniosLaborados(cantidadAnios);//llama a la funcion que devuelve los dias laborados con respecto a los anios laborados
            cesantia = ((cantidadAnios * salarioPromedio) / 30) * diasLaborados;

            return cesantia;
        }

        public double CalculoVacaciones(int diasVacaciones) {

            vacaciones = (salarioPromedio / 30) * diasVacaciones;
            return vacaciones;

        }

        public double CalculoPreaviso(int diasPreaviso) {

            preaviso = (salarioPromedio / 30) * diasPreaviso;
            return preaviso;

        }

        public double CalculoAguinaldo(int cantMesesAguinaldo) {

            aguinaldo = ((salarioPromedio * cantMesesAguinaldo) / 12);
            return aguinaldo;
        }

        //***************************************************



        //*******************PROPIEDADES*********************

        public double Cesantia { get => cesantia; }
        public double Vacaciones { get => vacaciones; }
        public double Preaviso { get => preaviso; }
        public double Aguinaldo { get => aguinaldo; }
        public double SalarioPromedio { get => salarioPromedio; set => salarioPromedio = value; }

        //***************************************************



    }//fin de la clase
}//fin del namespace
