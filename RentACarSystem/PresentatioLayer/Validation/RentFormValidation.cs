using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentatioLayer.Validation
{
    public static class RentFormValidation
    {
        public static bool ValidateClientSelection(object clientId, out string errorMessage)
        {
            if (clientId == null || clientId.ToString() == "")
            {
                errorMessage = "Debe seleccionar un cliente.";
                return false;
            }
            errorMessage = "";
            return true;
        }

        public static bool ValidateCarSelection(object carId, out string errorMessage)
        {
            if (carId == null || carId.ToString() == "")
            {
                errorMessage = "Debe seleccionar un carro.";
                return false;
            }
            errorMessage = "";
            return true;
        }

        public static bool ValidateDates(DateTime rentDate, DateTime returnDate, out string errorMessage)
        {
            if (rentDate.Date > returnDate.Date)
            {
                errorMessage = "La fecha de devolución no puede ser anterior a la fecha de renta.";
                return false;
            }
            errorMessage = "";
            return true;
        }

        public static bool ValidateTimes(DateTime rentDate, DateTime returnDate, TimeSpan rentTime, TimeSpan returnTime, out string errorMessage)
        {
            if (rentDate.Date == returnDate.Date)
            {
                if (rentTime >= returnTime)
                {
                    errorMessage = "La hora de devolución debe ser posterior a la hora de renta.";
                    return false;
                }
            }

            errorMessage = "";
            return true;
        }
    }

}
