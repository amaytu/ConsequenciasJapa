using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GerenciadorFases
{
    // guardar fases liberadas
    private static bool[] fasesDesbloqueadas = new bool[3] { true, false, false };

    public static void Inicializar()
    {
        fasesDesbloqueadas = new bool[3];
        fasesDesbloqueadas[0] = true; // desbloqueia fase 1.
        fasesDesbloqueadas[1] = true; // desbloqueia fase 2.
        fasesDesbloqueadas[2] = true; // desbloqueia fase 3.
    }
}
