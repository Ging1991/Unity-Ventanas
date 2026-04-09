using Ging1991.Core;
using Ging1991.Core.Interfaces;
using Ging1991.Interfaces.Personalizacion;
using UnityEngine;

namespace Ging1991.Ventanas {

	public class VentanaConfirmar : MonoBehaviour {

		private IEjecutable accionAceptar;
		private IEjecutable accionCancelar;
		public TextoUI texto;

		public virtual void Inicializar(string mensaje, IEjecutable accionAceptar, IEjecutable accionCancelar) {
			texto.SetTexto(mensaje);
			this.accionAceptar = accionAceptar;
			this.accionCancelar = accionCancelar;
		}

		public void BotonAceptar() {
			gameObject.SetActive(false);
			Bloqueador.BloquearGrupo("GLOBAL", false);
			accionAceptar?.Ejecutar();
		}

		public void BotonCancelar() {
			gameObject.SetActive(false);
			Bloqueador.BloquearGrupo("GLOBAL", false);
			accionCancelar?.Ejecutar();
		}

	}

}