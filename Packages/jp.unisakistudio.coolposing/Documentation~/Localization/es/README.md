# Cool Posing

Herramienta para fijar poses con estilo en VRChat, también con seguimiento de 3 puntos o escritorio. Incluye 50 poses: 11 de pie, 9 agachadas, 14 sentadas, 9 boca arriba y 7 boca abajo.

Este README corresponde a v1.2.0 en desarrollo. La fecha oficial no está fijada. La versión instalada aparece arriba del Inspector.

- [Página del producto en BOOTH](https://yunisaki.booth.pm/items/8797334)
- [Historial de cambios](CHANGELOG.md)

## Idioma de la interfaz y documentación sin conexión

Elige el idioma en «Language / 言語», arriba del Inspector. Una sola selección controla el Inspector y los menús VRChat generados. Vuelve a subir el avatar para cambiar el idioma dentro del juego.

Sin una selección explícita se usa el idioma del ordenador; si no está disponible, se utiliza inglés. Se admiten Windows, macOS y Linux. La última elección se guarda en EditorPrefs y se reutiliza en otros proyectos del mismo usuario del sistema en este ordenador. Se conserva cualquier elección explícita guardada en el avatar. No se sincroniza con otros ordenadores. El almacenamiento de las licencias no cambia.

Elige el idioma del README, historial y manual en la [lista de idiomas](../index.html) incluida. Los enlaces del Inspector al manual y los cambios también siguen esa selección. Las condiciones originales y sus traducciones de referencia siguen disponibles por separado.

## Funciones principales

- Ajuste IK automático de extremidades: adapta posición y orientación a las proporciones en 43 poses.

- Modo foto: hasta 3m hacia delante y orientación ajustable. 0 bit solo local, 16 bit para mostrar posición y dirección a otros.
- Cabeza visible en fotos: evita ocultar la cabeza cercana propia solo en Modo foto.
- Altura suelo: mueve cuerpo y cabeza hasta 3m arriba/abajo, distinta de Altura pies con cabeza fija.
- Darse vuelta: funciona en poses con movimientos compatibles que asignes. No se incluyen movimientos de giro.
- Respiración: anima pecho y otras partes; Ninguno, Bajo, Medio, Alto, Rápido o Personalizado por categoría.
- Desactivar el balanceo en reposo de VRChat: reduce el reposo estándar manteniendo respiración y movimientos propios.
- Reducir deformaciones por la rotación de cabeza: limita deformaciones por cuello distinto de la pose al desbloquearlo.
- Selección de funciones: añade solo menús deseados y comprueba ExpressionParameters.
- Búsqueda, importación múltiple y orden: busca entre categorías, importa varios clips y elige destino.
- Vista en Scene: «Vista previa» muestra la pose directamente.

- Iconos nuevos: imágenes dedicadas a respiración, Darse vuelta, Altura suelo, Modo foto y otras funciones, con el estilo de los iconos existentes.

### Configurar Darse vuelta

Activa «Activar Darse vuelta» en los Detalles y asigna «Pose lateral para darse vuelta». MotionTime normal queda inhabilitado. Activa también «Funciones > Funciones del menú > Darse vuelta», sube y selecciona pose y función en VRChat. Libera el cuello.

Las poses incluidas no tienen movimientos para darse vuelta. Asigna animaciones compatibles a las que quieras usar.

## Preajustes compatibles y ajuste

Incluye preajustes ajustados para トネール, 狛乃, 士堂 y 真央.

- [トネール](https://booth.pm/ja/items/5236104)
- [狛乃](https://booth.pm/ja/items/5260363)
- [士堂](https://booth.pm/ja/items/8086741)
- [真央](https://booth.pm/ja/items/6846646)

Otros avatares son utilizables. Adapta sus proporciones y modificaciones con Ajuste de animación. Configuración del avatar incluye Evitar la flexión inversa de rodillas y el detalle Flexión mínima de rodilla (grados).

IK está activa inicialmente. De 50 poses, 43 la usan y las otras 7 usan los ajustes individuales anteriores.

## Instalación

1. Descarga archivos de la tienda de compra.
2. Importa «カッコいいポーズツール.unitypackage» y registra licencia y repositorio.
3. Añade Cool Posing y Modular Avatar con VCC o ALCOM. Unisaki Posing System y NDMF son dependencias.
4. Clic derecho en el avatar de Hierarchy y «Unisaki Studio > Añadir Cool Posing».
5. Selecciona Cool Posing en el avatar y ajusta funciones y poses.
6. Sube normalmente.

Requisitos: Unity 2022.3, VRChat Avatars SDK 3.10.4 o posterior, Modular Avatar 1.x desde 1.15.1 y NDMF 1.x desde 1.14.0. Actualiza los paquetes necesarios juntos con VCC o ALCOM.

## Actualizar desde versiones anteriores

Actualiza este producto y Unisaki Posing System juntos. La configuración existente se conserva. Revisa funciones y ExpressionParameters en Inspector; si usabas precálculo, pulsa «Actualizar precálculo» antes de volver a subir.

Desde v1.1.0, nuevas instalaciones usan el Prefab normal 「カッコいいポーズ」. Con opciones innecesarias desactivadas, la selección mínima usa 8 bit; muchas poses pueden requerir bits adicionales.

Los antiguos Prefabs 8bit quedan en «Editor/Legacy» para preservar referencias de avatares y preajustes. No es necesario eliminarlos ni sustituirlos. El menú para añadir no muestra la versión 8bit.

## Dónde se configura

| Pestaña | Uso |
| --- | --- |
| Funciones | Menús del juego, funciones prácticas, respiración, iconos y consumo de ExpressionParameters |
| Poses | Selección, detalles, búsqueda, importación múltiple, orden, vista previa y ajuste de animación |
| Configuración del avatar | Correcciones propias y de rodillas, poses originales o movimientos propios y cambio de preajustes |

El enlace de ajustes abre los detalles debajo de cada opción. Respiración está en «Funciones > Funciones prácticas > Animar la respiración».

«Usar las poses originales de pie, agachado y boca abajo» importa automáticamente las posturas del avatar. Para movimientos propios abre los ajustes de importación separados y asigna cada tipo: de pie, agachado (Crouching), boca abajo (Prone), etc.

Los preajustes están al final de Configuración del avatar. «Aplicar este preajuste» reemplaza las poses actuales; guarda los retoques antes de cambiar.

### Consumo por función

- Respiración sola 0 bit; «Funciones del menú > Respiración» usa 1 bit para detener y reanudar sincronizadamente.
- Modo foto local 0 bit; «Funciones prácticas > Sincronizar el Modo foto» 16 bit; cabeza visible 0 bit.
- Altura pies y suelo 8 bit cada una. Alejar el suelo del centro mueve el cuerpo; cerca de 50% termina.
- Darse vuelta usa 10 bit y comparte 1 bit con Reducir deformaciones por la rotación de cabeza: ambos juntos 10 bit.
- Reflejar y Sin gestos 1 bit cada uno.

El total del Inspector corresponde a herramientas de poses, no a ropa u otros sistemas. Los ajustes comunes no se cuentan dos veces usando varias herramientas.

### Vista previa y edición

«Vista previa» de cada pose muestra la postura en Scene. Para retoques precisos abre «Ajuste de animación», edita mirando el resultado y guarda.

La vista sencilla no ejecuta MA o NDMF. Comprueba también el resultado de compilación antes de subir para ver ropa añadida y correcciones del suelo.

La lupa izquierda busca nombres. Ordena en «Detalles > Orden» o con botones arriba/abajo. Añade varios clips arrastrándolos o con «Importar clips seleccionados en Project».

«Actualizar miniaturas de poses» genera imágenes tras confirmar. «Generar iconos de poses» ayuda en el menú, pero alarga la compilación. Usa «Reducir el tamaño de los iconos» para ahorrar espacio. Android no genera iconos de poses.

## Controles básicos dentro del juego

- Elige poses por categoría en Expressions. La altura de cabeza cambia de pie, agachado, sentado y tumbado en VR.
- Dirección del rostro decide boca arriba/abajo. Con ambas elegidas puedes saltar; se desactiva en «Funciones → Funciones prácticas → Cambiar poses tumbadas al saltar». Los umbrales del menú regulan las alturas.
- C y Z en escritorio; si Z no tumba, aumenta el umbral correspondiente.
- Sin gestos usa manos de la pose en vez de los controladores.
- Altura pies mantiene cabeza; Altura suelo mueve cuerpo entero. Aparecen así ordenadas.
- Distancia del Modo foto avanza y orienta hacia ti; Dirección gira. Activa Fijar pies cuando quieras y Salir de foto restaura todo y libera pies.
- Respiración disponible con animación activa; intensidad en Unity y activación en el juego.

## Precálculo y advertencias

«Actualizar precálculo» reutiliza datos para acelerar la compilación. Sin precálculo, el proceso normal genera los datos necesarios.

Tras modificar ajustes, Comprobar configuración y las marcas de Hierarchy avisan de actualizaciones. Las preferencias de avisos están dentro del mismo recuadro. Ocultarlos no corrige problemas ni actualiza datos.

## Notas de uso

- No admite bloqueo con seguimiento de cuerpo completo.
- Proporciones, ropa y modificaciones pueden requerir retoques.
- Base especial y otras herramientas pueden no integrarse bien. Revisa Configuración del avatar > Integrar bloqueos de seguimiento con otras herramientas.
- Modo foto y suelo corrigen poses de herramienta y movimientos estándar o propios sin selección. Comprueba vista final y movimientos sustituidos en VRChat.
- Suprimir balanceo de VRChat solo afecta al reposo estándar, no a todas sus causas.

## Manual y asistencia

Abre manual, asistencia y cambios desde «Ayuda / Cambios» arriba del Inspector. Las funciones comunes también se explican en «Packages > Unisaki Posing System > README» de Project.

- [Manual oficial](https://docs.unisakistudio.jp/coolposing/manual/)
- [Asistencia](https://help.unisakistudio.jp/)

Al informar de fallos, incluye versiones del producto, Unisaki Posing System, Unity, VRChat SDK, Modular Avatar y NDMF, el avatar, los pasos exactos y el error de Console.

## Condiciones de uso

Se incluye «ゆにさきスタジオ販売・配布データ利用規約（日本語版）Ver1.0.0.pdf», condiciones VN3 comunes a los datos vendidos o distribuidos por Unisaki Studio. Léelas antes de usar.

Código fuente y recursos no son de código abierto. Se autoriza a compradores legítimos dentro de las condiciones incluidas.
