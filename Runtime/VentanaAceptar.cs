using Ging1991.Core;
using Ging1991.Core.Interfaces;
using Ging1991.Interfaces.Personalizacion;
using UnityEngine;

namespace Ging1991.Ventanas {//

	public class VentanaAceptar : MonoBehaviour {

		private IEjecutable accion;
		public TextoUI texto;

		public virtual void Inicializar(string mensaje, IEjecutable accion) {
			texto.SetTexto(mensaje);
			this.accion = accion;
		}

		public void BotonAceptar() {
			Bloqueador.BloquearGrupo("GLOBAL", false);
			gameObject.SetActive(false);
			accion?.Ejecutar();
		}

	}

}