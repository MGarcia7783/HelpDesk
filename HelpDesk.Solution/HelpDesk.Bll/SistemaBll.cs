using HelpDesk.Dal;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelpDesk.Bll
{
    public class SistemaBll
    {
        private readonly SistemaDal _sistemaDal;

        public SistemaBll(SistemaDal sistemaDal)
        {
            _sistemaDal = sistemaDal;
        }

        public async Task CrearAdministradorInicialAsync()
        {
            await _sistemaDal.CrearAdministradorInicialAsync();
        }
    }
}
