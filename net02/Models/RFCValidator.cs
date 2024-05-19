namespace net02.Models
{
    internal class RFCValidator
    {
        private RFCModel M;

        public RFCValidator(RFCModel rFCModel)
        {
            this.M = rFCModel;
            Validar();
        }

        private void Validar()
        {
            /*Regla 4*/
            if (M.Nombre.Trim().Length < 2)
            {
                throw new System.Exception("El nombre es muy corto");
            }
            if (M.AP.Trim().Length == 0)
            {
                if (M.AM.Trim().Length == 0)
                {
                    throw new System.Exception("No hay ningun apellido");
                }
                else if (M.Nombre.Trim().Length < 2)
                {
                    throw new System.Exception("El apellido debe tener por lo menos 2 caracteres");

                }
                else if (M.AP.Trim().Length < 2)
                {
                    throw new System.Exception("El apellido debe tener por lo menos 2 caracteres");
                }
                if (M.NombreN.Trim().Length < 2)
                {
                    throw new System.Exception("El nombre es muy corto");
                }
                if (M.APN.Trim().Length == 0)
                {
                    if (M.AMN.Trim().Length == 0)
                    {
                        throw new System.Exception("No hay ningun apellido");
                    }
                    else if (M.NombreN.Trim().Length < 2)
                    {
                        throw new System.Exception("El apellido debe tener por lo menos 2 caracteres");

                    }
                }
                else if (M.APN.Trim().Length < 2)
                {
                    throw new System.Exception("El apellido debe tener por lo menos 2 caracteres");
                }
            }
        }
    }
}