using Ging1991.Core;
using Ging1991.Core.Interfaces;
using UnityEngine;

namespace Ging1991.Ventanas {

	public class VentanaControl : MonoBehaviour {

		public VentanaConfirmar ventanaConfirmar;
		public VentanaAceptar ventanaAceptar;

		public void MostrarVentanaConfirmar(string mensaje, IEjecutable accionAceptar = null, IEjecutable accionCancelar = null) {
			if (HayVentanaActiva()) {
				Debug.LogWarning("Ya hay una ventana activa.");
				return;
			}
			Bloqueador.BloquearGrupo("GLOBAL", true);
			ventanaConfirmar.gameObject.SetActive(true);
			ventanaConfirmar.Inicializar(mensaje, accionAceptar, accionCancelar);
		}

		public void MostrarVentanaAceptar(string mensaje, IEjecutable accion = null) {
			if (HayVentanaActiva()) {
				Debug.LogWarning("Ya hay una ventana activa.");
				return;
			}
			Bloqueador.BloquearGrupo("GLOBAL", true);
			ventanaAceptar.gameObject.SetActive(true);
			ventanaAceptar.Inicializar(mensaje, accion);
		}

		public bool HayVentanaActiva() {
			return ventanaConfirmar.gameObject.activeSelf || ventanaAceptar.gameObject.activeSelf;
		}

	}

}