using PersonalDataConsole.Model;
using PersonalDataConsole.Repository;

namespace PersonalDataConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                PersonalBioRepository objdatbase = new PersonalBioRepository();
                //var ModelData = objdatbase.DynamicDataModel(); //getting dynamic data for model and store in madel data variablr
                //objdatbase.InsertPersonalData(ModelData);
                //objdatbase.Select();
               /* Console.WriteLine("Enter id to select");
                int selid = Convert.ToInt32(Console.ReadLine());*/
                objdatbase.Selectwithid(5);
                //objdatbase.ubdate(ModelData);
               // objdatbase.delete();
            }

            catch (NullReferenceException e)
            {
            }
            catch(DivideByZeroException ex)
            {
              throw new Exception("Diveed by Zero .Please contact Admin");
            }
            catch (Exception ex)
            {
                throw new Exception("Unknow error . Please contact Admin");
            }
            finally
            {


            }
        }
    }
}
