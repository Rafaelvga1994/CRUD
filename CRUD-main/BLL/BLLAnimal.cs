using System.Text;
using System.Threading.Tasks;
using DAL;
using MODEL;
using BLL;
using System.Data;
using System;
using System.Text.RegularExpressions;
using System.Globalization;
using MySql.Data.MySqlClient;

namespace BLL
{
    public class BLLAnimal
    {
        private referencia DAref;

        public BLLAnimal(conex cx)
        {
            DAref = new referencia(cx);
        }


        public void Atualizar(MODELAnimal modelo)
        {
            try
            {
                /* TRATAMENTO PROPRIETARIO------------------------------------------------------------------------------------------------------------------------------------------------------- */


                bool existeCaracterEspecial = Regex.IsMatch(modelo.Proprietario, (@"[!""#$%&'()*+,-./:;?@[\\\]_`{|}~]"));               
                if(existeCaracterEspecial == true)
                {
                    throw new ArgumentNullException("Proprietário", "Proprietário não pode conter caractéres especiais");
                }


                if (modelo.Proprietario == "")
                {
                    throw new ArgumentNullException("Proprietário", "Proprietário não pode estar vazio.");
                }

                /*------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ */


                /* TRATAMENTO ANIMAL--------------------------------------------------------------------------------------------------------------------------------------------------------------*/


                bool existeCaracterEspecial2 = Regex.IsMatch(modelo.Animal, (@"[!""#$%&'()*+,-./:;?@[\\\]_`{|}~]"));

                if (existeCaracterEspecial2 == true)
                {
                    throw new ArgumentNullException("Animal", "Animal não pode ter caractéres especiais");
                }

                if (modelo.Animal == "")
                {
                    throw new ArgumentNullException("Animal", "Nome do animal não pode estar vazio");
                }


                /*------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ */





                /* TRATAMENTO ANAMINESE--------------------------------------------------------------------------------------------------------------------------------------------------------------*/



                if (modelo.Anaminese == "")
                {
                    throw new ArgumentNullException("Anaminese", "Anaminese não pode estar vazio");
                }
              


                /*------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/
                

               




                    DAref.Atualizar(modelo);
            }

            catch (MySqlException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public void Incluir(MODELAnimal modelo)
        {
            try
            {
                /* TRATAMENTO PROPRIETARIO------------------------------------------------------------------------------------------------------------------------------------------------------- */


                bool existeCaracterEspecial = Regex.IsMatch(modelo.Proprietario, (@"[!""#$%&'()*+,-./:;?@[\\\]_`{|}~]"));
                if (existeCaracterEspecial == true)
                {
                    throw new ArgumentNullException("Proprietário", "Proprietário não pode conter caractéres especiais");
                }

                if(Convert.ToString(modelo.DataConsulta) == "")
                {
                    throw new ArgumentNullException("Data", "Data não pode estar vazio");
                }

                if (modelo.Proprietario == "")
                {
                    throw new ArgumentNullException("Proprietário", "Proprietário não pode estar vazio.");
                }

                /*------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ */


                /* TRATAMENTO ANIMAL--------------------------------------------------------------------------------------------------------------------------------------------------------------*/


                bool existeCaracterEspecial2 = Regex.IsMatch(modelo.Animal, (@"[!""#$%&'()*+,-./:;?@[\\\]_`{|}~]"));

                if (existeCaracterEspecial2 == true)
                {
                    throw new ArgumentNullException("Animal", "Animal não pode ter caractéres especiais");
                }

                if (modelo.Animal == "")
                {
                    throw new ArgumentNullException("Animal", "Nome do animal não pode estar vazio");
                }

                if (Convert.ToString(modelo.DataConsulta) == "")
                {
                    throw new ArgumentNullException("Data", "Data não pode estar vazio");
                }



                /*------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ */





                /* TRATAMENTO ANAMINESE--------------------------------------------------------------------------------------------------------------------------------------------------------------*/



                if (modelo.Anaminese == "")
                {
                    throw new ArgumentNullException("Anaminese", "Anaminese não pode estar vazio");
                }



                DAref.Incluir(modelo);
            }

            catch (MySqlException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public DataTable Procurar (string t,string op)
        {
            try
            {
                if (op == "Selecionar...")
                {
                    throw new ArgumentException("Opa, selecione um meio para buscar!");
                }
                return DAref.Procurar(t, op);
            }

            catch (MySqlException e )
            {
                throw e;
            }
            catch (ArgumentException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void Deletar (int c)
        {
            try
            {
                if(c <= 0)
                {
                    throw new ArgumentException("ID", "Id não pode ser zero");
                }
                DAref.Excluir(c);
            }
            catch(Exception e)
            {
                throw e;
            }
        }
    }
}
  

