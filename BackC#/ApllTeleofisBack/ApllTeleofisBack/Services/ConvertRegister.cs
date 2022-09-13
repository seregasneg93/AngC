using ApllTeleofisBack.Constants;

namespace ApllTeleofisBack.Services
{
    public class ConvertRegister
    {
        public static string ReceiveTableJob(DateTime version, double valueRegister)
        {
            if (version <= Convert.ToDateTime("2020.06.26"))
            {
                if (valueRegister == 0)
                    return ConstatansVariables.Continuios;
                else if (valueRegister == 1)
                    return ConstatansVariables.StartStop;
                else if (valueRegister == 2)
                    return ConstatansVariables.CancelBoiler;
            }
            else if (version >= Convert.ToDateTime("2020.07.17") && version < Convert.ToDateTime("2021.08.30"))
            {
                if (valueRegister == 0)
                    return ConstatansVariables.Continuios;
                else if (valueRegister == 1)
                    return ConstatansVariables.HotterWater;
                else if (valueRegister == 2)
                    return ConstatansVariables.StartStop;
                else if (valueRegister == 3)
                    return ConstatansVariables.CancelBoiler;
            }
            else if (version >= Convert.ToDateTime("2021.08.30"))
            {
                if (valueRegister == 0)
                    return ConstatansVariables.Continuios;
                else if (valueRegister == 1)
                    return ConstatansVariables.StartStop;
                else if (valueRegister == 2)
                    return ConstatansVariables.CancelBoiler;
                else if (valueRegister == 3)
                    return ConstatansVariables.HotterWater;
            }
            return "Ошибка преобразования";
        }

        public static string ReceiveMethodAdjustment(double valueRegister)
        {
            if (valueRegister == 0)
                return ConstatansVariables.ПО_УЛИЦЕ;
            else if (valueRegister == 1)
                return ConstatansVariables.ПО_ДЛИТЕЛЬНОСТИ;
            else if (valueRegister == 2)
                return ConstatansVariables.ПО_Т_ПОДАЧИ;

            return "Ошибка преобразования";
        }
    }
}
