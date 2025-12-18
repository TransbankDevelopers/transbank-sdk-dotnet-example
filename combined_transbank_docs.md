# ayuda.md

Source: https://www.transbankdevelopers.cl/ayuda

¿En cuántas horas un comercio puede pasar de integración a producción?
Si el comercio se encuentra validado y la documentación enviada esté correcta, el paso a producción es de 24 hrs. Cabe señalar que es necesario realizar una prueba en producción para cerrar el proceso de certificación.
¿Cuáles son los Parámetros de los métodos de WS?
Puedes revisar los parámetros de los servicios visitando el siguiente link: [https://www.transbankdevelopers.cl/referencia/webpay#crear-una-transaccion-webpay-plus-normal ](https://www.transbankdevelopers.cl/referencia/webpay#crear-una-transaccion-webpay-plus-normal )
Como integrador ¿cuál es el flujo completo de una transacción por WS?
El flujo consta de 3 métodos que puedes visualizar mejor en el diagrama que conseguirás en el siguiente link: [https://www.transbankdevelopers.cl/referencia/webpay#flujo-en-caso-de-exito](https://www.transbankdevelopers.cl/referencia/webpay#flujo-en-caso-de-exito)
Como integrador ¿cómo puedo realizar correctamente el control del botón anular?
El flujo completo cuando un usuario cancela un pago en el comercio lo puedes visualizar mejor en el diagrama que conseguirás en el siguiente link: [https://www.transbankdevelopers.cl/referencia/webpay#flujo-en-caso-de-exito](https://www.transbankdevelopers.cl/referencia/webpay#flujo-en-caso-de-exito)
Como integrador ¿cuáles son las etapas del proceso de integración hasta la puesta en producción?
Las etapas que forman parte del proceso de integración hasta la puesta de integración son las siguientes: Integración, pruebas que se refieren al proceso de validación, generación de credenciales y puesta en producción en la que se te solicitará realizar una compra por un valor de $10
Siendo integrador ¿dónde puedo descargar el OpenSSL?
Existen varios sitios que permiten la descarga de este programa, internamente utilizamos la versión disponible en el siguiente link: [http://gnuwin32.sourceforge.net/packages/openssl.html](http://gnuwin32.sourceforge.net/packages/openssl.html)
Como integrador ¿cómo se generan los certificados SSL?
En caso de estar utilizando algún producto Webpay, puedes seguir la guía de generación de certificados que encontrarás en el siguiente link: [https://www.transbankdevelopers.cl/documentacion/como_empezar#credenciales-en-webpay](https://www.transbankdevelopers.cl/documentacion/como_empezar#credenciales-en-webpay). En caso de Onepay y REST las credenciales serán entregadas por Transbank
Como comercio ¿qué beneficio obtengo al utilizar el método Webpay Autorización Captura Diferida?
Este método le permite al comercio realizar capturas de una transacción autorizada sin captura generada en Webpay Plus o Webpay OneClick. El método contempla una única captura por cada autorización. Para ello se deberá indicar los datos asociados a la transacción de venta con autorización sin captura y el monto requerido para capturar el cual debe ser menor o igual al monto originalmente autorizado. Puedes obtener mayor información en el siguiente link: [https://www.transbankdevelopers.cl/referencia/webpay#captura-diferida-webpay-plus](https://www.transbankdevelopers.cl/referencia/webpay#captura-diferida-webpay-plus)
Como integrador ¿dónde puedo ver las transacciones para validar que el paso a producción está Ok?
Las transacciones las puedes ver en el portal de Transbank ([transbank.cl](https://www.transbank.cl)) en la sección Webpay.
¿Cuáles son los parámetros que, como integrador, se necesitan para inicializar una transacción Webpay Plus normal?
Para una integración más sencilla, recomendamos el uso de un SDK, te dejamos el siguiente link en donde conseguirás la información necesaria para instalarlo: [https://www.transbankdevelopers.cl/documentacion/como_empezar#instalacion-sdk](https://www.transbankdevelopers.cl/documentacion/como_empezar#instalacion-sdk)
En caso de no poder utilizar un SDK aquí podrás encontrar la referencia a todos los endpoints de la API: [https://www.transbankdevelopers.cl/referencia/webpay](https://www.transbankdevelopers.cl/referencia/webpay)
Como integrador ¿dónde puedo descargar los plugins para X e-Commerce?
En el portal de Transbank Developers cuentas con Plugins para E-commerce.
Puedes revisarlos en el siguiente link: [https://www.transbankdevelopers.cl/plugin](https://www.transbankdevelopers.cl/plugin)
Como integrador ¿dónde puedo encontrar ejemplos de integración?
Puedes conseguir toda la información necesaria en la sección de ejemplos de nuestro portal Transbank Developers.
[https://www.transbankdevelopers.cl/documentacion/webpay#webpay-plus](https://www.transbankdevelopers.cl/documentacion/webpay#webpay-plus)
Siendo integrador ¿el ambiente de prueba tiene un costo para mi?
El ambiente de integración es de acceso libre, para que todos los integradores puedan acceder a realizar pruebas sin ningún costo asociado.
Como integrador ¿puedo integrarme a Transbank sin tener un contrato firmado?
Puedes optar a trabajar en el ambiente de integración de Transbank, no obstante para poder optar a todas los servicios de Transbank debes tener un comercio afiliado a Transbank.
¿Qué necesito para tener ambiente de integración?
Toda la información necesaria, para tener ambiente de integración la puedes obtener en nuestro portal Transbank Developers o en el siguiente link: [https://www.transbankdevelopers.cl/documentacion/como_empezar#ambientes](https://www.transbankdevelopers.cl/documentacion/como_empezar#ambientes)
Soy integrador, ¿en qué horarios puedo probar contra el ambiente de integración?
Los ambientes están disponibles 24x7, puedes ver el estado del mismo en nuestro sitio status.
Link: https://status.transbankdevelopers.cl/
¿Qué tipo de ejemplos de integración hay disponibles para integradores?
Puedes revisar el siguiente link en donde podrás conseguir todos los ejemplos de integración disponibles. [https://www.transbankdevelopers.cl/documentacion/como_empezar](https://www.transbankdevelopers.cl/documentacion/como_empezar)
Como integrador ¿qué herramientas puedo utilizar para probar flujos y comunicación con los webservices?
Recomendamos que pruebes Postman en el flujo para asegurar que funcione la comunicación.
¿Transbank me entrega tarjetas para poder realizar pruebas siendo integrador?
Si. Existe una tarjeta de crédito / débito para transacciones aprobadas y rechazadas. Puedes revisarlas en el siguiente Link: [https://www.transbankdevelopers.cl/documentacion/como_empezar#ambientes](https://www.transbankdevelopers.cl/documentacion/como_empezar#ambientes)
¿Transbank dispone de alguna herramienta donde pueda ver las transacciones que voy realizando?
En integración no. En producción (ventas reales) si, a través del portal Transbank.cl
Siendo integrador, ¿cómo puedo probar los ejemplos de Transbank Developers?
Transbank cuenta con ejemplos que muestran cómo utilizar los SDK, cada ejemplo cuenta con un readme con instrucciones para poder probarlos, todo esto lo puedes conseguir en el siguiente link: [https://www.transbankdevelopers.cl/documentacion/webpay#ejemplos-de-integracion](https://www.transbankdevelopers.cl/documentacion/webpay#ejemplos-de-integracion)
Siendo integrador ¿qué pasa si fallo en alguna validación?
Soporte te va a indicar los fallos y adicionalmente te dará los pasos a seguir para aprobar nuevamente la validación.
¿Qué debo hacer para realizar el cambio al ambiente de producción de Webpay?
Para realizar el cambio al ambiente de producción de Webpay es necesario contar con tu propio código de comercio y haber completado el proceso de validación de tu integración para obtener tu API Key Secret.
Si cuentas con un plugin para e-commerce, sigue las instrucciones indicadas aquí: [ https://www.transbankdevelopers.cl/documentacion/como_empezar#a-utilizando-plugins ](https://www.transbankdevelopers.cl/documentacion/como_empezar#a-utilizando-plugins)
Si realizaste tu integración mediante alguno de nuestros SDK, puedes encontrar el detalle de cómo pasar a producción en el siguiente link: [ https://www.transbankdevelopers.cl/documentacion/como_empezar#b-utilizando-los-sdk ](https://www.transbankdevelopers.cl/documentacion/como_empezar#b-utilizando-los-sdk)
¿Cuánto me demoro en pasar de integración a producción?
En soluciones para ventas de internet, si el comercio se encuentra validado y la documentación enviada esta correcta, el paso a producción es de 24 hrs. Cabe señalar que es necesario realizar una prueba en producción para cerrar el proceso de certificación.
En pagos con las maquinitas de TBK, una vez que recibes el POS de producción, este estará listo para su funcionamiento.
¿Debo configurar algunos parámetros en el POS?
El POS viene configurado con un terminal Id y un código de comercio, una vez realizada la actualización de los parámetros, se descargarán todas las opciones necesarias
¿Un equipo de prueba POS tiene costos para mi?
Los POS entregados por Transbank para el desarrollo de integración no cuentan con ningún costo asociado.
Si eres integrador, debes solicitar un POS a través de un comercio cliente.
Si tengo algún inconveniente con el POS o el ambiente de integración ¿donde puedo reportarlo?
Tenemos un canal de Slack que esta abierto 24x7 donde puedes reportar o hacer todas tus consultas. El personal de TBK responderá tus consultas en horario de oficina, pero muchas veces cualquier integrante de Slack podría ayudarte, lo puedes ubicar en el siguiente link: https://app.slack.com/client
Como integrador necesito ser cliente de Transbank para poder realizar pruebas con POS integrado?
Si, ya que debemos entregarte un POS en comodato. Los comercios deben estar afiliados a TBK, si eres integrador necesitas llegar a la empresa con un comercio para lograr su afiliación.
Cuando paso a producción, ¿con qué tarjetas puedo realizar pruebas?
Si. Existe una tarjeta de crédito / débito para transacciones aprobadas y rechazadas. Puedes revisarlas en el siguiente Link: https://www.transbankdevelopers.cl/documentacion/como_empezar#ambientes
En producción te recomendamos que hagas pruebas con montos bajos de $50, con tarjetas propias. Estas ventas se pueden anular y serán abonadas nuevamente a tu comercio, descontando la comisión por transacciones.
¿Qué es el ID de servicio en PatPass?
Es el identificador o número de cliente utilizado para reconocer la suscripción y gestionar los cobros automáticos. Este identificador es asignado por el comercio y puede variar dependiendo de cada uno.
¿Cómo un cliente puede suscribir un pago automático en tu comercio?
Existen tres canales para suscribir tus servicios
Canales de suscripción ofrecidos por el comercio
Mandato Digital: Solución donde el Tarjetahabiente suscribe su cuenta de servicio a través de un link o código QR propio del Comercio. Corresponde a un formulario digital que entrega una experiencia de suscripción tecnológica y segura.
PatPass Comercio: Solución donde el Tarjetahabiente suscribe su cuenta de servicio a través del sitio web del Comercio (previamente integrado). Corresponde a un formulario presente en el portal del Establecimiento Comercial.
Canales ofrecidos por el Banco
3. Banco Emisor: Solución donde el Tarjetahabiente suscribe su cuenta de servicio a través de la página de su Banco, seleccionando el comercio.
¿Cómo se confirma que una suscripción quedó realizada con éxito?
Existen dos rutas para comprobar que una suscripción quedó realizada con éxito, mediante el comercio y por medio del banco.
Por medio del comercio
Mandato Digital: Si la suscripción fue hecha por el canal de mandato digital, tanto al comercio como al cliente le llegará de manera instantánea un correo informando la suscripción desde noreplay@transbank.cl confirmando la suscripción.
Patpass Comercio: Si la suscripción fue hecha por el canal de PatPass Comercio, al cliente se le mostrará una pantalla con el éxito de la suscripción y le llegará un correo con la información (correo opcional que puede enviarlo el comercio)
Por medio del Banco
Si la suscripción fue hecha por el Banco, al cliente se le mostrará una pantalla con el éxito de la suscripción y se incorporará dentro del listado de suscripción en la misma página.
Adicionalmente, al comercio, siempre que exista una nueva suscripción, modificación o eliminación, independiente por el canal que el cliente lo haya realizado, se le informará por medio de Transdata bajo el archivo de novedades (diario) y el archivo de Base de instrucción de cargos (BIC) (semanal).
¿Cómo puedo gestionar los cobros, altas y/o bajas del servicio?
Toda la información referente a los cobros ya sea el cómo realizarlos junto a su gestión debe ser realizada a través del aplicativo Transdata. [Aquí](https://www.transbankdevelopers.cl/public/files/Manual_Comercios_PatPass.pdf) puedes encontrar el manual de usuario y ante cualquier duda debes comunicarte al call center o a tu ejecutivo comercial.
¿El comercio debe tener LOGS de validación en sus transacciones?
Para el comercio es una buena práctica utilizar LOGs en Webservices para ver y seguir todos los pasos de su sitio y las transacciones que se están cursando, de esa manera no solo podrá ver el resultado en su base de datos, sino que podrá usar el LOG para conversar con Transbank ante cualquier inconveniente sobre una transacción. Asimismo, esto se exige y es parte de las integraciones y validaciones previo a la puesta en producción de tu sitio.
¿Los certificados de producción son los mismos de integración?
Los certificados son distintos, deben ser emitidos con un código de comercio productivo que previamente te debe haber entregado el ejecutivo comercial; como mínimo deben tener 4 años de vigencia, sino se pueden ver interrumpidas tus ventas.
¿A qué comercios está orientado Webpay?
¿Cómo puedo identificar si Botones Webpay es la mejor solución para mi comercio?
Botones Webpay es un producto orientado a negocios que se están iniciando en el comercio electrónico, con baja oferta de precios y con baja variabilidad de estos.
Es una solución rápido para comercios que no administren carros de compra en sus portales Web y que no cuentan con sistemas informáticos internos o que no necesitan operar con sistemas transaccionales
¿A qué comercios está orientado Webpay Mall?
Webpay Plus Mall permite realizar una solicitud de autorizacioón financiera de un conjunto de pagos con tarjetas de crédito o débito, para mayor detalle te dejamos el siguiente link: [https://www.transbankdevelopers.cl/producto/webpay#webpay-plus-mall](https://www.transbankdevelopers.cl/producto/webpay#webpay-plus-mall)
¿Es posible vender a personas con tarjetas emitidas fuera de Chile?
Si, todas las soluciones Webpay (con excepción de Webpay Oneclick) operan para tarjetas emitidas en Chile y en el Extranjero. Webpay Oneclick opera solo para clientes con tarjetas emitidas en Chile.
¿A qué comercios está orientado Webpay.cl?
Como comercio quiero tener información sobre integradores, ¿en dónde puedo conseguirla?
La información referente a integradores la puedes encontrar en el siguiente link en donde se enlista una serie de desarrolladores que ofrecen servicios de integración, que a pesar de ser externos a Transbank, han demostrado poseer las capacidades necesarias para levantar este tipo de proyectos hasta su etapa productiva.
¿Debo habilitar algún tipo de LOGS de validación en transacciones en mi sistema de caja?
Se recomienda tener un timestamp para cada comando que envíe la caja y respuesta del POS, esto en desarrollo y en producción, lo cual permitirá detectar algún inconveniente o identificar algún posible incidente en producción. Es importante tomar en consideración los cambios que requieren un log, respaldos y limpieza.
¿Los POS de producción son los mismos de integración?
No, las llaves y firmas que tienen los POS de desarrollo son distintas a las de producción.
¿Los POS con que moneda trabajan?
Tenemos POS con ventas en pesos y dólares. Los POS en dólares generalmente solo se entregan a comercios relacionado al turismo.
¿A qué se refiere el error 283?
Usualmente, cuando se inicia una transacción y Webpay te da un error 283, éste corresponde a un problema de certificados (en Webservices) o llaves (.pem del KCC). Debes revisar que el certificado o la llave pública de Transbank sea la productiva. Asimismo, revisa si tu certificado o llave es el productivo y es el que informaste a Transbank cuando pasaste a producción.
Soy integrador, en caso de dudas, ¿con quién me puedo comunicar?
Para aclarar dudas más específicas te invitamos a unirte a nuestro canal de Slack: [https://transbank.continuumhq.dev/slack_community](https://transbank.continuumhq.dev/slack_community) o al link de contacto en el footer de nuestro sitio.

# brand-assets.md

Source: https://www.transbankdevelopers.cl/brand-assets

Recupera tu contraseña aquí
Se envió un correo a su cuenta inscrita.
Es necesario la validación de la cuenta.
Recuerda revisar la bandeja de spam
Se ha enviado un correo para cambiar la contraseña
Si aún mantienes tu integración de Webpay en la modalidad SOAP, te recordamos que en septiembre del presente año, esta modalidad será deprecada, por lo cual es necesario que realices la migración a la metodología REST para continuar operando posterior a dicha fecha.
¿Cuáles son los principales beneficios de REST para tu comercio?
¿Cómo realizar la integración Rest?
Puedes contactar a tu Integrador o revisar la información disponible [en este link.](https://www.transbankdevelopers.cl/documentacion/como_empezar#)
Si necesitas asistencia puedes contactar a tu Integrador o puedes contactarnos a Servicio al Cliente al 600 638 6380 desde teléfonos fijos o desde celulares al +562 2661 2700, casilla [soporteweb@transbank.cl.](mailto:soporteweb@transbank.cl)
Tu mensaje se ha enviado exitosamente, pronto nos contactaremos con usted
Hemos enviado una copia a tu correo
Si estás en los primeros pasos para integrarte, puedes solicitar ayuda seleccionado esta opción o escríbenos directamente a nuestro canal Slack, donde especialistas despejaran tus dudas
Si requieres resolver algún tipo de incidencia en la página www.transbankdevelopers.cl. Tu mensaje será dirigido al soporte de la plataforma.
Si ya terminaste la integración del medio de pago de manera exitosa, y necesitas soporte post venta selecciona esta opción en tipo de soporte o llama a los siguientes números:
Desde teléfonos fijos: 600 638 6380
Desde móviles : [+56 2 2661 2700]
También te invitamos a colaborar directamente en nuestro [repositorio en Github](https://github.com/TransbankDevelopers/transbank-developers-docs) enviándonos un Pull Request que felizmente revisaremos e incluiremos
<{msg_ajax}>

# comercio.md

Source: https://www.transbankdevelopers.cl/comercio

Recupera tu contraseña aquí
Se envió un correo a su cuenta inscrita.
Es necesario la validación de la cuenta.
Recuerda revisar la bandeja de spam
Se ha enviado un correo para cambiar la contraseña
Si aún mantienes tu integración de Webpay en la modalidad SOAP, te recordamos que en septiembre del presente año, esta modalidad será deprecada, por lo cual es necesario que realices la migración a la metodología REST para continuar operando posterior a dicha fecha.
¿Cuáles son los principales beneficios de REST para tu comercio?
¿Cómo realizar la integración Rest?
Puedes contactar a tu Integrador o revisar la información disponible [en este link.](https://www.transbankdevelopers.cl/documentacion/como_empezar#)
Si necesitas asistencia puedes contactar a tu Integrador o puedes contactarnos a Servicio al Cliente al 600 638 6380 desde teléfonos fijos o desde celulares al +562 2661 2700, casilla [soporteweb@transbank.cl.](mailto:soporteweb@transbank.cl)
Tu mensaje se ha enviado exitosamente, pronto nos contactaremos con usted
Hemos enviado una copia a tu correo
Si estás en los primeros pasos para integrarte, puedes solicitar ayuda seleccionado esta opción o escríbenos directamente a nuestro canal Slack, donde especialistas despejaran tus dudas
Si requieres resolver algún tipo de incidencia en la página www.transbankdevelopers.cl. Tu mensaje será dirigido al soporte de la plataforma.
Si ya terminaste la integración del medio de pago de manera exitosa, y necesitas soporte post venta selecciona esta opción en tipo de soporte o llama a los siguientes números:
Desde teléfonos fijos: 600 638 6380
Desde móviles : [+56 2 2661 2700]
También te invitamos a colaborar directamente en nuestro [repositorio en Github](https://github.com/TransbankDevelopers/transbank-developers-docs) enviándonos un Pull Request que felizmente revisaremos e incluiremos
<{msg_ajax}>
Si aún no te has decidido por cual de nuestros productos más se ajusta a la necesidad de tu negocio, podemos ayudarte a entender con mayor detalle que es lo que realmente necesitas.
Si ya conoces el producto que quieres integrar, te presentamos las alternativas que tienes para hacerlo
Te mostramos las alternativas para soluciones integrales para tener tu ecommerce funcionado en poco tiempo con todas sus ventajas.
Si no cuentas con un equipo técnico que pueda ayudarte a integrar nuestros productos, tenemos una lista de profesionales calificados para hacerlo.

# comercio_alternativa.md

Source: https://www.transbankdevelopers.cl/comercio/alternativa

Crea tu tienda online integrada con Transbank en poco tiempo.
Expertos Transbank realizan la integración del medio de pago Webpay Plus en tu sitio web, y se encargan de dejarlo configurado y listo para que puedas vender en línea.
Requisitos.
Contar con su página web desarrollada y disponer de carro de compra.
Costo del servicio.
3,39 UF + IVA
Transbank y Wix te ayudan a vender online, con un nuevo servicio que
combina el apoyo en la creación de tu sitio web y la integración del medio de pago. Todo esto en pocos días para que puedas recibir pagos con tarjeta.
Costo del servicio.
$149.990 IVA INCLUIDO.
¡Disponible hasta el 30 de noviembre 2025!
La plataforma de comercio electrónico para empresas que quieran enfocarse en hacer crecer su negocio. Con tu propio dominio, personalizado, integrado con Transbank y un servicio 24x7.
Vende más y en muchos canales.
Con boleta electrónica, informes y control de stock. Acepta pagos
con webpay y otros medios.
Bootic es la plataforma líder de e-commerce para PyMEs. Combina la flexibilidad de un software abierto con el respaldo de un servicio online, operado en Chile por un equipo de expertos.

# documentacion_como_empezar.md

Source: https://www.transbankdevelopers.cl/documentacion/como_empezar

Cómo empezar
Para empezar a integrar los productos de Transbank, te recomendamos usar nuestros SDK y plugins, disponibles para múltiples lenguajes de programación y plataformas. En general, existe un único Transbank SDK para el backend de tu e-commerce, el cual te permite operar con todos nuestros productos.
Si quieres implementar Webpay Plus, te recomendamos revisar [nuestros plugins oficiales](https://www.transbankdevelopers.cl/plugin).
En esta sección veremos los pasos para comenzar con el SDK que corresponda al lenguaje de programación que utilices en tu backend.
Flujo de Integración
Inicialmente, el comercio tendrá algunas tareas comerciales que realizar mientras ocurre el proceso de integración. Este proceso de afiliación comercial se puede realizar en paralelo al proceso técnico de integración.
A continuación, puedes conocer el flujo completo.
![step-one](https://www.transbankdevelopers.cl/public/library/img/emailing/images-correo-tbk/signature.png)
Hazte Cliente
Completa el formulario de afiliación en nuestro portal [publico.transbank.cl](https://publico.transbank.cl/), fírmalo digitalmente y recibirás tu código de
comercio en el correo que registraste.
![step-two](https://www.transbankdevelopers.cl/public/library/img/emailing/images-correo-tbk/step1.png)
Integrate
Realiza la integración del medio de pago en tu página web o aplicación. Consulta las herramientas
disponibles en [Transbank Developers](https://www.transbankdevelopers.cl/documentacion/como_empezar#proceso-tecnico-de-integracion) y [Slack](https://invitacion-slack.transbankdevelopers.cl/slack_community).
![step-three](https://www.transbankdevelopers.cl/public/library/img/emailing/images-correo-tbk/step2.png)
Valida
Para validar tu integración y verificar que funcione correctamente, ingresa a Transbank Developers, y
completa el [formulario de validación](https://www.transbankdevelopers.cl/documentacion/como_empezar#el-proceso-de-validacion).
Puedes realizar consultas en [soporte@transbank.cl](mailto: soporte@transbank.cl)
![step-four](https://transbankdevelopers.cl/public/library/img/emailing/images-correo-tbk/step3.png)
Vende
Finalizado el proceso de validación se te asignará una llave privada (Tbk-Api-Key-Secret). Configúrala en tu app o sitio web y ya estarás ¡Listo para vender!
Proceso técnico de integración
Este proceso contempla todas las tareas necesarias que debe realizar el comercio para integrar el producto contratado dentro de sus sistemas.
A) Usando un plugin
Si quieres implementar Webpay Plus con alguno de nuestros plugins oficiales, revisa [su documentación](https://www.transbankdevelopers.cl/plugin) específica. En ese caso, el proceso es más simple y no requiere escribir código como en el caso de los SDK, ya que basta con realizar la instalación y configuración del plugin en la plataforma que estés utilizando.
B) Usando un SDK
Para instalar el SDK, debes agregarlo al gestor de dependencias de tu lenguaje:
[En Java](https://github.com/TransbankDevelopers/transbank-sdk-java#instalaci%C3%B3n) debes agregar esta entrada en tu archivo pom.xml
de Maven:
<dependency>
<groupId>com.github.transbankdevelopers</groupId>
<artifactId>transbank-sdk-java</artifactId>
<version>{mira-en-github-la-ultima-version-disponible}</version>
</dependency>
Te recomendamos leer [las instrucciones de instalación detalladas para el SDK Java](https://github.com/TransbankDevelopers/transbank-sdk-java#instalaci%C3%B3n) para más opciones e información de la última versión disponible.
[En PHP](https://github.com/TransbankDevelopers/transbank-sdk-php#instalaci%C3%B3n) puedes usar composer (si no lo tienes, puedes instalarlo desde [acá](https://getcomposer.org/)) para descargar la última versión del SDK, ejecutando esto en la línea de comandos cuando estés en la raíz de tu proyecto:
composer require transbank/transbank-sdk:^5.0
Te recomendamos leer [las instrucciones de instalación detalladas para el SDK PHP](https://github.com/TransbankDevelopers/transbank-sdk-php#instalaci%C3%B3n) para más opciones de instalación.
[En .NET](https://github.com/TransbankDevelopers/transbank-sdk-dotnet#instalaci%C3%B3n) puedes instalar el SDK desde la línea de comandos del Package Manager de Visual Studio:
PM> Install-Package TransbankSDK
Te recomendamos leer [las instrucciones de instalación detalladas para el SDK .NET](https://github.com/TransbankDevelopers/transbank-sdk-dotnet#instalaci%C3%B3n) para más opciones de instalación.
[En Ruby](https://github.com/TransbankDevelopers/transbank-sdk-ruby#instalaci%C3%B3n) puedes instalar el SDK como una gema:
gem install transbank-sdk
Te recomendamos leer [las instrucciones de instalación detalladas para el SDK Ruby](https://github.com/TransbankDevelopers/transbank-sdk-ruby#instalaci%C3%B3n) para más opciones de instalación.
[En Python](https://github.com/TransbankDevelopers/transbank-sdk-python#instalaci%C3%B3n) puedes instalar el SDK desde PyPI:
pip install transbank-sdk
[En NodeJS](https://github.com/TransbankDevelopers/transbank-sdk-nodejs#instalación) puedes instalar el SDK desde NPM:
npm install transbank-sdk
Te recomendamos leer [las instrucciones de instalación detalladas para el SDK Python](https://github.com/TransbankDevelopers/transbank-sdk-python#instalaci%C3%B3n) para más opciones de instalación.
C) Usando el API REST
También puedes consumir el API REST de los productos directamente. Si usas un lenguaje de programación que no tiene un SDK oficial o simplemente quieres conectarte directamente al API, debes revisar la [Referencia del API REST](https://www.transbankdevelopers.cl/referencia/webpay?l=http) en el tab "http" para conocer los diferentes endpoints de cada producto, sus parámetros de entrada y parámetros de respuesta.
Ejemplos
Para ayudarte a entender la integración de mejor forma disponemos de un índice de proyectos de
ejemplo que puedes acceder a través de este [link](https://proyectos-ejemplo.transbankdevelopers.cl/)
Ambientes
Transbank provee dos ambientes: Integración y Producción.
Ambiente de integración: En este ambiente el comercio realiza la integración del producto a contratar y testea su solución de medio pago.
HOST: https://webpay3gint.transbank.cl
Ambiente de producción: En este ambiente el comercio operará luego de finalizar el [proceso de puesta en producción](#puesta-en-produccion) y realizará transacciones con tarjetas de crédito, débito o prepago reales.
HOST: https://webpay3g.transbank.cl
Ambiente de integración
En el ambiente de integración existen códigos de comercio previamente creados para todos los productos (Webpay Plus, Oneclick Mall, etc), para cada una de sus modalidades (Captura Diferida, Mall, Mall Captura Diferida, etc) y dependiendo de la moneda que acepten (USD o CLP).
Asegúrate de que estés usando el código de comercio de integración que tenga la misma configuración del producto que contrataste.
Tarjetas de Prueba
Para las transacciones Webpay en el ambiente de integración se deben usar estas tarjetas de prueba:
| Tipo de tarjeta | Detalle | Resultado |
|---|---|---|
| VISA | 4051 8856 0044 6623 CVV 123 cualquier fecha de expiración |
Genera transacciones aprobadas. |
| AMEX | 3700 0000 0002 032 CVV 1234 cualquier fecha de expiración |
Genera transacciones aprobadas. |
| MASTERCARD | 5186 0595 5959 0568 CVV 123 cualquier fecha de expiración |
Genera transacciones rechazadas. |
| Redcompra | 4051 8842 3993 7763 | Genera transacciones aprobadas (para operaciones que permiten débito Redcompra) |
| Redcompra | 4511 3466 6003 7060 | Genera transacciones aprobadas (para operaciones que permiten débito Redcompra) |
| Redcompra | 5186 0085 4123 3829 | Genera transacciones rechazadas (para operaciones que permiten débito Redcompra) |
| Prepago VISA | 4051 8860 0005 6590 CVV 123 cualquier fecha de expiración |
Genera transacciones aprobadas. |
| Prepago MASTERCARD | 5186 1741 1062 9480 CVV 123 cualquier fecha de expiración |
Genera transacciones rechazadas. |
Cuando aparece un formulario de autenticación con RUT y clave, se debe usar el RUT 11.111.111-1 y la clave 123.
Códigos de comercio
A continuación encontrarás todos los códigos de comercio disponibles en el ambiente de integración. Para todos los código de comercio, la llave secreta (Api Key Secret) es 579B532A7440BB0C9079DED94D31EA1615BACEB56610332264630D42D0A36B1C
| Producto | Código de Comercio |
|---|---|
| Webpay Plus | 597055555532 |
| Webpay Plus Captura Diferida | 597055555540 |
| Webpay Plus Mall | 597055555535 Mall597055555536 Tienda 1597055555537 Tienda 2 |
| Webpay Plus Mall Captura Diferida | 597055555581 Mall597055555582 Tienda 1597055555583 Tienda 2 |
| Oneclick Mall | 597055555541 Mall597055555542 Tienda 1597055555543 Tienda 2 |
| Oneclick Mall Captura Diferida | 597055555547 Mall597055555548 Tienda 1597055555549 Tienda 2 |
| Transacción Completa | 597055555530 |
| Transacción Completa sin CVV | 597055555557 |
| Transacción Completa Diferida | 597055555531 |
| Transacción Completa Diferida sin CVV | 597055555556 |
| Transacción Completa Mall | 597055555573 Mall597055555574 Tienda 1597055555575 Tienda 2 |
| Transacción Completa Mall sin CVV | 597055555551 Mall597055555552 Tienda 1597055555553 Tienda 2 |
| Transacción Completa Mall Captura Diferida | 597055555576 Mall597055555577 Tienda 1597055555578 Tienda 2 |
| Transacción Completa Mall Captura Diferida sin CVV | 597055555561 Mall597055555562 Tienda 1597055555563 Tienda 2 |
| Patpass Comercio | 28299257 Código de comerciocxxXQgGD9vrVe4M41FIt Llave secreta (Api Key Secret) |
El proceso de validación
Durante la validación de la integración se pretende verificar que el comercio transacciona de manera segura y sin problemas, por lo que se solicitarán una serie de pruebas y su posterior envío de evidencias para validar la integración. Esta validación es requisito necesario para dejar al comercio en producción y no se permitirá que un comercio utilice productivamente el servicio Webpay sin poseer una validación.
Transbank solo validará las integraciones de aquellos comercios que tengan un código de comercio productivo. Para obtenerlo, sigue las instrucciones en cómo hacerse cliente en el portal [http://www.transbank.cl](http://www.transbank.cl) o contacte a su ejecutivo comercial.
Para integración con plugins, creamos un nuevo formulario online para que comiences el proceso de validación: [ Comenzar formulario de integración ](https://form.typeform.com/to/fZqOJyFZ?typeform-medium=embed-snippet)
Para integraciones Webpay Plus, Webpay Plus Mall y OneClick Mall (con SDK o integración directa al API), creamos un nuevo formulario online para que comiences el proceso de validación: [ Comenzar formulario de integración ](https://form.typeform.com/to/ibXdg6Av?typeform-medium=embed-snippet)
Para otro tipo de integraciones (PatPass, Transacción Completa), el comercio debe enviar las evidencias a [soporte@transbank.cl](mailto:soporte@transbank.cl) empleando el formulario correspondiente al producto integrado indicando claramente las órdenes de compra, fecha y hora de las transacciones.
Descargar el formulario de envidencias:
- Para integraciones Webpay que usen un plugin oficial: usa el formulario indicado más arriba.
-
Para integraciones Webpay Plus, Webpay Plus Mall y OneClick Mall con SDK o intgración directa al API: usa el formulario indicado más arriba.
-
Para integraciones Transacción Completa:
[Descargar](https://transbankdevelopers.cl/files/evidencia-integracion-webpay-rest.docx) - Para integraciones Patpass Comercio:
[Descargar](https://transbankdevelopers.cl/files/evidencia-de-integracion-patpass-comercio.docx)
Para ambos procesos de validación (formulario online o envío de documentación) debes contar con el logo de tu tienda (GIF o PNG 130x59 px).
Soporte validará que los casos de prueba sean consistentes con los registrados en los sistemas de Webpay y, de estar todo correcto, se le notificará al comercio la conformidad para pasar a producción, recibiendo las instrucciones para ello. De no estar consistentes las pruebas, se le hará alcances al comercio respecto de su integración, para que realices las correcciones correspondientes y vuelvas a enviar las evidencias una vez terminadas dichas correcciones.
Durante el paso a producción se te exigirá realizar, al menos, una transacción de prueba real, con la que finalizará oficialmente la puesta en producción.
Puesta en Producción
- Una vez que el comercio determine que ha finalizado su integración, se debe realizar un
[proceso de validación](#el-proceso-de-validacion). - Transbank informará via correo electrónico el resultado de la validación enviado por el comercio. En caso de que la validación sea aprobada, Transbank indicará la llave secreta (API Key Secret) para poder usar el ambiente de producción. Posterior a ello, será necesario
[cambiar la configuración del e-commerce para funcionar en producción](#a-utilizando-plugins) - Con la configuración del ambiente de producción ya lista, será necesario realizar una compra de $50 para validar el correcto funcionamiento.
- Ya estás operando en producción.
Webpay, Oneclick y Transacción Completa
En el caso de Webpay, las credenciales consisten en:
- Un código de comercio (Api-Key-Id).
- Una llave secreta (Api-Key-Secret).
Obtener tu llave secreta (proceso de validación)
Para usar el ambiente de producción (donde se utiliza dinero real), necesitas tener tu llave secreta, que es un código especial que está asociado a tu código de comercio. Para obtenerla necesitas pasar un proceso de validación, que está [explicado a continuación](#el-proceso-de-validacion).
Al finalizar este proceso de validación, obtendrás tu llave secreta.
A) Utilizando Plugins
Si ya tienes tu código de comercio de producción y llave secreta, solo debes entrar a la configuración de tu plugin ([ver documentación de plugins](https://www.transbankdevelopers.cl/plugin)) y colocar:
- Ambiente: Producción
- Código de comercio: tu código de comercio de producción
- Api Key: Tu llave secreta
Al guardar, el plugin funcionará inmediatamente en ambiente de producción y podrás operar con tarjetas y transacciones reales.
B) Utilizando los SDK
Si ya tienes tu código de comercio de producción y llave secreta, ahora solo debes configurar tu proyecto para que use el ambiente de producción, proporcionándole tus credenciales. Te explicamos como hacerlo en los diferentes SDK realizando los siguientes pasos:
Definir que se usará el ambiente de producción y pasar el Api Key (Código de comercio) y el Api Key Secret (Llave secreta)
/**
* Todos los productos se pueden configurar de 2 formas:
* 1.- Pasando un objeto Options en su constructor.
* 2.- Utilizando los nuevos métodos de configuración
*/
//Uso del objeto Options (aplicable a todos los productos)
import cl.transbank.common.IntegrationType;
import cl.transbank.model.Options;
import cl.transbank.webpay.common.WebpayOptions;
import cl.transbank.webpay.webpayplus.WebpayPlus;
Options option = new WebpayOptions("commerceCode", "APIKey", IntegrationType.LIVE);
WebpayPlus.Transaction transaction = new WebpayPlus.Transaction(option);
//Uso de los métodos de configuración
//Webpay Plus
import cl.transbank.webpay.webpayplus.WebpayPlus;
WebpayPlus.Transaction transaction = WebpayPlus.Transaction.buildForProduction("commerceCode", "APIKey");
WebpayPlus.MallTransaction mallTransaction = WebpayPlus.MallTransaction.buildForProduction("commerceCode", "APIKey");
//Oneclick
import cl.transbank.webpay.oneclick.Oneclick;
Oneclick.MallInscription mallInscription = Oneclick.MallInscription.buildForProduction("commerceCode", "APIKey");
Oneclick.MallTransaction mallTransaction = Oneclick.MallTransaction.buildForProduction("commerceCode", "APIKey");
// Transacción Completa
import cl.transbank.webpay.transaccioncompleta.FullTransaction;
import cl.transbank.webpay.transaccioncompleta.MallFullTransaction;
FullTransaction fullTransaction = FullTransaction.buildForProduction("commerceCode", "APIKey");
MallFullTransaction mallFullTransaction = MallFullTransaction.buildForProduction("commerceCode", "APIKey");
// PatPass Comercio
// Es importante destacar que la clase Options para PatPass se importa desde una ruta distinta que en el resto de productos.
import cl.transbank.patpass.model.PatpassOptions;
import cl.transbank.patpass.PatpassComercio;
//Uso del objeto Options
PatpassComercio.Inscription patpassInscription = new PatpassComercio.Inscription(new PatpassOptions("commerceCode", "APIKey", IntegrationType.LIVE));
//Uso del método de configuración
PatpassComercio.Inscription patpassInscription = PatpassComercio.Inscription.buildForProduction("commerceCode", "APIKey");
/**
* Todos los productos se pueden configurar de 2 formas:
* 1.- Pasando un objeto Options en su constructor.
* 2.- Utilizando los nuevos métodos de configuración
*/
//Uso del objeto Options (aplicable a todos los productos)
use Transbank\Webpay\Options;
use Transbank\Webpay\WebpayPlus\Transaction;
$option = new Options($apiKey, $commerceCode, Options::ENVIRONMENT_PRODUCTION);
$transaction = new Transaction($option);
//Uso de los métodos de configuración
//Webpay Plus
use Transbank\Webpay\WebpayPlus\Transaction;
use Transbank\Webpay\WebpayPlus\MallTransaction;
$transaction = Transaction::buildForProduction($apiKey, $commerceCode);
$mallTransaction = MallTransaction::buildForProduction($apiKey, $commerceCode);
//Oneclick
use Transbank\Webpay\Oneclick\MallInscription;
use Transbank\Webpay\Oneclick\MallTransaction;
$mallInscription = MallInscription::buildForProduction($apiKey, $commerceCode);
$mallTransaction = MallTransaction::buildForProduction($apiKey, $commerceCode);
// PatPass Comercio
// Es importante destacar que la clase Options para PatPass se importa desde una ruta distinta que en el resto de productos.
use Transbank\PatpassComercio\Options;
use Transbank\PatpassComercio\Inscription;
//Uso del objeto Options
$options = new Options($apiKey, $commerceCode, Options::ENVIRONMENT_PRODUCTION);
$inscription = new Inscription($options);
//Uso del método de configuración
$inscription = Inscription::buildForProduction($apiKey, $commerceCode);
/**
* Todos los productos se pueden configurar de 2 formas:
* 1.- Pasando un objeto Options en su constructor.
* 2.- Utilizando los nuevos métodos de configuración
*/
//Uso del objeto Options (aplicable a todos los productos)
using Transbank.Webpay.Common;
using Transbank.Webpay.WebpayPlus;
var tx = new Transaction(new Options("commerceCode", "APIKey", WebpayIntegrationType.Live
));
//Uso de los método de configuración
//Webpay Plus
using Transbank.Webpay.WebpayPlus;
Transaction transaction = Transaction.buildForProduction("commerceCode", "APIKey");
MallTransaction mallTransaction = MallTransaction.buildForProduction("commerceCode", "APIKey");
//Oneclick
using Transbank.Webpay.Oneclick;
MallInscription mallInscription = MallInscription.buildForProduction("commerceCode", "APIKey");
MallTransaction mallTransaction = MallTransaction.buildForProduction("commerceCode", "APIKey");
// Transacción Completa
using Transbank.Webpay.TransaccionCompleta;
using Transbank.Webpay.TransaccionCompletaMall;
FullTransaction fullTransaction = FullTransaction.buildForProduction("commerceCode", "APIKey");
MallFullTransaction mallFullTransaction = MallFullTransaction.buildForProduction("commerceCode", "APIKey");
// PatPass Comercio
// Es importante destacar que la clase IntegrationType para PatPass se importa desde una ruta distinta que en el resto de productos.
using Transbank.PatpassComercio;
using Transbank.Common;
//Uso del objeto Options
Inscription inscription = new Inscription(new Options("commerceCode", "APIKey", PatpassComercioIntegrationType.Live
));
//Uso del método de configuración
Inscription inscription = Inscription.buildForProduction("commerceCode", "APIKey");
##
# Todos los productos se pueden configurar de 2 formas:
# 1.- Pasando un objeto Options en su constructor.
# 2.- Utilizando los nuevos métodos de configuración
##
# Uso del objeto Options (aplicable a todos los productos)
@options = Transbank::Webpay::Options.new("commerceCode", "APIKey", :production)
@transaction = Transbank::Webpay::WebpayPlus::Transaction.new(@options)
# Uso de los métodos de configuración
# Webpay Plus
@transaction = Transbank::Webpay::WebpayPlus::Transaction.build_for_production("commerceCode", "APIKey");
@mall_transaction = Transbank::Webpay::WebpayPlus::MallTransaction.build_for_production("commerceCode", "APIKey");
# Oneclick
@mall_inscription = Transbank::Webpay::Oneclick::MallInscription.build_for_production("commerceCode", "APIKey");
@mall_transaction = Transbank::Webpay::Oneclick::MallTransaction.build_for_production("commerceCode", "APIKey");
# Transacción Completa
@transaction = Transbank::Webpay::TransaccionCompleta::Transaction.build_for_production("commerceCode", "APIKey");
@mall_transaction = Transbank::Webpay::TransaccionCompleta::MallTransaction.build_for_production("commerceCode", "APIKey");
# PatPass Comercio
# Es importante destacar que la clase Options para PatPass se importa desde una ruta distinta que en el resto de productos.
# Uso del objeto Options
@options = Transbank::Patpass::Options.new("commerceCode", "APIKey", :production);
@inscription = Transbank::Patpass::PatpassComercio::Inscription.new(@options);
# Uso del método de configuración
@inscription = Transbank::Patpass::PatpassComercio::Inscription.build_for_production("commerceCode", "APIKey");
##
# Todos los productos se pueden configurar de 2 formas:
# 1.- Pasando un objeto Options en su constructor.
# 2.- Utilizando los nuevos métodos de configuración
##
# Uso del objeto Options (aplicable a todos los productos)
from transbank.webpay.webpay_plus.transaction import Transaction
from transbank.webpay.webpay_plus.transaction import Transaction
from transbank.common.options import WebpayOptions
from transbank.common.integration_type import IntegrationType
tx = Transaction(WebpayOptions("commerceCode", "APIKey", IntegrationType.LIVE))
# Uso de los métodos de configuración
# Webpay Plus
from transbank.webpay.webpay_plus.transaction import Transaction
from transbank.webpay.webpay_plus.mall_transaction import MallTransaction
tx = Transaction.build_for_production("commerceCode", "APIKey")
mall_tx = MallTransaction.build_for_production("commerceCode", "APIKey")
# Oneclick
from transbank.webpay.oneclick.mall_inscription import MallInscription
from transbank.webpay.oneclick.mall_transaction import MallTransaction
inscription = MallInscription.build_for_production("commerceCode", "APIKey")
transaction = MallTransaction.build_for_production("commerceCode", "APIKey")
# Transacción Completa
from transbank.webpay.transaccion_completa.transaction import Transaction
from transbank.webpay.webpay_plus.mall_transaction import MallTransaction
tx = Transaction.build_for_production("commerceCode", "APIKey")
mall_tx = MallTransaction.build_for_production("commerceCode", "APIKey")
# PatPass Comercio
# Es importante destacar que la clase Options para PatPass se importa desde una ruta distinta que en el resto de productos.
from transbank.common.options import PatpassComercioOptions
fromtransbank.patpass_comercio.inscription import Inscription
from transbank.common.integration_type import IntegrationType
# Uso del objeto Options
inscription = Inscription(PatpassComercioOptions("commerceCode", "APIKey", IntegrationType.LIVE))
# Uso del método de configuración
inscription = Inscription.build_for_production("commerceCode", "APIKey")
/**
* Todos los productos se pueden configurar de 2 formas:
* 1.- Pasando un objeto Options en su constructor.
* 2.- Utilizando los nuevos métodos de configuración
*/
//Uso del objeto Options (aplicable a todos los productos)
import { Environment, Options, WebpayPlus } from "transbank-sdk";
const options = new Options("commerceCode", "APIKey", Environment.Production);
const transaction = new WebpayPlus.Transaction(options);
//Uso de los métodos de configuración
//Webpay Plus
import { WebpayPlus } from "transbank-sdk";
const transaction = WebpayPlus.Transaction.buildForProduction(
"commerceCode",
"APIKey"
);
const mallTransaction = WebpayPlus.MallTransaction.buildForProduction(
"commerceCode",
"APIKey"
);
//Oneclick
import { Oneclick } from "transbank-sdk";
const inscription = Oneclick.MallInscription.buildForProduction(
"commerceCode",
"APIKey"
);
const transaction = Oneclick.MallTransaction.buildForProduction(
"commerceCode",
"APIKey"
);
// Transacción Completa
import { TransaccionCompleta } from "transbank-sdk";
const transaction = TransaccionCompleta.Transaction.buildForProduction(
"commerceCode",
"APIKey"
);
const mallTransaction = TransaccionCompleta.MallTransaction.buildForProduction(
"commerceCode",
"APIKey"
);
// PatPass Comercio
// Es importante destacar que la clase Options para PatPass se importa desde una ruta distinta que en el resto de productos.
import { PatpassComercio, PatpassEnvironment, Options } from "transbank-sdk";
//Uso del objeto Options
const options = new Options(
"commerceCode",
"APIKey",
PatpassEnvironment.Production
);
const inscription = new PatpassComercio.Inscription(options);
// Uso del método de configuración
const inscription = PatpassComercio.Inscription.buildForProduction(
"commerceCode",
"APIKey"
);
C) Utilizando la API directamente
Si estás consumiendo la API directamente, solo debes de preocuparte de usar el [host correspondiente al ambiente de producción](https://www.transbankdevelopers.cl/referencia/webpay#ambiente-de-produccion), el código de comercio productivo y llave secreta obtenida en el proceso de validación.
Requerimientos de página de resultado
La página de resultado de comercio, es la página que muestra el comercio cuando Webpay le entrega el control, después del proceso de autorización. Aplica para todos los tipos de transacciones.
Una vez finalizada a transacción, el comercio debe presentar una página al tarjetahabiente para que este se informe del resultado de la transacción. La información a presentar dependerá de si la transacción fue autorizada o no.
Se recomienda, como mínimo, que posea:
- Número de orden de pedido
- Nombre del comercio
- Monto y moneda de la transacción
- Código de autorización de la transacción
- Fecha de la transacción
- Tipo de pago realizado (Débito o Crédito)
- Cantidad de cuotas
- Cuatro últimos dígitos de la tarjeta bancaria
- Descripción de los bienes y/o servicios
Cuando la transacción no sea autorizada, se recomienda informar al tarjetahabiente al respecto. Puede presentar un texto explicativo como:
Orden de Compra XXXXXXX rechazada
Las posibles causas de este rechazo son:
* Error en el ingreso de los datos de su tarjeta de crédito o débito (fecha y/o código de seguridad).
* Su tarjeta de crédito o débito no cuenta con saldo suficiente.
* Tarjeta aún no habilitada en el sistema financiero.
Productos disponibles
Los siguientes productos están disponibles para que puedas realizar la integración. Revisa su documentación acá:
Seguridad
Los servicios Web de Transbank están protegidos para garantizar que solamente miembros autorizados por Transbank hagan uso de las operaciones disponibles.
El mecanismo de seguridad implementado está basado en un canal de comunicación seguro TLS 1.2 sumado a WS-Security (para servicios SOAP) o API Keys + Mensajes firmados (para servicios REST). Esto provee autenticación, confidencialidad e integridad a los Servicios Web.
Los plugins y SDK para Webpay que distribuye Transbank ya están construidos con las librerías necesarias para realizar las validaciones requeridas, pero es deber del comercio asegurarse que la solución o desarrollo de medio de pago que utilice, cumpla con los protocolos de seguridad.
Deberes del comercio
Recomendaciones de integración
- Realiza escaneos de vulnerabilidad a la infraestructura, al menos cada tres meses.
- Mantén todos los componentes actualizados, incluidos el sistema operativo y los plugins usados.
- Utiliza comunicaciones cifradas con protocolos seguros.
- Implementa protección contra malware y contra ataques web: elige un Web Application Firewall (WAF) o Intrusion Prevention System (IPS).
- Cuando desarrolles los sitios web e integraciones sigue las mejores prácticas de entidades reconocidas, como OWASP
[https://owasp.org/www-project-top-ten/](https://owasp.org/www-project-top-ten/) - Prefiere control de accesos restringido únicamente a usuarios autorizados y permite el acceso al Portal de Administración sólo desde ubicaciones seguras y conocidas.
- Crea contraseñas robustas y resguárdalas siempre.
- Respalda la información (código fuente, datos, etc.) en una ubicación distinta a la principal.
- Monitorea constantemente la actividad sospechosa (ej. conexiones de países inusuales en transacciones o consumo excesivo) y respalda los registros de auditoría para tener trazabilidad de cualquier incidencia.
- Una vez al año, realiza auditorías con un profesional externo
Migración de API y SDK
Si necesitas migrar tu integración actual, ya sea mediante integración directa con la API o mediante un SDK, te recomendamos descargar y revisar el documento de migración en el siguiente [Link](/public/files/Upgrade_API_1.2_V2.pdf).
Actualizaciones de plugins y SDK
Si el comercio está utilizando una solución basada en Plugins o SDK,
debe estar atento a las actualizaciones que periódicamente Transbank realizará.
Estas actualizaciones pueden responder a mantener compatibilidad con los e-commerces,
modificaciones por seguridad, adición de propiedades o funcionalidades.
La comunicación oficial siempre se realizará mediante la
[comunidad de Slack](https://invitacion-slack.transbankdevelopers.cl/slack_community) en el canal de Novedades.
También puedes revisar la última versión de los SDK en nuestra web de
[índice de proyectos de ejemplo](https://proyectos-ejemplo.transbankdevelopers.cl/)
Uso de HTTPS
Los servidores del comercio tanto en ambientes de integración como en ambiente de producción deben hacer uso de HTTPS para sus endpoints web (tanto de cara al tarjetahabiente como en los callbacks expuestos a Transbank). El no uso de HTTPS puede provocar problemas en las redirecciones en navegadores modernos (ej: Safari en iOS 11.3 o superior), impidiendo que se complete el flujo de pago.
Validación de montos y órdenes de compra
El comercio debe verificar al completar cualquier transacción que los valores informados por Transbank (monto de la compra, buyOrder, etc.) coinciden con los valores entregados por el comercio al principio del flujo transaccional.

# documentacion_host-to-host.md

Source: https://www.transbankdevelopers.cl/documentacion/host-to-host

Host to Host
¿Manejas un comercio con un alto número de transacciones y gran cantidad de locales, que requieren gestionar de manera centralizada las cuadraturas internas? Transbank tiene una buena alternativa para estos requerimientos. Host to Host, solución que implica un desarrollo en la aplicación de las cajas de tu comercio para integrarla a los equipos provistos por Transbank, conectándose vía enlace dedicado a nuestros servidores, lo que entregará robustez y gran velocidad al proceso de pago y flujo de información.
Cómo funciona
Host to Host requiere de un nivel de integración alto, que consta de las siguientes etapas:
Desarrollo Tu comercio deberá realizar el desarrollo según las especificaciones que te entregará Transbank.
Control de Calidad Este proceso verificará que el desarrollo de integración que hiciste, cumple con los que te entregamos en las especificaciones, o si requiere alguna corrección o mejora.
Etapa piloto En un lugar que acordemos juntos, llevamos a producción tu punto de venta pinpad host, donde con cliente reales haremos monitoreo en conjunto de su funcionamiento, por un periodo acotado de 2 semanas. Evaluamos los resultados, y acordamos masificación, tambien si se requiere algún ajuste.
Masificación Construimos en conjunto un plan de instalación de los puntos de ventas.
Flujo de venta en Pinpad Host:
- El cliente entrega los productos o servicio que desea comprar al vendedor.
- El vendedor realiza la venta en su sistema de caja.
- El vendedor pregunta al cliente como desea pagar, efectivo, tarjeta crédito, tarjeta débito y lo selecciona en la caja.
- La caja invoca al pinpad, pasándole el monto de la venta y la forma de pago crédito o débito
- El cliente opera tarjeta, selecciona cuotas si corresponde, e ingresa su pin
- El pinpad arma el mensaje de requerimiento de venta y lo entrega a la caja.
- La caja toma el mensaje lo entrega al host de comercio y este a su vez al host de Transbank (De ahí su nombre de host to host)
- El mensaje de respuesta recorre el camino inverso hasta llegar al pinpad
- El pinpad verifica la respuesta aprobada o rechaza e integridad del mensaje y entrega resultado a la caja
- La caja imprime los comprobantes de venta.
Equipos y conexiones disponibles
Verifone vx805
Equipo Fijo USB o Serial Pinpad host
![Verifone vx805](https://www.transbankdevelopers.cl/public/slate-library/images/documentacion/host2host/vx805.png)
Driver
Estos equipos funcionan tanto con puerto serial RS232 y USB (generalmente plug and play), para el cual puedes necesitar instalar un [driver de verifone](https://www.transbankdevelopers.cl/files/verifone.zip).
Este driver es compatible con los siguientes sistemas operativos, informados por Verifone:
- Windows 10 de 32/64 bits
- Windows 8/8.1 de 32/64 bits
- Windows 7 de 32/64 bits
Por normas PCI, los comercios no deben utilizar un sistema operativo bajo obsolescencia. Además es muy importante mantener su Sistema Operativo con los últimos parches instalados, esto principalmente por un tema de seguridad.
Verifone vx680
Equipo Movil wifi Pinpad host
![Verifone vx680](https://www.transbankdevelopers.cl/public/slate-library/images/documentacion/host2host/vx680.png)
Verifone e355
Equipo Movil Bluetooth Pinpad host
![Verifone e355](https://www.transbankdevelopers.cl/public/slate-library/images/documentacion/host2host/e355.png)
Funciones de pago disponibles en HOST
- Venta Crédito, con o sin cuotas, propina o donación
- Anulación de venta Crédito.
- Venta Débito, débito con vuelto, propina o donación
- Ventas en modalidad ONUS (tarjetas propias del comercio)
Cómo empezar
A continuación, verás la documentación asociada a como imprimir los voucher.
Puedes revisar la [Referencia](https://www.transbankdevelopers.cl/referencia/host-to-host) para ver la información asociada a la comunicación y los comandos.
Voucher
El pinpad entregará el voucher listo para imprimir, pero también entregará todos los datos necesarios para que la misma caja construya el voucher por sí misma. Si se requiere obtener el voucher duplicado la caja debe construir el voucher, sin los datos de PEL y agregando la glosa duplicado.
Consideraciones
Tipo de transacciones
Estas son las glosas que se deberían desplegar en la cabecera del voucher:
| Tipo de Tarjeta | Tipo de transacción |
|---|---|
| CR | VENTA CRÉDITO |
| CR | ANULACIÓN CRÉDITO |
| DB | VENTA DEBITO |
| NB | VENTA NO BANCARIA |
| NB | ANULACIÓN NO BANCARIA |
| DB | VENTA PREPAGO |
| CR | RESERVA |
| CR | ANULACIÓN RESERVA |
| CR | NO SHOW |
| CR | ANULACIÓN NO SHOW |
| CR | CHECK IN |
| CR | ANULACIÓN CHECK IN |
| CR | REAUTORIZACIÓN |
| CR | ANULACIÓN REAUTORIZACIÓN |
| CR | CHECK OUT |
| CR | ANULACIÓN CHECK OUT |
| CR | CARGO DEMORADO |
| CR | ANULACIÓN CARGO DEMORADO |
| DB | RETIRO EFECTIVO DEBITO |
| CR | AVANCE EFECTIVO CRÉDITO |
| CR | ANULACIÓN AVANCE EFECTIVO CRÉDITO |
Tipos de tarjeta
Considerar que las tarjetas emitidas por las casas comerciales bajo una marca como VISA o Master se consideran bancarias ya no tarjetas no bancarias. Las tarjetas de prepago se considerarán tarjetas de débito.
| Código | Glosa |
|---|---|
| CR | CRÉDITO |
| DB | DÉBITO |
| NB | NO BANCARIA |
| PR | PREPAGO |
Marcas de tarjetas
| Nombre | Abreviación |
|---|---|
| VISA | VI |
| MASTERCARD | MC |
| AMEX | AX |
| DINERS | DC |
| DISCOVER | DC |
| MAGNA | MG |
| PRESTO | TP |
| MAS | TM |
| RIPLEY | TR |
| RIPLEY | RP |
| CMR | TC |
| DEBITO | DB |
| ELECTRON | EL |
| MAESTRO | MT |
| PREPAGO | PR |
Orden de impresión
La idea de este voucher es que sea la única salida para cualquier tipo de voucher de Transbank, al ser un voucher único, independiente del tipo de transacción siempre se hacen las mismas validaciones, para ver si se imprime o no cada campo, sea voucher de crédito, débito o anulación de crédito.
Siempre se deben imprimir dos copias de voucher una para el comercio y otra para el cliente. En el caso de voucher con firma si el comercio lo desea puede no imprimir en la copia del comercio, las líneas de firmas, nombre del cliente y rut, en el voucher del comercio debe estar firmado si aplica.
El orden de impresión debe ser:
- Voucher de premio de TBK
- Voucher del cliente de TBK
- Voucher del comercio de TBK
Cualquier variación al orden o formato del voucher debe ser autorizada por Transbank
Otras consideraciones
Algunas consideraciones en la impresión de los voucher de Transbank
- Los vouchers deben contener exclusivamente la información solicitada en este manual. Cualquier excepción debe ser autorizada y formalizada por Transbank.
- El nombre del cliente se puede imprimir solo en voucher con firma
- Las líneas de vuelto no deben imprimirse si no están siendo utilizadas.
- Las líneas de donación o propina no deben imprimirse si no están siendo utilizadas.
- Los vouchers de premio NO deben ser impresos en papel auto copiativo. En caso de que el cliente solamente posea impresoras que utilicen papel autocopiativo, debe notificarse a Transbank de esta situación, y es este último quien debe autorizar el que sea aceptado este tipo de impresión, pudiendo quedar fuera la funcionalidad de promociones en línea.
- Solo debe generarse una copia de un voucher de premio, frente a cualquier condición de borde si no se pudo imprimir el voucher, se pierde el premio, en el duplicado no debe figurar nada al respecto.
- NO es posible reimprimir el voucher de premio ni realizar alusiones de premio en los vouchers de Transbank en caso de la impresión de un duplicado.
- El código del premio y las glosas son entregadas por el PINPAD luego de validar la respuesta del requerimiento.
- La impresión de voucher DEBE ser realizada en forma automática, al aprobarse la transacción, no opcional ni manual. No debe depender de un enter en caja para liberar la impresión
- Para los casos en que sea necesaria la firma del tarjetahabiente, la impresión DEBE suponer un espacio adecuado para dicha operación.
- El inicio de una nueva transacción DEBE realizarse SOLO al momento de finalizada la impresión del voucher de la transacción anterior, NUNCA durante su impresión o reimpresión, dado que la transacción se da por finalizada al momento de la impresión del voucher o su reimpresión.
- La separación entre los vouchers (de transacciones (original/copia), de premio) puede ser física (corte) o delimitada por líneas punteadas.
- Lo último que debe ser impreso es el voucher Transbank
- El voucher en impresora fiscal va entre las glosas. “INICIO COMENTARIO” y “FIN COMENTARIO”. Dado el número de líneas posibles de imprimir en este tipo de impresoras, está permitido la eliminación de líneas en blanco para que el voucher pueda ser impreso correctamente. Cada voucher podría ir separado por un inicio y fin de comentario, esto es el voucher de pel el de cliente y el del comercio.
Voucher de venta o anulaciones
![](https://www.transbankdevelopers.cl/public/slate-library/images/documentacion/host2host/voucher-venta.png)
Voucher Pel y reimpresión
Solo se permite imprimir 1 vez el voucher original y el voucher de PEL, si existe algún problema con
la impresión del voucher original se debe abortar la impresión y permitir obtener duplicado.
Original:
- Voucher de PEL
- Voucher 1 comercio/cliente
- Voucher 2 comercio/cliente
Duplicados:
- Voucher 1 comercio/cliente “duplicado sin glosa pel”
- Voucher 2 comercio/cliente “duplicado sin glosa pel”
Voucher pel 1 - Premiación en línea
Se debe imprimir este voucher solo si: COMANDO H505 CAMPO TIPO DE VOUCHER = Entrega Pto. de Venta
![](https://www.transbankdevelopers.cl/public/slate-library/images/documentacion/host2host/voucher-pel-1.png)
Voucher pel 2 - Premiación en línea
Se debe imprimir este voucher solo si: COMANDO H505 CAMPO TIPO DE VOUCHER = |2| Entrega Diferida
![](https://www.transbankdevelopers.cl/public/slate-library/images/documentacion/host2host/voucher-pel-2.png)
Voucher pel 3 - Premiación en línea
Se debe imprimir este voucher solo si: COMANDO H505 CAMPO TIPO DE VOUCHER = |3| Devolución al Tarjeta Habiente
![](https://www.transbankdevelopers.cl/public/slate-library/images/documentacion/host2host/voucher-pel-3.png)
ANEXO ONUS
Objetivos
Esta documentación describe la forma de operar, la funcionalidad y el detalle de la mensajería de un PINPAD TRANSBANK trabajando bajo la modalidad OnUs.
La aplicación del PINPAD, supone la existencia de un ECR inteligente (por ejemplo una caja registradora) que enviará los requerimientos al PINPAD, para que este los procese y entregue los resultados cuando corresponda.
Audiencia
Para entender completamente esta documentación es necesario tener conocimientos transaccionales y conocer las funciones implementadas habitualmente en los PINPAD usados en las transacciones bancarias.
En particular este manual está dirigido exclusivamente a los comercio ONUS que tienen tarjetas propias y utilizan el pinpad de Transabank para leer sus tarjetas, pero las transacciones las realizan y autorizan ellos mismos.
Alcance
Aplica para el equipo Verifone vx805 (Conexión Serial o USB)
Aplica para el equipo Verifone e355 (Conexión Bluetooth)
Puedes revisar la [Referencia](https://www.transbankdevelopers.cl/referencia/host-to-host#anexo-onus) para ver la información asociada a la comunicación y los comandos.
Especificaciones técnicas y salidas especiales
Cuadratura y liquidación
En esta sección se describen los archivos de cuadratura y liquidación que se entregan al cliente que utiliza el servicio de Salidas Especiales. Los archivos de cuadratura (conciliación) son archivos planos que contienen los registros de las transacciones (de venta y anulación) efectuadas en un comercio dentro de un periodo determinado. Los archivos de liquidación son archivos planos que contienen los registros de los abonos y retenciones hechas sobre la cuenta del comercio dentro de un período determinado.
Distribución
Los archivos de cuadratura y liquidación son colocados periódicamente en una casilla SFTP creada en forma exclusiva para el respectivo comercio, para que este los descargue a su propio sistema. La siguiente tabla indica la frecuencia y horario de colocación de archivos de cuadratura y liquidación en la casilla:
| Archivo | Periodo abarcado | Colocación en casilla | Horario de copia de archivos |
|---|---|---|---|
| Cuadratura | 00ºº hrs día – 00ºº hrs día siguiente | Todos los días | 12:00 Martes 14:00 |
| Liquidación | 00ºº hrs día – 00ºº hrs día siguiente | Día hábil | 12:00 Martes 14:00 |
Acceso a la casilla
Los comercios deberán utilizar alguna aplicación del tipo cliente SFTP disponible en el mercado para el acceso a la casilla, algunas de estas pueden ser Filezilla, WinSCP, PuTTY, MobaxTerm
El nombre de los archivos de las Salidas especiales (SSEE) se generará en forma dinámica a partir de los datos ingresados en el enrolamiento más la fecha de proceso
<Formato de Salida>_<Periodo>_<Agrupación Archivo de Salidas>_<RutComercio ó CódigoComercio>_<Tipo Conexion>_<Agrupación de Transacciones>_<Número Agrupación>
Formato de Salida
- LDN: Liquidación de débito
- LCN: Liquidación de crédito
- CDN: Cuadratura de débito
- CCN: Cuadratura de crédito
Periodo
- Diaria: Se genera un archivo diario en base a la fecha de proceso
- Mensual: Se genera un archivo por mes. Fecha asociada al penúltimo día hábil del mes
Agrupación Archivo de Salidas
- RE: Archivo con información única asociada al RUT enrolado (Genera un archivo)
- CC: Archivo con información separada por código de comercio de la transacción (genera un archivo diferente para cada código de comercio)
Tipo Conexión
- Se genera un único archivo. Información de archivos no es separada por tipo de conexión (cuando es un archivo único no es parte del nombre)
- Cuando se genera un archivo para transacciones con tipo de conexión presencial y no presencial o NP: No presencial o PR: presencial
Agrupación de transacciones
- Cuando esta agrupado por RUT no se incluye en el nombre del archivo
- RB: Rubro
Número Agrupación
- Corresponderá al número del Rubro enrolado.
Archivo de cuadratura crédito (L3)
A continuación, se describe en detalle la estructura de los registros de los archivos de cuadratura crédito. Cada archivo tiene un registro de encabezamiento (“header”), luego un registro por cada transacción efectuada en el periodo abarcado y al final un registro de pie (“footer”). El archivo de cuadraturas crédito contiene el registro al detalle de las transacciones financieras efectuadas con tarjeta de crédito. Contiene tanto las transacciones procesadas en forma presencial como no presencial.
Header
| Nombre | Descripción | Formato | Largo | Total |
|---|---|---|---|---|
| Dktt-Hr-Reg | "HR" | Alfanumérico | 2 | 2 |
| Dktt-Hr-Fech-Proc | Fecha De Proceso Formato "AAMMDD" El día en el que se procesa el archivo es el día hábil inmediato al período abarcado. |
Numérico | 6 | 8 |
| Dktt-Hr-Hora-Proc | Hora De Proceso Formato "HHMMSS" | Numérico | 6 | 14 |
| Dktt-Hr-Glosa | Nombre Del Comercio Nombre de Fantasía del comercio |
Alfanumérico | 25 | 39 |
| Filler | Disponible | Alfanumérico | 282 | 321 |
Footer
| Nombre | Descripción | Formato | Largo | Total |
|---|---|---|---|---|
| Dktt-Tr-Reg | Valor fijo "TR" | Alfanumérico | 2 | 2 |
| Dktt-Tr-Fech-Proc | Fecha De Proceso Formato "AAMMDD" | Numérico | 6 | 8 |
| Dktt-Tr-Hora-Proc | Hora De Proceso Formato "HHMMSS" | Numérico | 6 | 14 |
| Dktt-Tr-Cant-Reg | Total De Registros | Numérico | 7 | 21 |
| Dktt-Tr-Acum-Monto | Total. 11 enteros 2 decimales | Numérico | 13 | 34 |
| Dktt-Tr-Fech-Desde | Fecha menor de Txs Formato "AAMMDD". De entre las transacciones registradas en el archivo indica la fecha en la que se realizó la más temprana. |
Numérico | 6 | 40 |
| Dktt-Tr-Hora-Desde | Hora menor de Txs Formato "HHMMSS". De entre las transacciones registradas en el archivo indica la hora en la que se realizó la más temprana. |
Numérico | 6 | 46 |
| Dktt-Tr-Fech-Hasta | Fecha mayor de Txs. Formato "AAMMDD". De entre las transacciones registradas en el archivo indica la fecha en la que se realizó la más tardía. |
Numérico | 6 | 52 |
| Dktt-Tr-Hora-Hasta | Hora mayor de Txs. Formato "HHMMSS". De entre las transacciones registradas en el archivo indica la hora en la que se realizó la más tardía |
Numérico | 6 | 58 |
| Filler | Disponible | Alfanumérico | 263 | 321 |
Detalle La siguiente tabla describe cada uno de sus campos:
| Nombre | Descripción | Formato | Largo | Total |
|---|---|---|---|---|
| DSK-DT-REG | Tipo de Registro Valor fijo “DT” | Alfanumérico | 2 | 2 |
| DSK-TYP | Tipo de Transacción 0210 : venta en línea 0420 : reversa | Numérico | 4 | 6 |
| DSK-TC | Código de Transacción4 "10" : Compra "18" : Compra con vuelto "30" : Retención | Numérico | 2 | 8 |
| DSK-TRAN-DAT | Fecha de la Transacción Formato “AAMMDD”. Corresponde a la fecha en la cual Transbank emitió respuesta a la transacción |
Numérico | 6 | 14 |
| DSK-TRAN-TIM | Hora de la Transacción Formato “HHMMSS”. Corresponde a la hora en la cual Transbank emitió respuesta a la transacción |
Numérico | 6 | 20 |
| DSK-ID-RETAILER | Código del Comercio Prestador | Numérico | 12 | 32 |
| DSK-NAME-RETAILER | Nombre del Comercio Nombre de fantasía del comercio |
Alfanumérico | 20 | 52 |
| DSK-CARD | Número de Tarjeta Sólo aparecen los últimos 4 dígitos, los demás están enmascarados con * |
Alfanumérico | 19 | 71 |
| DSK-AMT-1 | Monto de la Compra. 11 enteros 2 decimales | Numérico | 13 | 84 |
| DSK-AMT-2 | Monto del Vuelto. 11 enteros 2 decimales | Numérico | 13 | 97 |
| DSK-AMT-PROPINA | Monto Propina. 7 enteros 2 decimales | Numérico | 9 | 106 |
| DSK-RESP-CDE | Código de Respuesta Emitido por Base-24. Los valores entre 000 y 009 indican transacción aprobada. |
Alfanumérico | 3 109 | |
| DSK-APPRV-CDE | Código de Aprobación “O De Autorización”. Entregado por el Emisor. |
Alfanumérico | 8 | 117 |
| DSK-TERM-NAME | Código del terminal POS Terminal ID | Alfanumérico | 16 | 133 |
| DSK-ID-CAJA | Identificador de la Caja | Alfanumérico | 16 | 149 |
| DSK-NUM-BOLETA | Número de Boleta | Alfanumérico | 10 | 159 |
| DSK-FECHA-PAGO | Fecha de Pago 1 día hábil después de la fecha de Proceso del archivo |
Numérico | 6 | 165 |
| DSK-IDENT | identificador del Host Corresponde al “Identificador del Comercio” que aparece al principio del nombre del nombre del archivo |
Alfanumérico | 2 | 167 |
| DSK-ID-RETAILER | Código del Comercio Responsable Código del comercio intermediario (si lo hubiese) entre el Comercio y la tarjeta habiente |
Numérico | 8 | 175 |
| DSK-ID-COD-SERVI | Código de Servicio | Alfanumérico | 20 | 195 |
| DSK-ID-NRO-UNICO | Número único Asignado por el comercio |
Alfanumérico | 26 | 221 |
| DSK-PREPAGO | Prepago Valor “P” para registros que provienen de prepago. En blanco si se trata de una transacción de otro producto. |
Alfanumérico | 1 | 222 |
| FILLER | Disponible | Alfanumérico | 18 | 240 |
Archivo de cuadratura débito (L3)
El archivo de cuadraturas débito contiene el registro al detalle de las transacciones financieras efectuadas con tarjeta de débito. Contiene tanto las transacciones procesadas en forma presencial como no presencial.
Header
| Nombre | Descripción | Formato | Largo | Total |
|---|---|---|---|---|
| Dktt-Hr-Reg | Tipo de registro | Alfanumérico | 2 | 2 |
| Dktt-Hr-Fech-Proc | Fecha De Proceso | Numérico | 6 | 8 |
| Dktt-Hr-Hora-Proc | Hora De Proceso | Numérico | 6 | 14 |
| Dktt-Hr-Glosa | Nombre Del Comercio Nombre de Fantasía del comercio |
Alfanumérico | 25 | 39 |
| Filler | Disponible | Alfanumérico | 201 | 240 |
Footer
| Nombre | Descripción | Formato | Largo | Total |
|---|---|---|---|---|
| DSK-TR-REG | Tipo de Registro. Valor "TR" | Alfanumérico | 2 | 2 |
| DSK-TR-FECHA-PROC | Fecha de Proceso | Numérico | 6 | 8 |
| DSK-TR-HORA-PROC | Hora de proceso | Numérico | 6 | 14 |
| DSK-TR-TOT-REG | Total Registros | Numérico | 7 | 21 |
| DSK-TR-MONTO | Monto Total. 11 enteros 2 decimales | Numérico | 13 | 34 |
| DSK-TR-MONTO-COM | Monto Comisiones Total. 11 enteros 2 | Numérico | 13 | 47 |
| FILLER | Alfanumérico | 193 | 240 |
Detalle
| Nombre | Descripción | Formato | Largo | Total |
|---|---|---|---|---|
| DSK-DT-REG | Tipo de Registro Valor fijo “DT” | Alfanumérico | 2 | 2 |
| DSK-TYP | Tipo de Transacción 0210 : venta en línea 0420 : reversa | Numérico | 4 | 6 |
| DSK-TC | Código de Transacción4 "10" : Compra "18" : Compra con vuelto "30" : Retención | Numérico | 2 | 8 |
| DSK-TRAN-DAT | Fecha de la Transacción Formato “AAMMDD”. Corresponde a la fecha en la cual Transbank emitió respuesta a la transacción |
Numérico | 6 | 14 |
| DSK-TRAN-TIM | Hora de la Transacción Formato “HHMMSS”. Corresponde a la hora en la cual Transbank emitió respuesta a la transacción |
Numérico | 6 | 20 |
| DSK-ID-RETAILER | Código del Comercio Prestador | Numérico | 12 | 32 |
| DSK-NAME-RETAILER | Nombre del Comercio Nombre de fantasía del comercio |
Alfanumérico | 20 | 52 |
| DSK-CARD | Número de Tarjeta Sólo aparecen los últimos 4 dígitos, los demás están enmascarados con * |
Alfanumérico | 19 | 71 |
| DSK-AMT-1 | Monto de la Compra. 11 enteros 2 decimales | Numérico | 13 | 84 |
| DSK-AMT-2 | Monto del Vuelto. 11 enteros 2 decimales | Numérico | 13 | 97 |
| DSK-AMT-PROPINA | Monto Propina. 7 enteros 2 decimales | Numérico | 9 | 106 |
| DSK-RESP-CDE | Código de Respuesta Emitido por Base-24. Los valores entre 000 y 009 indican transacción aprobada. |
Alfanumérico | 3 109 | |
| DSK-APPRV-CDE | Código de Aprobación “O De Autorización”. Entregado por el Emisor. |
Alfanumérico | 8 | 117 |
| DSK-TERM-NAME | Código del terminal POS Terminal ID | Alfanumérico | 16 | 133 |
| DSK-ID-CAJA | Identificador de la Caja | Alfanumérico | 16 | 149 |
| DSK-NUM-BOLETA | Número de Boleta | Alfanumérico | 10 | 159 |
| DSK-FECHA-PAGO | Fecha de Pago 1 día hábil después de la fecha de Proceso del archivo |
Numérico | 6 | 165 |
| DSK-IDENT | identificador del Host Corresponde al “Identificador del Comercio” que aparece al principio del nombre del nombre del archivo |
Alfanumérico | 2 | 167 |
| DSK-ID-RETAILER | Código del Comercio Responsable Código del comercio intermediario (si lo hubiese) entre el Comercio y la tarjeta habiente |
Numérico | 8 | 175 |
| DSK-ID-COD-SERVI | Código de Servicio | Alfanumérico | 20 | 195 |
| DSK-ID-NRO-UNICO | Número único Asignado por el comercio |
Alfanumérico | 26 | 221 |
| DSK-PREPAGO | Prepago Valor “P” para registros que provienen de prepago. En blanco si se trata de una transacción de otro producto. |
Alfanumérico | 1 | 222 |
| FILLER | Disponible | Alfanumérico | 18 | 240 |
Archivo de liquidaciones crédito (L5)
El archivo de liquidaciones crédito contiene el registro al detalle de los abonos y retenciones sobre la cuenta del comercio dentro de un período determinado por transacciones con tarjeta de crédito.
Header
| Nombre | Descripción | Formato | Largo | Total |
|---|---|---|---|---|
| Abono - Desde | Fecha inicio periodo de abono ddmmaaaa | Numérico | 8 | 8 |
| Filler | Relleno | Alfanumérico | 1 | 9 |
| Abono – Hasta | Fecha de término periodo de abono ddmmaaaa | Numérico | 8 | 17 |
| Filler | Relleno | Alfanumérico | 1 | 18 |
| Proceso – Fecha | Fecha de proceso, en formato ddmmaaaa | Numérico | 8 | 26 |
| Filler | Relleno | Alfanumérico | 1 | 27 |
| Abono - Fecha | Fecha de pago de las transacciones, en formato ddmmaaaa | Numérico | 8 | 35 |
SI largo de código cliente es menor que 4
| Nombre | Descripción | Formato | Largo | Total |
|---|---|---|---|---|
| Código cliente | Número interno de cliente | Numérico | 3 | 38 |
| Nombre de cliente | Nombre del comercio | Alfanumérico | 20 | 58 |
| Filler | Relleno | Alfanumérico | 76 | 134 |
| Filler | Contiene " HEADER" | Alfanumérico | 6 | 140 |
| Filler | Relleno | Alfanumérico | 89 | 229 |
SI largo de código cliente es mayor que 3
| Nombre | Descripción | Formato | Largo | Total |
|---|---|---|---|---|
| Código cliente | Número interno de cliente | Numérico | 5 | 40 |
| Nombre de cliente | Nombre del comercio | Alfanumérico | 20 | 60 |
| Filler | Relleno | Alfanumérico | 74 | 134 |
| Filler | Contiene " HEADER" | Alfanumérico | 6 | 140 |
| Filler | Relleno | Alfanumérico | 89 | 229 |
Footer
| Nombre | Descripción | Formato | Largo | Total |
|---|---|---|---|---|
| Sal - Contador | Número de transacciones a abonar | Numérico | 10 | 10 |
| Filler | Relleno | Alfanumérico | 1 | 11 |
| Sal - Monto | Monto total de las ventas a abonar (11 enteros, 2 decimales) | Numérico | 13 | 24 |
| Filler | Relleno | Alfanumérico | 1 | 25 |
| Sal - Rret. | Número de retenciones | Numérico | 10 | 35 |
| Filler | Relleno | Alfanumérico | 1 | 36 |
| Sal - Ret. | Monto total de retenciones (11 enteros, 2 decimales) | Numérico | 13 | 49 |
| Filler | Relleno | Alfanumérico | 1 | 50 |
| Sal - Ceic | Monto total de comisión más IVA de la comisión (Venta) (11 enteros, 2 decimales) | Numérico | 13 | 63 |
| Sal - caeica | Monto total de comisión adicional más IVA adicional de la comisión (11 enteros, 2 decimales) | Numérico | 13 | 76 |
| Sal - dceic | Monto total de comisión más IVA de la comisión (Retenciones) (11 enteros, 2 decimales) | Numérico | 13 | 89 |
| Sal - dcaeica | Monto total de comisión adicional más IVA adicional de la comisión (Retenciones) (11 enteros, 2 decimales). | Numérico | 13 | 102 |
| Filler | Relleno | Alfanumérico | 32 | 134 |
| Filler | Contiene " FOOTER" | Alfanumérico | 6 | 140 |
| Filler | Relleno | Alfanumérico | 89 | 229 |
Detalle
| Nombre | Descripción | Formato | Largo | Total |
|---|---|---|---|---|
| Liq-Numc | Código de Comercio | Numérico | 8 | 8 |
| Liq-Fproc | Fecha de Proceso, en formato ddmmaaaa | Numérico | 8 | 16 |
| Liq-Fcom | Fecha de la venta o retención, en formato ddmmaaaa | Numérico | 8 | 24 |
| Liq-Micr | Número de Microfilm | Alfanumérico | 8 | 32 |
| Liq-Numta | Número de Tarjeta SI numPedido es nulo | Alfanumérico | 19 | 51 |
| Liq-Marca | Tipo de Tarjeta. Los valores son, VI: Visa; MC: Master; DI: Diners; AX: Amex | Alfanumérico | 2 | 53 |
| Liq-Monto | Monto de la venta o retención (11 enteros, 2 decimales) | Numérico | 11 | 64 |
| Liq-Moneda | Tipo de Moneda. 0: pesos; 1: dólar. | Numérico | 1 | 65 |
| Liq-Txs | Tipo de transacción. Si es venta:”VA” Venta a abonar “VP” Venta pareada con retención (“RP”). Si es retención: “RP” Retención pareada con venta (“VP”) “RA” Retención total aplicada “RC” Saldo de retención aplicada en forma parcial. “RE” Retención Pendiente |
Alfanumérico | 2 | 67 |
| Liq-Rete | Atributo de la transacción. Si es venta a abonar o pareada va “0000”. Si es venta 3CSI, va “C3C” donde es el número de la cuota. Si es venta Cuotas Comercio, va “I&&&”, donde &&& es la cantidad de cuotas, alineada a la derecha. Si es venta NCuotas, va “nnSI”, donde nn indica el número de cuotas (02 a 24) y SI indica: cuotas sin interés.Si es retención, va el código de retención. | Alfanumérico | 4 | 71 |
| Liq-Cprin | Código de casa matriz del comercio. Si LiqNumc es la matriz, lleva “99999999”. | Numérico | 8 | 79 |
| Liq-Fpago | Fecha de pago, en formato ddmmaaaa | Numérico | 8 | 87 |
| Liq-orpedi | Número de Orden de Pedido o Código de Barra | Alfanumérico | 26 | 113 |
| Liq-codaut | Código de autorización de transacción | Alfanumérico | 6 | 119 |
| Liq-cuotas | Número de cuota que se está abonando y que opera para ventas efectuadas con los productos Ncuotas o Ventas en cuotas sin intereses. | Numérico | 2 | 121 |
| Liq-vci | Valor de autentificación de la transacción (Venta) | Numérico | 4 | 125 |
| Liq-ceic | Valor de la comisión más IVA de la comisión(Venta) | Numérico | 11 | 136 |
| Liq-caeica | Valor de la comisión adicional más IVA adicional de la comisión | Numérico | 11 | 147 |
| Liq-dceic | Valor de la comisión más IVA de la comisión(Retenciones) | Numérico | 11 | 158 |
| Liq-dcaeica | Valor de la comisión adicional más IVA adicional de la comisión (Retenciones) | Numérico | 11 | 169 |
| Liq-ntc | número total de cuotas de la venta original y que opera para ventas efectuadas con los productos NCuotas o Ventas en cuotas sin intereses. | Numérico | 2 | 171 |
| Liq_Nombre_banco | Nombre del banco indicará el nombre del banco | Alfabético | 35 | 206 |
| Liq_Tipo_cuenta_banco | Tipo de la cuenta del banco asociada al abono | Alfabético | 2 | 208 |
| Liq_Número_cuenta_banco | Número de la cuenta del banco asociada al abono | Alfabético | 18 | 226 |
| Liq_Moneda_cuenta_banco | Moneda de la cuenta de abono seleccionada | Alfabético | 3 | 229 |
Archivo de liquidaciones débito (L5)
El archivo de liquidaciones débito contiene el registro al detalle de los abonos y retenciones sobre la cuenta del comercio dentro de un período determinado por transacciones con tarjeta de débito.
Header
| Nombre | Descripción | Formato | Largo | Total |
|---|---|---|---|---|
| Abono-Desde | Fecha inicio periodo de abono Formato ‘ddmmaa’ | Numérico | 6 | 6 |
| Filler | Disponible | Alfanumérico | 1 | 7 |
| Abono-Hasta | Fecha final periodo de abono Formato ‘ddmmaa’ | Numérico | 6 | 13 |
| Filler | Disponible | Alfanumérico | 4 | 17 |
| Liqu-Fecha | Fecha de liquidación Formato ‘ddmmaa’ | Numérico | 6 | 23 |
| Filler | Disponible | Alfanumérico | 1 | 24 |
| Nombre-Fan | Nombre de fantasía del comercio | Alfanumérico | 25 | 49 |
| Header | Indicador de registros “HEADER” | Alfanumérico | 6 | 55 |
| Filler | Disponible | Alfanumérico | 160 | 215 |
Footer
| Nombre | Descripción | Formato | Largo | Total |
|---|---|---|---|---|
| Liq-Ncom | Sumatoria de registros de detalle Para registros de detalle con Liq-Ttra = “00” | Numérico | 10 | 10 |
| Filler | Disponible | Numérico | 1 | 11 |
| Liq-Tcom | Sumatoria de campo Liq-Amt1. 11 enteros 2 decimales Para registros de detalle con Liq-Ttra = “00” |
Numérico | 13 | 24 |
| Filler | Disponible | Numérico | 1 | 25 |
| Liq-Nret | Sumatoria de registros de detalle de retenciones | Numérico | 10 | 35 |
| Filler | Disponible | Alfanumérico | 1 | 36 |
| Liq-Mret | Sumatoria de campo Liq-Amt1, para registros de detalle con Liq-Ttra =”03”. 11 enteros 2 decimales | Numérico | 13 | 49 |
| Liq-Vret | Valores fijos de “000000000” | Numérico | 9 | 58 |
| Liq-Tret | Valores fijos de “0000000000” | Numérico | 10 | 68 |
| Footer | Indicador del tipo de registros “FOOTER” | Alfanumérico | 6 | 74 |
| Liq-Tot-Com-comiv | Sumatoria de la comisión más IVA de la comisión (Venta). 11 enteros 2 decimales | Numérico | 13 | 87 |
| Filler | Disponible | Alfanumérico | 1 | 88 |
| Liq-Tot-decom-ivcom | Sumatoria de la comisión más IVA de la comisión (Retenciones). 11 enteros 2 decimales | Numérico | 13 | 101 |
| Liq-Fill | Alfanumérico | 114 | 215 |
Detalle
| Nombre | Descripción | Formato | Largo | Total |
|---|---|---|---|---|
| Liq-Ccre | Código de Comercio interno de Transbank Es el código asignado al comercio por Transbank. No incluye el prefijo 5970. | Numérico | 8 | 8 |
| Liq-Fpro | Fecha de proceso del archivo Formato ‘ddmmaa’. Corresponde a la fecha de proceso de la respectiva transacción. | Numérico | 6 | 14 |
| Liq-Fcom | Fecha de compra Formato ‘ddmmaa’. Corresponde a la fecha en la cual se realizó la transacción | Numérico | 6 | 20 |
| Liq-Appr | Código de Autorización Entregado por el autorizador | Alfanumérico | 6 | 26 |
| Liq-Pan | Número de la tarjeta Sólo últimos cuatro dígitos, demás caracteres con asteriscos | Alfanumérico | 19 | 45 |
| Liq-Amt1 | Monto de la transacción. 11 enteros 2 decimales | Numérico | 13 | 58 |
| Liq-Ttra | Tipo de transacción = 0 : compra abonada mayor que 0 : retención |
Numérico | 2 | 60 |
| Liq-Cpri | Valor fijo “99999999” | Numérico | 8 | 68 |
| Liq-Marc | Retenciones Valor “RE” : para retenciones En blanco si se trata de una transacción abonada. | Alfanumérico | 2 | 70 |
| Liq-Fedi | Fecha de Liquidación Formato ‘dd/mm/aa’ Corresponde a la fecha de abono de la transacción respectiva | Alfanumérico | 8 | 78 |
| Liq-nro-unico | Número único | Alfanumérico | 26 | 104 |
| Liq-com-comiv | Valor de la comisión más IVA de la comisión (Venta). 11 enteros 2 decimales | Numérico | 13 | 117 |
| Liq-cad-cadiva | N/A Se rellena el largo con “0”. 11 enteros 2 decimales | Numérico | 13 | 130 |
| Liq-decom-ivcom | Valor de la comisión más IVA de la comisión(Retenciones). 11 enteros 2 decimales | Numérico | 13 | 143 |
| Liq-dcoad-ivcom | N/A Se rellena el largo con “0”. 11 enteros 2 decimales | Numérico | 13 | 156 |
| Liq_prepago | Prepago Valor “P” para registros que provienen de prepago. En blanco si se trata de una transacción de otro producto. | Alfanumérico | 1 | 157 |
| Liq_Nombre_banco | Nombre del banco se indicará el nombre del banco | Alfabético | 35 | 192 |
| Liq_Tipo_cuenta_banco | Tipo de la cuenta del banco asociada al abono | Alfabético | 2 | 194 |
| Liq_Número_cuenta_banco | Número de la cuenta del banco asociada al abono | Alfabético | 18 | 212 |
| Liq_Moneda_cuenta_banco | Moneda de la cuenta de abono seleccionada | Alfabético | 3 | 215 |
Notas
- Todos los campos “Fecha de Proceso” explicados en este documento aplican a la Fecha de Proceso del archivo
- La siguiente tabla indica qué transacciones pueden ocurrir tanto a través de Host como POS de contingencia, y cuáles solo a través de una de ambas vías:
| Tipo de transacción | |||
| Código de Transacción | 210 | 220 | 420 |
|---|---|---|---|
| 10 | Host - POS | Host - POS | Host - POS |
| 13 | Webpay | Webpay | |
| 14 | POS - Webpay | Host | Host - POS - Webpay |
| 18 | Host - POS | Host - POS |
- Para las aplicaciones con mensajería SPDH 3.1 las transacciones de anulación efectuadas a través del Host son consideradas como FS04 (fuera de línea), lo que en el archivo quedaría representado como una 220-14
- Para efectos de parear transacciones, solo se deben considerar los registros con código de transacción “10” (Compras), “13” (WebPay) y “18” (Compra con vuelto).
- Para los registros correspondientes a transacciones retenidas (Código de Transacción “30”), se informarán solamente los siguientes campos: o Fecha de Transacción (Dktt-Dt-Tran-Dat) o Código de comercio (Dktt-Dt-Id-Retailer) o Número de Único (DSK-ID-NUM-UNICO) o Monto de la transacción (Dktt-Dt-Amt-1)
- Para el caso de Liquidación el campo (liq-vci), podrá contener los valores TSY (correctamente autenticada), ya que muestras solo autorizaciones ok nacionales. En el caso de una transacción internacional, podrás visualizar TSY y A (intento de autenticación)
- En los casos de archivo de cuadratura, el campo (Dktt-Dt-VCI) además de los casos anteriores, también existirán los rechazos con TO (TimeOut) y TSN (Transacción no autenticada).
Archivo de saldos
Considera los saldos contables pendientes de abono para los productos Crédito ($ y US$) y Débito. Contiene todas las transacciones que se encuentran procesadas hasta el cierre contable (último día de proceso hasta las 14:00 hrs.) y que se encuentran pendientes de abono (ventas) o cargo (retenciones).
Material disponible en la casilla
- Detalle Saldos Contables Pendientes de abono; Archivo que contiene todas las transacciones pendientes de abono que respaldan el informe disponible en portal
- Detalle transacciones al cierre de Mes; Archivo que presenta el detalle de transacciones al cierre del mes, que no han sido procesadas dentro del mes y que no conforman el informe de saldo pendientes de abono. Para cada casilla de cliente se le creará una carpeta llamada CARTOLA_SALDOS, dentro de ella estará todos los archivos en donde su nombre identificará con PREFIJO_FECHA_RUT (DET_DDMMYYY_XXXXXXXXX).
DET_31102018_761349465. (.txt) COL_31122018_761349465. (.txt)
Estructura de archivo de texto
| Campo | Tipo Dato | Largo |
|---|---|---|
| FECHA PROCESO | DATE | |
| RUT COMERCIO | STRING | 9 |
| CÓDIGO COMERCIO | STRING | 8 |
| TIPO CONTRATO | STRING | 2 |
| DESCRIPCIÓN TIPO CONTRATO | STRING | 13 |
| TIPO FLUJO | STRING | 4 |
| DESCRIPCIÓN TIPO FLUJO | STRING | 2 |
| FECHA VENTA | DATE | |
| FECHA ABONO | DATE | |
| TARJETA | STRING | 19 |
| NRO CUOTA | NUMBER | 2 |
| MONTO CUOTA | NUMBER | 17,2 |
| LNIN SEC | NUMBER | 23 |
| FECHA PROCESO TXS | DATE | |
| MONTO VENTA | NUMBER | 17,2 |
| CÓDIGO AUTORIZACIÓN | STRING | 6 |
| ORDEN PEDIDO | STRING | 26 |
| ID SERVICIO | STRING | 20 |
| PAREADA | STRING | 2 |
Estructura nombres archivos saldos
Los nombres de archivos tendrán una nueva estructura, según el siguiente detalle:
<Formato de Salida>_<Periodo>_<Agrupación Archivo de Salidas>_<Agrupación de Transacciones>_<RutEnrolado ó CódigoComercio>_<Tipo Conexion><Modo Agrupación>
<Formato de Salida>
corresponde al formato de salida:
LDN = Liquidación de débito
LCN = Liquidación de crédito
CDN = Cuadratura de débito
CCN = Cuadratura de crédito
<Periodo>
corresponde a la fecha en formato DDMMAAAA, según la frecuencia
configurada:
- Diaria: Se genera un archivo diario en base a la fecha de proceso; esta es la frecuencia por defecto
- Mensual: Se genera un archivo por mes. Fecha asociada al penúltimo día hábil del mes
<Agrupación Archivo de Salidas>
corresponde a la naturaleza de agrupación:
- RE: Archivo con información única asociada al RUT enrolado (Genera un archivo)
- CC: Archivo con información separada por código de comercio de la transacción (genera un archivo diferente para cada código de comercio)
<Tipo Conexión>
corresponde al tipo de conexión de los códigos de comercio:
- UN: Se genera un único archivo. Información de archivos no es separada por tipo de conexión (cuando es un archivo único no es parte del nombre)
- SE: Se genera un archivo para transacciones con tipo de conexión presencial y no presencial
- NP: No presencial
- PR: presencial
<Modo Agrupación>
corresponde al modo de agrupación de los códigos de comercio
SC: Sucursal Matriz (cuando está agrupado por RUT no se incluye en el nombre
del archivo)
RB: Rubro
Procedimiento enlace y conexión Pinpad Bluetooth e355
Flujo de enlace Pinpad Bluetooth
![](https://www.transbankdevelopers.cl/public/slate-library/images/documentacion/host2host/flujo-pp-blue-e355.png)
Conexion Pinpad Bluetooth E355
Encendido de equipo
Paso 1
Al encender el equipo entra a la pantalla principal del aplicativo.
Paso 2
Se debe digitar secuencial mente las teclas “* 0 ” para ingresar al “Menú de Conexión Bluetooth.
![](https://www.transbankdevelopers.cl/public/slate-library/images/documentacion/host2host/conexion-paso-2.png)
Enlazar dispositivos
Paso 3
En el Menú de conexión bluetooth. Se selecciona la opción 1> Enlazar Dispositivo
Paso 4
Si anteriormente se realizo una búsqueda preguntara si desea Buscar nuevamente, si presiona 2> NO mostrara los dispositivos encontrados en la búsqueda anterior.
![](https://www.transbankdevelopers.cl/public/slate-library/images/documentacion/host2host/conexion-paso-4a.png)
El BT Name, que es el nombre que será visible al resto de dispositivos Bluetooth
![](https://www.transbankdevelopers.cl/public/slate-library/images/documentacion/host2host/conexion-paso-4b.png)
Paso 5
Al finalizar la búsqueda muestra los dispositivos encontrados
![](https://www.transbankdevelopers.cl/public/slate-library/images/documentacion/host2host/conexion-paso-5.png)
Paso 6
Al seleccionar un dispositivo aparecerá esta ventana para confirmar el enlace.
![](https://www.transbankdevelopers.cl/public/slate-library/images/documentacion/host2host/conexion-paso-6.png)
Paso 7
Al seleccionar el dispositivo aparecerá esta ventana para confirmar el enlace.
![](https://www.transbankdevelopers.cl/public/slate-library/images/documentacion/host2host/conexion-paso-7a.png)
Un mensaje similar aparecerá en el otro dispositivo, el código que aparece deberá ser el mismo en ambos dispositivos; En este caso 648005 Y seleccionamos YES y quedaran enlazados
![](https://www.transbankdevelopers.cl/public/slate-library/images/documentacion/host2host/conexion-paso-7b.png)
Paso 8
Comercio debe aceptar la conexión Bluetooth.
Se debe coordina la visita al comercio - Contraparte Comercio
Revisar habilitación SPP
SPP: Serial Profile interfaz (interfaz que emula una conexión puerto serie) se debe configurar en caso que este deshabilitado
Paso 1
En el Menú Principal del administrador de bluetooth. Si se Requiere habilitar SSP (Serial Port Profile) 3> Config MENU CONEC. BLUETOOTH SPP [Desactivado]
![](https://www.transbankdevelopers.cl/public/slate-library/images/documentacion/host2host/habilitacion-spp-paso-1.png)
Paso 2
Selecciona la opción 2> Servidor SPP
![](https://www.transbankdevelopers.cl/public/slate-library/images/documentacion/host2host/habilitacion-spp-paso-2.png)
Paso 3
Aparecerá esta Pantalla y Volverá al menú Principal
![](https://www.transbankdevelopers.cl/public/slate-library/images/documentacion/host2host/habilitacion-spp-paso-3.png)
Borrar equipos enlazados
Paso 1
En el Menú del Administrador de Bluetooth, seleccionar la opción 2> Dispositivos Enlazados
![](https://www.transbankdevelopers.cl/public/slate-library/images/documentacion/host2host/borrar-equipos-paso-1.png)
Paso 2
En esta opción se mostrará un menú con todos los dispositivos que están enlazados con el pinpad e355, quedan registrados los dispositivos anteriormente enlazados.
![](https://www.transbankdevelopers.cl/public/slate-library/images/documentacion/host2host/borrar-equipos-paso-2.png)
Paso 3
Si seleccionamos el dispositivo, aparecerá este menú que nos mostrar 2 opciones. Si seleccionamos SI eliminamos el enlace, y volvemos al menú principal.
![](https://www.transbankdevelopers.cl/public/slate-library/images/documentacion/host2host/borrar-equipos-paso-3.png)
Utilización del SDK
Para la integración con aplicaciones propias del
comercio, es necesario utilizar en los desarrollos
propios, las librerías incluidas en el SDK del equipo
Verifone e355.
Estas son:
libPtr
libVmf
Para facilitar el proceso de integración se utiliza la referencia al recurso “pinpad” que contiene funciones para la comunicación entre Pinpad y la App del Comercio. La estructura y el código de ejemplo están incluidos en el archivo demo_e355.zip
Importación de librerías y recurso Pinpad
![](https://www.transbankdevelopers.cl/public/slate-library/images/documentacion/host2host/sdk-import-lib-pinpad.png)
Declaración del activity principal y PINPadTransport
![](https://www.transbankdevelopers.cl/public/slate-library/images/documentacion/host2host/sdk-pinpadtransport.png)
Función para la conexión y desconexión
![](https://www.transbankdevelopers.cl/public/slate-library/images/documentacion/host2host/sdk-conexion-desconexion.png)
Ejemplo para enviar el comando 0100 (lectura tarjeta al pinpad) al Pinpad
![](https://www.transbankdevelopers.cl/public/slate-library/images/documentacion/host2host/sdk-comando-0100.png)
Función para recibir la respuesta del Pinpad
![](https://www.transbankdevelopers.cl/public/slate-library/images/documentacion/host2host/sdk-respuesta-pinpad.png)
Instalación en Windows
Cuando se realiza el enlace se crean 2 puertos COM que se enlazan al Bluetooth. Para poder revisarlo se debe ingresar a: Dispositivos
Paso 1
![](https://www.transbankdevelopers.cl/public/slate-library/images/documentacion/host2host/windows-1.png)
Paso 2
![](https://www.transbankdevelopers.cl/public/slate-library/images/documentacion/host2host/windows-2.png)
Paso 3
![](https://www.transbankdevelopers.cl/public/slate-library/images/documentacion/host2host/windows-3.png)
Paso 4
![](https://www.transbankdevelopers.cl/public/slate-library/images/documentacion/host2host/windows-4.png)

# documentacion_oneclick.md

Source: https://www.transbankdevelopers.cl/documentacion/oneclick

Oneclick
La modalidad de pago Oneclick permite al tarjetahabiente realizar pagos en el comercio sin la necesidad de ingresar cada vez información de la tarjeta al momento de realizar la compra. El modelo de pago contempla un proceso previo de inscripción o enrolamiento del tarjetahabiente, a través del comercio, que desee utilizar el servicio. Este tipo de pago facilita la venta, disminuye el tiempo de la transacción y reduce los riesgos de ingreso erróneo de los datos del medio de pago.
El proceso de integración con Oneclick consiste en desarrollar por parte del comercio las llamadas a los servicios web dispuestos por Transbank para la inscripción de los tarjetahabientes, así como para la realización de los pagos.
Flujo de inscripción y pago
La inscripción es el proceso en el cual el tarjetahabiente registra los datos de su tarjeta en Oneclick para usarlo en compras futuras. Estos datos son almacenados de forma segura en Transbank, y nunca son conocidos por el comercio. Este proceso debe ser iniciado por la tienda del comercio y es requisito que el cliente esté autenticado (haya iniciado sesión) en la página del comercio antes de iniciar la inscripción.
![Diagrama de secuencia inscripción Oneclick](https://www.transbankdevelopers.cl/public/slate-library/images/diagrama-secuencia-oneclick-inscripcion.png)
- El cliente se conecta y autentica en la página del comercio, mediante su nombre de usuario y clave.
- El cliente selecciona la opción de inscripción, la cual debe estar explicada en la página del comercio.
- El comercio consume un servicio web para crear una inscripción, donde entrega los datos del cliente y la URL de término; obtiene un token y URL de Webpay.
- El comercio envía el browser del cliente a la URL y pasa por parámetro el token (método POST).
- Webpay presenta el formulario de inscripción, este es similar al formulario de pago actual de Webpay Plus, para que el cliente ingrese los datos de su tarjeta. El tiempo en el cual permanece el formulario de Webpay en espera para incluir los datos de la tarjeta es de 4 minutos (10 minutos en el ambiente de integración), en caso de extender dicho plazo y no haber terminado la transacción, esta será abortada automáticamente.
- El cliente será autenticado por su banco emisor, de forma similar al flujo normal de pago. En este punto se realiza una transacción de $50 pesos, la cual no se captura (no se verá reflejada en su estado de cuenta).
- Finalizada la inscripción, Webpay envía el browser del cliente a la URL entregada por el comercio, pasando por parámetro el token.
- El comercio debe consumir otro servicio web de Transbank para finalizar la inscripción enviando el token, para
obtener el resultado de la inscripción y el identificador de usuario (
tbkUser
), que debe utilizar en el futuro para realizar los pagos. - El comercio presenta al cliente el resultado de la inscripción.
Resumen de flujos
Para resumir los flujos que puedan existir en la inscripción y las distintas respuestas que se puede recibir en cada uno, puedes guiarte por el siguiente detalle:
- Flujo normal: Cuando el usuario finaliza la transacción (tanto si es un rechazo o una aprobación) llegará solamente
TBK_TOKEN
como retorno a la url del comercio. Esta redirección es por el método GET si utilizas la versión del API 1.1 o superior, para versiones anteriores el retorno es por 'POST'. - Timeout: Cuando el usuario permanece por más de 4 minutos en el formulario de Transbank (o 10 minutos en el caso del ambiente de integración), llegará solamente
TBK_TOKEN
como parámetro de retorno a la url del comercio. Esta redirección se realizará con el método GET para versiones de API 1.1 o superiores, para versiones anteriores será por POST. - Pago abortado (con botón anular compra en el formulario de Webpay): Llegará
TBK_TOKEN
,TBK_ORDEN_COMPRA
yTBK_ID_SESION
. El retorno a la url del comercio dependerá de la versión de API y el entorno:- Si operas en producción, el método de retorno utilizado en API 1.1 o superior será GET, para versiones anteriores será POST
- Para el ambiente de integración, si usas la versión 1.1 del API el retorno es por GET, para los otros casos se utiliza POST.
Recomendamos preparar las integraciones para recibir respuestas por POST y GET con el fin de evitar confusión por la diferencia en los ambientes
Autorización (proceso de pago)
Después de realizado el proceso de inscripción, el comercio puede iniciar el proceso de pago cuando corresponda.
El pago es el proceso donde el comercio solicita el cargo de una compra a la tarjeta de un usuario inscrito anteriormente, usando el identificador entregado por Transbank al momento de la inscripción.
Los pagos en esta modalidad no requieren necesariamente la intervención del usuario.
El monto del pago debe estar dentro de los límites establecidos para este tipo de transacciones, el proceso interno es similar a un cargo normal de Webpay. Existe un máximo de transacciones diarias que puede realizar un solo usuario, además de un monto máximo por transacción y un monto máximo acumulado diario. Estos valores se definen en el proceso de afiliación comercial del producto.
![Diagrama de secuencia inscripción Oneclick](https://www.transbankdevelopers.cl/public/slate-library/images/diagrama-secuencia-oneclick-pago.png)
- El cliente se conecta y autentica en la página o aplicación del comercio mediante su nombre de usuario y clave.
- El cliente selecciona la opción de pagar con Oneclick.
- El comercio usa el servicio web de pago para autorizar pagos, entregando
el identificador de usuario (que se obtuvo durante la inscripción:
tbkUser
), el monto del pago y la orden de compra. Obtiene la respuesta con el código de respuesta. - El comercio presenta el resultado del pago al cliente.
Adicionalmente, este proceso puede suceder sin la intervención directa del usuario:
- El comercio, teniendo el identificador del usuario (
tbkUser
), puede usar el servicio web de pago en uncronjob
o algún proceso programado que tenga el comercio en sus sistemas. Ejemplo: El comercio puede crear un proceso que corre automáticamente una vez al mes por cada cliente, donde se realiza la llamada al servicio web de pago para cobrar una mensualidad.
Modalidad Mall
En la modalidad Oneclick Mall, existe un código de comercio "mall" que agrupa una serie de códigos de comercio "tienda".
- El usuario inscribe su tarjeta en la página del comercio "mall" agrupador, pero las transacciones son a nombre de las "tiendas" del mall.
- Se pueden indicar múltiples transacciones a autorizar en una misma operación con diferentes códigos de comercio tienda.
- Se debe verificar por separado el resultado de cada una de esas transacciones, validando el código de respuesta (
responseCode
), pues es posible que el emisor de la tarjeta autorice algunas y otras no.
Operaciones
Crear una inscripción
Permite comenzar con la inscripción de de la tarjeta del usuario. Retorna como respuesta un token, que representa la
inscripción, y una URL (urlWebpay
).
El usuario debe ser redireccionado a urlWebpay
, enviando como parámetro TBK_TOKEN
el token recibido (Puede ser una redirección por POST o GET).
Oneclick.MallInscription mallInscription = Oneclick.MallInscription.buildForIntegration("commerceCode", "APIKey");
final OneclickMallInscriptionStartResponse response = mallInscription.start(username, email, response_url);
$mallInscription = MallInscription::buildForIntegration($apiKey, $commerceCode);
$response = $mallInscription->start($username, $email, $response_url);
MallInscription mallInscription = MallInscription.buildForIntegration("commerceCode", "APIKey");
var response = mallInscription.Start(userName, email, returnUrl);
@mall_inscription = Transbank::Webpay::Oneclick::MallInscription.build_for_integration("commerceCode", "APIKey");
@resp = @mall_inscription.start(username: @username, email: @email, response_url: @response_url);
inscription = MallInscription.build_for_integration("commerceCode", "APIKey")
resp = inscription.start(username=user_name, email=email, response_url=response_url)
const inscription = Oneclick.MallInscription.buildForIntegration(
"commerceCode",
"APIKey"
);
const response = await inscription.start(username, email, responseUrl);
Respuesta de crear una inscripción
response.getToken();
response.getUrlWebpay();
$response->getToken();
$response->getUrlWebpay();
response.Token;
response.UrlWebpay
response.token
response.url_webpay
## Versión 3.x del SDK
response['token']
response['url_webpay']
## Versión 2.x del SDK
response.token
response.url_webpay
response.token
response.url_webpay
Con estos datos, debes redireccionar vía POST
el navegador del usuario a la url retornada en url_webpay
. Recordando que el nombre del parámetro que contiene el token se debe llamar TBK_TOKEN
.
<form method="post" action="Inserta aquí la url entregada">
<input type="hidden" name="TBK_TOKEN" value="Inserte aquí el token entregado" />
<input type="submit" value="Ir a pagar" />
</form>
Confirmar una inscripción
Una vez terminado el flujo de inscripción en Transbank el usuario es enviado a
la URL de fin de inscripción que definió el comercio (responseURL
). En ese
momento el comercio debe confirmar la inscripción.
Una vez que se autorice la inscripción del usuario, se retornará el control al comercio vía POST
(GET
si usas el API 1.1 o superior) en la url indicada en response_url
, con el parámetro TBK_TOKEN
identificando la transacción. Con esa información se puede finalizar la inscripción:
Oneclick.MallInscription mallInscription = Oneclick.MallInscription.buildForIntegration("commerceCode", "APIKey");
final OneclickMallInscriptionFinishResponse response = mallInscription.finish(tbk_token);
$mallInscription = MallInscription::buildForIntegration($apiKey, $commerceCode);
$response = $mallInscription->finish($tbk_token);
MallInscription mallInscription = MallInscription.buildForIntegration("commerceCode", "APIKey");
var response = mallInscription.Finish(tbk_token);
@mall_inscription = Transbank::Webpay::Oneclick::MallInscription.build_for_integration("commerceCode", "APIKey");
@resp = @mall_inscription.finish(token: @tbk_token);
inscription = MallInscription.build_for_integration("commerceCode", "APIKey")
resp = inscription.finish(token=tbk_token)
const inscription = Oneclick.MallInscription.buildForIntegration(
"commerceCode",
"APIKey"
);
const response = await inscription.finish(token);
Respuesta de confirmar una inscripción
response.getAuthorizationCode();
response.getCardType();
response.getCardNumber();
response.getResponseCode();
response.getTbkUser();
$response->getAuthorizationCode();
$response->getCardType();
$response->getCardNumber();
$response->getResponseCode();
$response->getTbkUser();
response.ResponseCode;
response.TransbankUser;
response.AuthorizationCode;
response.CardType;
response.CardNumber;
response.response_code
response.transbank_user
response.authorization_code
response.card_type
response.card_number
## Versión 3.x del SDK
response['response_code']
response['transbank_user']
response['authorization_code']
response['card_type']
response['card_number']
## Versión 2.x del SDK
response.response_code
response.transbank_user
response.authorization_code
response.card_type
response.card_number
response.response_code
response.transbank_user
response.authorization_code
response.card_type
response.card_number
Eliminar una inscripción
En el caso que el comercio requiera eliminar la inscripción de un usuario en OneClick Mall ya sea por la eliminación de un cliente en su sistema o por la solicitud de este para no operar con esta forma de pago, el comercio deberá invocar a removeInscription() con el identificador de usuario entregado en la inscripción.
Oneclick.MallInscription mallInscription = Oneclick.MallInscription.buildForIntegration("commerceCode", "APIKey");
mallInscription.delete(tbkUser, username);
$mallInscription = MallInscription::buildForIntegration($apiKey, $commerceCode);
$response = $mallInscription->delete($tbkUser, $username);
MallInscription mallInscription = MallInscription.buildForIntegration("commerceCode", "APIKey");
var response = mallInscription.Delete(tbkUser, username);
@mall_inscription = Transbank::Webpay::Oneclick::MallInscription.build_for_integration("commerceCode", "APIKey");
@mall_inscription.delete(tbk_user: @tbkUser, username: @username);
inscription = MallInscription.build_for_integration("commerceCode", "APIKey")
inscription.delete(tbk_user=tbkUser, username=username)
const inscription = Oneclick.MallInscription.buildForIntegration( "commerceCode", "APIKey" ); const response = await inscription.delete(tbkUser, username);
Respuesta Eliminar una inscripción
Esta petición no posee cuerpo de respuesta, solo entrega un 204 cuando se realiza correctamente
// 204 OK
// 204 OK
// 204 OK
# 204 OK
# 204 OK
// 204 OK
Si se quiere comprobar si se eliminó correctamente, la función retorna un boolean, el cual será true
en caso de éxito y false
en otro caso.
Recuerda que por cada transacción que hayas enviado en el arreglo (array de details
) recibiras una respuesta.
Debes validarlas de manera independiente, ya que unas podrías estar aprobadas y otras no.
Autorizar una transacción
Con el tbkUser
retornado de la confirmación (PUT /inscriptions/{token}
) puedes autorizar transacciones:
Una vez que ya tienes la tarjeta del usuario inscrita (ya tienes el token tbk_user
para ese usuario), puedes realizar
cargos a esa tarjeta en cualquier momento, solo llamando a este método de autorización, enviando el tbk_user
, el
username
del usuario, un identificador de compra parentBuyOrder
y los datos de la transacción.
Como Oneclick opera en modalidad Mall, en una misma autorización puedes realizar varios cobros, cada uno a códigos de comercio tienda diferente. No olvidar que para realizar el cargo correctamente, esos código de comercio tienda deben "pertenecer" o estar asociados a tu código de comercio Mall cuando se contratan. Al tarjetahabiente se le realizará un solo cobro por la suma del monto de todas las "sub-transacciones" solicitadas, pero el dinero será procesado y enviado a cada código de comercio por separado. Para aclararlo con un ejemplo, si solicito una autorización por $1.500 para el comercio A, y $2.500 para el comercio B, el tarjetahabiente verá un único cobro de $4.000 en su cartola, pero el comercio A recibirá los $1.500 y el comercio B los $2.500 (en ambos casos, restando la comisión).
Cada "sub-transacción" de la autorización requiere de un código de comercio, un identificador de compra (ojalá único y diferente al identificador de compra padre), un monto y, opcionalmente, el número de cuotas en que se realizará el cobro.
Oneclick.MallTransaction mallTransaction = Oneclick.MallTransaction.buildForIntegration("commerceCode", "APIKey");
double amountOne = 10000;
String commerceCodeStoreOne = "597055555542";
String buyOrderMallOne = String.valueOf(new Random().nextInt(Integer.MAX_VALUE));
byte installmentNumberOne = 3;
double amountTwo = 50000;
String commerceCodeStoreTwo = "597055555543";
String buyOrderMallTwo = String.valueOf(new Random().nextInt(Integer.MAX_VALUE));
byte installmentNumberTwo = 3;
MallTransactionCreateDetails details = MallTransactionCreateDetails.build()
.add(amountOne, commerceCodeStoreOne, buyOrderMallOne, installmentNumberOne)
.add(amountTwo, commerceCodeStoreTwo, buyOrderMallTwo, installmentNumberTwo);
final OneclickMallTransactionAuthorizeResponse response = mallTransaction.authorize(username, tbkUser, buyOrder, details);
$mallTransaction = MallTransaction::buildForIntegration($apiKey, $commerceCode);
$parentBuyOrder = rand(100000, 999999999);
$details = [
[
"commerce_code" => "commerceCodeStoreOne",
"buy_order" => rand(100000, 999999999), // Tu propio buyOrder
"amount" => 50000,
"installments_number" => 1
],
[
"commerce_code" => "commerceCodeStoreTwo",
"buy_order" => rand(100000, 999999999), // Tu propio buyOrder
"amount" => 20000,
"installments_number" => 1
]
];
$response = $mallTransaction->authorize($username, $tbkUser, $parentBuyOrder, $details);
MallTransaction mallTransaction = MallTransaction.buildForIntegration("commerceCode", "APIKey");
var commerceCodeStoreOne = "597055555542";
var installmentsNumber = 1;
List details = new List();
details.Add(new PaymentRequest(commerceCodeStoreOne, childBuyOrder, amount, installmentsNumber));
var result = mallTransaction.Authorize(userName, tbkUser, buyOrder, details);
@mall_transaction = Transbank::Webpay::Oneclick::MallTransaction.build_for_integration("commerceCode", "APIKey");
@details =
[{
commerce_code: "commerce_store_1",
buy_order: "abcdef" + Time.now.to_i.to_s,
amount: 10000,
installments_number: 3
},
{
commerce_code: "commerce_store_2",
buy_order: "abcdef" + Time.now.to_i.to_s,
amount: 50000,
installments_number: 3
}];
end
@resp = @mall_transaction.authorize(username: @username, tbk_user: @tbkUser, parent_buy_order: @buy_order, details: @details);
transaction = MallTransaction.build_for_integration("commerceCode", "APIKey")
commerce_store_1 = "597055555542"
buy_order_child1 = str(random.randrange(1000000, 99999999))
installments_number1 = 3
amount1 = 10000
commerce_store_1 = "597055555543"
buy_order_child2 = str(random.randrange(1000000, 99999999))
installments_number2 = 4
amount2 = 50000
details = MallTransactionAuthorizeDetails(commerce_store_1, buy_order_child1, installments_number1, amount1).add(commerce_store_2, buy_order_child2, installments_number2, amount2)
resp = transaction.authorize(username= username, tbk_user= tbkUser, parent_buy_order= buy_order, details= details)
const transaction = Oneclick.MallTransaction.buildForIntegration( "commerceCode", "APIKey" ); const details = [ new TransactionDetail(amount, commerceCodeStoreOne, childBuyOrder), new TransactionDetail(amount2, commerceCodeStoreTwo, childBuyOrder2), ]; const response = await transaction.authorize( userName, tbkUser, buyOrder, details );
Respuesta Autorizar un pago
Luego de llamar a este método, se obtendrá el estado del cobro inmediatamente, sin que el usuario tenga que pasar por el proceso de autorización bancaria.
En este punto, ya puedes saber si la transacción fue aprobada o rechazada.
Verás que el mensaje de respuesta devuelve datos generales sobre la operación, y un detalle del cobro por cada una de las "sub-transacciones" enviadas. Es importante verificar cada una de ellas, ya que eventualmente (poco probable pero posible), una podría salir aprobada y otra rechazada.
Revisa los posibles códigos de respuesta y el detalle de los parametros en [la referencia](https://www.transbankdevelopers.cl/referencia/oneclick#autorizar-una-transaccion)
response.getAccountingDate();
response.getBuyOrder();
response.getTransactionDate();
final CardDetail cardDetail = response.getCardDetail();
cardDetail.getCardNumber();
final List<Detail> detailsResp = response.getDetails();
for (Detail detail : detailsResp) {
detail.getAmount();
detail.getAuthorizationCode();
detail.getBuyOrder();
detail.getCommerceCode();
detail.getInstallmentsNumber();
detail.getPaymentTypeCode();
detail.getStatus();
}
print_r($response);
$response->getAccountingDate();
$response->getBuyOrder();
$response->getTransactionDate();
$details = $response->getDetails();
foreach($details as $detail){
$detail->getAmount();
$detail->getAuthorizationCode();
$detail->getBuyOrder();
$detail->getCommerceCode();
$detail->getInstallmentsNumber();
$detail->getPaymentTypeCode();
$detail->getResponseCode();
$detail->getStatus();
}
// Transbank\Webpay\Oneclick\Responses\MallTransactionAuthorizeResponse Object
// (
// [buyOrder] => 433025339
// [sessionId] =>
// [cardNumber] => 6623
// [expirationDate] =>
// [accountingDate] => 0413
// [transactionDate] => 2021-04-13T22:59:53.767Z
// [details] => Array
// (
// [0] => Transbank\Webpay\Oneclick\Responses\TransactionDetail Object
// (
// [amount] => 50000
// [status] => AUTHORIZED
// [authorizationCode] => 1213
// [paymentTypeCode] => VN
// [responseCode] => 0
// [installmentsNumber] => 0
// [installmentsAmount] =>
// [commerceCode] => 597055555542
// [buyOrder] => 523485045
// )
// [1] => Transbank\Webpay\Oneclick\Responses\TransactionDetail Object
// (
// [amount] => 20000
// [status] => AUTHORIZED
// [authorizationCode] => 1213
// [paymentTypeCode] => VN
// [responseCode] => 0
// [installmentsNumber] => 0
// [installmentsAmount] =>
// [commerceCode] => 597055555543
// [buyOrder] => 224502696
// )
// )
// )
response.AccountingDate;
response.BuyOrder;
var cardDetail = response.CardDetail;
cardDetail.CardNumber;
response.TransactionDate;
var details = response.Details;
foreach (var detail in details) {
detail.Amount;
detail.AuthorizationCode;
detail.BuyOrder;
detail.CommerceCode;
detail.InstallmentsNumber;
detail.PaymentTypeCode;
detail.ResponseCode;
detail.Status;
}
response.accounting_date
response.buy_order
card_detail = response.card_detail
card_detail.card_number
response.transaction_date
details = response.details
details.each do |detail|
detail.amount
detail.authorization_code
detail.buy_order
detail.commerce_code
detail.installments_number
detail.payment_type_code
detail.response_code
detail.status
end
## Versión 3.x del SDK
response['accounting_date']
response['buy_order']
response['card_detail']
response['transaction_date']
response['details']
## Versión 2.x del SDK
response.accounting_date
response.buy_order
card_detail = response.card_detail
card_detail.card_number
response.transaction_date
details = response.details
for detail in details:
detail.amount
detail.authorization_code
detail.buy_order
detail.commerce_code
detail.installments_number
detail.payment_type_code
detail.response_code
detail.status
response.accounting_date
response.buy_order
cardDetail = response.card_detail
cardDetail.card_number
response.transaction_date
details = response.details
for(let detail on details) {
detail.amount
detail.authorization_code
detail.buy_order
detail.commerce_code
detail.installments_number
detail.payment_type_code
detail.response_code
detail.status
}
Obtener estado de una transacción
Esta operación permite obtener el estado de la transacción en cualquier momento. En condiciones normales es probable que no se requiera ejecutar, pero en caso de ocurrir un error inesperado permite conocer el estado y tomar las acciones que correspondan.
Revisa la [referencia](https://www.transbankdevelopers.cl/referencia/oneclick#obtener-estado-de-una-transaccion) de este método para mayor detalle en los parámetros de entrada y respuesta.
Transaction.status()
Permite consultar el estado de pago realizado a través de Oneclick. Retorna el resultado de la autorización.
MallTransaction mallTransaction = MallTransaction.buildForIntegration("commerceCode", "APIKey");
final OneclickMallTransactionStatusResponse response = mallTransaction.status(buyOrder);
$mallTransaction = MallTransaction::buildForIntegration($apiKey, $commerceCode); $response = $mallTransaction->status($buyOrder);
MallTransaction mallTransaction = MallTransaction.buildForIntegration("commerceCode", "APIKey");
var result = mallTransaction.Status(buyOrder);
@mall_transaction = Transbank::Webpay::Oneclick::MallTransaction.build_for_integration("commerceCode", "APIKey");
@resp = @mall_transaction.status(buy_order: @buy_order);
transaction = MallTransaction.build_for_integration("commerceCode", "APIKey")
resp = transaction.status(buy_order)
const transaction = Oneclick.MallTransaction.buildForIntegration(
"commerceCode",
"APIKey"
);
const response = await transaction.status(token);
Respuesta de consulta de estado
response.getAccountingDate();
response.getBuyOrder();
response.getTransactionDate();
final CardDetail cardDetail = response.getCardDetail();
cardDetail.getCardNumber();
final List<Detail> detailsResp = response.getDetails();
for (Detail detail : detailsResp) {
detail.getAmount();
detail.getAuthorizationCode();
detail.getBuyOrder();
detail.getCommerceCode();
detail.getInstallmentsNumber();
detail.getPaymentTypeCode();
detail.getStatus();
}
print_r($response);
$response->getAccountingDate();
$response->getBuyOrder();
$response->getTransactionDate();
$details = $response->getDetails();
foreach($details as $detail){
$detail->getAmount();
$detail->getAuthorizationCode();
$detail->getBuyOrder();
$detail->getCommerceCode();
$detail->getInstallmentsNumber();
$detail->getPaymentTypeCode();
$detail->getResponseCode();
$detail->getStatus();
}
// Transbank\Webpay\Oneclick\Responses\MallTransactionAuthorizeResponse Object
// (
// [buyOrder] => 433025339
// [sessionId] =>
// [cardNumber] => 6623
// [expirationDate] =>
// [accountingDate] => 0413
// [transactionDate] => 2021-04-13T22:59:53.767Z
// [details] => Array
// (
// [0] => Transbank\Webpay\Oneclick\Responses\TransactionDetail Object
// (
// [amount] => 50000
// [status] => AUTHORIZED
// [authorizationCode] => 1213
// [paymentTypeCode] => VN
// [responseCode] => 0
// [installmentsNumber] => 0
// [installmentsAmount] =>
// [commerceCode] => 597055555542
// [buyOrder] => 523485045
// )
// [1] => Transbank\Webpay\Oneclick\Responses\TransactionDetail Object
// (
// [amount] => 20000
// [status] => AUTHORIZED
// [authorizationCode] => 1213
// [paymentTypeCode] => VN
// [responseCode] => 0
// [installmentsNumber] => 0
// [installmentsAmount] =>
// [commerceCode] => 597055555543
// [buyOrder] => 224502696
// )
// )
// )
response.AccountingDate;
response.BuyOrder;
var cardDetail = response.CardDetail;
cardDetail.CardNumber;
response.SessionId;
response.TransactionDate;
response.Vci;
var details = response.Details;
foreach (var detail in details) {
detail.Amount;
detail.AuthorizationCode;
detail.BuyOrder;
detail.CommerceCode;
detail.InstallmentsNumber;
detail.PaymentTypeCode;
detail.ResponseCode;
detail.Status;
}
response.accounting_date
response.buy_order
card_detail = response.card_detail
card_detail.card_number
response.session_id
response.transaction_date
response.vci
details = response.details
details.each do |detail|
detail.amount
detail.authorization_code
detail.buy_order
detail.commerce_code
detail.installments_number
detail.payment_type_code
detail.response_code
detail.status
end
## Versión 3.x del SDK
response['accounting_date']
response['buy_order']
response['card_detail']
response['session_id']
response['transaction_date']
response['vci']
response['details']
## Versión 2.x del SDK
response.accounting_date
response.buy_order
card_detail = response.card_detail
card_detail.card_number
response.session_id
response.transaction_date
response.vci
details = response.details
for detail in details:
detail.amount
detail.authorization_code
detail.buy_order
detail.commerce_code
detail.installments_number
detail.payment_type_code
detail.response_code
detail.status
response.accounting_date
response.buy_order
cardDetail = response.card_detail
cardDetail.card_number
response.session_id
response.transaction_date
response.vci
details = response.details
for(detail on details) {
detail.amount
detail.authorization_code
detail.buy_order
detail.commerce_code
detail.installments_number
detail.payment_type_code
detail.response_code
detail.status
}
Reversar o anular una transacción
Esta operación permite a todo comercio habilitado, reversar o anular una transacción que fue generada en Oneclick.
Puedes realizar un reembolso invocando al método refund(), dependiendo de algunas condiciones correspondera a una Reversa o Anulación.
Puedes [leer más sobre la anulación en la información del
producto Webpay](https://www.transbankdevelopers.cl/producto/webpay#anulaciones) para conocer
más detalles y restricciones.
MallTransaction mallTransaction = MallTransaction.buildForIntegration("commerceCode", "APIKey");
final OneclickMallTransactionRefundResponse response = mallTransaction.refund(buyOrder, commerceCodeStoreOne, childBuyOrder, amount);
$mallTransaction = MallTransaction::buildForIntegration($apiKey, $commerceCode);
$response = $mallTransaction$->refund($buyOrder, $commerceCodeStoreOne, $childBuyOrder, $amount);
MallTransaction mallTransaction = MallTransaction.buildForIntegration("commerceCode", "APIKey");
var result = mallTransaction.Refund(buyOrder, commerceCodeStoreOne, childBuyOrder, amount);
@mall_transaction = Transbank::Webpay::Oneclick::MallTransaction.build_for_integration("commerceCode", "APIKey");
@resp = @mall_transaction.refund(buy_order: @buy_order, child_commerce_code: @commerce_store_1, child_buy_order: @child_buy_order, amount: @amount);
transaction = MallTransaction.build_for_integration("commerceCode", "APIKey")
resp = transaction.refund(buy_order, commerce_store_1, child_buy_order, amount)
const transaction = Oneclick.MallTransaction.buildForIntegration(
"commerceCode",
"APIKey"
);
const response = await transaction.refund(
buyOrder,
commerceCodeStoreOne,
buyOrderChild,
amount
);
Capturar una transacción
En el caso de que tengas contratada la modalidad de Captura diferida, necesitas llamar al método capture
después
de llamar a authorize
para finalizar la transacción.
Para capturar una transacción, esta debe haber sido creada por un código de comercio configurado para captura diferida. De esa forma la transacción estará autorizada pero requerirá una captura explícita posterior para confirmar la transacción.
Para realizar esa captura explícita debe usarse el método capture()
Una inscripción Oneclick Mall permite que el tarjetahabiente registre su tarjeta, asociando dicha inscripción a un comercio padre. Una vez realizada la inscripción, el comercio padre autoriza transacciones para los comercios “hijo” que tiene registrados. La autorización se encarga de validar si es posible realizar el cargo a la tarjeta de crédito, débtio o prepago realizando en el mismo acto la reserva del monto de la transacción. La posterior captura hace efectiva dicha reserva y "captura" el monto "reservado" previamente.
Este método permite a los comercios Oneclick Mall habilitados, poder realizar capturas diferidas de una transacción previamente autorizada. El método contempla una única captura por cada autorización. Para ello se deberá indicar los datos asociados a la transacción de venta y el monto requerido para capturar, el cual debe ser menor o igual al monto originalmente autorizado. Para capturar una transacción, ésta debe haber sido creada por un código de comercio configurado para captura diferida. De esta forma la transacción estará autorizada pero requerirá una captura explícita posterior para confirmar la transacción.
MallTransaction mallTransaction = MallTransaction.buildForIntegration("commerceCode", "APIKey");
final OneclickMallTransactionCaptureResponse response = mallTransaction.capture(commerceCodeStoreOne, childBuyOrder, authorizationCode, amount);
$mallTransaction = MallTransaction::buildForIntegration($apiKey, $commerceCode);
$response = $mallTransaction$->capture($commerceCodeStoreOne, $child_buy_order, $authorization_code, $amount);
MallTransaction mallTransaction = MallTransaction.buildForIntegration("commerceCode", "APIKey");
var result = mallTransaction.Capture(commerceCodeStoreOne, ChildbuyOrder, authorizationCode, amount);
@mall_transaction = Transbank::Webpay::Oneclick::MallTransaction.build_for_integration("commerceCode", "APIKey");
@resp = @mall_transaction.capture(child_commerce_code: @commerce_store_1, child_buy_order: @buy_order, authorization_code: @authorization_code, amount: @capture_amount);
transaction = MallTransaction.build_for_integration("commerceCode", "APIKey")
response = transaction.capture(commerce_store_1, child_buy_order, authorization_code, amount)
const transaction = Oneclick.MallTransaction.buildForIntegration(
"commerceCode",
"APIKey"
);
const response = await transaction.capture(
commerceCodeStoreOne,
buyOrder,
authorizationCode,
amount
);
Respuesta de captura diferida
response.getAuthorizationCode();
response.getAuthorizationDate();
response.getCapturedAmount();
response.getResponseCode();
$response->getAuthorizationCode();
$response->getAuthorizationDate();
$response->getCapturedAmount();
$response->getResponseCode();
response.AuthorizationCode;
response.AuthorizationDate;
response.CapturedAmount;
response.ResponseCode;
response.authorization_code
response.authorization_date
response.captured_amount
response.response_code
## Versión 3.x del SDK
response['authorization_code']
response['authorization_date']
response['captured_amount']
response['response_code']
## Versión 2.x del SDK
# Este SDK aún no tiene implementada esta funcionalidad. Se puede consumir el método del API REST directamente, sin usar el SDK de momento.
response.authorization_code
response.authorization_date
response.captured_amount
response.response_code
Credenciales y Ambientes
Ambiente de integración
Puede encontrar más información al respecto [en este link](https://www.transbankdevelopers.cl/documentacion/como_empezar#ambiente-de-integracion)
Configuración SDK
Los SDK deben configurarse explícitamente para apuntar al ambiente que quieras utilizar (producción / integración). Para esto puedes crear los objetos de 2 maneras:
- Utilizar los métodos definidos para ello (buildForIntegration o buildForProduction).
- Utilizar un objeto Options que contenga la configuración y pasarlo en el constructor de cada objeto.
Puede encontrar m´s información al respecto [en este link](https://www.transbankdevelopers.cl/documentacion/como_empezar#b-utilizando-los-sdk)
Puesta en Producción
Puede encontrar más información al respecto [en este link](https://www.transbankdevelopers.cl/documentacion/como_empezar#puesta-en-produccion)
Ejemplos de integración
Ponemos a tu disposición una serie de repositorios en nuestro Github para ayudarte a entender la integración de mejor forma.
Puedes encontrar una lista de [proyectos de ejemplo acá](https://www.transbankdevelopers.cl/documentacion/como_empezar#ejemplos).

# documentacion_patpass.md

Source: https://www.transbankdevelopers.cl/documentacion/patpass#patpass

PatPass
Patpass ComercioREST
En esta sección encontrarás toda la información técnica para implementar el flujo de inscripciones vía Pat Comercio.
Toda la información referente a los cobros ya sea el cómo realizarlos junto a su gestión debe ser realizada
a través del aplicativo Transdata.
[Aquí](https://www.transbankdevelopers.cl/public/files/Manual_Comercios_PatPass.pdf) puedes encontrar el manual de usuario y ante cualquier
duda debes comunicarte al call center o a tu ejecutivo comercial.
Crear una suscripción
Para crear una transacción PatPass Comercio que registre una suscripción, lo primero que necesitas es una instancia de WebpayPatpassComercio
con la Configuration
que incluye el código de comercio y el Api Key
a usar.
Una forma fácil de comenzar es utilizar la configuración para pruebas que viene incluida en el SDK.
PatpassComercio.Inscription patpassInscription = new PatpassComercio.Inscription(new PatpassOptions("commerceCode", "APIKey", IntegrationType.TEST));
String url = request.getRequestURL().toString().replace("start","end-subscription");
String name = "nombre";
String firstLastName = "apellido";
String secondLastName = "sapellido";
String rut = "14140066-5";
String serviceId = String.valueOf(new Random().nextInt(Integer.MAX_VALUE));;
String finalUrl = request.getRequestURL().toString().replace("start","voucher-generated");
double maxAmount = 1500;
String phoneNumber = "123456734";
String mobileNumber = "123456723";
String patpassName = "nombre del patpass";
String personEmail = "otromail@persona.cl";
String commerceEmail = "otrocomercio@comercio.cl";
String address = "huerfanos 101";
String city = "Santiago";
final PatpassComercioInscriptionStartResponse response = patpassInscription.start(url,
name,
firstLastName,
secondLastName,
rut,
serviceId,
finalUrl,
maxAmount,
phoneNumber,
mobileNumber,
patpassName,
personEmail,
commerceEmail,
address,
city);
$options = new Options($apiKey, $commerceCode, Options::ENVIRONMENT_INTEGRATION);
$inscription = new Inscription($options);
$returnUrl = "https://callback_url/resultado/de/la/transaccion";
$name = "Nombre";
$lastname1 = "Primer Apellido";
$lastname2 = "Segundo Apellido";
$rut = "11111111-1";
$serviceId = "Identificador del servicio unico de suscripción";
$finalUrl = "https://callback/final/comprobante/transacción";
$maxAmount = 10000; # monto máximo de la suscripción
$telephone = "numero telefono fijo de suscrito";
$mobilePhone = "numero de telefono móvil de suscrito";
$patpassName = "Nombre asignado a la suscripción";
$clientEmail = "Correo de suscrito";
$commerceEmail = "Correo de comercio";
$address = "Dirección de Suscrito";
$city = "Ciudad de suscrito";
$response = $inscription->Start(
$returnUrl,
$name,
$lastname1,
$lastname2,
$rut,
$serviceId,
$finalUrl,
$maxAmount,
$telephone,
$mobilePhone,
$patpassName,
$clientEmail,
$commerceEmail,
$address,
$city
);
Inscription inscription = new Inscription(new Options("commerceCode", "APIKey", PatpassComercioIntegrationType.Test
));
var returnUrl = "https://callback_url/resultado/de/la/transaccion";
var name = "Nombre";
var lastname1 = "Primer Apellido";
var lastname2 = "Segundo Apellido";
var rut = "11111111-1";
var serviceId = "Identificador del servicio unico de suscripción";
var finalUrl = "https://callback/final/comprobante/transacción";
var maxAmount = 10000; # monto máximo de la suscripción
var telephone = "numero telefono fijo de suscrito";
var mobilePhone = "numero de telefono móvil de suscrito";
var patpassName = "Nombre asignado a la suscripción";
var clientEmail = "Correo de suscrito";
var commerceEmail = "Correo de comercio";
var address = "Dirección de Suscrito";
var city = "Ciudad de suscrito";
var result = inscription.Start(
url: url,
name: name,
lastName: f_lastname,
secondLastName: s_lastname,
rut: rut,
serviceId: service_id,
finalUrl: final_url,
maxAmount: max_amount,
phone: phone_number,
cellPhone: mobile_number,
patpassName: patpass_name,
personEmail: client_email,
commerceEmail: commerce_email,
address: address,
city: city);
@options = Transbank::Patpass::Options.new("commerceCode", "APIKey", :production)
@inscription = Transbank::Patpass::PatpassComercio::Inscription.new(options)
@url = "https://callback_url/resultado/de/la/transaccion"
@name = "Nombre"
@first_last_name = "Primer Apellido"
@second_last_name = "Segundo Apellido"
@rut = "11111111-1"
@service_id = "Identificador del servicio unico de suscripción"
@final_url = "https://callback/final/comprobante/transacción"
@max_amount = 10000; # monto máximo de la suscripció
@phone_number = "numero telefono fijo de suscrito"
@mobile_number = "numero de telefono móvil de suscrito"
@patpass_name = "Nombre asignado a la suscripción"
@person_email = "Correo de suscrito"
@commerce_email = "Correo de comercio"
@address = "Dirección de Suscrito"
@city = "Ciudad de suscrito"
@resp = @inscription.start(
@url,
@name,
@first_last_name,
@second_last_name,
@rut,
@service_id,
@final_url,
@max_amount,
@phone_number,
@mobile_number,
@patpass_name,
@person_email,
@commerce_email,
@address,
@city
)
inscription = Inscription(PatpassComercioOptions("commerceCode", "APIKey", IntegrationType.TEST))
return_url = "https://callback_url/resultado/de/la/transaccion"
name = "Nombre"
first_last_name = "Primer Apellido"
second_last_name = "Segundo Apellido"
rut = "11111111-1"
service_id = "Identificador del servicio unico de suscripción"
final_url = "https://callback/final/comprobante/transacción"
max_amount = 10000; # monto máximo de la suscripció
phone_number = "numero telefono fijo de suscrito"
mobile_number = "numero de telefono móvil de suscrito"
patpass_name = "Nombre asignado a la suscripción"
person_email = "Correo de suscrito"
commerce_mail = "Correo de comercio"
address = "Dirección de Suscrito"
city = "Ciudad de suscrito"
resp = inscription.start(return_url, name, first_last_name, second_last_name, rut, service_id, None,
max_amount, phone_number, mobile_number, patpass_name,
person_email, commerce_mail, address, city)
const options = new Options(
"commerceCode",
"APIKey",
PatpassEnvironment.Integration
);
const inscription = new PatpassComercio.Inscription(options);
var returnUrl ="https://callback_url/resultado/de/la/transaccion"
var name = "Nombre";
var firstLastName = "Primer Apellido"
var secondLastName = "Segundo Apellido"
var rut = "11111111-1"
var serviceId = "Identificador del servicio único de suscripción"
var finalUrl = "https://callback/final/comprobante/transaccion"
var maxAmount = 10000; # monto máximo de la suscripción"
var phoneNumber = "Numero telefono fijo de suscrito"
var mobileNumber = "Numero telefono móvil de suscrito";
var patpassName = "Nombre asignado a la suscripción"
var personEmail = "Correo de suscrito"
var commerceEmail = "Correo de comercio"
var address = "Dirección de suscrit"
var city = "Ciudad de suscrito"
const resp = await inscription.start(
returnUrl,
name,
firstLastName,
secondLastName,
rut,
serviceId,
finalUrl,
maxAmount,
phoneNumber,
mobileNumber,
patpassName,
personEmail,
commerceEmail,
address,
city
);
Te recomendamos encapsular estas asignaciones en una función para que puedas reutilizarlas en los demás métodos.
Una vez este preparado el ambiente y la integración, puedes iniciar la transacción sin problemas.
import cl.transbank.patpass.PatpassComercio;
import cl.transbank.patpass.model.PatpassComercioInscriptionStartResponse;
import cl.transbank.patpass.model.PatpassComercioTransactionStatusResponse;
String url = request.getRequestURL().toString().replace("start","end-subscription");
String name = "nombre";
String firstLastName = "apellido";
String secondLastName = "sapellido";
String rut = "14140066-5";
String serviceId = String.valueOf(new Random().nextInt(Integer.MAX_VALUE));;
String finalUrl = request.getRequestURL().toString().replace("start","voucher-generated");
double maxAmount = 1500;
String phoneNumber = "123456734";
String mobileNumber = "123456723";
String patpassName = "nombre del patpass";
String personEmail = "otromail@persona.cl";
String commerceEmail = "otrocomercio@comercio.cl";
String address = "huerfanos 101";
String city = "Santiago";
// Versión 3.x del SDK
PatpassComercio.Inscription inscription = new PatpassComercio.Inscription(new PatpassOptions(IntegrationCommerceCodes.PATPASS_COMERCIO, IntegrationApiKeys.PATPASS_COMERCIO, PatpassComercioIntegrationType.TEST));
final PatpassComercioInscriptionStartResponse response = inscription.start(url,
name,
firstLastName,
secondLastName,
rut,
serviceId,
finalUrl,
maxAmount,
phoneNumber,
mobileNumber,
patpassName,
personEmail,
commerceEmail,
address,
city);
// Versión 2.x del SDK
final PatpassComercioInscriptionStartResponse response = PatpassComercio.Inscription.start(url,
name,
firstLastName,
secondLastName,
rut,
serviceId,
finalUrl,
maxAmount,
phoneNumber,
mobileNumber,
patpassName,
personEmail,
commerceEmail,
address,
city);
use Transbank\Patpass\Options;
use Transbank\Patpass\PatpassComercio;
$returnUrl = "https://callback_url/resultado/de/la/transaccion";
$name = "Nombre";
$lastname1 = "Primer Apellido";
$lastname2 = "Segundo Apellido";
$rut = "11111111-1";
$serviceId = "Identificador del servicio unico de suscripción";
$finalUrl = "https://callback/final/comprobante/transacción";
$maxAmount = 10000; # monto máximo de la suscripción
$telephone = "numero telefono fijo de suscrito";
$mobilePhone = "numero de telefono móvil de suscrito";
$patpassName = "Nombre asignado a la suscripción";
$clientEmail = "Correo de suscrito";
$commerceEmail = "Correo de comercio";
$address = "Dirección de Suscrito";
$city = "Ciudad de suscrito";
$response = PatpassComercio\Inscription::Start(
$returnUrl,
$name,
$lastname1,
$lastname2,
$rut,
$serviceId,
$finalUrl,
$maxAmount,
$telephone,
$mobilePhone,
$patpassName,
$clientEmail,
$commerceEmail,
$address,
$city
);
using Transbank.Patpass.PatpassComercio;
// ...
var returnUrl = "https://callback_url/resultado/de/la/transaccion";
var name = "Nombre";
var lastname1 = "Primer Apellido";
var lastname2 = "Segundo Apellido";
var rut = "11111111-1";
var serviceId = "Identificador del servicio unico de suscripción";
var finalUrl = "https://callback/final/comprobante/transacción";
var maxAmount = 10000; # monto máximo de la suscripción
var telephone = "numero telefono fijo de suscrito";
var mobilePhone = "numero de telefono móvil de suscrito";
var patpassName = "Nombre asignado a la suscripción";
var clientEmail = "Correo de suscrito";
var commerceEmail = "Correo de comercio";
var address = "Dirección de Suscrito";
var city = "Ciudad de suscrito";
// Versión 4.x del SDK
var inscription = new Inscription(new Options(IntegrationCommerceCodes.PATPASS_COMERCIO, IntegrationApiKeys.PATPASS_COMERCIO, PatpassComercioIntegrationType.Test));
var result = inscription.Start(
url: url,
name: name,
lastName: f_lastname,
secondLastName: s_lastname,
rut: rut,
serviceId: service_id,
finalUrl: final_url,
maxAmount: max_amount,
phone: phone_number,
cellPhone: mobile_number,
patpassName: patpass_name,
personEmail: client_email,
commerceEmail: commerce_email,
address: address,
city: city);
// Versión 3.x del SDK
var response = Inscription.Start(
returnUrl,
name,
lastname1,
lastname2,
rut,
serviceId,
finalUrl,
maxAmount,
telephone,
mobilePhone,
patpassName,
clientEmail,
commerceEmail,
address,
city
);
@url = "https://callback_url/resultado/de/la/transaccion"
@name = "Nombre"
@first_last_name = "Primer Apellido"
@second_last_name = "Segundo Apellido"
@rut = "11111111-1"
@service_id = "Identificador del servicio unico de suscripción"
@final_url = "https://callback/final/comprobante/transacción"
@max_amount = 10000; # monto máximo de la suscripció
@phone_number = "numero telefono fijo de suscrito"
@mobile_number = "numero de telefono móvil de suscrito"
@patpass_name = "Nombre asignado a la suscripción"
@person_email = "Correo de suscrito"
@commerce_email = "Correo de comercio"
@address = "Dirección de Suscrito"
@city = "Ciudad de suscrito"
## Versión 2.x del SDK
@inscription = Transbank::Patpass::PatpassComercio::Inscription.new()
@resp = @inscription.start(
@url,
@name,
@first_last_name,
@second_last_name,
@rut,
@service_id,
@final_url,
@max_amount,
@phone_number,
@mobile_number,
@patpass_name,
@person_email,
@commerce_email,
@address,
@city
)
## Versión 1.x del SDK
@resp = Transbank::Patpass::PatpassComercio::Inscription::start(
url: @url,
name: @name,
first_last_name: @first_last_name,
second_last_name: @second_last_name,
rut: @rut,
service_id: @service_id,
final_url: @final_url,
max_amount: @max_amount,
phone_number: @phone_number,
mobile_number: @mobile_number,
patpass_name: @patpass_name,
person_email: @person_email,
commerce_email: @commerce_email,
address: @address,
city: @city
)
## Versión 3.x del SDK
from transbank.patpass_comercio.inscription import Inscription
## Versión 2.x del SDK
from transbank.patpass_comercio.inscription import Inscription
return_url = "https://callback_url/resultado/de/la/transaccion"
name = "Nombre"
first_last_name = "Primer Apellido"
second_last_name = "Segundo Apellido"
rut = "11111111-1"
service_id = "Identificador del servicio unico de suscripción"
final_url = "https://callback/final/comprobante/transacción"
max_amount = 10000; # monto máximo de la suscripció
phone_number = "numero telefono fijo de suscrito"
mobile_number = "numero de telefono móvil de suscrito"
patpass_name = "Nombre asignado a la suscripción"
person_email = "Correo de suscrito"
commerce_mail = "Correo de comercio"
address = "Dirección de Suscrito"
city = "Ciudad de suscrito"
## Versión 3.x del SDK
ins = Inscription(PatpassComercioOptions(IntegrationCommerceCodes.PATPASS_COMERCIO, IntegrationApiKeys.PATPASS_COMERCIO, IntegrationType.TEST))
resp = ins.start(return_url, name, first_last_name, second_last_name, rut, service_id, None,
max_amount, phone_number, mobile_number, patpass_name,
person_email, commerce_mail, address, city)
## Versión 2.x del SDK
resp = Inscription.start(return_url, name, first_last_name, second_last_name, rut, service_id, final_url,
max_amount, phone_number, mobile_number, patpass_name,
person_email, commerce_mail, address, city)
import { PatpassComercio } from "transbank-sdk";
var returnUrl ="https://callback_url/resultado/de/la/transaccion"
var name = "Nombre";
var firstLastName = "Primer Apellido"
var secondLastName = "Segundo Apellido"
var rut = "11111111-1"
var serviceId = "Identificador del servicio único de suscripción"
var finalUrl = "https://callback/final/comprobante/transaccion"
var maxAmount = 10000; # monto máximo de la suscripción"
var phoneNumber = "Numero telefono fijo de suscrito"
var mobileNumber = "Numero telefono móvil de suscrito";
var patpassName = "Nombre asignado a la suscripción"
var personEmail = "Correo de suscrito"
var commerceEmail = "Correo de comercio"
var address = "Dirección de suscrit"
var city = "Ciudad de suscrito"
const resp = await new PatpassComercio.Inscription().start(
returnUrl,
name,
firstLastName,
secondLastName,
rut,
serviceId,
finalUrl,
maxAmount,
phoneNumber,
mobileNumber,
patpassName,
personEmail,
commerceEmail,
address,
city
);
Confirmar suscripción
Para confirmar la suscripción se debe enviar el token generado en la respuesta a la url tambien generada en la respuesta con el metodo post en un formulario.
<form action="${model.url_webpay}" method="post" name="tokenForm">
<input type="hidden" name="tokenComercio" value="${model.tbk_token}">
<input type="submit" class="btn btn-success" value="Iniciar inscripción">
</form>
<form method="POST" action="$res['url']">
<input type="hidden" name="tokenComercio" value="$res['token']" />
<input type="submit" value="Iniciar inscripción" />
</form>
<form method="POST" action="@ViewBag.Url">
<input type="hidden" name="tokenComercio" value="@ViewBag.Token" />
<input type="submit" value="Iniciar inscripción" />
</form>
<form action="<%= @resp.url %>" method="post">
<input type="hidden" name="tokenComercio" value="<%= @resp.token %>">
<button type="submit">Iniciar inscripcion</button>
</form>
<form action="" method="POST">
<input type="hidden" name="tokenComercio" value="">
<input type="submit" value="Iniciar inscripcion">
</form>
<form action="<${resp.url}>" method="POST">
<input type="hidden" name="tokenComercio" value="<${resp.token}>">
< button type="submit">Iniciar inscripcion</button>
</form>
Estado de la suscripción
Una vez que el tarjetahabiente ha pagado (o declinado, o ha ocurrido un error), Webpay retornará el control vía POST a la URL que indicaste en el returnUrl. Recibirás también el parámetro j_token
que te permitirá conocer el resultado de la transacción:
PatpassComercio.Inscription patpassInscription = new PatpassComercio.Inscription(new PatpassOptions("commerceCode", "APIKey", IntegrationType.TEST));
final PatpassComercioTransactionStatusResponse status = patpassInscription.status(token);
$options = new Options($apiKey, $commerceCode, Options::ENVIRONMENT_INTEGRATION);
$inscription = new Inscription($options);
$response = $inscription->status($token);
Inscription inscription = new Inscription(new Options("commerceCode", "APIKey", PatpassComercioIntegrationType.Test
));
var result = inscription.Status(token);
@options = Transbank::Patpass::Options.new("commerceCode", "APIKey", :production)
@inscription = Transbank::Patpass::PatpassComercio::Inscription.new(options)
@resp = @inscription.status(token: @token)
inscription = Inscription(PatpassComercioOptions("commerceCode", "APIKey", IntegrationType.LIVE))
resp = inscription.status(token)
const options = new Options(
"commerceCode",
"APIKey",
PatpassEnvironment.Integration
);
const inscription = new PatpassComercio.Inscription(options);
const response = await inscription.status(token);
Credenciales y Ambiente
Ambiente de integración
Puede encontrar más información al respecto [en este link](https://www.transbankdevelopers.cl/documentacion/como_empezar#ambiente-de-integracion)
Configuración SDK
Los SDK deben configurarse explícitamente para apuntar al ambiente que quieras utilizar (producción / integración). Para esto puedes crear los objetos de 2 maneras:
- Utilizar los métodos definidos para ello (buildForIntegration o buildForProduction).
- Utilizar un objeto Options que contenga la configuración y pasarlo en el constructor de cada objeto.

# documentacion_pos-autoservicio.md

Source: https://www.transbankdevelopers.cl/documentacion/pos-autoservicio

POS Autoservicio
La solución Autoservicio se integra al kiosco de tu comercio, con la particularidad de que no necesita la intervención de un dependiente de tu establecimiento, sino que permite que los mismos clientes realicen la transacción de pago de manera completa y autónoma. Es ideal para negocios como estacionamientos, bencineras y cines, entre otros.
Cómo funciona
El paso a paso para su implementación:
Auditoría de factibilidad técnica Establecerá si tu comercio tiene las facultades para realizar el desarrollo tecnológico que requiere esta integración. En caso de aprobación, se te entregará un Documento Técnico con las indicaciones a seguir.
Desarrollo Tu comercio deberá realizar el desarrollo según las especificaciones que te entregará Transbank.
Control de Calidad Este proceso verificará que el desarrollo de integración que hiciste, cumple con los que te entregamos en las especificaciones, o si requiere alguna corrección o mejora.
Etapa piloto En un lugar que acordemos juntos, llevamos a producción tu punto de venta autoservicio, donde con clientes reales haremos monitoreo en conjunto de su funcionamiento, por un periódo acotado de 2 semanas. Evaluamos los resultados, y acordamos masificación, también si se requiere algún ajuste.
Masificación Construimos en conjunto un plan de instalación de los puntos de ventas.
Flujo de venta en POS autoservicio:
- El cliente realiza la selección del producto o servicio a comprar.
- El cliente selecciona la forma de pago que disponga el kiosko, efectivo, tarjeta de crédito o tarjeta de débito.
- El kiosco invoca al POS pasándole el monto a cobrar.
- El cliente opera la tarjeta, selecciona cuotas si corresponde, e ingresa su pin.
- El POS informa al kiosco el resultado de la venta (aprobada o rechazada).
- El kiosko libera el producto e imprime los comprobantes.
Equipos y conexiones disponibles
El POS autoservicio cuenta con un puerto LAN, serial y USB para realizar la conexión con la caja y los servidores de Transbank. Al conectar el equipo mediante la conexión serial, es posible establecer la velocidad de conexión, la que puede ir desde los 1200 Bps hasta 115200 Bps. Por defecto la velocidad de conexión es 19200 Bps 8N1. Cuando se conecta por USB la velocidad se establece automáticamente en 115200 y no puede ser cambiada.
PAX IM30
![PAX IM30](https://www.transbankdevelopers.cl/public/slate-library/images/documentacion/autoatencion/paxim30.png)
Funciones de pago disponibles en HOST
- Venta Crédito, con o sin cuotas
- Venta Débito
Cómo empezar
Con el objetivo de facilitar la integración a los equipos POS Autoservicio, se han creado algunos SDKs para diferentes lenguajes de programación, utilizando licencias Open Source, para que puedan modificar, mejorar o añadir alguna corrección en caso de ser necesario. También pueden reportar incidencias en los respectivos repositorios o indicarlas en la comunidad de Transbank Developers en [Slack](https://invitacion-slack.transbankdevelopers.cl/slack_community).
Por el momento, hay SDKs para [.NET](https://github.com/TransbankDevelopers/transbank-pos-sdk-dotnet), [Java](https://github.com/TransbankDevelopers/transbank-pos-sdk-java), [Node.js](https://github.com/TransbankDevelopers/transbank-pos-sdk-nodejs) y estamos trabajando para añadir otros lenguajes a futuro.
Para conocer todo lo que trae el kit de desarrollo, se puede revisar el siguiente [video](https://youtu.be/8TjlGbiPeiQ)
Para configurar el equipo IM30 a internet, revisa el siguiente [video](https://youtu.be/_dYlRuY8yog) donde aprenderás comó revisar el menú integrador con sus opciones y para saber si tu equipo está bien conectado a tu computador, puedes revisar el siguiente [video.](https://youtu.be/u0BKFZkf7iY)
SDK .NET
Para .NET lo puedes encontrar en [NuGet.org](https://www.nuget.org/packages/TransbankPosSDK/). Para instalarlo puedes utilizar por ejemplo el package manager de VisualStudio.
PM> Install-Package TransbankPosSDK
SDK Node.js
Para utilizar este SDK en tu proyecto, solo debes incluirlo utilizando npm/yarn.
npm install transbank-pos-sdk
Integración Nativa
Es recomendable utilizar un SDK disponible a la hora de desarrollar la integración, lo que ahorra tiempo y te despreocupa de desarrollar las comunicaciones con el equipo POS Autoservicio, facilitando bastante la integración, pero en el caso que prefieras realizar la integración por tu cuenta y utilizar los comandos nativos, puedes revisarlos en el manual de integración disponible en la sección de [documentación](https://www.transbankdevelopers.cl/documentacion/pos-autoservicio#documentacion-disponible).
Drivers
PAX IM30
Estos equipos funcionan tanto con puerto serial RS232 y USB (Generalmente plug and play), para el cual puedes necesitar instalar un driver.
Windows
Última versión
Este driver es compatible con los siguientes sistemas operativos:
- Windows 11
- Windows 10
- Windows 8
- Windows 7
- Windows XP
Linux
Última versión
Este driver es compatible con los siguientes kernel de linux:
- 2.6.32 hasta 6.8.0
Por normas PCI los comercios no deben utilizar un Sistema Operativo bajo obsolescencia, además es muy importante mantener su Sistema Operativo con los últimos parches instalado, esto principalmente por un tema de seguridad.
Recuerda que necesitas tener instalados los drivers correspondientes a tu tarjeta de puerto serial o adaptador USB Serial.
Documentación disponible
A continuación, encontrarás la documentación en formato PDF:
Manual de integración POS Autoservicio IM30 |
[Descargar](https://www.transbankdevelopers.cl/files/ManualIntegracion-IM30-v5.pdf)Este documento tiene por objetivo explicar las funcionalidades que debe implementar el Cliente o su proveedor de caja para el desarrollo del módulo de autoservicio, permitiendo realizar transacciones bancarias de Crédito o Débito (redcompra)
Primeros pasos
Para usar el SDK es necesario incluir las siguientes referencias.
using Transbank.POSAutoservicio;
using Transbank.Responses.CommonResponses;
using Transbank.Responses.AutoservicioResponse;
import cl.transbank.pos.POSAutoservicio;
import cl.transbank.pos.exceptions.common.*;
import cl.transbank.pos.exceptions.autoservicio.*;
import cl.transbank.pos.responses.common.*;
import cl.transbank.pos.responses.autoservicio.*;
const { POSAutoservicio } = require('transbank-pos-sdk');
const pos = new POSAutoservicio()
Listar puertos disponibles
Si los respectivos drivers están instalados, entonces puedes usar la función ListPorts()
para identificar los puertos que se encuentren disponibles y seleccionar el que
corresponda con el puerto donde conectaste el POS Autoservicio.
using Transbank.POSAutoservicio;
//...
List<string> ports = POSAutoservicio.Instance.ListPorts();
import cl.transbank.pos.POSAutoservicio;
//...
POSAutoservicio pos = new POSAutoservicio();
List<String> ports = pos.listPorts();
pos.listPorts().then( (ports) => {
console.log(ports);
}).catch( (err) => {
console.log('Ocurrió un error inesperado', err);
});
Abrir un puerto Serial
Para abrir un puerto serial y comunicarte con el POS Autoservicio, necesitarás el nombre del puerto (el cual puedes identificar usando [la función mencionada en el apartado anterior](https://www.transbankdevelopers.cl/documentacion/pos-autoservicio#listar-puertos-disponibles)). También necesitarás el baudrate al cual esta configurado el puerto serial del POS Autoservicio (por defecto es 19200).
Si el puerto no puede ser abierto, se lanzará una excepción TransbankException
en .NET y Java.
using Transbank.POSAutoservicio;
//...
string portName = "COM3";
POSAutoservicio.Instance.OpenPort(portName);
import cl.transbank.pos.POSAutoservicio;
//...
POSAutoservicio pos = new POSAutoservicio();
String port = "COM4";
int baudRate = 19200;
pos.openPort(port, baudRate);
let portName = "/dev/tty.usbserial-1410"; //Ejemplo en MAC
let portName = 'COM4'; //Ejempo en caso de windows
pos.connect(portName).then( (response) => {
console.log('Conectado correctamente');
}).catch( (err) => {
console.log('Ocurrió un error inesperado', {err});
});
Cerrar un puerto Serial
Al finalizar el uso del POS, o si se desea desconectar de la Caja se debe liberar el puerto serial abierto anteriormente.
using Transbank.POSAutoservicio;
//...
POSAutoservicio.Instance.ClosePort();
import cl.transbank.pos.POSAutoservicio;
//...
POSAutoservicio pos = new POSAutoservicio();
pos.closePort();
pos.disconnect().then( (response) => {
console.log('Puerto desconectado correctamente');
}).catch( (err) => {
console.log('Ocurrió un error inesperado', err);
});
Transacciones
Transacción de Venta
Este comando es enviado por la caja para solicitar la ejecución de una venta. Los siguientes parámetros deben ser enviados desde la caja:
Monto
: Monto en pesos informados al POS. Este parámetro es remitido a Transbank para realizar la autorización.Número Ticket/Boleta
: Este número es entregado por el POS en la respuesta o en el voucher que se genera luego de la venta.Enviar voucher
: (Opcional) Indica si el POS al finalizar la transacción envía el voucher formateado en la respuesta (verdadero) o se omite (falso, por defecto).Enviar Status
: (Opcional) Indica si se envían los mensajes intermedios (verdadero) o se omiten (falso, por defecto).
En el caso de C#, los mensajes intermedios se reciben mediante el evento IntermediateResponseChange
y el argumento retornado es de tipo IntermediateResponse
.
using Transbank.POSAutoservicio;
using Transbank.Responses.CommonResponses;
using Transbank.Responses.AutoservicioResponse;
//...
POSAutoservicio.Instance.IntermediateResponseChange += NewIntermadiateMessageRecived; //EventHandler para los mensajes intermedios.
Task<SaleResponse> response = POSAutoservicio.Instance.Sale(ammount, ticket, true, true);
//...
//Manejador de mensajes intermedios...
private static void NewIntermediateMessageReceived(object sender, IntermediateResponse e){
//...
}
//...
import cl.transbank.pos.POSAutoservicio;
import cl.transbank.pos.responses.autoservicio.*;
//...
POSAutoservicio pos = new POSAutoservicio();
SaleResponse response = pos.sale(amount, ticket, true);
pos.setOnIntermediateMessageReceivedListener(this::onIntermediateMessageReceived);
//...
//Manejador de mensajes intermedios...
private void onIntermediateMessageReceived(IntermediateResponse response) {
//...
}
//...
// Venta simple sin estados intermedios
pos.sale(1500, '12423').then( (response) => {
console.log('sale finalizado. Respuesta: ', response);
}).catch( (err) => {
console.log('Ocurrió un error inesperado', err);
}));
// Venta con estados intermedios
let callback = function (data) {
console.log('Mensaje intermedio recibido: ', data)
}
pos.sale(1500, '12423', true, true, callback)
.then( (response) => {
console.log('sale finalizado. Respuesta: ', response);
}).catch( (err) => {
console.log('Ocurrió un error inesperado', err);
});
El resultado de la venta se entrega en la forma de un objeto SaleResponse>
. Si ocurre algún error al ejecutar la acción en el POS se lanzará una excepción del tipo TransbankSaleException
en .NET.
El objeto SaleResponse retornará un objeto con los siguientes datos:
{
"Function": 210,
"ResponseCode": 0,
"ResponseMessage": "Aprobado",
"Commerce Code": 550062700310,
"Terminal Id": "ABC1234C",
"Ticket": "ABC123",
"Authorization Code": "XZ123456",
"Amount": 15000,
"Last 4 Digits": 6677,
"Operation Number": 60,
"Card Type": "CR",
"Accounting Date": "28/10/2019 22:35:12",
"Account Number": "30000000000",
"Card Brand": "AX",
"Real Date": "28/10/2019 22:35:12",
"Printing Field:": List<string>,
"Shares Type": 3,
"Shares Number": 3,
"Shares Amount": 5000,
"Shares Type Gloss": " "
}
Transacción de última venta
Este comando es enviado por la caja, solicitando al POS los datos de la última venta realizada.
Si el POS recibe el comando de Última Venta y no existen transacciones en memoria del POS, se envía la respuesta a la caja indicando el código de respuesta 11. El siguiente parámetro debe ser enviado desde la caja:
Enviar voucher
: (Opcional) Indica si el POS al finalizar la transacción envía el voucher formateado en la respuesta (verdadero) o se omite (falso, por defecto).
using Transbank.POSAutoservicio;
using Transbank.Responses.AutoservicioResponse;
//...
Task<LastSaleResponse> response = POSAutoservicio.Instance.LastSale();
import cl.transbank.pos.POSAutoservicio;
import cl.transbank.pos.responses.autoservicio.*;
//...
POSAutoservicio pos = new POSAutoservicio();
LastSaleResponse lastSaleResponse = pos.lastSale();
pos.getLastSale().then( (response) => {
console.log('getLastSale ejecutado. Respuesta: ', response);
}).catch( (err) => {
console.log('Ocurrió un error inesperado', err);
});
El resultado de la transacción última venta devuelve los mismos datos que una venta normal y se entrega en forma de un objeto LastSaleResponse
. Si ocurre algún error al ejecutar la acción en el POS se lanzará una excepción del tipo TransbankLastSaleException
en .NET.
El objeto LastSaleResponse retornará un objeto con los siguientes datos:
{
"Function": 260,
"ResponseCode": 0,
"ResponseMessage": "Aprobado",
"Commerce Code": 550062700310,
"Terminal Id": "ABC1234C",
"Ticket": "ABC123",
"Authorization Code": "XZ123456",
"Amount": 15000,
"Last 4 Digits": 6677,
"Operation Number": 60,
"Card Type": "CR",
"Accounting Date": "28/10/2019 22:35:12",
"Account Number": "30000000000",
"Card Brand": "AX",
"Real Date": "28/10/2019 22:35:12",
"Printing Field:": List<string>,
"Shares Type": 3,
"Shares Number": 3,
"Shares Amount": 5000,
"Shares Type Gloss": " "
}
Transacción de Cierre
Este comando es gatillado por la caja. El POS ejecuta la transacción de cierre contra el Autorizador (no se contempla Batch Upload). Como respuesta, el POS Autoservicio enviará un aprobado o rechazado.
El siguiente parámetro debe ser enviado desde la caja:
Enviar voucher
: (Opcional) Indica si el POS al finalizar la transacción envía el voucher formateado en la respuesta (verdadero) o se omite (falso, por defecto).
using Transbank.POSAutoservicio;
using Transbank.Responses.AutoservicioResponse;
//...
Task<CloseResponse> response = POSAutoservicio.Instance.Close();
import cl.transbank.pos.POSAutoservicio;
import cl.transbank.pos.responses.autoservicio.*;
//...
POSAutoservicio pos = new POSAutoservicio();
CloseResponse response = pos.close()
pos.closeDay().then( (response) => {
console.log('closeDay ejecutado. Respuesta: ', response);
}).catch( (err) => {
console.log('Ocurrió un error inesperado', err);
});
El resultado del cierre de caja se entrega en la forma de un objeto CloseResponse
. Si ocurre algún error al ejecutar la acción en el POS se lanzará una excepción del tipo TransbankCloseException
en .NET.
El objeto CloseResponse retornará un objeto con los siguientes datos:
{
"FunctionCode": 510,
"ResponseCode": 0,
"ResponseMessage": "Aprobado",
"Success": true,
"CommerceCode": 550062700310,
"TerminalId": "ABC1234C",
"Printing Field:": List<string>
}
Transacción de Carga de Llaves
Esta transacción permite al POS Autoservicio del comercio requerir cargar nuevas Working Keys desde Transbank. Como respuesta el POS Autoservicio enviará un aprobado o rechazado.
using Transbank.POSAutoservicio;
using Transbank.Responses.CommonResponses;
//...
Task<LoadKeysResponse> response = POSAutoservicio.Instance.LoadKeys();
import cl.transbank.pos.POSAutoservicio;
import cl.transbank.pos.responses.common.*;
//...
POSAutoservicio pos = new POSAutoservicio();
LoadKeysResponse response = pos.loadKeys();
pos.loadKeys().then( (response) => {
console.log('loadKeys ejecutado. Respuesta: ', response);
}).catch( (err) => {
console.log('Ocurrió un error inesperado', err);
});
El resultado de la carga de llaves se entrega en la forma de un objeto LoadKeysResponse
. Si ocurre algún error al ejecutar la acción en el POS se lanzará una excepción del tipo TransbankLoadKeysException
en .NET.
El objeto LoadKeysResponse retornará un objeto con los siguientes datos:
{
"FunctionCode": 810,
"ResponseCode": 0,
"ResponseMessage": "Aprobado",
"Success": true,
"CommerceCode": 550062700310,
"TerminalId": "ABC1234C"
}
Transacción de Poll
Esta mensaje es enviado por la caja para saber si el POS está conectado. En el SDK el resultado de esta operación es un Booleano
. Si ocurre algún error al momento de ejecutar la acción en el POS, se lanzará una excepción del tipo TransbankException
.
using Transbank.POSAutoservicio;
//...
Task<bool> connected = POSAutoservicio.Instance.Poll();
import cl.transbank.pos.POSAutoservicio;
//...
POSAutoservicio pos = new POSAutoservicio();
boolean pollResult = pos.poll();
pos.poll().then((res) => {
console.log('Resultado ejecucion:', res)
})
.catch( (err) => {
console.log('Ocurrió un error inesperado', err);
});
Transacción de Inicialización
Este mensaje es enviado por la caja para que el POS autoservicio pueda cargar los parámetros y el aplicativo. En el SDK el resultado de esta operación es un Booleano
. Si ocurre algún error al momento de ejecutar la acción en el POS, se lanzará una excepción del tipo TransbankException
en .NET.
Debido a que la transacción de Inicialización tiene un tiempo superior a una venta normal y el tiempo en que el POS autoservicio queda fuera de comunicación con la caja es variable, se dividió en 2 comandos:
- Transacción de Inicialización: Realiza la operación de inicialización.
- Respuesta de Inicialización: Se utiliza para conocer el resultado de la operación de inicialización.
using Transbank.POSAutoservicio;
//...
Task<bool> initialized = POSAutoservicio.Instance.Initialization();
import cl.transbank.pos.POSAutoservicio;
//...
POSAutoservicio pos = new POSAutoservicio();
boolean pollResult = pos.initialization();
pos.initialization().then((res) => {
console.log('Resultado ejecucion:', res)
})
.catch( (err) => {
console.log('Ocurrió un error inesperado', err);
});
Transacción de Respuesta Inicialización
Esta mensaje es enviado por la caja para conocer el resultado de la última operación de inicialización realizada por el POS autoservicio.
using Transbank.POSAutoservicio;
using Transbank.Responses.AutoservicioResponse;
//...
Task<InitializationResponse> response = POSAutoservicio.Instance.InitializationResponse();
import cl.transbank.pos.POSAutoservicio;
import cl.transbank.pos.responses.autoservicio.*;
//...
POSAutoservicio pos = new POSAutoservicio();
InitializationResponse response = pos.initializationResponse();
pos.initializationResponse().then((res) => {
console.log('Resultado ejecucion:', res)
})
.catch( (err) => {
console.log('Ocurrió un error inesperado', err);
});
El resultado de la inicialización se entrega en la forma de un objeto InitializationResponse
. Si ocurre algún error al ejecutar la acción en el POS se lanzará una excepción del tipo TransbankInitializationResponseException
en .NET.
El objeto InitializationResponse retornará un objeto con los siguientes datos:
{
"FunctionCode": 1080,
"ResponseCode": 0,
"ResponseMessage": "Aprobado",
"Success": true,
"Real Date": "28/10/2019 22:35:12"
}
Voucher
Los voucher serán generados por el POS Autoservicio cuando el parámetro Enviar voucher
sea verdadero, el voucher puede ser retornado en la respuesta de las transacciones de venta, última venta, anulación y cierre.
Cada línea contendrá 40 caracteres, los que se concatenarán en un solo buffer que será enviado en el campo de impresión en las respuesta de las transacciones mencionadas anteriormente. Al recibir el buffer se debe considerar que cada 40 caracteres se compone una línea del voucher.
En el SDK de .NET se entregará una lista con cada línea del voucher.
[
" REPORTE DE CIERRE DEL TERMINAL ",
" OPERACIONES TRANSBANK ",
" CALLE HUERFANOS 770 10 ",
" SANTIAGO ",
" 597029983518-V18.1A2 ",
"FECHA HORA TERMINAL",
"22/04/21 14:14:56 70000933",
" ",
" NUMERO TOTAL",
"DEBITO 003 $ 3.000",
"MAESTRO 001 $ 2.000",
"VISA 010 $ 111.100",
"MASTERCARD 004 $ 80.000",
"AMEX 000 $ 0",
"MAGNA 000 $ 0",
"DINERS 002 $ 500",
"----------------------------------------",
"TOTAL CAPTURAS 020 $ 196.600"
]

# documentacion_pos-bluetooth.md

Source: https://www.transbankdevelopers.cl/documentacion/pos-bluetooth

POS Integrado Bluetooth
Modelo de Operación
*La caja movilizada del comercio es la encargada de entregar internet al POS Integrado Bluetooth mediante la conexión Bluetooth que se establece entre los dos dispositivos.
**Es el POS Integrado Bluetooth quien se comunica con Transbank para toda transacción financiera
Requerimientos
Componentes
Android
- Librería POS Integrado Bluetooth: Librería encargada de manejar la transacción de POS integrado Bluetooth, iniciándola y obteniendo la respuesta.
iOS
- Framework iSMP(PCL): librería necesaria para comunicación Bluetooth con terminal.
- Framework Mpos Integrado: Librería encargada de manejar la transacción de Mpos integrado, iniciándola y obteniendo la respuesta.
Herramientas
- IDE Android Studio
- Xcode, una versión compatible con Swift 4.1 o 3+
Lenguajes soportados
- Java Nativo Android
- Kotlin 1.x
- Swift
Versión mínima de desarrollo con soporte
- Android 10.x
- iOS 16.x
Versión mínima de desarrollo sin soporte
- Android 4.x (API 14)
- iOS 10.0
Descarga de librerías
Proyectos de ejemplos
Se han creado proyectos de ejemplo para Android (10.x en adelante) y iOS (16.x en adelante) para que puedas probar antes de comenzar con tu desarrollo.
Android
Instalación
Es importante aclarar que la librería cuenta con dos componentes, uno por el lado de la comunicación con el terminal llamado PCL y la parte de POS Integrado Bluetooth la cual se encarga de la transacción. Esta sección explica que es necesario para establecer la comunicación Bluetooth entre el terminal de pago (Link2500) y el smartphone.
- Copiar el archivo “mposintegrado.aar” en el directorio de librerías (en este caso libs) de la aplicación.
- En el archivo build.gradle a nivel de proyecto agregar en la sección allProjects->repositories , lo siguiente:
flatDir {dirs 'libs'}
- En el archivo build.gradle a nivel de la aplicación en la sección dependencies agregar:
implementation (name:'mposintegrado', ext:'aar')
Esto agregara la librería para su uso en el proyecto, luego para importarlo en el código se utiliza:
import com.ingenico.pclservice.PclService;
import com.ingenico.pclutilities.PclUtilities;
import com.ingenico.pclutilities.PclUtilities.BluetoothCompanion;
import com.ingenico.pclutilities.SslObject;
import posintegrado.ingenico.com.mposintegrado.mposLib;
Requerimientos
Para el correcto funcionamiento de la librería se deben agregar los siguientes permisos al tag “manifest” del Android manifest de la aplicación:
<uses-permission android:name="android.permission.INTERNET"/>
<uses-permission android:name="android.permission.WRITE_EXTERNAL_STORAGE"/>
<uses-permission android:name="android.permission.ACCESS_NETWORK_STATE"/>
<uses-permission android:name="android.permission.BLUETOOTH"/>
<uses-permission android:name="android.permission.BLUETOOTH_ADMIN"/>
<uses-permission android:name="android.permission.ACCESS_WIFI_STATE"/>
Adicional es necesario agregar los siguientes servicios dentro del tag application del Android manifest:
<service android:name="com.ingenico.pclservice.PclService" />
<service android:name="com.ingenico.pclservice.BluetoothService"/>
Estableciendo comunicación con el terminal de pago
La comunicación con el terminal como ya se dijo con anterioridad es realizada mediante el componente PCL incluido ya en la librería de POS Integrado Bluetooth. Para la implementación usaremos dos clases:
- CommonActivity: Clase abstracta la cual cuenta con la implementación (y definición) de distintos métodos y atributos asociados a la comunicación, los cuales son usados por las distintas actividades.
- MainActivity: Clase que extiende commonActivity, esta contiene la lógica de la aplicación en sí.
Observación: El uso de una clase abstracta en común para las distintas actividades del app es recomendado, pero esto queda a decisión del desarrollador. Para efectos del ejemplo se irá detallando lo que se encuentra en cada clase y su objetivo.
CommonActivity
Lo primero a tomar en cuenta, es que esta clase debe extender de Activity Lo siguiente es definir las siguientes variables utilizadas en el proceso de conexión:
- protected PclService mPclService = null;
- Manejo del servicio PCL (comunicación)
- Protected boolean mBound = false;
- Control del estado servicio PCL (comunicación)
- Protected PclUtilities mPclUtil;
- Manejo de funcionalidades de PCL (comunicación)
- Protected mposLib mposLibobj;
- Manejo de transacciones de mposIntegrado.
- Protected boolean mServiceStarted;
- Control del estado servicio PCL (comunicación)
- Protected CharSequence mCurrentDevice;
- Dispositivo actual.
Binding al servicio PCL (Comunicación)
Se define la siguiente clase para la interacción con el terminal la cual se encarga de hacerle Bind al servicio de PCL para la comunicación entre terminal y smartphone:
// Implement ServiceConnection
class PclServiceConnection implements ServiceConnection
{
public void onServiceConnected(ComponentName className, IBinder boundService )
{
/*We've bound to LocalService, cast the IBinder and get
LocalService instance*/
PclService.LocalBinder binder = (PclService.LocalBinder)
boundService;
mPclService = (PclService) binder.getService();
onPclServiceConnected();
}
public void onServiceDisconnected(ComponentName className)
{
mPclService = null;
}
};
Esta clase tiene dos métodos definidos para la desconexión y conexión respectivamente. Luego de ser definida esta clase es importante agregar una instancia de esta, es decir:
private PclServiceConnection mServiceConnection;
Adicional se definen los siguientes métodos para iniciar el servicio de PCL y hacer release de este.
// You can call this method in onCreate for instance
protected void initService()
{
if (!mBound)
{
mServiceConnection = new PclServiceConnection();
Intent intent = new Intent(this, PclService.class);
mBound = bindService(intent, mServiceConnection,
Context.BIND_AUTO_CREATE);
}
}
protected void releaseService()
{
if (mBound)
{
unbindService(mServiceConnection );
mBound = false;
}
}
Manejo de estado de la conexión
Para controlar el manejo de la conexión se puede realizar de dos formas, mediante una llamada al api de PCL serverStatus constantemente o mediante la implementación de un broadcast receiver. Para efecto de esta implementación se usa la segunda opción:
Primero se implementa la clase StateReceiver la cual extiende de BroadcastReceiver:
private class StateReceiver extends BroadcastReceiver
{
private CommonActivity ViewOwner = null;
@SuppressLint("UseValueOf")
public void onReceive(Context context, Intent intent)
{
String state = intent.getStringExtra("state");
ViewOwner.onStateChanged(state);
}
StateReceiver(CommonActivity receiver)
{
super();
ViewOwner = receiver;
}
}
Luego de definida esta clase es importante agregar una instancia de esta, es decir:
private StateReceiver m_StateReceiver = null;
Luego se agrega los métodos que permiten iniciar o detener el broadcast receiver
private void initStateReceiver()
{
if(m_StateReceiver == null)
{
m_StateReceiver = new StateReceiver(this);
IntentFilter intentfilter = new IntentFilter(
IntentFilter("com.ingenico.pclservice.intent.action.STATE_CHANGED" );
registerReceiver(m_StateReceiver, intentfilter);
}
}
private void releaseStateReceiver()
{
if(m_StateReceiver != null)
{
unregisterReceiver(m_StateReceiver);
m_StateReceiver = null;
}
}
El objetivo es de escuchar por "com.ingenico.pclservice.intent.action.STATE_CHANGED" y obtener el string extra de “state” el cual puede ser “CONNECTED” o “DISCONNECTED”
Adicional se agregan las siguientes definiciones abstractas:
abstract void onStateChanged(String state);
abstract void onPclServiceConnected();
Las cuales deben ser implementadas por las distintas clases que extiendan de esta. Con el fin de que cada una de ellas pueda decidir qué hacer al momento de conectarse o desconectarse a nivel de dispositivo y servicio.
Se agrega a los eventos onResume y onPause la llamada a los métodos initStateReceiver y releaseStateReceiver implementados anteriormente para controlar cuando se está escuchando y cuando no.
@Override
protected void onResume()
{
super.onResume();
initStateReceiver();
}
@Override
protected void onPause()
{
super.onPause();
releaseStateReceiver();
}
Otra función importante de implementar es una en la cual se utilice el api de PCL “serverStatus” la cual permite validar si hay algún dispositivo conectado actualmente. La forma de implementación de esto queda a definición del desarrollador. En el ejemplo se implementó de la siguiente forma:
public boolean isCompanionConnected()
{
boolean bRet = false;
if (mPclService != null)
{
byte result[] = new byte[1];
{
if (mPclService.serverStatus(result) == true)
{
if (result[0] == 0x10)
{
bRet = true;
}
}
}
}
return bRet;
}
Main Activity
Esta es la actividad principal de implementación y la cual extiende a CommonActivity.
Lo primero a realizar, es instanciar en el método onCreate el evento “mPclUtil” que revisa si hay algún dispositivo ya activado de la siguiente forma:
mPclUtil = new PclUtilities(this, "posintegrado.ingenico.com.sampleandroidapp", "pairing_addr.txt");
Luego se crean los siguientes métodos para iniciar o detener el servicio de PCL(comunicación)
private void startPclService()
{
if (!mServiceStarted)
{
SharedPreferences settings = getSharedPreferences("PCLSERVICE", MODE_PRIVATE);
boolean enableLog = settings.getBoolean("ENABLE_LOG", true);
Intent i = new Intent(this, PclService.class);
i.putExtra("PACKAGE_NAME", "posintegrado.ingenico.com.sampleandroidapp");
i.putExtra("FILE_NAME", "pairing_addr.txt");
i.putExtra("ENABLE_LOG", enableLog);
if (getApplicationContext().startService(i) != null) mServiceStarted = true;
}
}
private void stopPclService()
{
if (mServiceStarted)
{
Intent i = new Intent(this, PclService.class);
if (getApplicationContext().stopService(i))
mServiceStarted = false;
}
}
En las siguientes líneas de código se realiza la elección de terminal y se llama a la función de inicio de la comunicación.
/*Variable de control si ya se encontró un dispositivo*/
boolean bFound = false;
/*Se obtiene con esto la lista de los dispositivos ingenico paired con el
terminal*/
Set<BluetoothCompanion> btComps = mPclUtil.GetPairedCompanions();
if (btComps != null && (btComps.size() > 0)) {
/* Loop through paired devices*/
for (BluetoothCompanion comp : btComps) {
/*Aca se revisa si el dispositivo esta activo y lo define como el actual*/
if (comp.isActivated()) {
bFound = true;
mCurrentDevice = comp.getBluetoothDevice().getAddress() + " - " +
comp.getBluetoothDevice().getName();
}
else {
/*Se activa el dispositivo*/
mPclUtil.ActivateCompanion(comp.getBluetoothDevice().getAddress());
return;
}
}
}
Para efectos de este ejemplo si no encuentra ninguno activado, activa el primer dispositivo pareado con el Smartphone. Esta lógica debe ser implementada según defina el desarrollador ya que es un flujo que depende de la aplicación misma.
Efectuando una venta
Para implementar una Transacción de Venta, lo primero es crear un método que gatillara la acción para transaccionar con el POS integrado bluetooth:
mposLibobj = new mposLib(mPclService);
String stx = "02";
String ext = "03";
String mensajeriaTrx = "0200|20000|123456|||0";
/*Convierto mi string de trx a hex*/
String trxToHex = mposLibobj.convertStringToHex(mensajeriaTrx);
/*Luego calculo el largo de mi trama en hex (LRC)*/
String obtenerLrc = calcularLRC(trxToHex);
/*Ahora armo el comando completo de trx*/
String trxCompleta = stx+trxToHex+ext+ obtenerLrc;
/*Envio el comando completo para que el POS integrado Bluetooth lo procese*/
mposLibobj.stratTransaction(trxCompleta);
El método que calcula el LRC del comando de transacción en hex es el siguiente:
private String calcularLRC(String input){
String LRC = "";
int uintVal = 0;
if(input != ""){
byte[] arrayofhex = hexStringToByteArray(input);
for(int count = 1; count < arrayofhex.length; ++count){
if(count == 1){
uintVal = arrayofhex[count - 1] ^ arrayofhex[count];
}else{
uintVal ^= arrayofhex[count];
}
}
}
LRC = Interger.toHexString(uintVal).toUpperCase();
int f = LRC.length();
if(f == 2){
return LRC;
}else {
char[] chars = LRC.toCharArray();
StringBuffer hex = new StringBuffer();
for(int i = 0; i < chars.length; i++) {
hex.append(Integer.toHexString(chars[i]));
}
return hex.toString();
}
}
Luego se debe implementar el callback de la librería de POS Integrado Bluetooth encargado de capturar la respuesta luego de finalizada la transacción. Esto se hace de la siguiente forma
mposLibobj.setOnTransactionFinishedListener(new mposLib.onTransactionFinishedListener() {
public void onFinish(String response) {
/*EJEMPLO DE RESPONSE*/
String respToString = mposLibobj.convertHexToString(response);
Log.i("Respuesta response: ", respToString);
}
});
Acá el integrador deberá decidir qué hacer con la respuesta obtenida en la variable response, cuando se gatille este callback.
iOS
Instalación
Framework iSMP(PCL)
Este framework es necesario para establecer la comunicación Bluetooth entre el terminal de pago (Link2500) y el smartphone. Los siguientes pasos son necesarios para su utilización:
- Copiar el archivo “iSMP.framework” en alg n directorio para su posterior utilización.
- En la configuración del proyecto seleccionar el “target” el cual utilizara el framework.
- Ir al tab “Build Phases”.
- Seleccionar el build step “Link Binary With Libraries”.
- Hacer click en el bot n “+” y luego en “Add Other”.
- Ir al directorio donde se tiene el framework y seleccionar “iSMP.framework”.
Esto agregara el framework al proyecto, luego para importarlo en el código se utiliza:
Import iSMP
Dependencias
El iSMP framework requiere que se asocien otros frameworks del iPhone SDK con el “target”. Los cuales son los siguientes:
- Foundation
- Security
- UiKit
- CoreGraphics
- SystemConfiguration
- ExternalAccessory
- CFNetwork
Estos se deben agregar de la siguiente forma:
- En la configuración del proyecto seleccionar el “target” el cual utilizara el framework.
- Ir al tab “Build Phases”.
- Seleccionar el build step “Link Binary With Libraries”.
- Hacer click en el bot n “+” y luego seleccionar las librerías requeridas.
- Hacer click en el bot n “add”.
Build settings de la aplicación
Se debe buscar en los build settings del target del proyecto “C language dialect” y elegir GNU99.
Requerimientos de la aplicación
Una aplicación que utilice el frame iSMP debe declarar en su info.plist los “protocol names” que son usados para la comunicación entre el smartphone y el terminal de pago, Los protocolos soportados son:
- com.ingenico.easypayemv.spm-transaction
- com.ingenico.easypayemv.spm-configuration
- com.ingenico.easypayemv.spm-networkaccess
- com.ingenico.easypayemv.spm-sppchannel
- com.ingenico.easypayemv.spm-pppchannel
Estos se deben agregar al archivo .plist en el key “Supported external accessory protocols”.
Framework Mpos Integrado
Este framework es necesario para iniciar la transacción y capturar la respuesta. Los siguientes pasos son necesarios para su utilización:
- Copiar el archivo “mPosIntegradoFrameworkiOS.framework” en algún directorio para su posterior utilización.
- En la configuración del proyecto seleccionar el “target” el cual utilizara el framework.
- Ir al tab “Build Phases”.
- Seleccionar el build step “Link Binary With Libraries”.
- Hacer click en el bot n “+” y luego en “Add Other”.
- Ir al directorio donde se tiene el framework y seleccionar "PosIntegradoFrameworkiOS.framework”.
- Luego agregar un nuevo “Build Phase” del tipo “Copy files Phase”.
- Dentro de este nuevo phase elegir como Destination “Frameworks” y agrega a la * sta “mPosIntegradoFrameworkiOS.framework” agregado anteriormente.
- Ponerle como nombre a este phase “Embed Frameworks”.
Todo este proceso agregara el framework al proyecto, luego para importarlo en el código se utiliza:
import mPosIntegradoFrameworkiOS
Dependiendo de la aplicación puede ser necesario la activación de “Wireless Accessory Configuration” en la sección capabilities del target del proyecto.
Estableciendo comunicación con el terminal de pago
A continuación, se explica cómo funciona la forma de establecer la comunicación. La comunicación con el terminal es realizada mediante el uso el framework iSMP(PCL) y framework de MposIntegrado.
Primero se debe contar con una variable del tipo ICPclService la cual se inicializa de la siguiente forma:
var pclService = ICPclService.shared()
Esta será utilizada para manejar los distintos métodos del framework que son necesarios para la conexión.
Adicional se deben crear las siguientes variables:
var ssl: ICSSLParameters = {
let initValue = ICSSLParameters()
initValue.isSSL=false
initValue.sslCertificateName = "serverb"
initValue.sslCertificatePassword = "coucou"
return initValue
}()
Variable utilizada en métodos para establecer la comunicación.
var terminals: [ICTerminal] = []
Variable en donde se guardarán los terminales de pago que ya se encuentran emparejados con el dispositivo.
var utils = mPosIntegrado()
Variable para manejar los distintos métodos del Framework.
En las siguientes líneas de código se realiza la elección de terminal y se llama a la función de inicio de la comunicación.
/*Se setea el objeto pclService que se utilizara en utils*/
utils.setPclServiceforUtils(service: self.pclService!)
/*Se detiene el servicio de pcl actual para evitar problemas con alguno iniciado anteriormente*/
self.pclService?.stop()
/*Se obtiene el listado de terminales pareados con el Smartphone*/
terminals=utils.getDevices();
/*Para efectos del ejemplo se selecciona el primero de la lista obtenida*/
let terminalSelected = terminals[0]
/*Se llama la función implementada para conectar al terminal*/
self.startPclService(terminal: terminalselected, sslParameters: self.ssl)
/*Función encargada de llamar a los m todos necesarios para partir la comunicación con el terminal*/
func startPclService(terminal:ICTerminal, sslParameters: ICSSLParameters)
{
/*Se inicia el servicio de PCL*/
pclService?.start(with: terminal, andSecurity: sslParameters)
/*Se obtiene el estado del servidor lo cual gatilla que se active la comunicación si es que estaba inactiva*/
pclService?.getState()
}
Hay algunos callback importantes que están implementados, particularmente los que se gatillan cuando la comunicación se establece correctamente y otro para poder ver el log del proceso en la consola.
Primero se debe agregar en la definición de la clase el siguiente protocolo:
ICPclServiceDelegate
También se realizan los siguientes seteos para su correcto funcionamiento (recomendado en el ViewDidLoad)
self.pclService?.delegate=self
Luego se implementan los siguientes callback:
public func notifyConnection(_ sender: ICPclService!)
{
//DO SOMETHING WHEN THE SERVER IS CONNECTED
}
public func notifyDisconnection(_ sender: ICPclService!)
{
//DO SOMETHING WHEN THE SERVER IS DISCONNECTED
}
/*Este callback se usa para mostrar un log en consola del framework pcl*/
public func pclLogEntry(_ message: String!, withSeverity severity: Int32) {
print("\(ICPclService.severityLevelString(severity) ?? "") \(message ?? "")")
}
Realizar un pago con Mpos Integrado
Luego de tener el terminal con la comunicación establecida como ya se explicó anteriormente, se puede dar inicio al proceso de pago.
Lo primero que se debe hacer es implementar el callback del framework de MposIntegrado encargado de capturar la respuesta luego de finalizada la transacción. Esto se hace de la siguiente forma:
utils.onFinishTransaction =
{
result in
// DO SOMETHING WITH THE RESPONSE
print("RESPONSE: \(result)")
// DO SOMETHING WITH THE RESPONSE
}//NEEDED TO CAPTURE RESULT OF TRANSACTION
Acá el integrador deber decidir qu hacer con la respuesta obtenida en la variable result, cuando se gatille este callback. En el ejemplo simplemente se imprime por consola.
Luego de tener implementado el callback se debe llamar al método startTransaction del framework de MposIntegrado, un ejemplo de llamada seria
utils.startTransaction(payload:"02303230307C313030307C3132333435367C7C7C30036B")
El parámetro payload corresponde al mensaje de POS Integrado disponibles en la [referencia de POS Integrado](https://www.transbankdevelopers.cl/referencia/posintegrado#mensajes) en formato Hex String.
El resultado será capturado en el callback y corresponde a la respuesta definidas en la [referencia de POS Integrado](https://www.transbankdevelopers.cl/referencia/posintegrado#mensajes) en formato Hex String
Transacción de obtener detalle de ventas
La respuesta de esta transacción tiene el siguiente formato:
<STX>0261|Datostransacion1<ENQ>Datostransaccion2<ENQ>Datostransaccion3<ENQ>…..DatostransaccionN<ETX><LRC>
A diferencia de pos integrado regular esta se entrega toda junta y no se va entregando transacción a transacción.
El siguiente sería un ejemplo de la respuesta en hex string:
02303236317C30307C3539373035353535303030317C49334445533137317C307C3735383039387C38313030307C30307C307C383634337C3232377C44427C3030303030307C202020202020202020202020202020202020207C44427C31323039323031387C3132303332367C307C300530307C3539373035353535303030317C49334445533137317C307C3936393233347C38313030307C30307C307C383634337C3232387C44427C3030303030307C202020202020202020202020202020202020207C44427C31323039323031387C3137323431367C307C307C034
Efectuando transacciones con POS Integrado Bluetooth
Luego de tener el terminal con la comunicación establecida con la caja movilizada como se explicó anteriormente, se puede dar inicio a la implementación de las diversas transacciones disponibles en la Integración Nativa de POS Integrado:
[Transacción de Venta](https://www.transbankdevelopers.cl/referencia/posintegrado#mensaje-de-venta)[Transacción Última Venta](https://www.transbankdevelopers.cl/referencia/posintegrado#mensaje-de-ultima-venta)[Transacción Anulación Venta](https://www.transbankdevelopers.cl/referencia/posintegrado#mensaje-de-anulacion)[Transacción de Cierre](https://www.transbankdevelopers.cl/referencia/posintegrado#mensaje-de-cierre)[Transacción Detalle de Ventas](https://www.transbankdevelopers.cl/referencia/posintegrado#mensaje-detalle-de-ventas)[Transacción Totales](https://www.transbankdevelopers.cl/referencia/posintegrado#mensaje-de-totales)[Transacción Carga de Llaves](https://www.transbankdevelopers.cl/referencia/posintegrado#mensaje-de-carga-de-llaves)[Transacción Polling](https://www.transbankdevelopers.cl/referencia/posintegrado#mensaje-de-poll)

# documentacion_transaccion-completa.md

Source: https://www.transbankdevelopers.cl/documentacion/transaccion-completa

Transacción Completa
Una Transacción Completa permite al comercio presentar al tarjetahabiente un
formulario propio para almacenar los datos de la tarjeta, fecha de vencimiento
y cvv (no necesario para comercios con la opción sin cvv
habilitada).
Transacción Completa
Crear una transacción
Esta operación te permite iniciar o crear una transacción, Transbank procesa el requerimiento y entrega como resultado de la operación el token de la transacción.
FullTransaction tx = new FullTransaction(new WebpayOptions(IntegrationCommerceCodes.TRANSACCION_COMPLETA, IntegrationApiKeys.WEBPAY, IntegrationType.TEST));
FullTransactionCreateResponse response = tx.create(buyOrder, sessionId, amount, cvv, cardNumber, cardExpirationDate);
$option = new Options($apiKey, $commerceCode, Options::ENVIRONMENT_PRODUCTION);
$transaction = new Transaction($option);
$response = $transaction->create(
$buy_order,
$session_id,
$amount,
$cvv,
$card_number,
$card_expiration_date
);
var tx = new FullTransaction(new Options(IntegrationCommerceCodes.TRANSACCION_COMPLETA, IntegrationApiKeys.WEBPAY, IntegrationType.TEST));
var response = tx.Create(
buyOrder: buy_order,
sessionId: session_id,
amount: amount,
cvv: cvv,
cardNumber: card_number,
cardExpirationDate: card_expiration_date);
@options = Transbank::Webpay::Options.new("commerceCode", "APIKey", :integration)
@transaction = Transbank::Webpay::TransaccionCompleta::Transaction.new(@options)
@resp = @transaction.create(buy_order: @buy_order, session_id: @session_id, amount: @amount, cvv: @cvv, card_number: @card_number, card_expiration_date: @card_expiration_date)
tx = Transaction(WebpayOptions(IntegrationCommerceCodes.TRANSACCION_COMPLETA, IntegrationApiKeys.WEBPAY, IntegrationType.TEST))
resp = tx.create(
buy_order: buy_order, session_id: session_id, amount: amount, cvv: cvv,
card_number: card_number, card_expiration_date: card_expiration_date
)
const tx = new TransaccionCompleta.Transaction(
new Options(
IntegrationCommerceCodes.TRANSACCION_COMPLETA,
IntegrationApiKeys.WEBPAY,
Environment.Integration
)
);
const response = await tx.create(
buyOrder,
sessionId,
amount,
cvv,
cardNumber,
cardExpirationDate
);
Respuesta Transaction.create
response.getToken();
$response->getToken();
response.Token;
response.token
## Versión 3.x del SDK
response['token']
## Versión 2.x del SDK
response.token
response.token
Consulta de cuotas
Antes de confirmar una transaccion es necesario confirmar la cantidad de cuotas y entregar el valor de estas.
FullTransaction tx = new FullTransaction(new WebpayOptions(IntegrationCommerceCodes.TRANSACCION_COMPLETA, IntegrationApiKeys.WEBPAY, IntegrationType.TEST));
final FullTransactionInstallmentResponse response = tx.installments(token, installmentsNumber);
$option = new Options($apiKey, $commerceCode, Options::ENVIRONMENT_PRODUCTION);
$transaction = new Transaction($option);
$response = $transaction->installments(
$token,
$installmentsNumber
);
var tx = new FullTransaction(new Options(IntegrationCommerceCodes.TRANSACCION_COMPLETA, IntegrationApiKeys.WEBPAY, IntegrationType.TEST));
var response = tx.Installments(
token,
installments_number);
@options = Transbank::Webpay::Options.new("commerceCode", "APIKey", :integration)
@transaction = Transbank::Webpay::TransaccionCompleta::Transaction.new(@options)
@resp = @transaction.installments(token: @token, installments_number: @installments_number )
tx = Transaction(WebpayOptions(IntegrationCommerceCodes.TRANSACCION_COMPLETA, IntegrationApiKeys.WEBPAY, IntegrationType.TEST))
resp = tx.installments(token=token, installments_number=installments_number)
const tx = new TransaccionCompleta.Transaction(
new Options(
IntegrationCommerceCodes.TRANSACCION_COMPLETA,
IntegrationApiKeys.WEBPAY,
Environment.Integration
)
);
const response = await tx.installments(token, installmentsNumber);
Respuesta consulta de cuotas
response.getInstallmentsAmount();
response.getIdQueryInstallments();
DeferredPeriod deferredPeriod = response.getDeferredPeriods()[0];
deferredPeriod.getAmount();
deferredPeriod.getPeriod();
$response->getInstallmentsAmount();
$response->getIdQueryInstallments();
$response->getDeferredPeriods();
response.InstallmentsAmount;
respone.IdQueryInstallments;
response.DeferredPeriods;
response.installments_amount
response.id_query_installments
response.deferred_periods
## Versión 3.x del SDK
response['installments_amount']
response['id_query_installments']
response['deferred_periods']
## Versión 2.x del SDK
response.installments_amount
response.id_query_installments
response.deferred_periods
response.installments_amount
response.id_query_installments
response.deferred_periods
Si el comercio no tiene configurado periodos diferidos, la respuesta de deferred_periods
será []
:
Confirmar una transacción
Una vez obtenido la respuesta de la consulta de cuotas, con los datos de esta se puede realizar la
confirmación de la transaccion utilizando el metodo commit
FullTransaction tx = new FullTransaction(new WebpayOptions(IntegrationCommerceCodes.TRANSACCION_COMPLETA, IntegrationApiKeys.WEBPAY, IntegrationType.TEST));
final FullTransactionCommitResponse response = tx.commit(token, idQueryInstallments, deferredPeriodIndex, gracePeriod);
$option = new Options($apiKey, $commerceCode, Options::ENVIRONMENT_PRODUCTION);
$transaction = new Transaction($option);
$response = $transaction->commit(
$token,
$idQueryInstallments,
$deferredPeriodIndex,
$gracePeriod
);
var tx = new FullTransaction(new Options(IntegrationCommerceCodes.TRANSACCION_COMPLETA, IntegrationApiKeys.WEBPAY, IntegrationType.TEST));
var response = tx.Commit(token, idQueryInstallments, deferredPeriodsIndex, gracePeriods);
@options = Transbank::Webpay::Options.new("commerceCode", "APIKey", :integration)
@transaction = Transbank::Webpay::TransaccionCompleta::Transaction.new(@options)
@resp = @transaction.commit(
token: @token,
id_query_installments: @id_query_installments,
deferred_period_index: @deferred_period_index,
grace_period: @grace_period
)
tx = Transaction(WebpayOptions(IntegrationCommerceCodes.TRANSACCION_COMPLETA, IntegrationApiKeys.WEBPAY, IntegrationType.TEST))
resp = tx.commit(token=token,
id_query_installments=id_query_installments,
deferred_period_index=deferred_period_index,
grace_period=grace_period)
const tx = new TransaccionCompleta.Transaction(
new Options(
IntegrationCommerceCodes.TRANSACCION_COMPLETA,
IntegrationApiKeys.WEBPAY,
Environment.Integration
)
);
const response = await tx.commit(
token,
idQueryInstallments,
deferredPeriodIndex,
gracePeriod
);
Respuesta confirmación
response.getAccountingDate();
response.getAmount();
response.getAuthorizationCode();
response.getBuyOrder();
CardDetail cardDetail = response.getCardDetail();
cardDetail.getCardNumber();
response.getInstallmentsAmount();
response.getInstallmentsNumber();
response.getPaymentCodeType();
response.getResponseCode();
response.getSessionId();
response.getTransactionDate();
$response->getAccountingDate();
$response->getAmount();
$response->getAuthorizationCode();
$response->getBuyOrder();
$cardDetail = $response->getCardDetail();
$cardDetail->getCardNumber();
$response->getInstallmentsAmount();
$response->getInstallmentsNumber();
$response->getPaymentCodeType();
$response->getResponseCode();
$response->getSessionId();
$response->getTransactionDate();
response.AccountingDate;
response.Amount;
response.AuthorizationCoda;
response.BuyOrder;
var cardDetail = response.CardDetail;
cardDetail.CardNumber;
response.InstallmentsAmount;
response.InstallmentsNumber;
response.PaymentTypeCode;
response.ResponseCode;
response.SessionId;
response.Status;
response.TransactionDate;
response.amount
response.status
response.buy_order
response.session_id
response.card_number
response.accounting_date
response.transaction_date
response.authorization_code
response.payment_type_code
response.response_code
response.installments_number
response.installments_amount
response.balance
## Versión 3.x del SDK
response['amount']
response['status']
response['buy_order']
response['session_id']
response['card_number']
response['accounting_date']
response['transaction_date']
response['authorization_code']
response['payment_type_code']
response['response_code']
response['installments_number']
response['installments_amount']
response['balance']
## Versión 2.x del SDK
response.amount
response.status
response.buy_order
response.session_id
response.card_number
response.accounting_date
response.transaction_date
response.authorization_code
response.payment_type_code
response.response_code
response.installments_number
response.installments_amount
response.balance
response.amount
response.status
response.buy_order
response.session_id
response.card_number
response.accounting_date
response.transaction_date
response.authorization_code
response.payment_type_code
response.response_code
response.installments_number
response.installments_amount
response.balance
Obtener estado de una transacción
Esta operación permite obtener el estado de la transacción en cualquier momento. En condiciones normales es probable que no se requiera ejecutar, pero en caso de ocurrir un error inesperado permite conocer el estado y tomar las acciones que correspondan.
Este método puede ser invocado los 7 días siguientes luego de realizada la transacción. Después de esto no será posible.
FullTransaction tx = new FullTransaction(new WebpayOptions(IntegrationCommerceCodes.TRANSACCION_COMPLETA, IntegrationApiKeys.WEBPAY, IntegrationType.TEST));
final FullTransactionStatusResponse response = tx.status(token);
$option = new Options($apiKey, $commerceCode, Options::ENVIRONMENT_PRODUCTION);
$transaction = new Transaction($option);
$response = $transaction->status($token_ws);
var tx = new FullTransaction(new Options(IntegrationCommerceCodes.TRANSACCION_COMPLETA, IntegrationApiKeys.WEBPAY, IntegrationType.TEST));
var response = tx.Status(token);
@options = Transbank::Webpay::Options.new("commerceCode", "APIKey", :integration)
@transaction = Transbank::Webpay::TransaccionCompleta::Transaction.new(@options)
@resp = @transaction.status(token: @token)
tx = Transaction(WebpayOptions(IntegrationCommerceCodes.TRANSACCION_COMPLETA, IntegrationApiKeys.WEBPAY, IntegrationType.TEST))
resp = tx.status(token=token)
const tx = new TransaccionCompleta.Transaction(
new Options(
IntegrationCommerceCodes.TRANSACCION_COMPLETA,
IntegrationApiKeys.WEBPAY,
Environment.Integration
)
);
const response = await tx.status(token);
Respuesta estado
response.getAccountingDate();
response.getAmount();
response.getAuthorizationCode();
response.getBuyOrder();
CardDetail cardDetail = response.getCardDetail();
cardDetail.getCardNumber();
response.getInstallmentsAmount();
response.getInstallmentsNumber();
response.getPaymentCodeType();
response.getResponseCode();
response.getSessionId();
response.getTransactionDate();
$response->getAccountingDate();
$response->getAmount();
$response->getAuthorizationCode();
$response->getBuyOrder();
$cardDetail = $response->getCardDetail();
$cardDetail->getCardNumber();
$response->getInstallmentsAmount();
$response->getInstallmentsNumber();
$response->getPaymentCodeType();
$response->getResponseCode();
$response->getSessionId();
$response->getTransactionDate();
response.AccountingDate;
response.Amount;
response.AuthorizationCoda;
response.BuyOrder;
var cardDetail = response.CardDetail;
cardDetail.CardNumber;
response.InstallmentsAmount;
response.InstallmentsNumber;
response.PaymentTypeCode;
response.ResponseCode;
response.SessionId;
response.Status;
response.TransactionDate;
response.amount
response.status
response.buy_order
response.session_id
response.card_number
response.accounting_date
response.transaction_date
response.authorization_code
response.payment_type_code
response.response_code
response.installments_number
response.installments_amount
response.balance
## Versión 3.x del SDK
response['amount']
response['status']
response['buy_order']
response['session_id']
response['card_number']
response['accounting_date']
response['transaction_date']
response['authorization_code']
response['payment_type_code']
response['response_code']
response['installments_number']
response['installments_amount']
response['balance']
## Versión 2.x del SDK
response.amount
response.status
response.buy_order
response.session_id
response.card_number
response.accounting_date
response.transaction_date
response.authorization_code
response.payment_type_code
response.response_code
response.installments_number
response.installments_amount
response.balance
response.amount
response.status
response.buy_order
response.session_id
response.card_number
response.accounting_date
response.transaction_date
response.authorization_code
response.payment_type_code
response.response_code
response.installments_number
response.installments_amount
response.balance
Reversar o anular una transacción
Esta operación permite a todo comercio habilitado, reversar o anular una transacción que fue generada en Transacción Completa.
Puedes realizar un reembolso invocando al método refund(), dependiendo de algunas condiciones correspondera a una Reversa o Anulación.
Puedes [leer más sobre la anulación en la información del
producto Webpay](https://www.transbankdevelopers.cl/producto/webpay#anulaciones) para conocer
más detalles y restricciones.
FullTransaction tx = new FullTransaction(new WebpayOptions(IntegrationCommerceCodes.TRANSACCION_COMPLETA, IntegrationApiKeys.WEBPAY, IntegrationType.TEST));
final FullTransactionRefundResponse response = tx.refund(token, amount);
$option = new Options($apiKey, $commerceCode, Options::ENVIRONMENT_PRODUCTION);
$transaction = new Transaction($option);
$response = $transaction->refund($token, $amount);
var tx = new FullTransaction(new Options(IntegrationCommerceCodes.TRANSACCION_COMPLETA, IntegrationApiKeys.WEBPAY, IntegrationType.TEST));
var response = tx.Refund(token, amount);
@options = Transbank::Webpay::Options.new("commerceCode", "APIKey", :integration)
@transaction = Transbank::Webpay::TransaccionCompleta::Transaction.new(@options)
@resp = @transaction.refund(token: @token, amount: @amount)
tx = Transaction(WebpayOptions(IntegrationCommerceCodes.TRANSACCION_COMPLETA, IntegrationApiKeys.WEBPAY, IntegrationType.TEST))
resp = tx.refund(token=token, amount=amount)
const tx = new TransaccionCompleta.Transaction(
new Options(
IntegrationCommerceCodes.TRANSACCION_COMPLETA,
IntegrationApiKeys.WEBPAY,
Environment.Integration
)
);
const response = await tx.refund(token, amount);
Respuesta reembolso
response.getType();
response.getAuthorizationCode();
response.getAuthorizationDate();
response.getNullifiedAmount();
response.getBalance();
response.getResponse();
$response->getType();
$response->getAuthorizationCode();
$response->getAuthorizationDate();
$response->getNullifiedAmount();
$response->getBalance();
$response->getResponse();
response.AuthorizationCode;
response.AuthorizationDate;
response.Balance;
response.NullifiedAmount;
response.ResponseCode;
response.Type;
response.type
response.authorization_code
response.authorization_date
response.nullified_amount
response.balance
response.response_code
## Versión 3.x del SDK
response['type']
response['authorization_code']
response['authorization_date']
response['nullified_amount']
response['balance']
response['response_code']
## Versión 2.x del SDK
response.type
response.authorization_code
response.authorization_date
response.nullified_amount
response.balance
response.response_code
response.type
response.authorization_code
response.authorization_date
response.nullified_amount
response.balance
response.response_code
Captura diferida Transacción completa
Este método permite a todo comercio habilitado realizar capturas de una transacción autorizada sin captura generada en Transacción Completa. El método contempla una única captura por cada autorización. Para ello se deberá indicar los datos asociados a la transacción de venta con autorización sin captura y el monto requerido para capturar el cual debe ser menor o igual al monto originalmente autorizado.
Para capturar una transacción, ésta debe haber sido creada por un código de comercio configurado para captura diferida. De esa forma la transacción estará autorizada pero requerirá una captura explícita posterior para confirmar la transacción.
Puedes [leer más sobre la captura en la información del
producto Webpay](https://www.transbankdevelopers.cl/producto/webpay#autorizacion-y-captura)
para conocer más detalles y restricciones.
FullTransaction tx = new FullTransaction(new WebpayOptions(IntegrationCommerceCodes.TRANSACCION_COMPLETA, IntegrationApiKeys.WEBPAY, IntegrationType.TEST));
final FullTransactionCaptureResponse response = tx.capture(token, buyOrder, authorizationCode, captureAmount);
$option = new Options($apiKey, $commerceCode, Options::ENVIRONMENT_PRODUCTION);
$transaction = new Transaction($option);
$response = $transaction->capture($token, $buyOrder, $authorizationCode, $captureAmount);
var tx = new FullTransaction(new Options(IntegrationCommerceCodes.TRANSACCION_COMPLETA, IntegrationApiKeys.WEBPAY, IntegrationType.TEST));
var response = tx.Capture(token, buyOrder, authorizationCode, captureAmount);
@options = Transbank::Webpay::Options.new("commerceCode", "APIKey", :integration)
@transaction = Transbank::Webpay::TransaccionCompleta::Transaction.new(@options)
@resp = @transaction.capture(
token: @token,
buy_order: @buy_order,
authorization_code: @authorization_code,
capture_amount: @capture_amount
)
tx = Transaction(WebpayOptions(IntegrationCommerceCodes.TRANSACCION_COMPLETA, IntegrationApiKeys.WEBPAY, IntegrationType.TEST))
resp = tx.capture(token, buy_order, authorization_code, capture_amount)
const tx = new TransaccionCompleta.Transaction(
new Options(
IntegrationCommerceCodes.TRANSACCION_COMPLETA,
IntegrationApiKeys.WEBPAY,
Environment.Integration
)
);
const response = await tx.capture(token, buyOrder, authorizationCode, amount);
Transacción Completa Mall
Una transacción Mall corresponde a una solicitud de autorización financiera de un conjunto de pagos con tarjetas de crédito, débito o prepago, en donde quién realiza el pago ingresa al sitio del comercio, selecciona productos o servicios, y el ingreso asociado a los datos de la tarjeta lo realiza una única vez para el conjunto de pagos. Cada pago tendrá su propio resultado, autorizado o rechazado.
![Desagregación de un pago Mall](https://www.transbankdevelopers.cl/public/slate-library/images/pago-webpay-mall.png)
Es la tienda Mall la que agrupa múltiples tiendas, son estas últimas las que pueden generar transacciones. Tanto el mall como las tiendas asociadas son identificadas a través de un número denominado código de comercio.
Flujo
El flujo de Transaccion Completa Mall es en general el mismo que el de Transaccion Completa tanto de cara al tarjeta habiente como de cara al integrador.
Las diferencias son:
- Se debe usar un código de comercio configurado para modalidad Mall en Transbank, el cual debe ser indicado al iniciar la transacción.
- Se pueden indicar múltiples transacciones, cada una asociada a un código de comercio de tienda (que debe estar configurada en Transbank como perteneciente al mall).
- Se debe verificar por separado el resultado de cada una de esas transacciones individualmente, pues es posible que el emisor de la tarjeta autorice algunas y otras no.
Crear una transacción mall
Esta operación te permite iniciar o crear varias transacciones de una sola vez, Transbank procesa el requerimiento y entrega como resultado de la operación el token de la transacción.
MallFullTransaction tx = new MallFullTransaction(new WebpayOptions(IntegrationCommerceCodes.TRANSACCION_COMPLETA, IntegrationApiKeys.WEBPAY, IntegrationType.TEST));
MallTransactionCreateDetails transactionDetails = MallTransactionCreateDetails.build()
.add(amountMallOne, commerceCodeStoreOne, buyOrderMallOne, installmentsNumberMallOne)
.add(amountMallTwo, commerceCodeStoreTwo, buyOrderMallTwo, installmentsNumberMallTwo);
MallFullTransactionCreateResponse response = tx.create(buyOrder, sessionId, cardNumber, cardExpirationDate, transactionDetails);
$transaction_details = [
[
'amount' => 10000,
'commerce_code' => "commerceCodeStoreOne",
'buy_order' => '123456789'
],
[
'amount' => 12000,
'commerce_code' => "commerceCodeStoreTwo",
'buy_order' => '123456790'
],
];
$option = new Options($apiKey, $commerceCode, Options::ENVIRONMENT_PRODUCTION);
$transaction = new MallTransaction($option);
$response = $transaction->create(
$buyOrder,
$sessionId,
$cardNumber,
$cardExpirationDate,
$transaction_details,
$cvv);
var tx = new MallFullTransaction(new Options(IntegrationCommerceCodes.TRANSACCION_COMPLETA_MALL, IntegrationApiKeys.WEBPAY, IntegrationType.TEST));
var details = new List();
details.Add(new CreateDetails(amountMallOne, commerceCodeStoreOne, buyOrderMallOne));
details.Add(new CreateDetails(amountMallTwo, commerceCodeStoreTwo, buyOrderMallTwo));
var response = tx.Create(
buyOrder: buy_order,
sessionId: session_id,
cardNumber: card_number,
cardExpirationDate: card_expiration_date,
details,
cvv: cvv
);
@options = Transbank::Webpay::Options.new("commerceCode", "APIKey", :integration)
@tx = Transbank::Webpay::TransaccionCompleta::Transaction.new(@options)
@resp = @tx.create(buy_order: @buy_order, session_id: @session_id, card_number: @card_number, card_expiration_date: @card_expiration_date, @details, cvv: @cvv)
tx = MallTransaction(WebpayOptions(IntegrationCommerceCodes.TRANSACCION_COMPLETA_MALL, IntegrationApiKeys.WEBPAY, IntegrationType.TEST))
details = [
{
'commerce_code': 'commerce_store_1',
'buy_order': '123456789',
'amount': 10000
},
{
'commerce_code': 'commerce_store_1',
'buy_order': '123456790',
'amount': 12000
}
]
resp = tx.create(
buy_order=buy_order,
session_id=session_id,
card_number=card_number,
card_expiration_date=card_expiration_date,
details=details,
cvv=None
)
const tx = new TransaccionCompleta.MallTransaction(
new Options(
IntegrationCommerceCodes.TRANSACCION_COMPLETA_MALL,
IntegrationApiKeys.WEBPAY,
Environment.Integration
)
);
const details = [
new TransactionDetail(amount, commerceCodeStoreOne, childBuyOrder),
new TransactionDetail(amount2, commerceCodeStoreTwo, childBuyOrder2),
];
const response = await tx.create(
parentBuyOrder,
sessionId,
cardNumber,
cardExpirationDate,
details,
cvv
);
Respuesta creación
response.getToken();
$response->getToken();
response.Token;
response.token
## Versión 3.x del SDK
response['token']
## Versión 2.x del SDK
response.token
response.token
Consulta de cuotas mall
Para consultar el valor de las cuotas que pagará el tarjeta habiente en cada transacción dentro transacción completa mall, es necesario llamar al método Transaction.installments()
Operación que permite obtener el monto de la cuota a partir del número de cuotas. El id de la consulta que selecciona el tarjetahabiente debe ser informado en la invocación de la confirmación.
MallFullTransaction tx = new MallFullTransaction(new WebpayOptions(IntegrationCommerceCodes.TRANSACCION_COMPLETA, IntegrationApiKeys.WEBPAY, IntegrationType.TEST));
MallFullTransactionInstallmentsDetails installmentsDetails =
MallFullTransactionInstallmentsDetails.build().add(commerceCodeStoreOne, buyOrder, installmentsNumber);
final MallFullTransactionInstallmentsResponse response = tx.installments(token, installmentsDetails);
$option = new Options($apiKey, $commerceCode, Options::ENVIRONMENT_PRODUCTION);
$transaction = new MallTransaction($option);
$installments_details = [
[
'commerce_code' => 'commerceCodeStoreOne',
'buy_order' => '123456789',
'installments_number' => 2
],
[
'commerce_code' => 'commerceCodeStoreTwo',
'buy_order' => '123456790',
'installments_number' => 2
],
];
$response = $transaction->installments($token, $installments_details);
var tx = new MallFullTransaction(new Options(IntegrationCommerceCodes.TRANSACCION_COMPLETA_MALL, IntegrationApiKeys.WEBPAY, IntegrationType.TEST));
var details = new List();
details.Add(new CreateDetails(amountMallOne, commerceCodeStoreOne, buyOrderMallOne));
details.Add(new CreateDetails(amountMallTwo, commerceCodeStoreTwo, buyOrderMallTwo));
var response = tx.Installments(
token, details
);
@options = Transbank::Webpay::Options.new("commerceCode", "APIKey", :integration)
@tx = Transbank::Webpay::TransaccionCompleta::Transaction.new(options)
@installment_details = [
{
commerce_code: 'commerce_store_1',
buy_order: '123456789',
installments_number: 2
},
{
commerce_code: 'commerce_store_2',
buy_order: '123456790',
installments_number: 2
},
]
@resp = @tx.installments(token, installment_details)
tx = MallTransaction(WebpayOptions(IntegrationCommerceCodes.TRANSACCION_COMPLETA_MALL, IntegrationApiKeys.WEBPAY, IntegrationType.TEST))
details = [
{
'commerce_code': 'commerce_store_1',
'buy_order': '123456789',
'installments_number': 2
},
{
'commerce_code': 'commerce_store_2',
'buy_order': '123456790',
'installments_number': 2
}
]
resp = tx.installments(token=token, details=details)
const tx = new TransaccionCompleta.MallTransaction(
new Options(
IntegrationCommerceCodes.TRANSACCION_COMPLETA_MALL,
IntegrationApiKeys.WEBPAY,
Environment.Integration
)
);
const details = [
new InstallmentDetail(
commerceCodeStoreOne,
childBuyOrder,
installmentsNumber
),
new InstallmentDetail(
commerceCodeStoreTwo,
childBuyOrder2,
installmentsNumber2
),
];
const response = await tx.installments(token, details);
Confirmar una transacción mall
Una vez iniciada la transacción y consultado el monto de las cuotas por cada subtransacción, puedes confirmar y obtener el resultado de una transacción completa usando el metodo Transaction.commit()
.
Es una operación que permite confirmar una transacción. Retorna el estado de la transacción.
MallFullTransaction tx = new MallFullTransaction(new WebpayOptions(IntegrationCommerceCodes.TRANSACCION_COMPLETA, IntegrationApiKeys.WEBPAY, IntegrationType.TEST));
MallTransactionCommitDetails details = MallTransactionCommitDetails.build().add(
commerceCodeStoreOne,buyOrder,idQueryInstallments,deferredPeriodIndex,gracePeriod
);
final MallFullTransactionCommitResponse response = tx.commit(token, details);
$option = new Options($apiKey, $commerceCode, Options::ENVIRONMENT_PRODUCTION);
$transaction = new MallTransaction($option);
$details = [
[
'commerce_code' => 'commerceCodeStoreOne',
'buy_order' => '123456789',
'id_query_installments' => $firstInstallmentResponse->getIdQueryInstallments(),
'deferred_period_index' => null,
'grace_period' => false
],
[
'commerce_code' => 'commerceCodeStoreTwo',
'buy_order' => '123456790',
'id_query_installments' => $secondInstallmentResponse->getIdQueryInstallments(),
'deferred_period_index' => null,
'grace_period' => false
]
];
$response = $transaction->commit($token, $details);
var tx = new MallFullTransaction(new Options(IntegrationCommerceCodes.TRANSACCION_COMPLETA_MALL, IntegrationApiKeys.WEBPAY, IntegrationType.TEST));
var transactionDetails = new List();
transactionDetails.Add(new MallCommitDetails(
commerceCodeStoreOne,
buyOrderMallOne,
idQueryInstallmentsOne,
deferredPeriodIndexOne,
gracePeriodOne
));
transactionDetails.Add(new MallCommitDetails(
commerceCodeStoreTwo,
buyOrderMallTwo,
idQueryInstallmentsTwo,
deferredPeriodIndexTwo,
gracePeriodTwo
));
var response = tx.Commit(
token, transactionDetails
);
@options = Transbank::Webpay::Options.new("commerceCode", "APIKey", :integration)
@tx = Transbank::Webpay::TransaccionCompleta::Transaction.new(options)
@details = [
{
commerce_code: 'commerce_store_1',
buy_order: 'ordenCompra1234',
id_query_installments: 12,
deferred_period_index: 1,
grace_period: false
},
{
commerce_code: 'commerce_store_2',
buy_order: 'ordenCompra12345',
id_query_installments: 12,
deferred_period_index: 1,
grace_period: false
}
]
@resp = @tx.commit(token: token, details: details)
tx = MallTransaction(WebpayOptions(IntegrationCommerceCodes.TRANSACCION_COMPLETA_MALL, IntegrationApiKeys.WEBPAY, IntegrationType.TEST))
details = [
{
"commerce_code": 'commerce_store_1',
"buy_order": 'ordenCompra1234',
"id_query_installments": 12,
"deferred_period_index": 1,
"grace_period": false
},
{
"commerce_code": 'commerce_store_2',
"buy_order": 'ordenCompra12345',
"id_query_installments": 12,
"deferred_period_index": 1,
"grace_period": false
}
]
resp = tx.commit(
token=token, details=details
)
const tx = new TransaccionCompleta.MallTransaction(
new Options(
IntegrationCommerceCodes.TRANSACCION_COMPLETA_MALL,
IntegrationApiKeys.WEBPAY,
Environment.Integration
)
);
let commitDetails = [
new CommitDetail(commerceCodeStoreOne, childBuyOrder),
new CommitDetail(commerceCodeStoreTwo, childBuyOrder2),
];
const response = await tx.commit(token, commitDetails);
Respuesta confirmación mall
response.getBuyOrder();
response.getCardNumber();
response.getAccountingDate();
response.getTransactionDate();
Detail detail = response.getDetails()[0];
detail.getAuthorizationCode();
detail.getPaymentCodeType();
detail.getResponseCode();
detail.getInstallmentsAmount();
detail.getInstallmentsNumber();
detail.getAmount();
detail.getCommerceCode();
detail.getBuyOrder();
detail.getStatus();
detail.getBalance();
$response->getBuyOrder();
$response->getCardNumber();
$response->getAccountingDate();
$response->getTransactionDate();
$detail = $response->getDetails()[0];
$detail->getAuthorizationCode();
$detail->getPaymentTypeCode();
$detail->getResponseCode();
$detail->getInstallmentsAmount();
$detail->getInstallmentsNumber();
$detail->getAmount();
$detail->getCommerceCode();
$detail->getBuyOrder();
$detail->getStatus();
response.BuyOrder;
response.CardNumber;
response.AccountingDate;
response.TransactionDate;
detail = response.Details[0];
detail.AuthorizationCode;
detail.PaymentCodeType;
detail.ResponseCode;
detail.InstallmentsAmount;
detail.InstallmentsNumber;
detail.Amount;
detail.CommerceCode;
detail.BuyOrder;
detail.Status;
detail.Balance;
response.buy_order
response.card_number
response.accounting_date
response.transaction_date
detail = response.details[0]
detail.authorization_code
detail.payment_code_type
detail.response_code
detail.installments_amount
detail.installments_number
detail.amount
detail.commerce_code
detail.buy_order
detail.status
detail.balance
## Versión 3.x del SDK
response['buy_order']
response['card_number']
response['accounting_date']
response['transaction_date']
response['details']
## Versión 2.x del SDK
response.buy_order
response.card_number
response.accounting_date
response.transaction_date
detail = response.details[0]
detail.authorization_code
detail.payment_code_type
detail.response_code
detail.installments_amount
detail.installments_number
detail.amount
detail.commerce_code
detail.buy_order
detail.status
detail.balance
response.buy_order
response.card_number
response.accounting_date
response.transaction_date
detail = response.details[0]
detail.authorization_code
detail.payment_code_type
detail.response_code
detail.installments_amount
detail.installments_number
detail.amount
detail.commerce_code
detail.buy_order
detail.status
detail.balance
Obtener estado de una transacción mall
Esta operación permite obtener el estado de la transacción Completa Mall en cualquier momento. En condiciones normales es probable que no se requiera ejecutar, pero en caso de ocurrir un error inesperado permite conocer el estado y tomar las acciones que correspondan.
Obtiene resultado de transacción a partir de un token.
MallFullTransaction tx = new MallFullTransaction(new WebpayOptions(IntegrationCommerceCodes.TRANSACCION_COMPLETA, IntegrationApiKeys.WEBPAY, IntegrationType.TEST));
final MallFullTransactionStatusResponse response = tx.status(tokenWs);
$option = new Options($apiKey, $commerceCode, Options::ENVIRONMENT_PRODUCTION);
$transaction = new MallTransaction($option);
$response = $transaction->status(token);
var tx = new MallFullTransaction(new Options(IntegrationCommerceCodes.TRANSACCION_COMPLETA_MALL, IntegrationApiKeys.WEBPAY, IntegrationType.TEST));
var response = tx.Status(token);
@options = Transbank::Webpay::Options.new("commerceCode", "APIKey", :integration)
@tx = Transbank::Webpay::TransaccionCompleta::Transaction.new(options)
@resp = @tx.status(token)
tx = MallTransaction(WebpayOptions(IntegrationCommerceCodes.TRANSACCION_COMPLETA_MALL, IntegrationApiKeys.WEBPAY, IntegrationType.TEST))
resp = tx.status(token)
const tx = new TransaccionCompleta.MallTransaction(
new Options(
IntegrationCommerceCodes.TRANSACCION_COMPLETA_MALL,
IntegrationApiKeys.WEBPAY,
Environment.Integration
)
);
const response = await tx.status(token);
Respuesta consulta de estado
response.getBuyOrder();
response.getCardNumber();
response.getAccountingDate();
response.getTransactionDate();
Detail detail = response.getDetails()[0];
detail.getAuthorizationCode();
detail.getPaymentCodeType();
detail.getResponseCode();
detail.getInstallmentsAmount();
detail.getInstallmentsNumber();
detail.getAmount();
detail.getCommerceCode();
detail.getBuyOrder();
detail.getStatus();
detail.getBalance();
$response->getBuyOrder();
$response->getCardNumber();
$response->getAccountingDate();
$response->getTransactionDate();
$detail = $response->getDetails()[0];
$detail->getAuthorizationCode();
$detail->getPaymentTypeCode();
$detail->getResponseCode();
$detail->getInstallmentsAmount();
$detail->getInstallmentsNumber();
$detail->getAmount();
$detail->getCommerceCode();
$detail->getBuyOrder();
$detail->getStatus();
response.BuyOrder;
response.CardNumber;
response.AccountingDate;
response.TransactionDate;
detail = response.Details[0];
detail.AuthorizationCode;
detail.PaymentCodeType;
detail.ResponseCode;
detail.InstallmentsAmount;
detail.InstallmentsNumber;
detail.Amount;
detail.CommerceCode;
detail.BuyOrder;
detail.Status;
detail.Balance;
response.buy_order
response.card_number
response.accounting_date
response.transaction_date
detail = response.details[0]
detail.authorization_code
detail.payment_code_type
detail.response_code
detail.installments_amount
detail.installments_number
detail.amount
detail.commerce_code
detail.buy_order
detail.status
detail.balance
## Versión 3.x del SDK
response['buy_order']
response['card_number']
response['accounting_date']
response['transaction_date']
response['details']
## Versión 2.x del SDK
response.buy_order
response.card_number
response.accounting_date
response.transaction_date
detail = response.details[0]
detail.authorization_code
detail.payment_code_type
detail.response_code
detail.installments_amount
detail.installments_number
detail.amount
detail.commerce_code
detail.buy_order
detail.status
detail.balance
response.buy_order
response.card_number
response.accounting_date
response.transaction_date
detail = response.details[0]
detail.authorization_code
detail.payment_code_type
detail.response_code
detail.installments_amount
detail.installments_number
detail.amount
detail.commerce_code
detail.buy_order
detail.status
detail.balance
Reversar o anular una transacción mall
Esta operación permite a todo comercio habilitado, reversar o anular una transacción que fue generada en Transacción Completa.
Puedes realizar un reembolso invocando al método refund(), dependiendo de algunas condiciones correspondera a una Reversa o Anulación.
Puedes [leer más sobre la anulación en la información del
producto Webpay](https://www.transbankdevelopers.cl/producto/webpay#anulaciones) para conocer
más detalles y restricciones.
MallFullTransaction tx = new MallFullTransaction(new WebpayOptions(IntegrationCommerceCodes.TRANSACCION_COMPLETA, IntegrationApiKeys.WEBPAY, IntegrationType.TEST));
final MallFullTransactionRefundResponse response = tx.refund(token, buyOrder, commerceCodeStoreOne, amount);
$option = new Options($apiKey, $commerceCode, Options::ENVIRONMENT_PRODUCTION);
$transaction = new MallTransaction($option);
$response = $transaction->refund(
$token,
$childBuyOrder,
$commerceCodeStoreOne,
$amount
);
var tx = new MallFullTransaction(new Options(IntegrationCommerceCodes.TRANSACCION_COMPLETA_MALL, IntegrationApiKeys.WEBPAY, IntegrationType.TEST));
var response = tx.Refund(
token,
buyOrder,
commerceCodeStoreOne,
amount
);
@options = Transbank::Webpay::Options.new("commerceCode", "APIKey", :integration)
@tx = Transbank::Webpay::TransaccionCompleta::Transaction.new(options)
@resp = @tx.refund(
token: token,
buy_order: child_buy_order,
commerce_code_child: commerce_store_1,
amount: amount
)
tx = MallTransaction(WebpayOptions(IntegrationCommerceCodes.TRANSACCION_COMPLETA_MALL, IntegrationApiKeys.WEBPAY, IntegrationType.TEST))
resp = tx.refund(token: token, child_buy_order: child_buy_order, child_commerce_code: commerce_store_1, amount: amount)
const tx = new TransaccionCompleta.MallTransaction(
new Options(
IntegrationCommerceCodes.TRANSACCION_COMPLETA_MALL,
IntegrationApiKeys.WEBPAY,
Environment.Integration
)
);
const response = await tx.refund(token, buyOrder, commerceCodeStoreOne, amount);
Respuesta reembolso mall
response.getType();
response.getAuthorizationCode();
response.getAuthorizationDate();
response.getNullifiedAmount();
response.getBalance();
response.getResponseCode();
$response->getType();
$response->getAuthorizationCode();
$response->getAuthorizationDate();
$response->getNullifiedAmount();
$response->getBalance();
$response->getResponseCode();
response.Type;
response.AuthorizationCode;
response.AuthorizationDate;
response.NullifiedAmount;
response.Balance;
response.ResponseCode;
response.type
response.authorization_code
response.authorization_date
response.nullified_amount
response.balance
response.response_code
## Versión 3.x del SDK
response['type']
response['authorization_code']
response['authorization_date']
response['nullified_amount']
response['balance']
response['response_code']
## Versión 2.x del SDK
response.type
response.authorization_code
response.authorization_date
response.nullified_amount
response.balance
response.response_code
response.type
response.authorization_code
response.authorization_date
response.nullified_amount
response.balance
response.response_code
Captura diferida de una transacción mall
Este método permite a todo comercio habilitado realizar capturas de una transacción autorizada sin captura generada en Transacción Completa. El método contempla una única captura por cada autorización. Para ello se deberá indicar los datos asociados a la transacción de venta con autorización sin captura y el monto requerido para capturar el cual debe ser menor o igual al monto originalmente autorizado.
Para capturar una transacción, ésta debe haber sido creada por un código de comercio configurado para captura diferida. De esa forma la transacción estará autorizada pero requerirá una captura explícita posterior para confirmar la transacción.
Puedes [leer más sobre la captura en la información del
producto Webpay](https://www.transbankdevelopers.cl/producto/webpay#autorizacion-y-captura)
para conocer más detalles y restricciones.
MallFullTransaction tx = new MallFullTransaction(new WebpayOptions(IntegrationCommerceCodes.TRANSACCION_COMPLETA, IntegrationApiKeys.WEBPAY, IntegrationType.TEST));
final MallFullTransactionCaptureResponse response = tx.capture(token, commerceCodeStoreOne, buyOrder, authorizationCode, captureAmount);
$option = new Options($apiKey, $commerceCode, Options::ENVIRONMENT_PRODUCTION);
$transaction = new MallTransaction($option);
$response = $transaction->capture($token, $commerceCodeStoreOne, $buyOrder, $authorizationCode, $captureAmount);
var tx = new MallFullTransaction(new Options(IntegrationCommerceCodes.TRANSACCION_COMPLETA_MALL, IntegrationApiKeys.WEBPAY, IntegrationType.TEST));
var response = tx.Capture(
token,
commerceCodeStoreOne,
buyOrder,
authorizationCode,
captureAmount
);
@options = Transbank::Webpay::Options.new("commerceCode", "APIKey", :integration)
@tx = Transbank::Webpay::TransaccionCompleta::Transaction.new(options)
@resp = @tx.capture(
token: token,
commerce_code: commerce_store_1,
buy_order: buy_order,
authorization_code: authorization_code,
amount: capture_amount
)
tx = MallTransaction(WebpayOptions(IntegrationCommerceCodes.TRANSACCION_COMPLETA_MALL, IntegrationApiKeys.WEBPAY, IntegrationType.TEST))
resp = tx.capture(token, commerce_store_1, child_buy_order, authorization_code, capture_amount)
const tx = new TransaccionCompleta.MallTransaction(
new Options(
IntegrationCommerceCodes.TRANSACCION_COMPLETA_MALL,
IntegrationApiKeys.WEBPAY,
Environment.Integration
)
);
const response = await tx.capture(
token,
commerceCodeStoreOne,
childBuyOrder,
authorizationCode,
captureAmount
);
response.getResponseCode()
response.getCapturedAmount()
response.getAuthorizationDate()
response.getAuthorizationCode()
$response->getToken();
$response->getAuthorizationCode();
$response->getAuthorizationDate();
$response->getCapturedAmount();
$response->getResponseCode();
response.authorization_code
response.authorization_date
response.captured_amount
response.response_code
## Versión 3.x del SDK
response['authorization_code']
response['authorization_date']
response['captured_amount']
response['response_code']
## Versión 2.x del SDK
response.token
response.authorization_code
response.authorization_date
response.captured_amount
response.response_code
response.authorization_code
response.authorization_date
response.captured_amount
response.response_code
Credenciales y Ambientes
Ambiente de integración
Puede encontrar más información al respecto [en este link](https://www.transbankdevelopers.cl/documentacion/como_empezar#ambiente-de-integracion)
Configuración SDK
Los SDK deben configurarse explícitamente para apuntar al ambiente que quieras utilizar (producción / integración). Para esto puedes crear los objetos de 2 maneras:
- Utilizar los métodos definidos para ello (buildForIntegration o buildForProduction).
- Utilizar un objeto Options que contenga la configuración y pasarlo en el constructor de cada objeto.
Puede encontrar más información al respecto [en este link](https://www.transbankdevelopers.cl/documentacion/como_empezar#b-utilizando-los-sdk)
Puesta en Producción
Puede encontrar más información al respecto [en este link](https://www.transbankdevelopers.cl/documentacion/como_empezar#puesta-en-produccion)
Ejemplos de integración
Ponemos a tu disposición una serie de repositorios en nuestro Github para ayudarte a entender la integración de mejor forma.
Puedes encontrar una lista de [proyectos de ejemplo acá](https://www.transbankdevelopers.cl/documentacion/como_empezar#ejemplos).

# documentacion_webpay-plus.md

Source: https://www.transbankdevelopers.cl/documentacion/webpay-plus

Webpay
Webpay Plus
Webpay Plus permite realizar una solicitud de autorización financiera de un pago con tarjetas de crédito o débito Redcompra en donde quién realiza el pago ingresa al sitio del comercio, selecciona productos o servicio, y el ingreso asociado a los datos de la tarjeta de crédito o débito Redcompra lo realiza en forma segura en Webpay Plus. El comercio que recibe pagos mediante Webpay Plus es identificado mediante un código de comercio.
Es el tipo de transacción mas común, usada para un pago puntual en una tienda simple. Se generará un único cobro para todos los productos o servicios adquiridos por el tarjetahabiente.
Flujo en caso de éxito
De cara al tarjetahabiente, el flujo de páginas para la transacción es el siguiente:
![Flujo de páginas Webpay Plus](https://www.transbankdevelopers.cl/public/slate-library/images/referencia/webpayrest/flujo-paginas-webpayrest.png)
Desde el punto de vista técnico, la secuencia es la siguiente:
![Diagrama de secuencia Webpay Plus](https://www.transbankdevelopers.cl/public/slate-library/images/referencia/webpayrest/diagrama-secuencia-webpayrest.png)
- Una vez seleccionado los bienes o servicios, el tarjetahabiente decide pagar a través de Webpay.
- El comercio inicia una transacción en Webpay.
- Webpay procesa el requerimiento y entrega como resultado de la operación el token de la transacción y URL de redireccionamiento a la cual se deberá redirigir al tarjetahabiente.
- Comercio redirecciona al tarjetahabiente hacia Webpay, con el token de la
transacción a la URL indicada en punto 3. La redirección se realiza
enviando por método POST el token en variable
token_ws
. - El navegador Web del tarjetahabiente realiza una petición HTTPS a Webpay, en base al redireccionamiento generado por el comercio en el punto 4.
- Webpay responde al requerimiento desplegando el formulario de pago de Webpay. Desde este punto la comunicación es entre Webpay y el tarjetahabiente, sin interferir el comercio. El formulario de pago de Webpay despliega, entre otras cosas, el monto de la transacción, información del comercio como nombre y logotipo, las opciones de pago a través de crédito o débito.
Tarjetahabiente ingresa los datos de la tarjeta, hace clic en pagar en formulario Webpay. El tiempo en el cual permanece el formulario de Webpay depende del ambiente, en producción el tiempo es de 4 minutos y en integración es de 10 minutos. En caso extender dicho plazo y no haber terminado la transacción, esta será abortada automáticamente.
- Webpay procesa la solicitud de autorización (primero autenticación bancaria y luego la autorización de la transacción).
- Una vez resuelta la autorización, Webpay retorna el control al comercio,
realizando un redireccionamiento HTTPS hacia la página de transición
del comercio, enviando el token de la transacción en la variable
token_ws
. En la versión 1.1 y superiores de la API, esta redirección es por GET. Para versiones anteriores se envía por método POST. El comercio debe implementar la recepción de esta variable. - El navegador Web del tarjetahabiente realiza una petición HTTPS al sitio del comercio, en base a la redirección generada por Webpay en el punto 9.
- El sitio del comercio recibe la variable
token_ws
e invoca el segundo método Web para confirmar y obtener el resultado de la autorización. El resultado de la autorización podrá ser consultado posteriormente con la variable anteriormente mencionada. - Comercio recibe el resultado de la confirmación.
- Sitio del comercio despliega voucher con los datos de la transacción.
Flujo si usuario aborta el pago
Si el tarjetahabiente anula la transacción en el formulario de pago de Webpay, el flujo cambia y los pasos son los siguientes:
![Diagrama de secuencia si usuario aborta el pago](https://www.transbankdevelopers.cl/public/slate-library/images/referencia/webpayrest/diagrama-secuencias-webpayrest-abortar.png)
- Una vez seleccionado los bienes o servicios, tarjetahabiente decide pagar a través de Webpay.
- El comercio inicia una transacción en Webpay.
- Webpay procesa el requerimiento y entrega como resultado de la operación el token de la transacción y URL de redireccionamiento a la cual se deberá redirigir al tarjetahabiente.
- Comercio redirecciona al tarjetahabiente hacia Webpay, con el token de la
transacción a la URL indicada en punto 3. La redirección se realiza
enviando por método POST el token en variable
token_ws
. - El navegador Web del tarjetahabiente realiza una petición HTTPS a Webpay, en base al redireccionamiento generado por el comercio en el punto 4.
- Webpay responde al requerimiento desplegando el formulario de pago de Webpay. Desde este punto la comunicación es entre Webpay y el tarjetahabiente, sin interferir el comercio. El formulario de pago de Webpay despliega, entre otras cosas, el monto de la transacción, información del comercio como nombre y logotipo, las opciones de pago a través de crédito o débito.
- Tarjetahabiente hace clic en “anular”, en formulario Webpay.
Webpay retorna el control al comercio, realizando un redireccionamiento HTTPS hacia la página de retorno del comercio, en donde se envía por método GET el token de la transacción en la variable
TBK_TOKEN
además de las variablesTBK_ORDEN_COMPRA
yTBK_ID_SESION
(para el entorno de integración, este redireccionamiento es realizado con el método POST).El comercio con la variable
TBK_TOKEN
consulta la transacción para validar el estado (no es necesario
confirmar la transacción).El comercio debe informar al tarjetahabiente que su pago no se completó.
Resumen de flujos
A la URL de return_url
siempre se llega por POST, aunque desde la versión 1.1 del API, en adelante, la redirección es por GET (solo en el caso de pago abortado en el ambiente de integración, el retorno se mantiene por POST).
Para resumir los diferentes flujos que pueden existir, y las diferentes respuestas que se pueden esperar:
Hay 4 diferentes flujos, donde cada uno llega con datos distintos:
- Flujo normal: El usuario al finalizar la transacción (tanto si es un rechazo o una aprobación) llegará solamente
token_ws
. - Timeout (Tiempo excedido en el formulario de Webpay): El tiempo es de 4 minutos para el ambiente de producción y 10 minutos para el entorno de integración.Llegará solamente
TBK_ID_SESION
que contiene elsession_id
enviado al crear la transacción,TBK_ORDEN_COMPRA
que representa elbuy_order
enviado. No llegará token. - Pago abortado (con botón anular compra en el formulario de Webpay): Llegará
TBK_TOKEN
(notar que no se llamatoken_ws
, pero igualmente contiene el token de la transacción),TBK_ID_SESION
,TBK_ORDEN_COMPRA
- *Si ocurre un error en el formulario de pago, y hace click en el link de "volver al sitio" de la pantalla de error: (replicable solo en producción si inicias una transacción, abres el formulario de pago, cierras el tab de Chrome y luego lo recuperas) Llegará
token_ws
,TBK_TOKEN
,TBK_ID_SESION
,TBK_ORDEN_COMPRA
.
Proyectos de ejemplo
Recuerda que tienes varios proyectos de ejemplos para cada lenguaje, que puedes [revisar acá.](https://www.transbankdevelopers.cl/documentacion/como_empezar#ejemplos)
Para PHP, [en el mismo repositorio](https://github.com/TransbankDevelopers/transbank-sdk-php/tree/master/examples) también puedes encontrar algunos ejemplos básicos.
Crear una transacción
Esta operación te permite iniciar o crear una transacción, Webpay Plus procesa el requerimiento y entrega como resultado de la operación el token de la transacción y URL de redireccionamiento a la cual se deberá redirigir al tarjetahabiente.
WebpayPlus.Transaction transaction = WebpayPlus.Transaction.buildForIntegration("commerceCode", "APIKey");
final WebpayPlusTransactionCreateResponse response = transaction.create(buyOrder, sessionId, amount, returnUrl);
$transaction = Transaction::buildForIntegration($apiKey, $commerceCode);
$response = $transaction->create($buy_order, $session_id, $amount, $return_url);
Transaction transaction = Transaction.buildForIntegration("commerceCode", "APIKey");
var response = transaction.Create(buyOrder, sessionId, amount, returnUrl);
@transaction = Transbank::Webpay::WebpayPlus::Transaction.build_for_integration("commerceCode", "APIKey");
@resp = @transaction.create(
buy_order: @buy_order,
session_id: @session_id,
amount: @amount,
return_url: @return_url
);
tx = Transaction.build_for_integration("commerceCode", "APIKey")
resp = tx.create(buy_order, session_id, amount, return_url)
const transaction = WebpayPlus.Transaction.buildForIntegration(
"commerceCode",
"APIKey"
);
const response = await transaction.create(
buyOrder,
sessionId,
amount,
returnUrl
);
Respuesta Crear una transacción
La respuesta de Webpay Plus a la creación es el token de la transacción y la URL a la cual debes redirigir al tarjetahabiente.
response.getUrl();
response.getToken();
$response->getUrl();
$response->getToken();
response.Url;
response.Token;
response.url
response.token
## Versión 3.x del SDK
response['url']
response['token']
## Versión 2.x del SDK
response.url
response.token
response.url
response.token
Con estos datos debes crear un formulario en el cual debes poner un input
de nombre token_ws
y en su valor debes insertar el token devuelto. El formulario debe usar el método POST
y su acción (o URL)
debe ser la URL devuelta por Webpay Plus.
<form method="post" action="Inserta aquí la url entregada">
<input type="hidden" name="token_ws" value="Inserte aquí el token entregado" />
<input type="submit" value="Ir a pagar" />
</form>
Confirmar una transacción
Una vez que el tarjetahabiente ha pagado, Webpay Plus retornará
el control vía POST
a la URL
que indicaste en el return_url
(si la versión de la API es 1.1 o superior, este retorno es por GET
).
Recibirás también el parámetro token_ws
que te permitirá conocer el resultado de la transacción.
En caso de que el tarjetahabiente haya declinado, o haya ocurrido un error, recibirás la variable TBK_TOKEN
además de las variables TBK_ORDEN_COMPRA
y TBK_ID_SESION
. Para este caso, el retorno en el ambiente de integración es vía POST
, para producción es por GET
.
WebpayPlus.Transaction transaction = WebpayPlus.Transaction.buildForIntegration("commerceCode", "APIKey");
final WebpayPlusTransactionCommitResponse response = transaction.commit(token);
$transaction = Transaction::buildForIntegration($apiKey, $commerceCode);
$response = $transaction->commit($token);
Transaction transaction = Transaction.buildForIntegration("commerceCode", "APIKey");
var response = transaction.Commit(token);
@transaction = Transbank::Webpay::WebpayPlus::Transaction.build_for_integration("commerceCode", "APIKey");
@resp = @transaction.commit(token: @token);
tx = Transaction.build_for_integration("commerceCode", "APIKey")
resp = tx.commit(token)
const transaction = WebpayPlus.Transaction.buildForIntegration(
"commerceCode",
"APIKey"
);
const response = await transaction.commit(token);
Respuesta Confirmar una transacción
Utilizando la respuesta de la confirmación podrás mostrar un comprobante o página de éxito a tu usuario. Con eso habrás completado el flujo "feliz" en que todo funciona.
response.getVci();
response.getAmount();
response.getStatus();
response.getBuyOrder();
response.getSessionId();
response.getCardDetail().getCardNumber();
response.getAccountingDate();
response.getTransactionDate();
response.getAuthorizationCode();
response.getPaymentTypeCode();
response.getResponseCode();
response.getInstallmentsAmount();
response.getInstallmentsNumber();
response.getBalance();
// Del objeto $response de respuesta, puedes obtener cualquier de estos datos.
// Para validar la transacción recomendamos usar $response->isApproved();
// pero puedes usar el resto de la información para guardar detalles de la respuesta en tu base de datos
$response->getVci();
$response->getAmount();
$response->getStatus();
$response->getBuyOrder();
$response->getSessionId();
$response->getCardDetail();
$response->getCardNumber(); // Solo en SDK 2.x
$response->getAccountingDate();
$response->getTransactionDate();
$response->getAuthorizationCode();
$response->getPaymentTypeCode();
$response->getResponseCode();
$response->getInstallmentsAmount();
$response->getInstallmentsNumber();
$response->getBalance();
// Adicionalmente en el SDK 2.x existe
$response->isApproved(); // Devuelve true si response_code es 0 y status es AUTHORIZED, y false en caso contrario.
response.Vci;
response.Amount;
response.Status;
response.BuyOrder;
response.SessionId;
response.CardDetail;
response.AccountingDate;
response.TransactionDate;
response.AuthorizationCode;
response.PaymentTypeCode;
response.ResponseCode;
response.InstallmentsAmount;
response.InstallmentsNumber;
response.Balance;
response.vci
response.amount
response.status
response.buy_order
response.session_id
response.card_detail
response.accounting_date
response.transaction_date
response.authorization_code
response.payment_type_code
response.response_code
response.installments_amount
response.installments_number
response.balance
## Versión 3.x del SDK
response['vci']
response['amount']
response['status']
response['buy_order']
response['session_id']
response['card_detail']
response['accounting_date']
response['transaction_date']
response['authorization_code']
response['payment_type_code']
response['response_code']
response['installments_amount']
response['installments_number']
response['balance']
## Versión 2.x del SDK
response.vci
response.amount
response.status
response.buy_order
response.session_id
response.card_detail
response.accounting_date
response.transaction_date
response.authorization_code
response.payment_type_code
response.response_code
response.installments_amount
response.installments_number
response.balance
response.vci
response.amount
response.status
response.buy_order
response.session_id
response.card_detail
response.accounting_date
response.transaction_date
response.authorization_code
response.payment_type_code
response.response_code
response.installments_amount
response.installments_number
response.balance
Obtener estado de una transacción
Esta operación permite obtener el estado de la transacción en los siguientes 7 días desde su creación. En condiciones normales es probable que no se requiera ejecutar, pero en caso de ocurrir un error inesperado permite conocer el estado y tomar las acciones que correspondan.
Debes enviar el token
dela transacción de la cual desees obtener el estado.
WebpayPlus.Transaction transaction = WebpayPlus.Transaction.buildForIntegration("commerceCode", "APIKey");
final WebpayPlusTransactionStatusResponse response = transaction.status(token);
use Transbank\Webpay\WebpayPlus\Transaction;
$transaction = Transaction::buildForIntegration($apiKey, $commerceCode);
$response = $transaction->status($token);
using Transbank.Webpay.WebpayPlus;
Transaction transaction = Transaction.buildForIntegration("commerceCode", "APIKey");
var response = transaction.status(token);
@transaction = Transbank::Webpay::WebpayPlus::Transaction.build_for_integration("commerceCode", "APIKey");
@resp = @transaction.status(token: @token);
tx = Transaction.build_for_integration("commerceCode", "APIKey")
resp = tx.status(token)
const transaction = WebpayPlus.Transaction.buildForIntegration(
"commerceCode",
"APIKey"
);
const response = await transaction.status(token);
Respuesta estado de una transacción
Para obtener la información contenida en la respuesta puedes hacerlo de la siguiente manera.
response.getVci();
response.getAmount();
response.getStatus();
response.getBuyOrder();
response.getSessionId();
response.getCardDetail().getCardNumber();
response.getAccountingDate();
response.getTransactionDate();
response.getAuthorizationCode();
response.getPaymentTypeCode();
response.getResponseCode();
response.getInstallmentsAmount();
response.getInstallmentsNumber();
response.getBalance();
$response->getVci();
$response->getAmount();
$response->getStatus();
$response->getBuyOrder();
$response->getSessionId();
$response->getCardDetail();
$response->getCardNumber(); // Solo SDK 2.x
$response->getAccountingDate();
$response->getTransactionDate();
$response->getAuthorizationCode();
$response->getPaymentTypeCode();
$response->getResponseCode();
$response->getInstallmentsAmount();
$response->getInstallmentsNumber();
$response->getBalance();
// Adicionalmente en el SDK 2.x existe:
$response->isApproved(); // Devuelve true si response_code es 0 y status es AUTHORIZED, y false en caso contrario.
response.Vci;
response.Amount;
response.Status;
response.BuyOrder;
response.SessionId;
response.CardDetail;
response.AccountingDate;
response.TransactionDate;
response.AuthorizationCode;
response.PaymentTypeCode;
response.ResponseCode;
response.InstallmentsAmount;
response.InstallmentsNumber;
response.Balance;
response.vci
response.amount
response.status
response.buy_order
response.session_id
response.card_detail
response.accounting_date
response.transaction_date
response.authorization_code
response.payment_type_code
response.response_code
response.installments_amount
response.installments_number
response.balance
## Versión 3.x del SDK
response['vci']
response['amount']
response['status']
response['buy_order']
response['session_id']
response['card_detail']
response['accounting_date']
response['transaction_date']
response['authorization_code']
response['payment_type_code']
response['response_code']
response['installments_amount']
response['installments_number']
response['balance']
## Versión 2.x del SDK
response.vci
response.amount
response.status
response.buy_order
response.session_id
response.card_detail
response.accounting_date
response.transaction_date
response.authorization_code
response.payment_type_code
response.response_code
response.installments_amount
response.installments_number
response.balance
response.vci
response.amount
response.status
response.buy_order
response.session_id
response.card_detail
response.accounting_date
response.transaction_date
response.authorization_code
response.payment_type_code
response.response_code
response.installments_amount
response.installments_number
response.balance
Reversar o Anular una transacción
Esta operación permite a todo comercio habilitado, reversar o anular una transacción que fue generada en Webpay Plus.
Puedes realizar un reembolso invocando al método refund(), dependiendo de algunas condiciones correspondera a una Reversa o Anulación.
Puedes [leer más sobre la anulación en la información del
producto Webpay](https://www.transbankdevelopers.cl/producto/webpay#anulaciones-y-reversas) para conocer
más detalles y restricciones.
WebpayPlus.Transaction transaction = WebpayPlus.Transaction.buildForIntegration("commerceCode", "APIKey");
final WebpayPlusTransactionRefundResponse response = transaction.refund(token, amount);
$transaction = Transaction::buildForIntegration($apiKey, $commerceCode);
$response = $transaction->refund($token, $amount);
Transaction transaction = Transaction.buildForIntegration("commerceCode", "APIKey");
var response = transaction.Refund(token, refundAmount);
@transaction = Transbank::Webpay::WebpayPlus::Transaction.build_for_integration("commerceCode", "APIKey");
@resp = @transaction.refund(token: @token, amount: @amount);
tx = Transaction.build_for_integration("commerceCode", "APIKey")
resp = tx.refund(token, amount)
const transaction = WebpayPlus.Transaction.buildForIntegration(
"commerceCode",
"APIKey"
);
const response = await transaction.refund(token, amount);
Respuesta Reversa o Anulación
Para obtener la información contenida en la respuesta puedes hacerlo de la siguiente manera.
response.getAuthorizationCode();
response.getAuthorizationDate();
response.getBalance();
response.getNullifiedAmount();
response.getResponseCode();
response.getType();
$response->getAuthorizationCode();
$response->getAuthorizationDate();
$response->getBalance();
$response->getNullifiedAmount();
$response->getResponseCode();
$response->getType();
response.AuthorizationCode;
response.AuthorizationDate;
response.Balance;
response.NullifiedAmount;
response.ResponseCode;
response.Type;
response.authorization_code;
response.authorization_date;
response.balance;
response.nullified_amount;
response.response_code;
response.type;
## Versión 3.x del SDK
response['authorization_code']
response['authorization_date']
response['balance']
response['nullified_amount']
response['response_code']
response['type']
## Versión 2.x del SDK
response.authorization_code
response.authorization_date
response.balance
response.nullified_amount
response.response_code
response.type
response.authorization_code
response.authorization_date
response.balance
response.nullified_amount
response.response_code
response.type
Capturar una transacción
Los comercios que están configurados para operar con captura diferida deben ejecutar el método de captura para realizar el cargo al tarjetahabiente.
Este método permite a todo comercio habilitado realizar capturas de una transacción autorizada sin captura generada en Webpay Plus. El método contempla una única captura por cada autorización. Para ello se deberá indicar los datos asociados a la transacción de venta con autorización sin captura y el monto requerido para capturar el cual debe ser menor o igual al monto originalmente autorizado.
Para capturar una transacción, ésta debe haber sido creada (según lo visto anteriormente para Webpay Plus o Webpay Plus Mall) por un código de comercio configurado para captura diferida. De esa forma la transacción estará autorizada pero requerirá una captura explícita posterior para confirmar la transacción.
Puedes [leer más sobre la captura en la información del
producto Webpay](https://www.transbankdevelopers.cl/producto/webpay#autorizacion-y-captura)
para conocer más detalles y restricciones.
Para realizar esa captura explícita debe usarse el método Transaction.capture()
Transaction.capture()
Los SDKs permiten indicar opcionalmente el código de comercio de la transacción a capturar, para soportar la captura en comercios Webpay Plus Mall o Transacción Completa Mall. En comercios sin modalidad Mall no es necesario especificar el código de comercio, ya que se usa el indicado en la configuración.
WebpayPlus.Transaction transaction = WebpayPlus.Transaction.buildForIntegration("commerceCode", "APIKey");
final WebpayPlusTransactionCaptureResponse response = transaction.capture(token, buyOrder, authorizationCode, amount);
use Transbank\Webpay\WebpayPlus\Transaction;
$transaction = Transaction::buildForIntegration($apiKey, $commerceCode);
$response = $transaction->capture($token, $buyOrder, $authCode, $amount);
Transaction transaction = Transaction.buildForIntegration("commerceCode", "APIKey");
var response = transaction.capture(token, buyOrder, authorizationCode, amount);
@transaction = Transbank::Webpay::WebpayPlus::Transaction.build_for_integration("commerceCode", "APIKey");
@resp = @transaction.capture(
token: @token,
buy_order: @buy_order,
authorization_code: @auth_code,
amount: @amount
);
tx = Transaction.build_for_integration("commerceCode", "APIKey")
resp = tx.capture(
token=token, buy_order=buy_order, authorization_code=authorization_code, capture_amount=amount
)
const transaction = WebpayPlus.Transaction.buildForIntegration(
"commerceCode",
"APIKey"
);
const response = await tx.capture(
token,
buyOrder,
authorizationCode,
captureAmount
);
Una vez realizada la captura, recibirás un objeto con la respuesta. Revisa la [referencia API](https://www.transbankdevelopers.cl/referencia/webpay) para conocer más detalles
sobre los posibles resultados.
Respuesta de una captura
response.getAuthorizationCode();
response.getAuthorizationDate();
response.getCapturedAmount();
response.getResponseCode();
$response->getAuthorizationCode();
$response->getAuthorizationDate();
$response->getCapturedAmount();
$response->getResponseCode();
response.AuthorizationCode;
response.AuthorizationDate;
response.CapturedAmount;
response.ResponseCode;
response.authorization_code
response.authorization_date
response.captured_amount
response.response_code
## Versión 3.x del SDK
response['authorization_code']
response['authorization_date']
response['captured_amount']
response['response_code']
## Versión 2.x del SDK
response.authorization_code
response.authorization_date
response.captured_amount
response.response_code
response.authorization_code
response.authorization_date
response.captured_amount
response.response_code
Webpay Plus Mall
Una transacción Mall Normal corresponde a una solicitud de autorización financiera de un conjunto de pagos con tarjetas de crédito o débito, en donde quién realiza el pago ingresa al sitio del comercio, selecciona productos o servicios, y el ingreso asociado a los datos de la tarjeta de crédito o débito lo realiza una única vez en forma segura en Webpay para el conjunto de pagos. Cada pago tendrá su propio resultado, autorizado o rechazado.
![Desagregación de un pago Webpay Mall](https://www.transbankdevelopers.cl/public/slate-library/images/pago-webpay-mall.png)
Es la tienda Mall la que agrupa múltiples tiendas, son estas últimas las que pueden generar transacciones. Tanto el mall como las tiendas asociadas son identificadas a través de un número denominado código de comercio.
Flujo
El flujo de Webpay Plus Mall es en general el mismo que el de [Webpay Plus](#webpay-plus-normal)
tanto de cara al tarjeta habiente como de cara al integrador.
Las diferencias son:
- Se debe usar un código de comercio configurado para modalidad Mall en Transbank, el cual debe ser indicado al iniciar la transacción.
- Se pueden indicar múltiples transacciones, cada una asociada a un código de comercio de tienda (que debe estar configurada en Transbank como perteneciente al mall).
- Se debe verificar por separado el resultado de cada una de esas transacciones individualmente, pues es posible que el emisor de la tarjeta autorice algunas y otras no.
Crear una transacción mall
Esta operación te permite iniciar o crear varias transacciones de una sola vez, Webpay Plus Mall procesa el requerimiento y entrega como resultado de la operación el token de la transacción y URL de redireccionamiento a la cual se deberá redirigir al tarjetahabiente.
WebpayPlus.MallTransaction mallTransaction = WebpayPlus.MallTransaction.buildForIntegration("commerceCode", "APIKey");
MallTransactionCreateDetails mallDetails = MallTransactionCreateDetails.build()
.add(amountMallOne, commerceCodeStoreOne, buyOrderMallOne)
.add(amountMallTwo, commerceCodeStoreTwo, buyOrderMallTwo);
final WebpayPlusMallTransactionCreateResponse response = mallTransaction.create(buyOrder, sessionId, returnUrl, mallDetails);
$mallTransaction = MallTransaction::buildForIntegration($apiKey, $commerceCode);
$transaction_details = [
[
"amount" => 10000,
"commerce_code" => 'commerceCodeStoreOne',
"buy_order" => "ordenCompraDetalle1234"
],
[
"amount" =>12000,
"commerce_code" => 'commerceCodeStoreTwo',
"buy_order" => "ordenCompraDetalle4321"
],
];
$response = $mallTransaction->create($buy_order, $session_id, $return_url, $transaction_details);
MallTransaction mallTransaction = MallTransaction.buildForIntegration("commerceCode", "APIKey");
var transactionDetails = new List();
transactionDetails.Add(new TransactionDetail(
amountMallOne,
commerceCodeStoreOne,
buyOrderMallOne
));
transactionDetails.Add(new TransactionDetail(
amountMallTwo,
commerceCodeStoreTwo,
buyOrderMallTwo
));
var result = mallTransaction.Create(buyOrder, sessionId, returnUrl, transactionDetails);
@mall_transaction = Transbank::Webpay::WebpayPlus::MallTransaction.build_for_integration("commerceCode", "APIKey");
@transaction_details = [
{
amount: 10000,
commerce_code: "commerce_store_1",
buy_order: "ordenCompraDetalle1234"
},
{
amount: 12000,
commerce_code: "commerce_store_2",
buy_order: "ordenCompraDetalle4321"
},
];
@resp = @mall_transaction.create(
buy_order: @buy_order,
session_id: @session_id,
return_url: @return_url,
details: @transaction_details
);
mall_tx = MallTransaction.build_for_integration("commerceCode", "APIKey")
transaction_details = MallTransactionCreateDetails(
amount_child_1, commerce_store_1, buy_order_child_1
).add(
amount_child_2, commerce_store_2, buy_order_child_2
)
resp = mall_tx.create(
buy_order=buy_order,
session_id=session_id,
return_url=return_url,
details = transaction_details,
)
const mallTransaction = WebpayPlus.MallTransaction.buildForIntegration(
"commerceCode",
"APIKey"
);
let details = [
new TransactionDetail(amount, commerceCodeStoreOne, buyOrder),
new TransactionDetail(amount2, commerceCodeStoreTwo, buyOrder2),
];
const response = await mallTransaction.create(
buyOrder,
sessionId,
returnUrl,
details
);
Respuesta Crear una transacción mall
La respuesta de Webpay Plus Mall a la creación de es el token de la transacción y la URL a la cual debes redirigir al tarjetahabiente.
response.getToken();
response.getUrl();
$response->getToken();
$response->getUrl();
response.Token;
response.Url;
response.token
response.url
## Versión 3.x del SDK
response['token']
response['url']
## Versión 2.x del SDK
response.token
response.url
response.token
response.url
Con estos datos debes crear un formulario en el cual debes poner un input
de nombre token_ws
y en su valor debes insertar el token devuelto. El formulario debe usar el método POST
y su acción (o URL)
debe ser la URL devuelta por Webpay Plus.
<form method="post" action="Inserta aquí la url entregada">
<input type="hidden" name="token_ws" value="Inserte aquí el token entregado" />
<input type="submit" value="Ir a pagar" />
</form>
Confirmar una transacción mall
Una vez que el tarjetahabiente ha pagado, Webpay Plus retornará
el control vía POST
(o GET
si usas la API v1.1 o posterior) a la URL
que indicaste en el return_url
.
Recibirás también el parámetro token_ws
que te permitirá conocer el resultado de la transacción.
En caso de que el tarjetahabiente haya declinado, o haya ocurrido un error, recibirás la variable TBK_TOKEN
además de las variables TBK_ORDEN_COMPRA
y TBK_ID_SESION
.
WebpayPlus.MallTransaction mallTransaction = WebpayPlus.MallTransaction.buildForIntegration("commerceCode", "APIKey");
final WebpayPlusMallTransactionCommitResponse response = mallTransaction.commit(token);
$mallTransaction = MallTransaction::buildForIntegration($apiKey, $commerceCode);
$response = $mallTransaction->commit($token);
using Transbank.Webpay.WebpayPlus;
MallTransaction mallTransaction = MallTransaction.buildForIntegration("commerceCode", "APIKey");
var response = mallTransaction.Commit(token);
@mall_transaction = Transbank::Webpay::WebpayPlus::MallTransaction.build_for_integration("commerceCode", "APIKey");
@resp = @mall_transaction.commit(token: @token);
mall_tx = MallTransaction.build_for_integration("commerceCode", "APIKey")
resp = mall_tx.commit(token)
const mallTransaction = WebpayPlus.MallTransaction.buildForIntegration(
"commerceCode",
"APIKey"
);
const response = await mallTransaction.commit(token);
Respuesta Confirmar una transacción mall
Utilizando la respuesta de la confirmación podrás mostrar un comprobante o página de éxito a tu usuario. Con eso habrás completado el flujo "feliz" en que todo funciona.
response.getAccountingDate();
response.getBuyOrder();
final CardDetail cardDetail = response.getCardDetail();
cardDetail.getCardNumber();
response.getSessionId();
response.getTransactionDate();
response.getVci();
final List<Detail> details = response.getDetails();
for (Detail detail : details) {
detail.getAmount();
detail.getAuthorizationCode();
detail.getBuyOrder();
detail.getCommerceCode();
detail.getInstallmentsNumber();
detail.getPaymentTypeCode();
detail.getResponseCode();
detail.getStatus();
}
$response->getAccountingDate();
$response->getBuyOrder();
$response->getCardDetail();
$response->getCardNumber(); // Solo en SDK 2.x
$response->getSessionId();
$response->getTransactionDate();
$response->getVci();
$details = $response->getDetails();
foreach($details as $detail){ // En SDk 2.x cada $detail es un Objeto TransactionDetails
$detail->getAmount();
$detail->getAuthorizationCode();
$detail->getBuyOrder();
$detail->getCommerceCode();
$detail->getInstallmentsNumber();
$detail->getPaymentTypeCode();
$detail->getResponseCode();
$detail->getStatus();
$detail->isApproved(); // Solo en SDK 2.x - Indica si esta sub transacción puede ser considerada como aprobada
}
$response->isApproved(); // Solo en SDK 2.x - Devuelve true si al menos una de las subtransacciones fue autorizada.
response.AccountingDate;
response.BuyOrder;
var cardDetail = response.CardDetail;
cardDetail.CardNumber;
response.SessionId;
response.TransactionDate;
response.Vci;
var details = response.Details;
foreach (var detail in details) {
detail.Amount;
detail.AuthorizationCode;
detail.BuyOrder;
detail.CommerceCode;
detail.InstallmentsNumber;
detail.PaymentTypeCode;
detail.ResponseCode;
detail.Status;
}
response.accounting_date
response.buy_order
card_detail = response.card_detail
card_detail.card_number
response.session_id
response.transaction_date
response.vci
details = response.details
details.each do |detail|
detail.amount
detail.authorization_code
detail.buy_order
detail.commerce_code
detail.installments_number
detail.payment_type_code
detail.response_code
detail.status
end
## Versión 3.x del SDK
response['accounting_date']
response['buy_order']
response['card_detail']
response['session_id']
response['transaction_date']
response['vci']
## Versión 2.x del SDK
response.accounting_date
response.buy_order
card_detail = response.card_detail
card_detail.card_number
response.session_id
response.transaction_date
response.vci
details = response.details
for detail in details:
detail.amount
detail.authorization_code
detail.buy_order
detail.commerce_code
detail.installments_number
detail.payment_type_code
detail.response_code
detail.status
response.accounting_date
response.buy_order
cardDetail = response.card_detail
cardDetail.card_number
response.session_id
response.transaction_date
response.vci
details = response.details
details.forEach(detail => {
detail.amount
detail.authorization_code
detail.buy_order
detail.commerce_code
detail.installments_number
detail.payment_type_code
detail.response_code
detail.status
});
Obtener estado de una transacción mall
Esta operación permite obtener el estado de la transacción en cualquier momento. En condiciones normales es probable que no se requiera ejecutar, pero en caso de ocurrir un error inesperado permite conocer el estado y tomar las acciones que correspondan.
WebpayPlus.MallTransaction mallTransaction = WebpayPlus.MallTransaction.buildForIntegration("commerceCode", "APIKey");
final WebpayPlusMallTransactionStatusResponse response = mallTransaction.status(token);
$mallTransaction = MallTransaction::buildForIntegration($apiKey, $commerceCode);
$response = $mallTransaction->status($token);
MallTransaction mallTransaction = MallTransaction.buildForIntegration("commerceCode", "APIKey");
var response = mallTransaction.Status(token);
@mall_transaction = Transbank::Webpay::WebpayPlus::MallTransaction.build_for_integration("commerceCode", "APIKey");
@resp = @mall_transaction.status(token: @token);
mall_tx = MallTransaction.build_for_integration("commerceCode", "APIKey")
resp = mall_tx.status(token)
const mallTransaction = WebpayPlus.MallTransaction.buildForIntegration(
"commerceCode",
"APIKey"
);
const response = await mallTransaction.status(token);
Respuesta estado de una transacción mall
Para obtener la información contenida en la respuesta puedes hacerlo de la siguiente manera.
response.getAccountingDate();
response.getBuyOrder();
final CardDetail cardDetail = response.getCardDetail();
cardDetail.getCardNumber();
response.getSessionId();
response.getTransactionDate();
response.getVci();
final List<Detail> details = response.getDetails();
for (Detail detail : details) {
detail.getAmount();
detail.getAuthorizationCode();
detail.getBuyOrder();
detail.getCommerceCode();
detail.getInstallmentsNumber();
detail.getPaymentTypeCode();
detail.getResponseCode();
detail.getStatus();
}
response.AccountingDate;
response.BuyOrder;
var cardDetail = response.CardDetail;
cardDetail.CardNumber;
response.SessionId;
response.TransactionDate;
response.Vci;
var details = response.Details;
foreach (var detail in details) {
detail.Amount;
detail.AuthorizationCode;
detail.BuyOrder;
detail.CommerceCode;
detail.InstallmentsNumber;
detail.PaymentTypeCode;
detail.ResponseCode;
detail.Status;
}
$response->getAccountingDate();
$response->getBuyOrder();
$response->getCardDetail();
$response->getCardNumber(); // Solo en SDK 2.x
$response->getSessionId();
$response->getTransactionDate();
$response->getVci();
$details = $response->getDetails();
foreach($details as $detail){ // En SDk 2.x cada $detail es un Objeto TransactionDetails
$detail->getAmount();
$detail->getAuthorizationCode();
$detail->getBuyOrder();
$detail->getCommerceCode();
$detail->getInstallmentsNumber();
$detail->getPaymentTypeCode();
$detail->getResponseCode();
$detail->getStatus();
$detail->isApproved(); // Solo en SDK 2.x - Indica si esta sub transacción puede ser considerada como aprobada
}
$response->isApproved(); // Solo en SDK 2.x - Devuelve true si al menos una de las subtransacciones fue autorizada.
response.accounting_date
response.buy_order
card_detail = response.card_detail
card_detail.card_number
response.session_id
response.transaction_date
response.vci
details = response.details
details.each do |detail|
detail.amount
detail.authorization_code
detail.buy_order
detail.commerce_code
detail.installments_number
detail.payment_type_code
detail.response_code
detail.status
end
## Versión 3.x del SDK
response['accounting_date']
response['buy_order']
response['card_detail']
response['session_id']
response['transaction_date']
response['vci']
## Versión 2.x del SDK
response.accounting_date
response.buy_order
card_detail = response.card_detail
card_detail.card_number
response.session_id
response.transaction_date
response.vci
details = response.details
for detail in details:
detail.amount
detail.authorization_code
detail.buy_order
detail.commerce_code
detail.installments_number
detail.payment_type_code
detail.response_code
detail.status
response.accounting_date
response.buy_order
cardDetail = response.card_detail
cardDetail.card_number
response.session_id
response.transaction_date
response.vci
details = response.details
details.forEach(detail => {
detail.amount
detail.authorization_code
detail.buy_order
detail.commerce_code
detail.installments_number
detail.payment_type_code
detail.response_code
detail.status
});
Reversar o Anular una transacción mall
Esta operación permite a todo comercio habilitado, reversar o anular una transacción que fue generada en Webpay Plus.
Puedes realizar un reembolso invocando al método refund(), dependiendo de algunas condiciones correspondera a una Reversa o Anulación.
Puedes [leer más sobre la anulación en la información del
producto Webpay](https://www.transbankdevelopers.cl/producto/webpay#anulaciones-y-reversas) para conocer
más detalles y restricciones.
WebpayPlus.MallTransaction mallTransaction = WebpayPlus.MallTransaction.buildForIntegration("commerceCode", "APIKey");
final WebpayPlusTransactionRefundResponse response = mallTransaction.refund(token, childBuyOrder, commerceCodeStoreOne, amount);
$mallTransaction = MallTransaction::buildForIntegration($apiKey, $commerceCode);
$response = $mallTransaction->refund($token, $buy_order, $commerce_code, $amount);
MallTransaction mallTransaction = MallTransaction.buildForIntegration("commerceCode", "APIKey");
var response = mallTransaction.Refund(token, buyOrder, commerceCode, amount);
@mall_transaction = Transbank::Webpay::WebpayPlus::MallTransaction.build_for_integration("commerceCode", "APIKey");
@resp = @mall_transaction.refund(token: @token, buy_order: @child_buy_order, child_commerce_code: @commerce_store_1, amount: @amount);
mall_tx = MallTransaction.build_for_integration("commerceCode", "APIKey")
resp = mall_tx.refund(token, child_buy_order, commerce_store_1, amount)
const mallTransaction = WebpayPlus.MallTransaction.buildForIntegration(
"commerceCode",
"APIKey"
);
const response = await mallTransaction.refund(
token,
buyOrder,
commerceCodeStoreOne,
amount
);
Respuesta Reversa o Anulacion mall
Para obtener la información contenida en la respuesta puedes hacerlo de la siguiente manera.
response.getAuthorizationCode();
response.getAuthorizationDate();
response.getBalance();
response.getNullifiedAmount();
response.getResponseCode();
response.getType();
response.AuthorizationCode;
response.AuthorizationDate;
response.Balance;
response.NullifiedAmount;
response.ResponseCode;
response.Type;
$response->getAuthorizationCode();
$response->getAuthorizationDate();
$response->getBalance();
$response->getNullifiedAmount();
$response->getResponseCode();
$response->getType();
response.authorization_code
response.authorization_date
response.balance
response.nullified_amount
response.response_code
response.type
## Versión 3.x del SDK
response['authorization_code']
response['authorization_date']
response['balance']
response['nullified_amount']
response['response_code']
response['type']
## Versión 2.x del SDK
response.authorization_code
response.authorization_date
response.balance
response.nullified_amount
response.response_code
response.type
Capturar una transacción mall
WebpayPlus.MallTransaction mallTransaction = WebpayPlus.MallTransaction.buildForIntegration("commerceCode", "APIKey");
final WebpayPlusMallTransactionCaptureResponse response = mallTransaction.capture(token, commerceCodeStoreOne, childBuyOrder, authorizationCode, amount);
$mallTransaction = MallTransaction::buildForIntegration($apiKey, $commerceCode);
$response = $mallTransaction->capture($commerceCodeStoreOne, $token, $buyOrder, $authorizationCode, $captureAmount);
MallTransaction mallTransaction = MallTransaction.buildForIntegration("commerceCode", "APIKey");
var response = mallTransaction.Capture(token, commerceCodeStoreOne, buyOrder, authorizationCode, captureAmount);
@mall_transaction = Transbank::Webpay::WebpayPlus::MallTransaction.build_for_integration("commerceCode", "APIKey");
@resp = @mall_transaction.capture(child_commerce_code: @commerce_store_1, token: @token, buy_order: @buy_order, authorization_code: @authorization_code, capture_amount: @capture_amount);
mall_tx = MallTransaction.build_for_integration("commerceCode", "APIKey") resp = mall_tx.capture( token=token, capture_amount=amount, commerce_code=commerce_store_1, buy_order=buy_order, authorization_code=authorization_code )
const mallTransaction = WebpayPlus.MallTransaction.buildForIntegration(
"commerceCode",
"APIKey"
);
const response = await mallTransaction.capture(
token,
commerceCodeStoreOne,
buyOrder,
authorizationCode,
captureAmount
);
Respuesta de una captura mall
response.getAuthorizationCode();
response.getAuthorizationDate();
response.getCapturedAmount();
response.getResponseCode();
$response->getAuthorizationCode();
$response->getAuthorizationDate();
$response->getCapturedAmount();
$response->getResponseCode();
response.AuthorizationCode;
response.AuthorizationDate;
response.CapturedAmount;
response.ResponseCode;
response.authorization_code
response.authorization_date
response.captured_amount
response.response_code
## Versión 3.x del SDK
response['authorization_code']
response['authorization_date']
response['captured_amount']
response['response_code']
## Versión 2.x del SDK
response.authorization_code
response.authorization_date
response.captured_amount
response.response_code
response.authorization_code
response.authorization_date
response.balance
response.nullified_amount
response.response_code
response.type
Esta operación funciona de la misma manera que la [captura de Webpay Plus normal](#capturar-una-transaccion).
Credenciales y Ambiente
Ambiente de integración
Puede encontrar más información al respecto [en este link](https://www.transbankdevelopers.cl/documentacion/como_empezar#ambiente-de-integracion)
Configuración SDK
Los SDK deben configurarse explícitamente para apuntar al ambiente que quieras utilizar (producción / integración). Para esto puedes crear los objetos de 2 maneras:
-
Utilizar los métodos definidos para ello (
buildForIntegration
obuildForProduction
). -
Utilizar un objeto
Options
que contenga la configuración y pasarlo en el constructor de cada objeto.
Puede encontrar más información al respecto [en este link](https://www.transbankdevelopers.cl/documentacion/como_empezar#b-utilizando-los-sdk)
Puesta en Producción
Puede encontrar más información al respecto [en este link](https://www.transbankdevelopers.cl/documentacion/como_empezar#puesta-en-produccion)
Ejemplos de integración
Puedes encontrar ejemplos de integración de los diferentes productos Webpay visitando
el [índice de proyectos de ejemplo. ](https://proyectos-ejemplo.transbankdevelopers.cl/)Allí se explica paso a paso las etapas del flujo de pago, con fragmentos de código para comprender a profundidad el procedimiento a integrar en tu comercio.

# index.md

Source: https://www.transbankdevelopers.cl/

Nuestros SDK y API REST, te permitirán realizar una integración más personaliza de nuestros productos en tu APP o sitio web.
Hemos desarrollado plugins para los gestores de contenidos más utilizados, tales como: WooCommerce, Magento, Prestashop.
Herramientas para integrar nuestras maquinitas a tus sistemas de pago presencial.
Los productos que te presentamos en este sitio son los que necesitan de un proceso de integración en
comercio y otras aplicaciones. Para los demás productos
que no requieren integración puedes encontrar información en la web [transbank.cl](https://www.transbank.cl/web/productos-y-servicios/soluciones-para-ventas-internet)
Pagos recurrentes de suscripciones fijas y otros pagos automáticos en la tarjeta de crédito.
Pagos presenciales con tarjeta de crédito y Redcompra con terminales integrados a la caja para grandes flujos de venta.
Si quieres comprender de mejor manera cada uno de los productos
Para validar tu integración y verificar que funcione correctamente, ingresa a los formularios dispuestos según la forma en que realizaste la integración y completa el formulario respectivo.
Integración realizada con alguno de nuestros plugin para los gestores de e-commerce más populares
Integración realizada con alguno de nuestros SDK, API o desarrollo propio de tu comercio
Hemos desarrollado plugins fácil de instalar especialmente para los
e-commerce más populares.
Estas soluciones operan con nuestro producto Webpay Plus.
Hemos decidido rehacer nuestro portal, pensando en los desarrolladores. Queremos facilitar el proceso de integración al máximo, eliminar las fricciones y estar a la altura de los mayores referentes en sistemas de pago y documentación.
Porque queremos que la competencia y la oferta en el mundo de ventas online crezca, Damos a conocer a los nuevos comercios las alternativas que hoy existen para levantar una tienda virtual

# integradores.md

Source: https://www.transbankdevelopers.cl/integradores

Encuentra acá ayuda para poder integrar Transbank a tu e-commerce
Servicio de integración realizada por expertos Transbank
Los perfiles publicados en esta sección corresponden a desarrolladores que ofrecen servicios de integración de manera independiente de Transbank en www.transbankdevelopers.cl. Transbank no realiza certificación de integradores, ni se hace responsable por su gestión, por lo que cualquier error en este proceso es responsabilidad de cada integrador para con el comercio. Por lo anterior, recomendamos validar siempre su veracidad y calidad de servicio.
Integraciones
Valorización

# our_products.md

Source: https://www.transbankdevelopers.cl/our_products

Conoce nuestros productos de acuerdo a tu necesidad
Te recomendamos cuales de nuestros productos se ajustan mejor a lo que realmente necesita tu negocio
Escoge el tipo de venta
Puedes conseguir productos relacionados a pagos únicos, frecuentes o por suscripción. Webpay Plus
Internet
Aquí conseguirás productos para optimizar los tiempos de espera en comercios físicos
Presencial
A través de nuestro call center puedes realizar transacciones de pago
Telefónica
Te recomendamos
Para desktop
Webpay Plus es el producto más usado para realizar un pago puntual en una tienda simple. Se genera un único cobro para todos los productos o servicios adquiridos por el tarjetahabiente (carro de compras).
Cuenta además con la característica Mall, mejor conocida como Webpay Plus Mall que permite agrupar a múltiples tiendas. Es un tipo de transacción útil para proveedores de servicios tecnológicos (PST) que pueden realizar una única integración con Transbank y realizar cobros a nombre de los clientes de dichos servicios tecnológicos.
Se integra en plataformas web a través de SDK y diferentes plugins. Permite la visualización correcta en móviles gracias a su interfaz responsiva.
[Más sobre este producto](producto/webpay#webpay-plus)
Otras Alternativas
Para desktop
Botones Webpay Plus
Cada botón se integra en los sitios web a través de un script que es generado en un sitio de Transbank mediante una interfaz simple de usar y no requiere ningún conocimiento técnico. Es una manera sencilla de integrar Webpay Plus como medio de pago, sin embargo es poco flexible.
Cuadro Comparativo
| Producto | Móvil | Desktop (responsive) | Dificultad integración |
| Webpay Plus | Media | ||
| Botones Webpay Plus | Baja |
Nuestra recomendación
Desktop y mobile
Cuenta también con la característica Mall, también conocida como Webpay Oneclick Mall que permite agrupar múltiples tiendas y sus pagos en una única transacción Oneclick. Permite por ejemplo a un proveedor de servicios tecnológicos (PST) realizar una única integración y hacer cobros a nombre de múltiples tiendas clientes.
Se integra en plataformas web a través de SDK y diferentes plugins. Permite la visualización correcta en móviles gracias a su interfaz responsiva. Sin embargo, durante la validación con el banco emisor, se pueden generar diferencias negativas en la experiencia en móvil si la interfaz del emisor no es responsiva.
[Más sobre este producto](producto/webpay#webpay-oneclick)
Te recomendamos
Desktop
Patpass by Webpay es la mezcla entre la funcionalidad de autentificación de Webpay con la recurrencia de Patpass. Permite dejar la administración de los cobros en Transbank, sin la necesidad que el comercio tenga que estar enviando nóminas. El primer cobro se hace al momento de la suscripción usando Webpay y el comercio se entera en línea de la suscripción y primer pago y los siguientes pagos (del 2 al n) se hacen de forma automática a través del motor PatPass y son informados al comercio a través de la plataforma Transdata.
Las ventajas para el comercio son la suscripción sin mandato físico ni riesgo de fuga de información. Además de enterarse en línea del estado de la suscripción.
Está pensado para comercios que venden por internet y que tienen un tipo de cobro de monto fijo en pesos, UF o dólares.
Se integra mediante el SDK único de Transbank y también por plugins muy parecidos a Webpay, incluido su interacción con el tarjetahabiente.
[Más sobre este producto](producto/patpass#patpass-by-webpay)
Nuestra recomendación
Físico/Integrado
POS integrado es un tipo de POS conectado directamente a la caja (software) de un comercio y que permite a este último, acceder a información adicional de las transacciones para apoyar sus procesos de conciliación y cuadratura al cierre de la caja.
Este producto requiere alto conocimiento técnico y está enfocado en comercios que ya posean usuarios de POS estándar y posean una solución robusta de caja.
[Más sobre este producto](producto/posintegrado)
Cuadro Comparativo
| Producto | Móvil | Desktop (responsive) | Dificultad integración |
| POS (Integrado) | N/A | N/A | Alta |
Nuestra recomendación
![](https://www.transbankdevelopers.cl/public/library/img/svg/cortafilas_totem.png)
pago tienda física
Onepay como cortafila es un tipo de integración especial que permite hacer más eficiente las ventas en tiendas físicas, reduciendo el tiempo de espera de los clientes en el comercio. Su implementación es muy simple, proporcionas al staff de tu tienda una aplicación móvil (por ejemplo, en un Tablet o Smartphone) o ubicas tótems de autoservicio que permitan crear una transacción Onepay y cerrar una venta.
La modalidad de Cortafila/Caja Móvil es una gran alternativa para el cliente y el comercio, gracias a su facilidad de uso e implementación. En el comercio, Onepay como cortafila se integra mediante SDKs, mientras que el usuario autoriza la compra con su PIN de Onepay, generado al configurar la aplicación y registrar su tarjeta de crédito o débito.
Permite una visualización correcta en cualquier dispositivo gracias a su interfaz responsiva para una mejor y fluida experiencia para el usuario.
![](https://www.transbankdevelopers.cl/public/library/img/svg/cortafilas_imagen.png)
Nuestra recomendación
Físico/Integrado
POS integrado es un tipo de POS conectado directamente a la caja (software) de un comercio y que permite a este último, acceder a información adicional de las transacciones para apoyar sus procesos de conciliación y cuadratura al cierre de la caja.
La integración del dispositivo POS puede hacerse de igual manera en un kiosko o módulo de autoatención, donde el dispositivo va incrustado en la infraestructura del módulo e integrado al software (web) del kiosko, con el objetivo de operar directamente en las transacciones, tal como lo hacen productos como la pasarela de pago de transacciones por internet Webpay.
Este producto requiere alto conocimiento técnico y está enfocado en comercios que ya posean usuarios de POS estándar y posean una solución robusta de caja.
[Más sobre este producto](producto/posintegrado)
Cuadro Comparativo
| Producto | Móvil | Desktop (responsive) | Dificultad integración |
| POS (Integrado) | N/A | N/A | Alta |
Te recomendamos
Para desktop
Call Center
Opera con las mismas características de Webpay Plus, sólo que es realizado a través de un tercero (ejecutivo telefónico). Y por esta razón el formulario Webpay no permite autentificación bancaria, por lo que sólo soporta transacciones con Tarjeta de Crédito. En caso de fraude, el riesgo es asumido por el comercio.
Es un producto que está orientado a comercios que posean una elevada infraestructura, que permita el manejo data sensible, con los estándares de seguridad (PCI Compliance HW/SW), y que bajo su responsabilidad administren la autentificación de tarjetahabiente y el riesgo de fraude. Por este motivo, este producto no se encuentra dentro de la oferta pública de Transbank. Para su implementación, el establecimiento comercial debe solicitarlo directamente con su ejecutivo comercial.
Cuadro Comparativo
| Producto | Móvil | Desktop (responsive) | Dificultad integración |
| Webpay Call Center | Alta |

# plugin.md

Source: https://www.transbankdevelopers.cl/plugin

Recupera tu contraseña aquí
Se envió un correo a su cuenta inscrita.
Es necesario la validación de la cuenta.
Recuerda revisar la bandeja de spam
Se ha enviado un correo para cambiar la contraseña
Si aún mantienes tu integración de Webpay en la modalidad SOAP, te recordamos que en septiembre del presente año, esta modalidad será deprecada, por lo cual es necesario que realices la migración a la metodología REST para continuar operando posterior a dicha fecha.
¿Cuáles son los principales beneficios de REST para tu comercio?
¿Cómo realizar la integración Rest?
Puedes contactar a tu Integrador o revisar la información disponible [en este link.](https://www.transbankdevelopers.cl/documentacion/como_empezar#)
Si necesitas asistencia puedes contactar a tu Integrador o puedes contactarnos a Servicio al Cliente al 600 638 6380 desde teléfonos fijos o desde celulares al +562 2661 2700, casilla [soporteweb@transbank.cl.](mailto:soporteweb@transbank.cl)
Tu mensaje se ha enviado exitosamente, pronto nos contactaremos con usted
Hemos enviado una copia a tu correo
Si estás en los primeros pasos para integrarte, puedes solicitar ayuda seleccionado esta opción o escríbenos directamente a nuestro canal Slack, donde especialistas despejaran tus dudas
Si requieres resolver algún tipo de incidencia en la página www.transbankdevelopers.cl. Tu mensaje será dirigido al soporte de la plataforma.
Si ya terminaste la integración del medio de pago de manera exitosa, y necesitas soporte post venta selecciona esta opción en tipo de soporte o llama a los siguientes números:
Desde teléfonos fijos: 600 638 6380
Desde móviles : [+56 2 2661 2700]
También te invitamos a colaborar directamente en nuestro [repositorio en Github](https://github.com/TransbankDevelopers/transbank-developers-docs) enviándonos un Pull Request que felizmente revisaremos e incluiremos
<{msg_ajax}>
Hemos desarrollado diferentes plugins de acuerdo a los gestores de contenidos más usados en el e-commerce mundial.
Estos te permitirán vender en línea en pocos pasos de forma rápida, segura y sencilla.
Estas soluciones operan con nuestro producto Webpay Plus.

# plugin_magento.md

Source: https://www.transbankdevelopers.cl/plugin/magento/

Webpay REST Magento2
Webpay REST
Descripción
Este plugin oficial ha sido creado para que puedas integrar Webpay fácilmente en tu comercio, basado en Magento2.
Puedes encontrar el repositorio Open Source de este plugin [acá](https://github.com/TransbankDevelopers/transbank-plugin-magento2-webpay-rest).
Requisitos
Debes tener instalado previamente [Magento2](https://magento.com/).
Asegúrate de tener habilitados los siguientes módulos / extensiones para PHP:
- OpenSSL 1.0.1 o superior
- SimpleXML
- DOM 2.7.8 o superior
- PHP 7.0 o superior
Al instalar el plugin, podrás revisar si todas estos requisitos se cumplen, a través de la pantalla de diagnóstico que se incluye.
Esta pantalla de diagnóstico se encuentra en la sección de configuración del plugin (en donde configuras tu código de comercio y tu llave secreta). Ahí debes presionar el botón "Información del sistema"
Instalación
A) Con composer (recomendado)
Esta es la opción recomendada para instalar el paquete en Magento.
Primero, entrar con la terminal al directorio raíz de Magento e instalar el paquete usando [Composer](https://getcomposer.org/).
composer require transbank/webpay-magento2-rest
Cuando finalice, ejecutar el comando:
magento module:enable Transbank_Webpay --clear-static-content
y finalmente:
magento setup:upgrade && magento setup:di:compile && magento setup:static-content:deploy
Puedes encontrar las instrucciones detalladas de instalación las puedes encontrar en el [siguiente link](https://github.com/TransbankDevelopers/transbank-plugin-magento2-webpay-rest/blob/master/docs/INSTALLATION.md) del repositorio.
B) Como archivo
[Descargar el archivo .zip del plugin](https://github.com/TransbankDevelopers/transbank-plugin-magento2-webpay-rest/releases/latest)- Descomprimir el archivo en la carpeta app/code/Transbank/WebpayRest
- Edita el archivo app/etc/config.php y agrega
Transbank_Webpay_Rest => 1
a la lista de módulos. - Entra al admin de magento y elimina el caché. (System > Cache Management)
- El módulo debería estar instalado.
Ambiente de pruebas
Una vez instalado el plugin, este viene configurado en el ambiente de Integración de Transbank, por lo que puedes realizar todas las pruebas de pago que necesites, ya que no se usa dinero real.
En este ambiente solo funcionan las tarjetas de crédito y débito de prueba que puedes [encontrar acá](https://www.transbankdevelopers.cl/documentacion/como_empezar#ambiente-de-integracion).
Obtener tu llave secreta (proceso de validación)
Para usar el plugin en el ambiente de producción (donde se utiliza dinero real), necesitas tener tu llave secreta, que es un código especial que está asociado a tu código de comercio.
Para obtenerla necesitas pasar un proceso de validación, que está [explicado acá](https://transbankdevelopers.cl/documentacion/como_empezar#puesta-en-produccion).
Al finalizar este proceso de validación, obtendrás tu llave secreta. Nota: Esta llave secreta es como la contraseña de tu código de comercio, por lo que no debes compartirla. Se usa para identificar que tu comercio es quién realmente está realizando cada operación (transacción, anulación de un pago, etc).
Puesta en producción
Si ya tienes tu código de comercio de producción y llave secreta, solo debes entrar a la configuración de tu plugin ([instrucciones en este link](https://github.com/TransbankDevelopers/transbank-plugin-magento2-webpay-rest/blob/master/docs/INSTALLATION.md#configuraci%C3%B3n)) y colocar:
- Ambiente: Producción
- Código de comercio: tu código de comercio de producción
- Api Key: Tu llave secreta
Al guardar, el plugin funcionará inmediatamente en ambiente de producción y podrás operar con tarjetas y transacciones reales.
Problemas, Dudas, Sugerencias
Si tienes algún problema, duda o sugerencia, puedes contactarnos en nuestra comunidad de Slack, a la que puedes [unirte acá](https://invitacion-slack.transbankdevelopers.cl/slack_community)
Adicionalmente, puedes revisar si más comercios han presentado algún error/dudas similares en los [issues del repositorio github](https://github.com/TransbankDevelopers/transbank-plugin-magento2-webpay-rest/issues). Si nadie ha comentado algo similar, puedes [crear un nuevo issue](https://github.com/TransbankDevelopers/transbank-plugin-magento2-webpay-rest/issues/new) con tu sugerencia, bug, problema, etc.

# plugin_magento_webpay.md

Source: https://www.transbankdevelopers.cl/plugin/magento/webpay

Webpay REST Magento2
Webpay REST
Descripción
Este plugin oficial ha sido creado para que puedas integrar Webpay fácilmente en tu comercio, basado en Magento2.
Puedes encontrar el repositorio Open Source de este plugin [acá](https://github.com/TransbankDevelopers/transbank-plugin-magento2-webpay-rest).
Requisitos
Debes tener instalado previamente [Magento2](https://magento.com/).
Asegúrate de tener habilitados los siguientes módulos / extensiones para PHP:
- OpenSSL 1.0.1 o superior
- SimpleXML
- DOM 2.7.8 o superior
- PHP 7.0 o superior
Al instalar el plugin, podrás revisar si todas estos requisitos se cumplen, a través de la pantalla de diagnóstico que se incluye.
Esta pantalla de diagnóstico se encuentra en la sección de configuración del plugin (en donde configuras tu código de comercio y tu llave secreta). Ahí debes presionar el botón "Información del sistema"
Instalación
A) Con composer (recomendado)
Esta es la opción recomendada para instalar el paquete en Magento.
Primero, entrar con la terminal al directorio raíz de Magento e instalar el paquete usando [Composer](https://getcomposer.org/).
composer require transbank/webpay-magento2-rest
Cuando finalice, ejecutar el comando:
magento module:enable Transbank_Webpay --clear-static-content
y finalmente:
magento setup:upgrade && magento setup:di:compile && magento setup:static-content:deploy
Puedes encontrar las instrucciones detalladas de instalación las puedes encontrar en el [siguiente link](https://github.com/TransbankDevelopers/transbank-plugin-magento2-webpay-rest/blob/master/docs/INSTALLATION.md) del repositorio.
B) Como archivo
[Descargar el archivo .zip del plugin](https://github.com/TransbankDevelopers/transbank-plugin-magento2-webpay-rest/releases/latest)- Descomprimir el archivo en la carpeta app/code/Transbank/WebpayRest
- Edita el archivo app/etc/config.php y agrega
Transbank_Webpay_Rest => 1
a la lista de módulos. - Entra al admin de magento y elimina el caché. (System > Cache Management)
- El módulo debería estar instalado.
Ambiente de pruebas
Una vez instalado el plugin, este viene configurado en el ambiente de Integración de Transbank, por lo que puedes realizar todas las pruebas de pago que necesites, ya que no se usa dinero real.
En este ambiente solo funcionan las tarjetas de crédito y débito de prueba que puedes [encontrar acá](https://www.transbankdevelopers.cl/documentacion/como_empezar#ambiente-de-integracion).
Obtener tu llave secreta (proceso de validación)
Para usar el plugin en el ambiente de producción (donde se utiliza dinero real), necesitas tener tu llave secreta, que es un código especial que está asociado a tu código de comercio.
Para obtenerla necesitas pasar un proceso de validación, que está [explicado acá](https://transbankdevelopers.cl/documentacion/como_empezar#puesta-en-produccion).
Al finalizar este proceso de validación, obtendrás tu llave secreta. Nota: Esta llave secreta es como la contraseña de tu código de comercio, por lo que no debes compartirla. Se usa para identificar que tu comercio es quién realmente está realizando cada operación (transacción, anulación de un pago, etc).
Puesta en producción
Si ya tienes tu código de comercio de producción y llave secreta, solo debes entrar a la configuración de tu plugin ([instrucciones en este link](https://github.com/TransbankDevelopers/transbank-plugin-magento2-webpay-rest/blob/master/docs/INSTALLATION.md#configuraci%C3%B3n)) y colocar:
- Ambiente: Producción
- Código de comercio: tu código de comercio de producción
- Api Key: Tu llave secreta
Al guardar, el plugin funcionará inmediatamente en ambiente de producción y podrás operar con tarjetas y transacciones reales.
Problemas, Dudas, Sugerencias
Si tienes algún problema, duda o sugerencia, puedes contactarnos en nuestra comunidad de Slack, a la que puedes [unirte acá](https://invitacion-slack.transbankdevelopers.cl/slack_community)
Adicionalmente, puedes revisar si más comercios han presentado algún error/dudas similares en los [issues del repositorio github](https://github.com/TransbankDevelopers/transbank-plugin-magento2-webpay-rest/issues). Si nadie ha comentado algo similar, puedes [crear un nuevo issue](https://github.com/TransbankDevelopers/transbank-plugin-magento2-webpay-rest/issues/new) con tu sugerencia, bug, problema, etc.

# plugin_opencart.md

Source: https://www.transbankdevelopers.cl/plugin/opencart/

Webpay REST OpenCart
Webpay REST
Descripción
Este plugin oficial ha sido creado para que puedas integrar Webpay fácilmente en tu comercio, basado en OpenCart.
Requisitos
Debes tener instalado previamente [OpenCart](https://opencart.com/).
Asegúrate de tener habilitados los siguientes módulos / extensiones para PHP:
- OpenSSL 1.0.1 o superior
- SimpleXML
- DOM 2.7.8 o superior
- PHP 7.0 o superior
Al instalar el plugin, podrás revisar si todas estos requisitos se cumplen, a través de la pantalla de diagnóstico que se incluye.
Instalación
[Descargar el archivo .zip del plugin](https://github.com/TransbankDevelopers/transbank-plugin-opencart-webpay-rest/releases/latest)- Sube el archivo zip en la sección Extensions > Installer en el administrador de tu Opencart
Las instrucciones detalladas de instalación las puedes encontrar en el [siguiente link](https://github.com/TransbankDevelopers/transbank-plugin-opencart-webpay-rest/blob/master/docs/INSTALLATION.md).
Ambiente de pruebas
Una vez instalado el plugin, este viene configurado en el ambiente de Integración de Transbank, por lo que puedes realizar todas las pruebas de pago que necesites, ya que no se usa dinero real.
En este ambiente solo funcionan las tarjetas de crédito y débito de prueba que puedes [encontrar acá](https://www.transbankdevelopers.cl/documentacion/como_empezar#ambiente-de-integracion).
Obtener tu llave secreta (proceso de validación)
Para usar el plugin en el ambiente de producción (donde se utiliza dinero real), necesitas tener tu llave secreta, que es un código especial que está asociado a tu código de comercio.
Para obtenerla necesitas pasar un proceso de validación, que está [explicado acá](https://transbankdevelopers.cl/documentacion/como_empezar#puesta-en-produccion).
Al finalizar este proceso de validación, obtendrás tu llave secreta. Nota: Esta llave secreta es como la contraseña de tu código de comercio, por lo que no debes compartirla. Se usa para identificar que tu comercio es quién realmente está realizando cada operación (transacción, anulación de un pago, etc).
Puesta en producción
Si ya tienes tu código de comercio de producción y llave secreta, solo debes entrar a la configuración de tu plugin ([instrucciones en este link](https://github.com/TransbankDevelopers/transbank-plugin-opencart-webpay-rest/blob/master/docs/INSTALLATION.md#configuraci%C3%B3n)) y colocar:
- Ambiente: Producción
- Código de comercio: tu código de comercio de producción
- Api Key: Tu llave secreta
Al guardar, el plugin funcionará inmediatamente en ambiente de producción y podrás operar con tarjetas y transacciones reales.
Problemas, Dudas
Si tienes algún problema, duda o sugerencia, puedes contactarnos en nuestra comunidad de Slack, a la que puedes [unirte acá](https://invitacion-slack.transbankdevelopers.cl/slack_community)
Adicionalmente, puedes revisar si más comercios han presentado algun error/dudas similares en los [issues del repositorio github](https://github.com/TransbankDevelopers/transbank-plugin-opencart-webpay-rest/issues). Si nadie ha comentado algo similar, puedes [crear un nuevo issue](https://github.com/TransbankDevelopers/transbank-plugin-opencart-webpay-rest/issues/new) con tu sugerencia, bug, problema, etc.

# plugin_opencart_webpay.md

Source: https://www.transbankdevelopers.cl/plugin/opencart/webpay

Webpay REST OpenCart
Webpay REST
Descripción
Este plugin oficial ha sido creado para que puedas integrar Webpay fácilmente en tu comercio, basado en OpenCart.
Requisitos
Debes tener instalado previamente [OpenCart](https://opencart.com/).
Asegúrate de tener habilitados los siguientes módulos / extensiones para PHP:
- OpenSSL 1.0.1 o superior
- SimpleXML
- DOM 2.7.8 o superior
- PHP 7.0 o superior
Al instalar el plugin, podrás revisar si todas estos requisitos se cumplen, a través de la pantalla de diagnóstico que se incluye.
Instalación
[Descargar el archivo .zip del plugin](https://github.com/TransbankDevelopers/transbank-plugin-opencart-webpay-rest/releases/latest)- Sube el archivo zip en la sección Extensions > Installer en el administrador de tu Opencart
Las instrucciones detalladas de instalación las puedes encontrar en el [siguiente link](https://github.com/TransbankDevelopers/transbank-plugin-opencart-webpay-rest/blob/master/docs/INSTALLATION.md).
Ambiente de pruebas
Una vez instalado el plugin, este viene configurado en el ambiente de Integración de Transbank, por lo que puedes realizar todas las pruebas de pago que necesites, ya que no se usa dinero real.
En este ambiente solo funcionan las tarjetas de crédito y débito de prueba que puedes [encontrar acá](https://www.transbankdevelopers.cl/documentacion/como_empezar#ambiente-de-integracion).
Obtener tu llave secreta (proceso de validación)
Para usar el plugin en el ambiente de producción (donde se utiliza dinero real), necesitas tener tu llave secreta, que es un código especial que está asociado a tu código de comercio.
Para obtenerla necesitas pasar un proceso de validación, que está [explicado acá](https://transbankdevelopers.cl/documentacion/como_empezar#puesta-en-produccion).
Al finalizar este proceso de validación, obtendrás tu llave secreta. Nota: Esta llave secreta es como la contraseña de tu código de comercio, por lo que no debes compartirla. Se usa para identificar que tu comercio es quién realmente está realizando cada operación (transacción, anulación de un pago, etc).
Puesta en producción
Si ya tienes tu código de comercio de producción y llave secreta, solo debes entrar a la configuración de tu plugin ([instrucciones en este link](https://github.com/TransbankDevelopers/transbank-plugin-opencart-webpay-rest/blob/master/docs/INSTALLATION.md#configuraci%C3%B3n)) y colocar:
- Ambiente: Producción
- Código de comercio: tu código de comercio de producción
- Api Key: Tu llave secreta
Al guardar, el plugin funcionará inmediatamente en ambiente de producción y podrás operar con tarjetas y transacciones reales.
Problemas, Dudas
Si tienes algún problema, duda o sugerencia, puedes contactarnos en nuestra comunidad de Slack, a la que puedes [unirte acá](https://invitacion-slack.transbankdevelopers.cl/slack_community)
Adicionalmente, puedes revisar si más comercios han presentado algun error/dudas similares en los [issues del repositorio github](https://github.com/TransbankDevelopers/transbank-plugin-opencart-webpay-rest/issues). Si nadie ha comentado algo similar, puedes [crear un nuevo issue](https://github.com/TransbankDevelopers/transbank-plugin-opencart-webpay-rest/issues/new) con tu sugerencia, bug, problema, etc.

# plugin_prestashop.md

Source: https://www.transbankdevelopers.cl/plugin/prestashop/

Webpay REST Prestashop
Webpay REST
Descripción
Este plugin oficial ha sido creado para que puedas integrar Webpay fácilmente en tu comercio, basado en Prestashop.
Estás viendo la nueva documentación REST de este plugin. Si aún estás usando la versión anterior SOAP (la que te solicita certificados y una llave privada), revisa este video para actualizarte.
Requisitos
Debes tener instalado previamente [Prestashop](https://prestashop.com/).
Asegúrate de tener habilitados los siguientes módulos / extensiones para PHP:
- PHP 7.0 o superior
Al instalar el plugin, podrás revisar si todas estos requisitos se cumplen, a través de la pantalla de diagnóstico que se incluye.
Esta pantalla de diagnóstico se encuentra en la sección de configuración del plugin (en donde configuras tu código de comercio y tu llave secreta). Ahí debes presionar el botón "Información del sistema"
Instalación
[Descargar el archivo .zip del plugin](https://github.com/TransbankDevelopers/transbank-plugin-prestashop-webpay-rest/releases/latest)- Sube el archivo zip en la sección Plugin > Subir nuevo plugin en el administrador de tu Prestashop
Las instrucciones detalladas de instalación las puedes encontrar en el [siguiente link](https://github.com/TransbankDevelopers/transbank-plugin-prestashop-webpay-rest/blob/master/docs/INSTALLATION.md).
Ambiente de pruebas
Una vez instalado el plugin, este viene configurado en el ambiente de Integración de Transbank, por lo que puedes realizar todas las pruebas de pago que necesites, ya que no se usa dinero real.
En este ambiente solo funcionan las tarjetas de crédito y débito de prueba que puedes [encontrar acá](https://www.transbankdevelopers.cl/documentacion/como_empezar#ambiente-de-integracion).
Obtener tu llave secreta (proceso de validación)
Para usar el plugin en el ambiente de producción (donde se utiliza dinero real), necesitas tener tu llave secreta, que es un código especial que está asociado a tu código de comercio.
Para obtenerla necesitas pasar un proceso de validación, que está [explicado acá](https://www.transbankdevelopers.cl/documentacion/como_empezar#el-proceso-de-validacion).
Al finalizar este proceso de validación, obtendrás tu llave secreta.
Nota: Esta llave secreta es como la contraseña de tu código de comercio, por lo que no debes compartirla. Se usa para identificar que tu comercio es quién realmente está realizando cada operación (transacción, anulación de un pago, etc).
Puesta en producción
Si ya tienes tu código de comercio de producción y llave secreta, solo debes entrar a la configuración de tu plugin ([instrucciones en este link](https://github.com/TransbankDevelopers/transbank-plugin-prestashop-webpay-rest/blob/master/docs/INSTALLATION.md#configuraci%C3%B3n)) y colocar:
- Ambiente: Producción
- Código de comercio: tu código de comercio de producción
- Api Key: Tu llave secreta
Al guardar, el plugin funcionará inmediatamente en ambiente de producción y podrás operar con tarjetas y transacciones reales. Se te solicitará realizar una transacción real en este ambiente de producción por $50 para finalizar tu proceso.
Problemas, Dudas, Sugerencias
Si tienes algún problema, duda o sugerencia, puedes contactarnos en nuestra comunidad de Slack, a la que puedes [unirte acá](https://invitacion-slack.transbankdevelopers.cl/slack_community)
Adicionalmente, puedes revisar si más comercios han presentado algún error o dudas similares en los [issues del repositorio github](https://github.com/TransbankDevelopers/transbank-plugin-prestashop-webpay-rest/issues). Si nadie ha comentado algo similar, puedes [crear un nuevo issue](https://github.com/TransbankDevelopers/transbank-plugin-prestashop-webpay-rest/issues/new) con tu sugerencia, bug, problema, etc.

# plugin_prestashop_webpay.md

Source: https://www.transbankdevelopers.cl/plugin/prestashop/webpay

Webpay REST Prestashop
Webpay REST
Descripción
Este plugin oficial ha sido creado para que puedas integrar Webpay fácilmente en tu comercio, basado en Prestashop.
Estás viendo la nueva documentación REST de este plugin. Si aún estás usando la versión anterior SOAP (la que te solicita certificados y una llave privada), revisa este video para actualizarte.
Requisitos
Debes tener instalado previamente [Prestashop](https://prestashop.com/).
Asegúrate de tener habilitados los siguientes módulos / extensiones para PHP:
- PHP 7.0 o superior
Al instalar el plugin, podrás revisar si todas estos requisitos se cumplen, a través de la pantalla de diagnóstico que se incluye.
Esta pantalla de diagnóstico se encuentra en la sección de configuración del plugin (en donde configuras tu código de comercio y tu llave secreta). Ahí debes presionar el botón "Información del sistema"
Instalación
[Descargar el archivo .zip del plugin](https://github.com/TransbankDevelopers/transbank-plugin-prestashop-webpay-rest/releases/latest)- Sube el archivo zip en la sección Plugin > Subir nuevo plugin en el administrador de tu Prestashop
Las instrucciones detalladas de instalación las puedes encontrar en el [siguiente link](https://github.com/TransbankDevelopers/transbank-plugin-prestashop-webpay-rest/blob/master/docs/INSTALLATION.md).
Ambiente de pruebas
Una vez instalado el plugin, este viene configurado en el ambiente de Integración de Transbank, por lo que puedes realizar todas las pruebas de pago que necesites, ya que no se usa dinero real.
En este ambiente solo funcionan las tarjetas de crédito y débito de prueba que puedes [encontrar acá](https://www.transbankdevelopers.cl/documentacion/como_empezar#ambiente-de-integracion).
Obtener tu llave secreta (proceso de validación)
Para usar el plugin en el ambiente de producción (donde se utiliza dinero real), necesitas tener tu llave secreta, que es un código especial que está asociado a tu código de comercio.
Para obtenerla necesitas pasar un proceso de validación, que está [explicado acá](https://www.transbankdevelopers.cl/documentacion/como_empezar#el-proceso-de-validacion).
Al finalizar este proceso de validación, obtendrás tu llave secreta.
Nota: Esta llave secreta es como la contraseña de tu código de comercio, por lo que no debes compartirla. Se usa para identificar que tu comercio es quién realmente está realizando cada operación (transacción, anulación de un pago, etc).
Puesta en producción
Si ya tienes tu código de comercio de producción y llave secreta, solo debes entrar a la configuración de tu plugin ([instrucciones en este link](https://github.com/TransbankDevelopers/transbank-plugin-prestashop-webpay-rest/blob/master/docs/INSTALLATION.md#configuraci%C3%B3n)) y colocar:
- Ambiente: Producción
- Código de comercio: tu código de comercio de producción
- Api Key: Tu llave secreta
Al guardar, el plugin funcionará inmediatamente en ambiente de producción y podrás operar con tarjetas y transacciones reales. Se te solicitará realizar una transacción real en este ambiente de producción por $50 para finalizar tu proceso.
Problemas, Dudas, Sugerencias
Si tienes algún problema, duda o sugerencia, puedes contactarnos en nuestra comunidad de Slack, a la que puedes [unirte acá](https://invitacion-slack.transbankdevelopers.cl/slack_community)
Adicionalmente, puedes revisar si más comercios han presentado algún error o dudas similares en los [issues del repositorio github](https://github.com/TransbankDevelopers/transbank-plugin-prestashop-webpay-rest/issues). Si nadie ha comentado algo similar, puedes [crear un nuevo issue](https://github.com/TransbankDevelopers/transbank-plugin-prestashop-webpay-rest/issues/new) con tu sugerencia, bug, problema, etc.

# plugin_virtuemart.md

Source: https://www.transbankdevelopers.cl/plugin/virtuemart/

Webpay REST Virtuemart
Webpay REST
Descripción
Este plugin oficial ha sido creado para que puedas integrar Webpay fácilmente en tu comercio, basado en Virtuemart.
Requisitos
Debes tener instalado previamente [Virtuemart](https://virtuemart.net/).
Asegúrate de tener habilitados los siguientes módulos / extensiones para PHP:
- OpenSSL 1.0.1 o superior
- SimpleXML
- DOM 2.7.8 o superior
- PHP 7.0 o superior
Al instalar el plugin, podrás revisar si todas estos requisitos se cumplen, a través de la pantalla de diagnóstico que se incluye.
Esta pantalla de diagnóstico se encuentra en la sección de configuración del plugin (en donde configuras tu código de comercio y tu llave secreta). Ahí debes presionar el botón "Información del sistema"
Instalación
[Descargar el archivo .zip del plugin](https://github.com/TransbankDevelopers/transbank-plugin-virtuemart-webpay-rest/releases/latest)- Sube el archivo zip en la sección Plugin > Subir nuevo plugin en el administrador de tu Virtuemart
Las instrucciones detalladas de instalación las puedes encontrar en el [siguiente link](https://github.com/TransbankDevelopers/transbank-plugin-virtuemart-webpay-rest/blob/master/docs/INSTALLATION.md).
Ambiente de pruebas
Una vez instalado el plugin, este viene configurado en el ambiente de Integración de Transbank, por lo que puedes realizar todas las pruebas de pago que necesites, ya que no se usa dinero real.
En este ambiente solo funcionan las tarjetas de crédito y débito de prueba que puedes [encontrar acá](https://www.transbankdevelopers.cl/documentacion/como_empezar#ambiente-de-integracion).
Obtener tu llave secreta (proceso de validación)
Para usar el plugin en el ambiente de producción (donde se utiliza dinero real), necesitas tener tu llave secreta, que es un código especial que está asociado a tu código de comercio.
Para obtenerla necesitas pasar un proceso de validación, que está [explicado acá](https://transbankdevelopers.cl/documentacion/como_empezar#puesta-en-produccion).
Al finalizar este proceso de validación, obtendrás tu llave secreta.
Nota: Esta llave secreta es como la contraseña de tu código de comercio, por lo que no debes compartirla. Se usa para identificar que tu comercio es quién realmente está realizando cada operación (transacción, anulación de un pago, etc).
Puesta en producción
Si ya tienes tu código de comercio de producción y llave secreta, solo debes entrar a la configuración de tu plugin ([instrucciones en este link](https://github.com/TransbankDevelopers/transbank-plugin-virtuemart-webpay-rest/blob/master/docs/INSTALLATION.md#configuraci%C3%B3n)) y colocar:
- Ambiente: Producción
- Código de comercio: tu código de comercio de producción
- Api Key: Tu llave secreta
Al guardar, el plugin funcionará inmediatamente en ambiente de producción y podrás operar con tarjetas y transacciones reales.
Problemas, Dudas
Si tienes algún problema, duda o sugerencia, puedes contactarnos en nuestra comunidad de Slack, a la que puedes [unirte acá](https://invitacion-slack.transbankdevelopers.cl/slack_community)
Adicionalmente, puedes revisar si más comercios han presentado algun error/dudas similares en los [issues del repositorio github](https://github.com/TransbankDevelopers/transbank-plugin-virtuemart-webpay-rest/issues). Si nadie ha comentado algo similar, puedes [crear un nuevo issue](https://github.com/TransbankDevelopers/transbank-plugin-virtuemart-webpay-rest/issues/new) con tu sugerencia, bug, problema, etc.

# plugin_virtuemart_webpay.md

Source: https://www.transbankdevelopers.cl/plugin/virtuemart/webpay

Webpay REST Virtuemart
Webpay REST
Descripción
Este plugin oficial ha sido creado para que puedas integrar Webpay fácilmente en tu comercio, basado en Virtuemart.
Requisitos
Debes tener instalado previamente [Virtuemart](https://virtuemart.net/).
Asegúrate de tener habilitados los siguientes módulos / extensiones para PHP:
- OpenSSL 1.0.1 o superior
- SimpleXML
- DOM 2.7.8 o superior
- PHP 7.0 o superior
Al instalar el plugin, podrás revisar si todas estos requisitos se cumplen, a través de la pantalla de diagnóstico que se incluye.
Esta pantalla de diagnóstico se encuentra en la sección de configuración del plugin (en donde configuras tu código de comercio y tu llave secreta). Ahí debes presionar el botón "Información del sistema"
Instalación
[Descargar el archivo .zip del plugin](https://github.com/TransbankDevelopers/transbank-plugin-virtuemart-webpay-rest/releases/latest)- Sube el archivo zip en la sección Plugin > Subir nuevo plugin en el administrador de tu Virtuemart
Las instrucciones detalladas de instalación las puedes encontrar en el [siguiente link](https://github.com/TransbankDevelopers/transbank-plugin-virtuemart-webpay-rest/blob/master/docs/INSTALLATION.md).
Ambiente de pruebas
Una vez instalado el plugin, este viene configurado en el ambiente de Integración de Transbank, por lo que puedes realizar todas las pruebas de pago que necesites, ya que no se usa dinero real.
En este ambiente solo funcionan las tarjetas de crédito y débito de prueba que puedes [encontrar acá](https://www.transbankdevelopers.cl/documentacion/como_empezar#ambiente-de-integracion).
Obtener tu llave secreta (proceso de validación)
Para usar el plugin en el ambiente de producción (donde se utiliza dinero real), necesitas tener tu llave secreta, que es un código especial que está asociado a tu código de comercio.
Para obtenerla necesitas pasar un proceso de validación, que está [explicado acá](https://transbankdevelopers.cl/documentacion/como_empezar#puesta-en-produccion).
Al finalizar este proceso de validación, obtendrás tu llave secreta.
Nota: Esta llave secreta es como la contraseña de tu código de comercio, por lo que no debes compartirla. Se usa para identificar que tu comercio es quién realmente está realizando cada operación (transacción, anulación de un pago, etc).
Puesta en producción
Si ya tienes tu código de comercio de producción y llave secreta, solo debes entrar a la configuración de tu plugin ([instrucciones en este link](https://github.com/TransbankDevelopers/transbank-plugin-virtuemart-webpay-rest/blob/master/docs/INSTALLATION.md#configuraci%C3%B3n)) y colocar:
- Ambiente: Producción
- Código de comercio: tu código de comercio de producción
- Api Key: Tu llave secreta
Al guardar, el plugin funcionará inmediatamente en ambiente de producción y podrás operar con tarjetas y transacciones reales.
Problemas, Dudas
Si tienes algún problema, duda o sugerencia, puedes contactarnos en nuestra comunidad de Slack, a la que puedes [unirte acá](https://invitacion-slack.transbankdevelopers.cl/slack_community)
Adicionalmente, puedes revisar si más comercios han presentado algun error/dudas similares en los [issues del repositorio github](https://github.com/TransbankDevelopers/transbank-plugin-virtuemart-webpay-rest/issues). Si nadie ha comentado algo similar, puedes [crear un nuevo issue](https://github.com/TransbankDevelopers/transbank-plugin-virtuemart-webpay-rest/issues/new) con tu sugerencia, bug, problema, etc.

# plugin_woocommerce.md

Source: https://www.transbankdevelopers.cl/plugin/woocommerce/

WooCommerce | Plugin Webpay Plus
Webpay REST
Descripción
Este plugin oficial ha sido creado para que puedas integrar Webpay fácilmente en tu comercio, basado en WooCommerce.
Estás viendo la nueva documentación REST de este plugin. Si aún estás usando la versión anterior SOAP (la que te solicita certificados y una llave privada), revisa este video para actualizarte.
Requisitos
Debes tener instalado previamente [WooCommerce](https://woocommerce.com/).
Asegúrate de tener habilitados los siguientes módulos / extensiones para PHP:
- Extensión de PHP JSON (ext-json)
- OpenSSL 1.0.1 o superior
- DOM 2.7.8 o superior
- PHP 7.4 o superior
Al instalar el plugin, podrás revisar si todas estos requisitos se cumplen, a través de la pantalla de diagnóstico que se incluye.
Esta pantalla de diagnóstico se encuentra en la sección de configuración del plugin (en donde configuras tu código de comercio y tu llave secreta). Ahí verás un tab "Diagnóstico".
Instalación
Como se puede ver en el video, los pasos para instalar el plugin son los siguientes:
- Entra al panel de administración de tu Wordpress > Plugins > Agregar Nuevo
- Busca el plugin "Transbank Webpay Plus REST", instálalo y actívalo.
Instalación manual
Si no puedes instalarlo de manera automática, también puedes descargar el archivo .zip del plugin y cargarlo manualmente en tu Wordpress.
[Descargar el archivo .zip del plugin](https://github.com/TransbankDevelopers/transbank-plugin-woocommerce-webpay-rest/releases/latest)- Sube el archivo zip en la sección Plugin > Subir nuevo plugin en el administrador de tu Wordpress
Las instrucciones detalladas de instalación las puedes encontrar en el
[siguiente link](https://github.com/TransbankDevelopers/transbank-plugin-woocommerce-webpay-rest/blob/master/docs/INSTALLATION.md).
Cómo usar
Una vez instalado, se agregará un nuevo método de pago al proceso de checkout. Si no se activa correctamente, revisa que el plugin esté activo y que tu tienda está configurada en Pesos Chilenos.
Ambiente de pruebas
Una vez instalado el plugin, este viene configurado en el ambiente de Integración de Transbank, por lo que puedes realizar todas las pruebas de pago que necesites, ya que no se usa dinero real.
En este ambiente solo funcionan las tarjetas de crédito y débito de prueba que puedes [encontrar acá](https://www.transbankdevelopers.cl/documentacion/como_empezar#ambiente-de-integracion).
Anulaciones
Dentro del detalle de una orden, podrás realizar una anulación o reversa de un pago.
Puedes ver el detalle de una reversa o anulación ("refund") [en este link](https://transbankdevelopers.cl/documentacion/webpay-plus#reversar-o-anular-una-transaccion)
Las tarjetas de débito solo soportan Reversas (refunds realizados dentro de los primeros 30 minutos de aprobada la transacción). En tarjetas de crédito se permiten reversas, anulaciones y anulaciones parciales.
En el siguiente video te mostramos como realizar el proceso:
Consultar estado
También en el detalle de una orden, se puede revisar el estado actual de una transacción (hasta por 7 días de realizada la transacción). Se puede revisar si una transacción está autorizada, anulada, parcialmente anulada o reversada.
En el siguiente video te dejamos las instrucciones para realizar este proceso
Obtener tu llave secreta (proceso de validación)
Para usar el plugin en el ambiente de producción (donde se utiliza dinero real), necesitas tener tu llave secreta, que es un código especial que está asociado a tu código de comercio.
Para obtenerla necesitas pasar un proceso de validación, que está [explicado acá](https://www.transbankdevelopers.cl/documentacion/como_empezar#el-proceso-de-validacion).
Este proceso pretende verificar que el comercio transacciona de manera segura y sin problemas. Esta validación es un requisito para dejar al comercio en producción y no se permitirá que un comercio utilice productivamente el servicio Webpay sin poseer esta validación.
Para integración con plugins, creamos un nuevo formulario online para que comiences el proceso de validación: [ Comenzar formulario de integración ](https://form.typeform.com/to/fZqOJyFZ?typeform-medium=embed-snippet)
Soporte validará el formulario enviado y, de estar todo correcto, se te notificará la conformidad para pasar a producción, recibiendo tu llave secreta (Api Key Secret) de producción y algunas instrucciones.
Nota: Esta llave secreta es una contraseña de tu código de comercio, por lo que no debes compartirla.
Puesta en producción
Si ya tienes tu código de comercio de producción y llave secreta, solo debes entrar a la configuración de tu plugin ([instrucciones en este link](https://github.com/TransbankDevelopers/transbank-plugin-woocommerce-webpay-rest/blob/master/docs/INSTALLATION.md#configuraci%C3%B3n)) y colocar:
- Ambiente: Producción
- Código de comercio: tu código de comercio de producción
- Api Key: Tu llave secreta
Al guardar, el plugin funcionará inmediatamente en ambiente de producción y podrás operar con tarjetas y transacciones reales. Se te solicitará realizar una transacción real en este ambiente de producción por $50 para finalizar tu proceso.
Problemas, Dudas, Sugerencias
Si tienes algún problema, duda o sugerencia, puedes contactarnos en nuestra comunidad de Slack, a la que puedes [unirte acá](https://invitacion-slack.transbankdevelopers.cl/slack_community)
Adicionalmente, puedes revisar si más comercios han presentado algún error o dudas similares en los [issues del repositorio github](https://github.com/TransbankDevelopers/transbank-plugin-woocommerce-webpay-rest/issues). Si nadie ha comentado algo similar, puedes [crear un nuevo issue](https://github.com/TransbankDevelopers/transbank-plugin-woocommerce-webpay-rest/issues/new) con tu sugerencia, bug, problema, etc.

# plugin_woocommerce_webpay.md

Source: https://www.transbankdevelopers.cl/plugin/woocommerce/webpay

WooCommerce | Plugin Webpay Plus
Webpay REST
Descripción
Este plugin oficial ha sido creado para que puedas integrar Webpay fácilmente en tu comercio, basado en WooCommerce.
Estás viendo la nueva documentación REST de este plugin. Si aún estás usando la versión anterior SOAP (la que te solicita certificados y una llave privada), revisa este video para actualizarte.
Requisitos
Debes tener instalado previamente [WooCommerce](https://woocommerce.com/).
Asegúrate de tener habilitados los siguientes módulos / extensiones para PHP:
- Extensión de PHP JSON (ext-json)
- OpenSSL 1.0.1 o superior
- DOM 2.7.8 o superior
- PHP 7.4 o superior
Al instalar el plugin, podrás revisar si todas estos requisitos se cumplen, a través de la pantalla de diagnóstico que se incluye.
Esta pantalla de diagnóstico se encuentra en la sección de configuración del plugin (en donde configuras tu código de comercio y tu llave secreta). Ahí verás un tab "Diagnóstico".
Instalación
Como se puede ver en el video, los pasos para instalar el plugin son los siguientes:
- Entra al panel de administración de tu Wordpress > Plugins > Agregar Nuevo
- Busca el plugin "Transbank Webpay Plus REST", instálalo y actívalo.
Instalación manual
Si no puedes instalarlo de manera automática, también puedes descargar el archivo .zip del plugin y cargarlo manualmente en tu Wordpress.
[Descargar el archivo .zip del plugin](https://github.com/TransbankDevelopers/transbank-plugin-woocommerce-webpay-rest/releases/latest)- Sube el archivo zip en la sección Plugin > Subir nuevo plugin en el administrador de tu Wordpress
Las instrucciones detalladas de instalación las puedes encontrar en el
[siguiente link](https://github.com/TransbankDevelopers/transbank-plugin-woocommerce-webpay-rest/blob/master/docs/INSTALLATION.md).
Cómo usar
Una vez instalado, se agregará un nuevo método de pago al proceso de checkout. Si no se activa correctamente, revisa que el plugin esté activo y que tu tienda está configurada en Pesos Chilenos.
Ambiente de pruebas
Una vez instalado el plugin, este viene configurado en el ambiente de Integración de Transbank, por lo que puedes realizar todas las pruebas de pago que necesites, ya que no se usa dinero real.
En este ambiente solo funcionan las tarjetas de crédito y débito de prueba que puedes [encontrar acá](https://www.transbankdevelopers.cl/documentacion/como_empezar#ambiente-de-integracion).
Anulaciones
Dentro del detalle de una orden, podrás realizar una anulación o reversa de un pago.
Puedes ver el detalle de una reversa o anulación ("refund") [en este link](https://transbankdevelopers.cl/documentacion/webpay-plus#reversar-o-anular-una-transaccion)
Las tarjetas de débito solo soportan Reversas (refunds realizados dentro de los primeros 30 minutos de aprobada la transacción). En tarjetas de crédito se permiten reversas, anulaciones y anulaciones parciales.
En el siguiente video te mostramos como realizar el proceso:
Consultar estado
También en el detalle de una orden, se puede revisar el estado actual de una transacción (hasta por 7 días de realizada la transacción). Se puede revisar si una transacción está autorizada, anulada, parcialmente anulada o reversada.
En el siguiente video te dejamos las instrucciones para realizar este proceso
Obtener tu llave secreta (proceso de validación)
Para usar el plugin en el ambiente de producción (donde se utiliza dinero real), necesitas tener tu llave secreta, que es un código especial que está asociado a tu código de comercio.
Para obtenerla necesitas pasar un proceso de validación, que está [explicado acá](https://www.transbankdevelopers.cl/documentacion/como_empezar#el-proceso-de-validacion).
Este proceso pretende verificar que el comercio transacciona de manera segura y sin problemas. Esta validación es un requisito para dejar al comercio en producción y no se permitirá que un comercio utilice productivamente el servicio Webpay sin poseer esta validación.
Para integración con plugins, creamos un nuevo formulario online para que comiences el proceso de validación: [ Comenzar formulario de integración ](https://form.typeform.com/to/fZqOJyFZ?typeform-medium=embed-snippet)
Soporte validará el formulario enviado y, de estar todo correcto, se te notificará la conformidad para pasar a producción, recibiendo tu llave secreta (Api Key Secret) de producción y algunas instrucciones.
Nota: Esta llave secreta es una contraseña de tu código de comercio, por lo que no debes compartirla.
Puesta en producción
Si ya tienes tu código de comercio de producción y llave secreta, solo debes entrar a la configuración de tu plugin ([instrucciones en este link](https://github.com/TransbankDevelopers/transbank-plugin-woocommerce-webpay-rest/blob/master/docs/INSTALLATION.md#configuraci%C3%B3n)) y colocar:
- Ambiente: Producción
- Código de comercio: tu código de comercio de producción
- Api Key: Tu llave secreta
Al guardar, el plugin funcionará inmediatamente en ambiente de producción y podrás operar con tarjetas y transacciones reales. Se te solicitará realizar una transacción real en este ambiente de producción por $50 para finalizar tu proceso.
Problemas, Dudas, Sugerencias
Si tienes algún problema, duda o sugerencia, puedes contactarnos en nuestra comunidad de Slack, a la que puedes [unirte acá](https://invitacion-slack.transbankdevelopers.cl/slack_community)
Adicionalmente, puedes revisar si más comercios han presentado algún error o dudas similares en los [issues del repositorio github](https://github.com/TransbankDevelopers/transbank-plugin-woocommerce-webpay-rest/issues). Si nadie ha comentado algo similar, puedes [crear un nuevo issue](https://github.com/TransbankDevelopers/transbank-plugin-woocommerce-webpay-rest/issues/new) con tu sugerencia, bug, problema, etc.

# producto_patpass.md

Source: https://www.transbankdevelopers.cl/producto/patpass

PatPass
PatPass es el servicio de Transbank que permite el pago automático de cuentas mediante tarjetas de crédito. Es la solución ideal para pago de cuentas, centros educativos, aportes a fundaciones, y otros comercios e instituciones.
PatPass opera exclusivamente con tarjetas de crédito (nacionales e internacionales). No se aceptan tarjetas de débito Redcompra. No se contempla el uso de cuotas.
PatPass se relaciona con los comercios y emisores mediante las siguientes plataformas:
Transdata es la plataforma que Transbank pone a disposición de los comercios para que puedan revisar el resultado de los cobros generados a sus clientes suscritos a PatPass, permitiendo además la administración de su universo de suscripciones.
PatPass Emisor es la plataforma que le permite al tarjetahabiente gestionar los pagos automáticos existentes en su tarjeta desde el sitio web de su banco emisor.
PatPass by Webpay
Mediante PatPass by Webpay el tarjetahabiente genera un pago automático con Tarjeta de Crédito de un producto y/o servicio por un monto fijo, efectuando el primer pago en línea a través de Webpay Plus y luego efectuándose el cobro mensualmente de forma automática a través del motor de PatPass, con una fecha de término definida por el comercio.
En cuanto a monedas, PatPass by Webpay permite realizar cargos en Peso, UF y Dólar. Para cobros en pesos y UF PatPass asignará un mismo código de comercio. Para Dólar (en el caso en que el comercio haya firmado el Anexo de Contrato Dólar) se asignará un código de comercio diferente. Los cobros en UF serán valorizado al mismo día efectuado el cobro. En el caso que el cobro sea un día no hábil, éste se cobrará al día hábil siguiente.
PatPass by Webpay es un canal utilizado sólo para dar de alta pagos automáticos. Si el comercio requiere dar de baja un pago automático, debe utilizar los otros canales existentes (como Transdata).
El comercio deberá almacenar la información de todas las transacciones efectuadas a través del producto PatPass by Webpay, debiendo mantener los respectivos registros a lo menos por el plazo de un año desde la fecha de cada operación, a modo de respaldo de las ventas efectuadas y de los servicios prestados. Esta información deberá ser puesta a disposición de Transbank cada vez y tan pronto éste la requiera. La información mínima que deberá almacenar el Establecimiento Comercial por cada una de las transacciones es la siguiente:
- Código de Comercio asignado por Transbank.
- Número de Orden de Pedido.
- Fecha y hora de la transacción.
- Monto y moneda de la operación.
- Número de Código de Autorización entregado por Transbank.
- Identificación de Servicio.
- Descripción de bienes vendidos o servicios prestados.
- Nombre del tarjetahabiente que efectúa la compra.
- Campo de autenticación emisor.
- Fecha de vencimiento de la suscripción.
- Mail de contacto de Tarjetahabiente.
Flujo de una transacción PatPass by Webpay
El flujo de una transacción PatPass by Webpay se puede resumir en los siguientes pasos:
- El tarjetahabiente navega dentro de la página del comercio.
- El tarjetahabiente selecciona la opción de pago PatPass by Webpay y completa la información requerida por el comercio (RUT, nombre, email, teléfono)
- Luego de completar la información, el tarjetahabiente es redirigido a Webpay donde se le informa el monto y la fecha de término de su suscripción mensual. En el formulario de Webpay el tarjetahabiente ingresa la información de su tarjeta.
- El emisor de la tarjeta autentica al tarjetahabiente antes de realizar la transacción financiera, con el objetivo de validar que la tarjeta este siendo utilizada por el titular.
- Si la autenticación es exitosa, PatPass by Webpay contrasta la información del cliente enviada por el emisor con la información provista por el comercio para asegurar que coincidan. De ser así, se procede con la autorización y captura del monto cobrado.
- Si dicha autorización y captura es exitosa, Transbank procede de forma automática y transparente (tanto para el comercio como para el tarjetahabiente) a realizar la inscripción de la recurrencia en la Plataforma PatPass.
- Finalmente se enviará un correo electrónico al comercio y otro correo electrónico al tarjetahabiente con la información del pago automático activado.
Una vez completada la operación, el comercio podrá visualizar el detalle de las transacciones y consultar los cobros recurrentes mediante Transdata. Por parte del tarjetahabiente, podrá visualizar la inscripción de este cobro mensual a través del PatPass Emisor (HomeBanking) en su respectivo Banco. Allí podrá observar el canal de origen que corresponde a “Webpay Mensual” y la fecha de término de este cobro recurrente.
En caso que un cobro no sea exitoso o el pago automático sea dado de baja, el tarjetahabiente también recibirá una alerta por correo electrónico (tal como la recibe en la inscripción descrita anteriormente en el punto 7).
PatPass Comercio
Mediante PatPass Comercio el tarjetahabiente genera una suscripción de pago automático con Tarjeta de Crédito por un producto o servicio por un monto fijo, efectuando el primer pago en línea a través de Plataforma PatPass y luego efectuándose el cobro mensualmente de forma automática a traves del mismo motor PatPass, con una fecha de término definida por el comercio.
En cuanto a monedas, PatPass Comercio solo permite utilizar Peso Chileno. Para cobros en otras divisas, el comercio tiene que encargase de la conversión con las tasas que esto conlleva.
PatPass Comercio es un canal utilizado sólo para dar de alta pagos automáticos. Si el comercio requiere dar de baja un pago automático, debe utilizar los otros canales existentes (como Transdata).
El comercio deberá almacenar la información de todas las transacciones efectuadas a través del producto PatPass Comercio, debiendo mantener los respectivos registros a lo menos por el plazo de un año desde la fecha de cada operación, a modo de respaldo de las ventas efectuadas y de los servicios prestados. Esta información deberá ser puesta a disposición de Transbank cada vez y tan pronto éste la requiera. La información mínima que deberá almacenar el Establecimiento Comercial por cada una de las transacciones es la siguiente:
- Código de Comercio asignado por Transbank.
- Número de Orden de Pedido.
- Fecha y hora de la transacción.
- Monto y moneda de la operación.
- Número de Código de Autorización entregado por Transbank.
- Identificación de Servicio.
- Descripción de bienes vendidos o servicios prestados.
- Nombre del tarjetahabiente que efectúa la compra.
- Campo de autenticación emisor.
- Fecha de vencimiento de la suscripción.
- Mail de contacto de Tarjetahabiente.
Flujo de una transacción PatPass Comercio
El flujo de transacción PatPass Comercio se puede resumir en los siguientes pasos:
- El tarjetahabiente navega dentro de la página del comercio.
- El tarjetahabiente selecciona la opción de pago PatPass Comercio y completa la información requerida por el comercio (RUT, nombre completo, email, dirección, teléfonos móvil y fijo).
- Una vez enviada la información el cliente es redirigido a Webpay donde se le informa tanto el monto, como la fecha de término de la suscripción mensual, en este formulario debe ingresar la información de su tarjeta.
- El emisor de la tarjeta autentica al tarjetahabiente antes de realizar la transacción financiera, con el objetivo de validar que la tarjeta este siendo utilizada por el titular.
- Si la autenticación es exitosa, PatPass Comercio contrasta la información del cliente enviada por el emisor con la información provista por el comercio para asegurar que coincidan. De ser así, se procede con la autorización y captura del monto cobrado.
- Si dicha autorización y captura es exitosa, Transbank procede de forma automática y transparente (tanto para el comercio como para el tarjetahabiente) a realizar la inscripción de la recurrencia en la Plataforma PatPass.
- Finalmente se enviará un correo electrónico al comercio y otro correo electrónico al tarjetahabiente con la información del pago automático activado.
Una vez completada toda la operación el comercio podrá visualizar el detalle de las transacciones y consultar por los cobros recurrentes mediante Transadata. Por parte del tarjetahabiente, podrá visualizar la inscripción de este cobro mensual a través del PatPass Emisor (HomeBanking) en su respectivo Banco. Allí podrá observar el canal de origen que corresponde a “Webpay Mensual” y la fecha de término de este cobro recurrente.
Anulaciones PatPass
Una Anulación corresponde a la revocación de una venta ya autorizada y capturada por Transbank.
Las anulaciones de ventas podrán solicitarse por:
- Ingresando a portal web de Transbank.
- Llamando al Servicio al Cliente.

# producto_posbluetooth.md

Source: https://www.transbankdevelopers.cl/producto/posbluetooth

POS Integrado Bluetooth
Una solución presencial que permite a un POS inalámbrico provisto por Transbank operar de manera integrada a un sistema de caja del comercio (fijo o móvil), conectado vía bluetooth, para cobros con tarjeta de crédito, débito y prepago.
Especial para comercio que requieren gran movilidad de puntos de ventas dentro de un mismo local o atención en terreno, tales como: flotas de distribución de productos, delivery, rompe filas en tiendas de departamento, islas de atención, etc.
Permite mantener una gestión integrada de los puntos de venta con información en línea de cada una de sus transacciones.
Sin costo de reparación o atención de fallas.
| Pos Integrado Bluetooth | Funcionalidades |
|---|---|
| Operaciones Administrativas | Carga de Llaves Cierre de terminal Detalle de Venta Emitir Voucher de venta en caja (1) Polling Totales de venta Multicomercio |
| Medios de pago | Débito: Redcompra, Maestro y Electrón Crédito: Visa, MasterCard, Magna, Amex Prepago |
| Funciones Débito | Venta Normal Venta con propina Venta con Vuelto |
| Funciones Crédito | Venta Normal Venta en cuotas con y sin interés Anulación (2) Venta con propina |
| Funciones Tarjetas Comerciales | No acepta tarjetas comerciales |
| Terminal (Ingénico Link 2500) |
Funcionalidades |
|---|---|
| Operaciones Administrativas | Sincronización Desincronización |
(1) Funcionalidad que será habilitada por el cliente en su sistema de caja. (2) Las anulaciones también pueden ser realizadas en Portal Web de Transbank.
Características del Terminal
Comodato: Transbank provee el equipo en arriendo mensual a un costo menor que un POS estándar.
Máxima seguridad: encriptación 3DES bajo normas PCI-PTS.
Medios de Pago: lectura de banda, chip EMV (con y sin contacto) y wallet.
Amigable: de fácil uso, liviano con pantalla en color (2,4”).
Batería: duración promedio de 6 a 7 horas.
Contratación del producto
Disponibles a través de ejecutivo comercial o por solicitud al Call Center.
Los comercios deberán firmar un anexo de contrato de afiliación para el producto “POS Integrado Bluetooth”.
Las tarifas de arriendo de los terminales están divididas por tramos de cantidad de equipos.
Las comisiones por venta están sujeta a lo indicado en el sitio web de Transbank, según rubros de cada comercio.
Requisitos Tecnológicos del Comercio
Punto de Venta: contar con un sistema de caja movilizado instalado en un equipo Tablet, Smartphone o equipo móvil, con sistema operativo Android, con conexión Bluetooth 4.x.
Conexión Internet: el comercio deberá proveer acceso a servicio de Internet para operación de la caja móvil con una conexión GPRS o WiFi según corresponda.
Integración: efectuar integración entre el POS y el sistema de caja movilizado para comunicar los datos de venta y autorización de cada transacción (se requiere habilitar integración con apoyo TBK (ver sección integración).
Modelo Post Venta
Consultas
| Canal | Atención Remota | Visita a Terreno |
|---|---|---|
| Contact Center Desde celulares: +56 226612700 Desde Red fija: 600 368 6380 |
Dudas Comerciales Dudas Transaccionales * Uso del equipo |
* Instalación y configuración |
Fallas
| Canal | Atención Remota | Visita a Terreno |
|---|---|---|
| Call Center Fallas Desde celulares: +56 226612700 Desde Red fija: 600 368 6380 Opción 2 |
Tradicional para clientes de venta o arriendo | Reposición de equipos Visitas evaluacion y atención |

# producto_posintegrado.md

Source: https://www.transbankdevelopers.cl/producto/posintegrado

POS Integrado
El POS integrado permite realizar transacciones con tarjeta de Crédito/Débito/Prepago con Transbank utilizando el puerto serial de un PC o Caja. La comunicación con Transbank y la lógica del procesamiento de una transacción financiera es realizada por el equipo POS, facilitando así la integración con un sistema de caja.
Transacciones Soportadas
- Venta.
- Cierre.
- Anulación.
- Última venta.
- Detalle de ventas.
- Totales.
- Carga de llaves.
- Poll (prueba de comunicación POS - caja).
- Cambio a modalidad POS normal.
- Venta multicódigo.
- Ultima venta multicódigo
- Detalle de ventas multicódigo.
Requerimientos
Requisitos en Local
- El comercio debe contar con sistema propio de caja, con las siguientes características deseables:
- Sistema de Lectura de producto (scanner / código).
- Sistema de Stock.
- Sistema de Cuadratura.
- Proveedor de Soporte de Sistema.
- Acceso Remoto.
- La caja debe contar con a lo menos un puerto
RS232
o en su defecto con entrada USB exclusiva para el Dispositivo POS. - El comercio debe disponer en cada local con puntos exclusivos para conectar a Internet vía Lan
RJ45
los POS. - Se recomienda segmentar el ancho de banda con
300 kb
exclusivos para el uso del POS, dado que cuando existen procesos batch, cámaras de seguridad, uso de aplicaciones de escritorio, etc. bajo la mismo segmento pueden afectar una transacción si la banda ancha contratada no es suficientemente alta. - El local debe disponer con un punto de corriente exclusivo de
220v
para enchufar el POS.
Requisitos del Comercio
- El comercio debe contar con una o más áreas encargadas de los siguientes puntos:
- Procedimientos de Contingencia ante caídas de señal Internet y energía eléctrica.
- Procedimiento de Respaldo y Recuperación de operaciones efectuadas en POS Integrado de Transbank.
- Homologación en versiones sistemas de Caja.
- Homologación en Sistema Operativos de Caja.
- Manejo de Claves Supervisora y de usuarios de Sistema Operativo.
- Procedimientos de Seguridad y responsabilidad en el uso de la información proporcionada por Transbank y Clientes.
- Capacitación y divulgación de uso de nuevos sistemas.
- Manuales de Sistemas.
- Soporte de Redes.
Seguridad
Confidencialidad de la Información
De acuerdo a las normativas vigentes, las transacciones con Tarjeta de Crédito y Débito incorporan los siguientes elementos de seguridad en el sistema:
- La información leída en el punto de venta NO es almacenada en ningún sistema.
- Para efectos de cuadratura e identificación de transacciones, se utilizar el NÚMERO DE OPERACIÓN.
Tratamiento de los Tracks de la Tarjeta
La información grabada en el Track I y Track II es leída sólo por los dispositivos de seguridad (POS). Estos dispositivos encriptan el contenido del Track I y Track II.
Tratamiento de datos sensibles
Para asegurar la confidencialidad de la información, los mensajes de las transacciones o al menos los datos sensibles (además del PIN) viajan encriptados en los distintos tramos de la conexión, tanto en el requerimiento como en la respuesta. Como datos sensibles se consideran: número de tarjeta, fecha expiración, número de cuenta y monto de la transacción (dato validado en Autenticación de Mensajes o MAC).
El modelo Master/Session KEY
El método actual de administración de llaves es el llamado Máster/Session Key, en el cual los PED (Pin Entry Device) son cargados en un ambiente seguro con una Master Key y en forma remota se carga la Working Key o Session Key.
El procedimiento actual para cifrar en los Pin Pads un PinBlock es el siguiente:
- Se descifra la Working Key usando la Master Key que tiene cargado el PED.
- Con la Working Key, se cifra el PinBlock y se envía al servidor.
La Working Key se cambia en forma periódica (al menos en cada cierre), para evitar que sea descubierta por terceros.
Este modelo de administración de llaves es el que se usa para las llaves MAC.
El modelo DUKPT – Encriptación de PIN
El nuevo método de administración de llaves para PIN que usará Transbank es el denominado ―Llave Única derivada por transacción o DUKPT por sus iniciales en inglés.
Bajo este método los PED son inicializados en un ambiente seguro, con datos de identificación propios de cada PED (Identificador de la llave de derivación, Identificador de PED único y un contador de transacciones iniciado en cero), más una llave inicial que se calcula usando los datos propios de cada PED y la llave de derivación base. Con esta llave inicial se genera la próxima llave de cifrado para PIN. Este proceso se realiza con una función asimétrica (DUKPT del PinPad), es decir, una función de un solo sentido, de forma que el PED no sea capaz de generar ninguna llave anterior a la actual.
Cálculo de MAC
Para asegurar la integridad de la información que viaja desde y hacia el Autorizador de comercio, se introduce un código de autenticación de mensajes (MAC) el cual es enviado en el mensaje de requerimiento y validado por el Autorizador de Transbank al recibirlo. A su vez, el Autorizador de Transbank envía un código de MAC para el mensaje de respuesta, el cual debe ser validado por la caja. Si la validación que hace la caja del código de MAC es negativa debe generar una reversa. La transacción de reversa debe ser igual a la respuesta recibida pero con el campo RESPONSE CODE con el valor 989 y el campo MESSAGE SUBTYPE en R. Cuando el Autorizador de Transbank detecta un MAC inválido en el mensaje de requerimiento, envía un mensaje de respuesta con código de rechazo 898 (MAC inválido).
Manejo de llaves MAC (Message Authentication Code)
Las llaves criptográficas para la generación de MAC (working key de MAC) se maneja de acuerdo a lo siguiente:
- Las working key son generadas por el sistema de Transbank y transmitidas en línea para cada uno de los terminal ID definidos en el comercio cliente.
- Para la carga y / o cambio de la working keys de MAC se utilizan las transacciones de CIERRE BATCH y CARGA DE LLAVE (Ver Transacciones Administrativas).
Las llaves working keys de MAC se actualizan en cada nueva transacción atendida por Transbank. Por lo que la caja debe registrar esta nueva llave para su uso en la siguiente transacción. Las llaves se deben cambiar automáticamente todos los días. Esto implica que debe existir un procedimiento de inicialización o cierre obligatorio en cada caja (terminal ID) que se ejecuta en forma automática todos los días y que como parte de este procedimiento se envía a Transbank una transacción de CIERRE BATCH o CARGA DE LLAVE por cada caja (terminal ID).
Las working keys (MAC) se transmiten encriptadas utilizando el algoritmo DES (dato a encriptar es la working key) con una llave de encriptación denominada master key, definida por Transbank. Transbank define una master key para PIN y otra master key para MAC.
Transbank carga inicialmente las master keys en cada POS, operación que se realiza previamente a la instalación de éstos en las cajas.
Para la carga de las master keys de PIN y MAC, el modelo de POS utilizado debe contar con un dispositivo cargador de llaves que será administrado por Transbank y que permite:
Ingresar las master keys en el dispositivo, la que no podrá ser modificada, violada o adulterada. Cargar las master keys conectando uno por uno los POS al dispositivo
Manejo de Clave Técnico
Para acceder al Menú de opciones para Técnico, deberá acreditarse con el RUT y la Clave que corresponde a este rut. Esta clave es de generación dinámica, con caducidad máxima en 31 días.
Manejo de Clave Supervisora
En las versiones más antiguas cada comercio tenía una tarjeta supervisora que le permitía autenticarse para realizar cierres, anulaciones y otras operaciones. A partir del año 2011 en adelante, durante el proceso de auto instalación se solicitará la digitación de la clave supervisora, quedando esta almacenada hasta que el comercio desee cambiarla, siendo esta responsabilidad del mismo. Si el comercio olvida esta clave, existe una clave maestra de comercio que permite la digitación de una nueva clave de comercio. Para obtenerla, debe llamar a Servicio al Cliente, desde celulares 600 638 6380 y desde teléfonos fijos +56 2 2661 2700.
Manejo de Clave Maestra de Comercio Activación
La solicitud de esta clave se realiza a Servicio al Cliente, desde celulares 600 638 6380 y desde teléfonos fijos +56 2 2661 2700.

# producto_webpay.md

Source: https://www.transbankdevelopers.cl/producto/webpay

Webpay
Webpay es la pasarela de pago de Transbank para realizar transacciones desde Internet con tarjetas bancarias de crédito y débito Redcompra de manera eficaz y segura.
Un flujo de pago en Webpay generalmente cuenta con los siguientes pasos:
El tarjetahabiente selecciona los productos o servicios a pagar en el sitio del comercio.
El tarjetahabiente elige pagar con Webpay en donde, dependiendo de los productos contratados por el comercio, se despliegan las alternativas de pago: Tarjeta de crédito, débito Redcompra y/o prepago.
Durante el proceso de pago, el emisor de la tarjeta autentica al tarjetahabiente antes de realizar la transacción financiera, con el objetivo de validar que la tarjeta esté siendo utilizada por el titular.
Una vez resuelta la autenticación se procede a autorizar el pago. Webpay entrega al sistema del comercio el resultado de la autorización.
Productos Webpay
A continuación se describen los productos que se ofrecen en los servicios web de Webpay.
Webpay Plus
Webpay Plus permite realizar una solicitud de autorización financiera de un pago con tarjetas de crédito, débito Redcompra o prepago en donde quién realiza el pago ingresa al sitio del comercio, selecciona productos o servicio, e indica los datos asociados a la tarjeta del medio de pago seleccionado anteriormente, esta acción lo realiza en forma segura en Webpay. El comercio que recibe pagos mediante Webpay Plus es identificado mediante un código de comercio.
Es el tipo de transacción mas común, usada para un pago puntual en una tienda simple. Se generará un único cobro para todos los productos o servicios adquiridos por el tarjetahabiente.
Webpay Plus Mall
Webpay Plus Mall permite realizar una solicitud de autorización financiera de un conjunto de pagos con tarjetas de crédito, débito o prepago, a través de una sola transacción unificada. Quién realiza el pago, ingresa al sitio del comercio, selecciona varios productos o servicios (pertenecientes a diferentes códigos de comercio), y selecciona Webpay Plus como medio de pago, realizando la transacción de forma segura en Webpay para el conjunto de pagos. Cada pago tendrá su propio resultado, autorizado o rechazado. El concepto de "mall" agrupa múltiples tiendas. Son dichas tiendas las que pueden generar transacciones. Tanto el mall como cada una de las tiendas asociadas son identificadas por un código de comercio diferente.
El tipo de transacción Mall es útil para proveedores de servicios tecnológicos (PST) que pueden realizar una única integración con Transbank y realizar cobros a nombre de los clientes de dichos servicios tecnológicos. Por ejemplo, una plataforma SaaS puede ser un mall y las empresas clientes de la plataforma pueden ser las tiendas de dicho mall. De esa manera, la recaudación que la plataforma realice irá directo al cliente a nombre del cual realizó cada cobro.
Oneclick Mall
Oneclick Mall permite agrupar pagos en una única transacción Oneclick hacia múltiples códigos de comercios (similar a una transacción Mall). En una transacción de este tipo, al igual que en Oneclick, el tarjetahabiente podrá realizar pagos sin la necesidad de ingresar la información de su tarjeta de crédito en cada uno de ellos. Este tipo de pago facilita la venta, centraliza los pagos, disminuye el tiempo de la transacción y reduce los riesgos de ingreso erróneo de los datos del medio de pago.
Oneclick Mall opera con tarjetas de crédito, prepago y débito Redcompra. El modelo de pago contempla el mismo proceso de enrolamiento que la transacción Oneclick.
De cara al comercio, Oneclick Mall combina dos grupos de beneficios:
Permite que un tarjetahabiente registre su tarjeta una única vez y pague frecuentemente en cualquiera de las tiendas del mall.
Permite que un proveedor de servicios tecnológicos (PST) realice una única integración y haga cobros a nombre de múltiples tiendas clientes.
Al no contar con sistema de autenticación bancaria en los cargos que se realizan después de la autorización, será el comercio el responsable de asumir el riesgo de fraude o desconocimientos de compra que realice un tarjetahabiente.
Webpay Transacción Completa
Este producto permite realizar transacciones con tarjetas de crédito sin utilizar el formulario standard de Webpay. La mayor diferencia con Webpay Plus Tradicional es que el ingreso de los datos de la tarjeta de crédito, se realiza dentro del mismo sitio web del comercio, lo que permite personalizar, a su criterio, la manera en como pide y valida los datos del cliente.
La modalidad de Transacción Completa solo funciona con tarjetas de crédito.
El comercio puede personalizar el formulario en el que solicita los datos del tarjetahabiente para procesar una transacción. El comercio que desee comenzar a operar con la modalidad de Transacción Completa, debe contar con la certificación de Normas PCI DSS (Payment Card Industry-Data Security Standard) y renovarlas anualmente, debido al manejo de data sensible que pueden procesar y que serán utilizados exclusivamente en su relación con Transbank.
Transacción Completa, le ofrece al comercio elegir una o ambas de las siguientes funcionalidades:
- Autorización en línea y captura simultánea, en la que se realiza el cargo al tarjetahabiente de inmediato.
- Autorización en línea y captura diferida, en la que se efectúa una reserva de crédito sobre un valor estimado del producto y/o servicio a adquirir por el tarjetahabiente, posteriormente el comercio define el monto de la transacción el cual será menor o igual al autorizado, en caso de ser superior la transacción será rechazada.
Por este motivo este producto no se encuentra dentro de la oferta publica de Transbank.
Tipos de Pago
Los tipos de pago disponibles actualmente a través de Webpay dependen del tipo de tarjeta usada por el tarjetahabiente y los que tenga activado el comercio.
Para tarjeta de crédito pueden ser los siguientes tipos de pago (con las abreviaciones entre paréntesis):
- Venta Normal (VN): Pago en 1 cuota.
- 2 Cuotas sin interés (S2): El comercio recibe el pago en 2 cuotas iguales sin interés.
- 3 Cuotas sin interés (SI): El comercio recibe el pago en 3 cuotas iguales sin interés.
- N Cuotas sin interés (NC): El comercio recibe el pago en un número de cuotas iguales y sin interés que el tarjetahabiente puede elegir de entre un rango de 2 y N (el valor N es definido por el comercio y no puede ser superior a 12)
- Cuotas normales (VC): El emisor ofrece al tarjetahabiente entre 2 y 48 cuotas. El emisor define si son sin interés (si ha establecido un rango de cuotas en promoción) o con interés. El emisor también puede ofrecer de 1 hasta 3 meses de pago diferida. Todo esto sin impacto para el comercio que en esta modalidad de cuotas siempre recibe el pago en 48 horas hábiles.
Para tarjeta de débito Redcompra el tipo de pago siempre corresponde a:
Venta débito Redcompra (VD): Pago con tarjeta de débito Redcompra.
Venta Prepago (VP): Pago con tarjeta de débito Redcompra.
Códigos de respuesta de autorización
Cuando una transacción es rechazada, Transbank envía un código de respuesta al comercio indicando que esta no pudo efectuarse correctamente. Actualmente, los comercios tienen configurado el nivel 1, el cuál es el estandar para Webpay y entrega información del rechazo de carácter general, agrupando en el mismo distintos tipos de rechazo.
Puedes ver el detalle del nivel 1 a continuación:
| Respuestas al comercio |
Descripción |
|---|---|
| -1 | Rechazo - Posible error en el ingreso de datos de la transacción |
| -2 | Rechazo - Se produjo fallo al procesar la transacción, este mensaje de rechazo se encuentra relacionado a parámetros de la tarjeta y/o su cuenta asociada |
| -3 | Rechazo - Error en Transacción |
| -4 | Rechazo - Rechazada por parte del emisor |
| -5 | Rechazo - Transacción con riesgo de posible fraude |
A partir del 01 de marzo de 2021, se encuentra disponible el nivel 2 de códigos de respuesta de autorización los cuales entregan información del rechazo de forma más específica.
Para la activación del nivel 2, debes enviar un correo a [soporte@transbank.cl](mailto:soporte@transbank.cl) indicando el código de comercio al cual
deseas realizar esta activación.
Serás informado oportunamente el día en el cual se realizará la activación.
Puedes ver el detalle del nivel 2 a continuación:
| Respuestas al comercio |
Descripción |
|---|---|
| -1 | Tarjeta inválida |
| -2 | Error de conexión |
| -3 | Excede monto máximo |
| -4 | Fecha de expiración inválida |
| -5 | Problema en autenticación |
| -6 | Rechazo general |
| -7 | Tarjeta bloqueada |
| -8 | Tarjeta vencida |
| -9 | Transacción no soportada |
| -10 | Problema en la transacción |
| -11 | Excede límite de reintentos de rechazos |
El código -11 será retornado en caso de cumplir algunas de las condiciones de la marca.
1.- En el caso de MASTERCARD, se bloqueará todo reintento de transacción rechazada a partir del reintento número 8° (octavo) en adelante, dentro de 24 horas de realizada la transacción original. Los criterios que la marca utiliza para identificar un reintento es a través del código de comercio y el número de tarjeta.
2.- Para el caso de VISA, se bloqueará todo reintento de transacción rechazada a partir del reintento número 21° (vigésimo primero) en adelante, dentro de 30 días de realizada la transacción original. Los criterios que la marca utiliza para identificar un reintento es a través del código de comercio, el número de tarjeta y el monto de la transacción.
Autorización y Captura
Las transacciones Webpay cuentan con 2 fases: autorización y captura. La autorización se encarga de validar si es posible realizar el cargo a la cuenta asociada a la tarjeta de crédito realizando en el mismo acto la reserva de monto de la transacción. La captura hace efectiva la reserva hecha previamente o cargo en la cuenta de crédito asociada a la tarjeta del titular.
Para tarjetas de débito Redcompra y prepago, la autorización y captura es siempre simultánea. Para tarjetas de crédito, la autorización y captura puede ser simultánea o separada. En este último caso, se trata de una captura diferida.
Desde el punto de vista de la transacción, lo que ocurre es lo siguiente:
Autorización y captura simultánea: La transacción es validada en línea por Transbank. El cargo del pago se hace simultáneamente en la tarjeta de crédito o débito Redcompra del cliente.
Autorización y captura diferida (Sólo válida para tarjetas de crédito): Se retiene el valor de la compra del saldo de la tarjeta de crédito del cliente, reservando cupo pero sin realizar la transacción definitivamente hasta que el comercio confirma la compra (vía captura diferida) y lo comunique a Transbank. Existe un tiempo máximo de 7 días calendario para realizar la captura. Superado ese tiempo la retención de la tarjeta de crédito será reversada y el cupo liberado. La captura puede realizarse a través del
[portal Transbank](https://www.transbank.cl/web/login)o mediante[el servicio web de captura diferida](https://www.transbankdevelopers.cl/referencia/webpay#capturar-una-transaccion).
VCI
Al realizar la autorización de una transacción, el comercio recibe una respuesta por parte de Transbank informando el resultado. En esta respuesta, el campo VCI corresponde a la autenticación del tarjetahabiente y es información adicional suplementaria al responseCode
.
El comercio no debe validar este campo porque constantemente se agregan nuevos mecanismos de autenticación que se traducen en nuevos valores para este campo, que no están necesariamente documentados.
(En el caso de tarjetas internacionales que no proveen 3D-Secure, la decisión del comercio de aceptarlas o no se realiza a nivel de configuración del comercio en Transbank y debe ser conversada con el ejecutivo del comercio)
| Código de respuesta | Descripción |
|---|---|
| TSY | Autenticación Exitosa |
| TSN | Autenticación Rechazada |
| NP | No Participa, sin autenticación |
| U3 | Falla conexión, Autenticación Rechazada |
| INV | Datos Inválidos |
| A | Intentó |
| CNP1 | Comercio no participa |
| EOP | Error operacional |
| BNA | BIN no adherido |
| ENA | Emisor no adherido |
Para venta extranjera, estos son algunos de los códigos:
| Código de respuesta | Descripción |
|---|---|
| TSYS | Autenticación exitosa Sin fricción. Resultado autenticación: Autenticación Existosa |
| TSAS | (Intento, tarjeta no enrolada / emisor no disponible. Resultado autenticación: Autenticación Exitosa) |
| TSNS | (Fallido, no autenticado, denegado / no permite intentos. Resultado autenticación: Autenticación denegada) |
| TSRS | (Autenticación rechazada - sin fricción. Resultado autenticación: Autenticación rechazada) |
| TSUS | (Autenticación no se pudo realizar por problema técnico u otro motivo. Resultado autenticación: Autenticación fallida) |
| TSCF | (Autenticación con fricción (No aceptada por el comercio). Resultado autenticación: Autenticación incompleta) |
| TSYF | (Autenticación exitosa con fricción. Resultado autenticación: Autenticación exitosa) |
| TSNF | (No autenticado. Transacción denegada con fricción. Resultado autenticación: Autenticación denegada) |
| TSUF | (Autenticación con fricción no se pudo realizar por problema técnico u otro. Resultado autenticación: Autenticación fallida) |
| NPC | (Comercio no Participa. Resultado autenticación: Comercio/BIN no participa) |
| NPB | (BIN no participa. Resultado autenticación: Comercio/BIN no participa) |
| NPCB | (Comercio y BIN no participan. Resultado autenticación: Comercio/BIN no participa) |
| SPCB | (Comercio y BIN sí participan. Resultado autenticación: Autorización incompleta) |
Anulaciones y Reversas
Las transacciones de Webpay se pueden anular o reversar dadas algunas condiciones. Para cualquiera de éstas operaciones se utiliza el mismo servicio web que discernirá si se realizará una reversa o una anulación.
Para poder ejecutar una reversa ésta debe ser realizada antes de las 3 horas de efectuada la confirmación por el monto total y en compras con tarjeta de crédito, débito o prepago.
Una vez pasadas las tres horas, siempre se ejecutará una anulación.
- En transacciones realizadas con débito y prepago puedes anular total y parcial.
- Para transacciones realizadas con crédito existen dos tipos de anulaciones:
- Anulación total: disponible para normal sin cuotas, cuotas emisores y cuotas comercio.
- Anulación parcial: únicamente para normal sin cuotas y cuotas emisores.
En caso que la transacción haya sido abonada al comercio, la anulación generará una retención en los siguientes abonos por el monto previamente autorizado.
La anulación de transacciones realizadas con débito o prepago se encuentra disponibles a partir de la versión 1.2 del API de Transbank.
El comercio tiene un plazo de 90 días desde la fecha de venta para anular transacciones vía servicios web.
En el caso de los productos con modalidad mall es importante destacar que las anulaciones actúan individualmente sobre las transacciones de las tiendas de un mall. Por ende, la anulación es la operación correcta a utilizar para fines financieros, de manera de anular un cargo ya realizado.

# public_<{x.url.profile}>.md

Source: https://www.transbankdevelopers.cl/public/<{x.url.profile}>

Nuestros SDK y API REST, te permitirán realizar una integración más personaliza de nuestros productos en tu APP o sitio web.
Hemos desarrollado plugins para los gestores de contenidos más utilizados, tales como: WooCommerce, Magento, Prestashop.
Herramientas para integrar nuestras maquinitas a tus sistemas de pago presencial.
Los productos que te presentamos en este sitio son los que necesitan de un proceso de integración en
comercio y otras aplicaciones. Para los demás productos
que no requieren integración puedes encontrar información en la web [transbank.cl](https://www.transbank.cl/web/productos-y-servicios/soluciones-para-ventas-internet)
Pagos recurrentes de suscripciones fijas y otros pagos automáticos en la tarjeta de crédito.
Pagos presenciales con tarjeta de crédito y Redcompra con terminales integrados a la caja para grandes flujos de venta.
Si quieres comprender de mejor manera cada uno de los productos
Para validar tu integración y verificar que funcione correctamente, ingresa a los formularios dispuestos según la forma en que realizaste la integración y completa el formulario respectivo.
Integración realizada con alguno de nuestros plugin para los gestores de e-commerce más populares
Integración realizada con alguno de nuestros SDK, API o desarrollo propio de tu comercio
Hemos desarrollado plugins fácil de instalar especialmente para los
e-commerce más populares.
Estas soluciones operan con nuestro producto Webpay Plus.
Hemos decidido rehacer nuestro portal, pensando en los desarrolladores. Queremos facilitar el proceso de integración al máximo, eliminar las fricciones y estar a la altura de los mayores referentes en sistemas de pago y documentación.
Porque queremos que la competencia y la oferta en el mundo de ventas online crezca, Damos a conocer a los nuevos comercios las alternativas que hoy existen para levantar una tienda virtual

# referencia.md

Source: https://www.transbankdevelopers.cl/referencia

Webpay Plus
Ambientes y Credenciales
La API REST de Webpay está protegida para garantizar que solamente comercios autorizados por Transbank hagan uso de las operaciones disponibles. La seguridad esta implementada mediante los siguientes mecanismos:
- Canal seguro a través de TLSv1.2 para la comunicación del cliente con Webpay.
- Autenticación y autorización mediante el intercambio de headers
Tbk-Api-Key-Id
(código de comercio) yTbk-Api-Key-Secret
(llave secreta).
Ambiente de Producción
Las URLs de endpoints de producción están alojados dentro de
[https://webpay3g.transbank.cl/](https://webpay3g.transbank.cl/).
// Host: https://webpay3g.transbank.cl
// Host: https://webpay3g.transbank.cl
// Host: https://webpay3g.transbank.cl
# Host: https://webpay3g.transbank.cl
# Host: https://webpay3g.transbank.cl
Host: https://webpay3g.transbank.cl
Ambiente de Integración
Las URLs de endpoints de integración están alojados dentro de
[https://webpay3gint.transbank.cl/](https://webpay3gint.transbank.cl/).
// Host: https://webpay3gint.transbank.cl
// Host: https://webpay3gint.transbank.cl
// Host: https://webpay3gint.transbank.cl
# Host: https://webpay3gint.transbank.cl
# Host: https://webpay3g.transbank.cl
Host: https://webpay3gint.transbank.cl
Consulta [la documentación para conocer las tarjetas de prueba que funcionan en
el ambiente de integración](https://www.transbankdevelopers.cl/documentacion/como_empezar#ambientes).
Credenciales del Comercio
// Tbk-Api-Key-Id: Código de comercio
// Tbk-Api-Key-Secret: Llave secreta
// Content-Type: application/json
// Tbk-Api-Key-Id: Código de comercio
// Tbk-Api-Key-Secret: Llave secreta
// Content-Type: application/json
// Tbk-Api-Key-Id: Código de comercio
// Tbk-Api-Key-Secret: Llave secreta
// Content-Type: application/json
# Tbk-Api-Key-Id: Código de comercio
# Tbk-Api-Key-Secret: Llave secreta
# Content-Type: application/json
# Tbk-Api-Key-Id: Código de comercio
# Tbk-Api-Key-Secret: Llave secreta
# Content-Type: application/json
Tbk-Api-Key-Id: Código de comercio
Tbk-Api-Key-Secret: Llave secreta
Content-Type: application/json
Todas las peticiones que hagas deben incluir el código de comercio y la llave secreta entregada por Transbank, actuando ambas como las credenciales que autorizan distintas operaciones.
Códigos de comercio
En la documentación puedes revisar [todos los códigos de comercio](https://www.transbankdevelopers.cl/documentacion/como_empezar#codigos-de-comercio) del ambiente de integración
Los SDKs ya incluyen esos códigos de comercio y llaves secretas que funcionan en el ambiente de integración, por lo que puedes obtener rápidamente una configuración lista para hacer tus primeras pruebas en dicho ambiente:
WebpayPlus.Transaction tx = new WebpayPlus.Transaction(new WebpayOptions(IntegrationCommerceCodes.WEBPAY_PLUS, IntegrationApiKeys.WEBPAY, IntegrationType.TEST));
use Transbank\Webpay\Options;
use Transbank\Webpay\WebpayPlus\Transaction;
$option = new Options($apiKey, $commerceCode, Options::ENVIRONMENT_INTEGRATION);
$transaction = new Transaction($option);
var tx = new Transaction(new Options(IntegrationCommerceCodes.WEBPAY_PLUS, IntegrationApiKeys.WEBPAY, WebpayIntegrationType.Test));
@tx = Transbank::Webpay::WebpayPlus::Transaction.new(::Transbank::Common::IntegrationCommerceCodes::WEBPAY_PLUS, ::Transbank::Common::IntegrationApiKeys::WEBPAY, :integration)
tx = Transaction(WebpayOptions(IntegrationCommerceCodes.WEBPAY_PLUS, IntegrationApiKeys.WEBPAY, IntegrationType.TEST))
const tx = new WebpayPlus.Transaction(
new Options(
IntegrationCommerceCodes.WEBPAY_PLUS,
IntegrationApiKeys.WEBPAY,
Environment.Integration)
);
Tbk-Api-Key-Id: 597055555532
Tbk-Api-Key-Secret: 579B532A7440BB0C9079DED94D31EA1615BACEB56610332264630D42D0A36B1C
Webpay Plus
Una transacción de autorización normal (o transacción normal), corresponde a una solicitud de autorización financiera de un pago con tarjetas de crédito o débito, en donde quién realiza el pago ingresa al sitio del comercio, selecciona productos o servicio, y el ingreso asociado a los datos de la tarjeta de crédito, débito o prepago lo realiza en forma segura en Webpay.
Flujo en caso de éxito y abortar un pago
Revisa [la documentación](https://www.transbankdevelopers.cl/documentacion/webpay-plus#flujo-en-caso-de-exito) de Webpay plus para revisar los diferentes flujos de pago posibles.
Crear una transacción
Puedes revisar más detalles de esta operación en [su documentación](https://www.transbankdevelopers.cl/documentacion/webpay-plus#crear-una-transaccion)
Permite inicializar una transacción en Webpay. Como respuesta a la invocación se genera un token que representa en forma única una transacción.
Para crear una transacción basta llamar al método Transaction.create()
WebpayPlus.Transaction transaction = WebpayPlus.Transaction.buildForIntegration("commerceCode", "APIKey");
final WebpayPlusTransactionCreateResponse response = transaction.create(buyOrder, sessionId, amount, returnUrl);
$transaction = Transaction::buildForIntegration($apiKey, $commerceCode);
$response = $transaction->create($buy_order, $session_id, $amount, $return_url);
Transaction transaction = Transaction.buildForIntegration("commerceCode", "APIKey");
var response = transaction.Create(buyOrder, sessionId, amount, returnUrl);
@transaction = Transbank::Webpay::WebpayPlus::Transaction.build_for_integration("commerceCode", "APIKey");
@resp = @transaction.create(
buy_order: @buy_order,
session_id: @session_id,
amount: @amount,
return_url: @return_url
);
tx = Transaction.build_for_integration("commerceCode", "APIKey")
resp = tx.create(buy_order, session_id, amount, return_url)
const transaction = WebpayPlus.Transaction.buildForIntegration(
"commerceCode",
"APIKey"
);
const response = await transaction.create(
buyOrder,
sessionId,
amount,
returnUrl
);
POST /rswebpaytransaction/api/webpay/v1.2/transactions
Tbk-Api-Key-Id: 597055555532
Tbk-Api-Key-Secret: 579B532A7440BB0C9079DED94D31EA1615BACEB56610332264630D42D0A36B1C
Content-Type: application/json
{
"buy_order": "ordenCompra12345678",
"session_id": "sesion1234557545",
"amount": 10000,
"return_url": "http://www.comercio.cl/webpay/retorno"
}
Parámetros Transaction.create
| Nombre tipo |
Descripción |
|---|---|
| buy_order String |
Orden de compra de la tienda. Este número debe ser único para cada transacción. Largo máximo: 26. La orden de compra puede tener: Números, letras, mayúsculas y minúsculas, y los signos |_=&%.,~:/?[+!@()>- . Los caracteres con signos no están soportados, como los acentos o signos no especificados. |
| session_id String |
Identificador de sesión, uso interno de comercio, este valor es devuelto al final de la transacción. Largo máximo: 61 |
| amount Decimal |
Monto de la transacción. Máximo 2 decimales para USD. Largo máximo: 17 |
| return_url String |
URL del comercio, a la cual Webpay redireccionará posterior al proceso de autorización. Largo máximo: 256 |
Respuesta Transaction.create
response.getUrl();
response.getToken();
// Puedes obtener la URL y el token devuelo utilizando estos métodos del objeto de respuesta:
$response->getUrl();
$response->getToken();
response.Url;
response.Token;
response.url
response.token
## Versión 3.x del SDK
response['url']
response['token']
## Versión 2.x del SDK
response.url
response.token
response.url
response.token
200 OK
Content-Type: application/json
{
"token": "e9d555262db0f989e49d724b4db0b0af367cc415cde41f500a776550fc5fddd3",
"url": "https://webpay3gint.transbank.cl/webpayserver/initTransaction"
}
| Nombre tipo |
Descripción |
|---|---|
| token String |
Token de la transacción. Largo: 64. |
| url String |
URL de formulario de pago Webpay. Largo máximo: 255. |
Confirmar una transacción
Puedes revisar más detalles de esta operación en [su documentación](https://www.transbankdevelopers.cl/documentacion/webpay-plus#confirmar-una-transaccion)
Permite confirmar y obtener el resultado de la transacción una vez que Webpay ha resuelto su autorización financiera.
Cuando el comercio retoma el control mediante return_url
debes confirmar y obtener
el resultado de una transacción usando el método Transaction.commit()
.
WebpayPlus.Transaction transaction = WebpayPlus.Transaction.buildForIntegration("commerceCode", "APIKey");
final WebpayPlusTransactionCommitResponse response = transaction.commit(token);
$transaction = Transaction::buildForIntegration($apiKey, $commerceCode);
$response = $transaction->commit($token);
Transaction transaction = Transaction.buildForIntegration("commerceCode", "APIKey");
var response = transaction.Commit(token);
@transaction = Transbank::Webpay::WebpayPlus::Transaction.build_for_integration("commerceCode", "APIKey");
@resp = @transaction.commit(token: @token);
tx = Transaction.build_for_integration("commerceCode", "APIKey")
resp = tx.commit(token)
const transaction = WebpayPlus.Transaction.buildForIntegration(
"commerceCode",
"APIKey"
);
const response = await transaction.commit(token);
PUT /rswebpaytransaction/api/webpay/v1.2/transactions/{token}
Tbk-Api-Key-Id: 597055555532
Tbk-Api-Key-Secret: 579B532A7440BB0C9079DED94D31EA1615BACEB56610332264630D42D0A36B1C
Content-Type: application/json
Parámetros Transaction.commit
| Nombre tipo |
Descripción |
|---|---|
| token String |
Token de la transacción. Largo: 64. (Se envía en la URL, no en el body) |
Respuesta Transaction.commit
response.getVci();
response.getAmount();
response.getStatus();
response.getBuyOrder();
response.getSessionId();
response.getCardDetail().getCardNumber();
response.getAccountingDate();
response.getTransactionDate();
response.getAuthorizationCode();
response.getPaymentTypeCode();
response.getResponseCode();
response.getInstallmentsAmount();
response.getInstallmentsNumber();
response.getBalance();
$response->getVci();
$response->getAmount();
$response->getStatus();
$response->getBuyOrder();
$response->getSessionId();
$response->getCardDetail();
$response->getAccountingDate();
$response->getTransactionDate();
$response->getAuthorizationCode();
$response->getPaymentTypeCode();
$response->getResponseCode();
$response->getInstallmentsAmount();
$response->getInstallmentsNumber();
$response->getBalance();
response.Vci;
response.Amount;
response.Status;
response.BuyOrder;
response.SessionId;
response.CardDetail;
response.AccountingDate;
response.TransactionDate;
response.AuthorizationCode;
response.PaymentTypeCode;
response.ResponseCode;
response.InstallmentsAmount;
response.InstallmentsNumber;
response.Balance;
response.vci
response.amount
response.status
response.buy_order
response.session_id
response.card_detail
response.accounting_date
response.transaction_date
response.authorization_code
response.payment_type_code
response.response_code
response.installments_amount
response.installments_number
response.balance
## Versión 3.x del SDK
response['vci']
response['amount']
response['status']
response['buy_order']
response['session_id']
response['card_detail']
response['accounting_date']
response['transaction_date']
response['authorization_code']
response['payment_type_code']
response['response_code']
response['installments_amount']
response['installments_number']
response['balance']
## Versión 2.x del SDK
response.vci
response.amount
response.status
response.buy_order
response.session_id
response.card_detail
response.accounting_date
response.transaction_date
response.authorization_code
response.payment_type_code
response.response_code
response.installments_amount
response.installments_number
response.balance
response.vci
response.amount
response.status
response.buy_order
response.session_id
response.card_detail
response.accounting_date
response.transaction_date
response.authorization_code
response.payment_type_code
response.response_code
response.installments_amount
response.installments_number
response.balance
200 OK
Content-Type: application/json
{
"vci": "TSY",
"amount": 10000,
"status": "AUTHORIZED",
"buy_order": "ordenCompra12345678",
"session_id": "sesion1234557545",
"card_detail": {
"card_number": "6623"
},
"accounting_date": "0522",
"transaction_date": "2019-05-22T16:41:21.063Z",
"authorization_code": "1213",
"payment_type_code": "VN",
"response_code": 0,
"installments_number": 0
}
| Nombre tipo |
Descripción |
|---|---|
| vci String |
Resultado de la autenticación del tarjetahabiente. Algunos de ellos son: TSY - Autenticación Exitosa TSN - Autenticación Rechazada NP - No Participa, sin autenticación U3 - Falla conexión, Autenticación Rechazada INV - Datos Inválidos A - Intentó CNP1 - Comercio no participa EOP - Error operacional BNA - BIN no adherido ENA - Emisor no adherido Para venta extranjera, estos son algunos de los códigos: TSYS (Autenticación exitosa Sin fricción. Resultado autenticación: Autenticación Existosa) TSAS (Intento, tarjeta no enrolada / emisor no disponible. Resultado autenticación: Autenticación Exitosa) TSNS (Fallido, no autenticado, denegado / no permite intentos. Resultado autenticación: Autenticación denegada) TSRS (Autenticación rechazada - sin fricción. Resultado autenticación: Autenticación rechazada) TSUS (Autenticación no se pudo realizar por problema técnico u otro motivo. Resultado autenticación: Autenticación fallida) TSCF (Autenticación con fricción (No aceptada por el comercio). Resultado autenticación: Autenticación incompleta) TSYF (Autenticación exitosa con fricción. Resultado autenticación: Autenticación exitosa) TSNF (No autenticado. Transacción denegada con fricción. Resultado autenticación: Autenticación denegada) TSUF (Autenticación con fricción no se pudo realizar por problema técnico u otro. Resultado autenticación: Autenticación fallida) NPC (Comercio no Participa. Resultado autenticación: Comercio/BIN no participa) NPB (BIN no participa. Resultado autenticación: Comercio/BIN no participa) NPCB (Comercio y BIN no participan. Resultado autenticación: Comercio/BIN no participa) SPCB (Comercio y BIN sí participan. Resultado autenticación: Autorización incompleta) Este campo es información adicional suplementaria al responseCode pero el comercio no debe validar este campo porque constantemente se agregan nuevos mecanismos de autenticación que se traducen en nuevos valores para este campo que no están necesariamente documentados. |
| amount Decimal |
Formato número entero para transacciones en peso y decimal para transacciones en dólares. Largo máximo: 17 |
| status String |
Estado de la transacción (INITIALIZED, AUTHORIZED, REVERSED, FAILED, NULLIFIED, PARTIALLY_NULLIFIED, CAPTURED). Largo máximo: 64 |
| buy_order String |
Orden de compra de la tienda indicado en Transaction.create() . Largo máximo: 26 |
| session_id String |
Identificador de sesión, el mismo enviado originalmente por el comercio en Transaction.create() . Largo máximo: 61. |
| card_detail carddetails |
Objeto que representa los datos de la tarjeta de crédito del tarjeta habiente. |
| card_detail.card_number String |
4 últimos números de la tarjeta de crédito del tarjetahabiente. Largo máximo: 19. |
| accounting_date String |
Fecha de la autorización. Largo: 4, formato MMDD |
| transaction_date String |
Fecha y hora de la autorización. Largo: 24, formato: ISO 8601 (Ej: yyyy-mm-ddTHH:mm:ss.xxxZ) |
| authorization_code String |
Código de autorización de la transacción Largo máximo: 6 |
| payment_type_code String |
VD = Venta Débito. VN = Venta Normal. VC = Venta en cuotas. SI = 3 cuotas sin interés. S2 = 2 cuotas sin interés. NC = N Cuotas sin interés VP = Venta Prepago. |
Number
0 = Transacción aprobada
Puedes revisar los códigos de respuesta de rechazo en el siguiente
[link](https://www.transbankdevelopers.cl/producto/webpay#codigos-de-respuesta-de-autorizacion)Number
Number
Number
Obtener estado de una transacción
Puedes revisar más detalles de esta operación en [su documentación](https://www.transbankdevelopers.cl/documentacion/webpay-plus#obtener-estado-de-una-transaccion)
Esta operación permite obtener el estado de la transacción en cualquier momento. En condiciones normales es probable que no se requiera ejecutar, pero en caso de ocurrir un error inesperado permite conocer el estado y tomar las acciones que correspondan.
Transaction.status()
WebpayPlus.Transaction transaction = WebpayPlus.Transaction.buildForIntegration("commerceCode", "APIKey");
final WebpayPlusTransactionStatusResponse response = transaction.status(token);
$transaction = Transaction::buildForIntegration($apiKey, $commerceCode);
$response = $transaction->status($token);
using Transbank.Webpay.WebpayPlus;
Transaction transaction = Transaction.buildForIntegration("commerceCode", "APIKey");
var response = transaction.status(token);
@transaction = Transbank::Webpay::WebpayPlus::Transaction.build_for_integration("commerceCode", "APIKey");
@resp = @transaction.status(token: @token);
tx = Transaction.build_for_integration("commerceCode", "APIKey")
resp = tx.status(token)
const transaction = WebpayPlus.Transaction.buildForIntegration(
"commerceCode",
"APIKey"
);
const response = await transaction.status(token);
GET /rswebpaytransaction/api/webpay/v1.2/transactions/{token}
Tbk-Api-Key-Id: 597055555532
Tbk-Api-Key-Secret: 579B532A7440BB0C9079DED94D31EA1615BACEB56610332264630D42D0A36B1C
Content-Type: application/json
Parámetros Transaction.status
| Nombre tipo |
Descripción |
|---|---|
| token String |
Token de la transacción. Largo: 64. (Se envía en la URL, no en el body) |
Respuesta Transaction.status
response.getVci();
response.getAmount();
response.getStatus();
response.getBuyOrder();
response.getSessionId();
response.getCardDetail().getCardNumber();
response.getAccountingDate();
response.getTransactionDate();
response.getAuthorizationCode();
response.getPaymentTypeCode();
response.getResponseCode();
response.getInstallmentsAmount();
response.getInstallmentsNumber();
response.getBalance();
$response->getVci();
$response->getAmount();
$response->getStatus();
$response->getBuyOrder();
$response->getSessionId();
$response->getCardDetail();
$response->getAccountingDate();
$response->getTransactionDate();
$response->getAuthorizationCode();
$response->getPaymentTypeCode();
$response->getResponseCode();
$response->getInstallmentsAmount();
$response->getInstallmentsNumber();
$response->getBalance();
response.Vci;
response.Amount;
response.Status;
response.BuyOrder;
response.SessionId;
response.CardDetail;
response.AccountingDate;
response.TransactionDate;
response.AuthorizationCode;
response.PaymentTypeCode;
response.ResponseCode;
response.InstallmentsAmount;
response.InstallmentsNumber;
response.Balance;
response.vci
response.amount
response.status
response.buy_order
response.session_id
response.card_detail
response.accounting_date
response.transaction_date
response.authorization_code
response.payment_type_code
response.response_code
response.installments_amount
response.installments_number
response.balance
## Versión 3.x del SDK
response['vci']
response['amount']
response['status']
response['buy_order']
response['session_id']
response['card_detail']
response['accounting_date']
response['transaction_date']
response['authorization_code']
response['payment_type_code']
response['response_code']
response['installments_amount']
response['installments_number']
response['balance']
## Versión 2.x del SDK
response.vci
response.amount
response.status
response.buy_order
response.session_id
response.card_detail
response.accounting_date
response.transaction_date
response.authorization_code
response.payment_type_code
response.response_code
response.installments_amount
response.installments_number
response.balance
response.vci
response.amount
response.status
response.buy_order
response.session_id
response.card_detail
response.accounting_date
response.transaction_date
response.authorization_code
response.payment_type_code
response.response_code
response.installments_amount
response.installments_number
response.balance
200 OK
Content-Type: application/json
{
"vci": "TSY",
"amount": 10000,
"status": "AUTHORIZED",
"buy_order": "ordenCompra12345678",
"session_id": "sesion1234557545",
"card_detail": {
"card_number": "6623"
},
"accounting_date": "0522",
"transaction_date": "2019-05-22T16:41:21.063Z",
"authorization_code": "1213",
"payment_type_code": "VN",
"response_code": 0,
"installments_number": 0
}
| Nombre tipo |
Descripción |
|---|---|
| vci String |
Resultado de la autenticación del tarjetahabiente. Algunos de ellos son: TSY - Autenticación Exitosa TSN - Autenticación Rechazada NP - No Participa, sin autenticación U3 - Falla conexión, Autenticación Rechazada INV - Datos Inválidos A - Intentó CNP1 - Comercio no participa EOP - Error operacional BNA - BIN no adherido ENA - Emisor no adherido Para venta extranjera, estos son algunos de los códigos: TSYS (Autenticación exitosa Sin fricción. Resultado autenticación: Autenticación Existosa) TSAS (Intento, tarjeta no enrolada / emisor no disponible. Resultado autenticación: Autenticación Exitosa) TSNS (Fallido, no autenticado, denegado / no permite intentos. Resultado autenticación: Autenticación denegada) TSRS (Autenticación rechazada - sin fricción. Resultado autenticación: Autenticación rechazada) TSUS (Autenticación no se pudo realizar por problema técnico u otro motivo. Resultado autenticación: Autenticación fallida) TSCF (Autenticación con fricción (No aceptada por el comercio). Resultado autenticación: Autenticación incompleta) TSYF (Autenticación exitosa con fricción. Resultado autenticación: Autenticación exitosa) TSNF (No autenticado. Transacción denegada con fricción. Resultado autenticación: Autenticación denegada) TSUF (Autenticación con fricción no se pudo realizar por problema técnico u otro. Resultado autenticación: Autenticación fallida) NPC (Comercio no Participa. Resultado autenticación: Comercio/BIN no participa) NPB (BIN no participa. Resultado autenticación: Comercio/BIN no participa) NPCB (Comercio y BIN no participan. Resultado autenticación: Comercio/BIN no participa) SPCB (Comercio y BIN sí participan. Resultado autenticación: Autorización incompleta) Este campo es información adicional suplementaria al responseCode pero el comercio no debe validar este campo porque constantemente se agregan nuevos mecanismos de autenticación que se traducen en nuevos valores para este campo que no están necesariamente documentados. |
| amount Formato número entero para transacciones en peso y decimal para transacciones en dólares. |
Monto de la transacción. Largo máximo: 17 |
| status String |
Estado de la transacción (INITIALIZED, AUTHORIZED, REVERSED, FAILED, NULLIFIED, PARTIALLY_NULLIFIED, CAPTURED). Largo máximo: 64 |
| buy_order String |
Orden de compra de la tienda indicado en Transaction.create() . Largo máximo: 26 |
| session_id String |
Identificador de sesión, el mismo enviado originalmente por el comercio en Transaction.create() . Largo máximo: 61. |
| card_detail carddetails |
Objeto que representa los datos de la tarjeta de crédito del tarjeta habiente. |
| card_detail.card_number String |
4 últimos números de la tarjeta de crédito del tarjetahabiente. Largo máximo: 19. |
| accounting_date String |
Fecha de la autorización. Largo: 4, formato MMDD |
| transaction_date String |
Fecha y hora de la autorización. Largo: 24, formato: ISO 8601 (Ej: yyyy-mm-ddTHH:mm:ss.xxxZ) |
| authorization_code String |
Código de autorización de la transacción Largo máximo: 6 |
| payment_type_code String |
VD = Venta Débito. VN = Venta Normal. VC = Venta en cuotas. SI = 3 cuotas sin interés. S2 = 2 cuotas sin interés. NC = N Cuotas sin interés VP = Venta Prepago. |
Number
0 = Transacción aprobada
Puedes revisar los códigos de respuesta de rechazo en el siguiente
[link](https://www.transbankdevelopers.cl/producto/webpay#codigos-de-respuesta-de-autorizacion)Number
Number
Number
Reversar o Anular un pago
Puedes revisar más detalles de esta operación en [su documentación](https://www.transbankdevelopers.cl/documentacion/webpay-plus#reversar-o-anular-una-transaccion)
Para anular una transacción se debe invocar al método Transaction.refund()
.
Transaction.refund()
Los SDKs permiten indicar opcionalmente el código de comercio de la transacción a anular, para soportar la anulación en comercios Webpay Plus Mall. En comercios Webpay Plus, no es necesario especificar el código de comercio pues se usa el indicado en la configuración.
WebpayPlus.Transaction transaction = WebpayPlus.Transaction.buildForIntegration("commerceCode", "APIKey");
final WebpayPlusTransactionRefundResponse response = transaction.refund(token, amount);
$transaction = Transaction::buildForIntegration($apiKey, $commerceCode);
$response = $transaction->refund($token, $amount);
Transaction transaction = Transaction.buildForIntegration("commerceCode", "APIKey");
var response = transaction.Refund(token, refundAmount);
@transaction = Transbank::Webpay::WebpayPlus::Transaction.build_for_integration("commerceCode", "APIKey");
@resp = @transaction.refund(token: @token, amount: @amount);
tx = Transaction.build_for_integration("commerceCode", "APIKey")
resp = tx.refund(token, amount)
const transaction = WebpayPlus.Transaction.buildForIntegration(
"commerceCode",
"APIKey"
);
const response = await transaction.refund(token, amount);
POST /rswebpaytransaction/api/webpay/v1.2/transactions/{token}/refunds
Tbk-Api-Key-Id: 597055555532
Tbk-Api-Key-Secret: 579B532A7440BB0C9079DED94D31EA1615BACEB56610332264630D42D0A36B1C
Content-Type: application/json
{
"amount": 1000
}
Parámetros Transaction.refund
| Nombre tipo |
Descripción |
|---|---|
| token String |
Token de la transacción. Largo: 64. (Se envía en la URL, no en el body) |
| amount Formato número entero para transacciones en peso. Sólo en caso de dólar acepta dos decimales. |
Monto que se desea anular o reversar de la transacción. Largo máximo: 17. |
Respuesta Transaction.refund
En el caso de que la transacción corresponda a una Reversa solo se retorna el parámetro type (REVERSED).
response.getAuthorizationCode();
response.getAuthorizationDate();
response.getBalance();
response.getNullifiedAmount();
response.getResponseCode();
response.getType();
// Puedes obtener los datos de la respuesta usando cualquiera de estos métedos del objeto de respuesta:
$response->getAuthorizationCode();
$response->getAuthorizationDate();
$response->getBalance();
$response->getNullifiedAmount();
$response->getResponseCode();
$response->getType();
response.AuthorizationCode;
response.AuthorizationDate;
response.Balance;
response.NullifiedAmount;
response.ResponseCode;
response.Type;
response.authorization_code;
response.authorization_date;
response.balance;
response.nullified_amount;
response.response_code;
response.type;
## Versión 3.x del SDK
response['authorization_code']
response['authorization_date']
response['balance']
response['nullified_amount']
response['response_code']
response['type']
## Versión 2.x del SDK
response.authorization_code
response.authorization_date
response.balance
response.nullified_amount
response.response_code
response.type
response.authorization_code
response.authorization_date
response.balance
response.nullified_amount
response.response_code
response.type
200 OK
Content-Type: application/json
{
"type": "NULLIFIED",
"authorization_code": "123456",
"authorization_date": "2019-03-20T20:18:20Z",
"nullified_amount": 1000.00,
"balance": 0.00,
"response_code": 0
}
| Nombre tipo |
Descripción |
|---|---|
| type String |
Tipo de reembolso (REVERSED o NULLIFIED). Si es REVERSED no se devolverán datos de la transacción (authorization code, etc). Largo máximo: 10 |
| authorization_code String |
(Solo si es NULLIFIED) Código de autorización de la anulación. Largo máximo: 6 |
| authorization_date String |
(Solo si es NULLIFIED) Fecha y hora de la autorización. |
| balance Decimal |
(Solo si es NULLIFIED) Saldo actualizado de la transacción (considera la venta menos el monto anulado). Largo máximo: 17 |
| nullified_amount Decimal |
(Solo si es NULLIFIED) Monto anulado. Largo máximo: 17 |
| response_code Number |
(Solo si es NULLIFIED) Código de resultado de la reversa/anulacion. Si es exitoso es 0, de lo contrario la reversa/anulación no fue realizada Largo Máximo: 2 |
En caso de error pueden aparecer los siguientes códigos de error comunes para el método Transaction.refund()
:
| Código | Descripción |
|---|---|
| 304 | Validación de campos de entrada nulos |
| 245 | Código de comercio no existe |
| 22 | El comercio no se encuentra activo |
| 316 | El comercio indicado no corresponde al certificado o no es hijo del comercio MALL en caso de transacciones MALL |
| 308 | Operación no permitida |
| 274 | Transacción no encontrada |
| 16 | La transacción no permite anulación |
| 292 | La transacción no está autorizada |
| 284 | Periodo de anulación excedido |
| 310 | Transacción anulada previamente |
| 311 | Monto a anular excede el saldo disponible para anular |
| 312 | Error genérico para anulaciones |
| 315 | Error del autorizador |
| 53 | La transacción no permite anulación parcial de transacciones con cuotas |
Capturar una transacción
Puedes revisar más detalles de esta operación en [su documentación](https://www.transbankdevelopers.cl/documentacion/webpay-plus#capturar-una-transaccion)
Permite solicitar a Webpay la captura diferida de una transacción con autorización y sin captura simultánea.
Transaction.capture()
WebpayPlus.Transaction transaction = WebpayPlus.Transaction.buildForIntegration("commerceCode", "APIKey");
final WebpayPlusTransactionCaptureResponse response = transaction.capture(token, buyOrder, authorizationCode, amount);
use Transbank\Webpay\WebpayPlus\Transaction;
$transaction = Transaction::buildForIntegration($apiKey, $commerceCode);
$response = $transaction->capture($token, $buyOrder, $authCode, $amount);
Transaction transaction = Transaction.buildForIntegration("commerceCode", "APIKey");
var response = transaction.capture(token, buyOrder, authorizationCode, amount);
@transaction = Transbank::Webpay::WebpayPlus::Transaction.build_for_integration("commerceCode", "APIKey");
@resp = @transaction.capture(
token: @token,
buy_order: @buy_order,
authorization_code: @auth_code,
amount: @amount
);
tx = Transaction.build_for_integration("commerceCode", "APIKey")
resp = tx.capture(
token=token, buy_order=buy_order, authorization_code=authorization_code, capture_amount=amount
)
const transaction = WebpayPlus.Transaction.buildForIntegration(
"commerceCode",
"APIKey"
);
const response = await tx.capture(
token,
buyOrder,
authorizationCode,
captureAmount
);
PUT /rswebpaytransaction/api/webpay/v1.2/transactions/{token}/capture
Tbk-Api-Key-Id: 597055555540
Tbk-Api-Key-Secret: 579B532A7440BB0C9079DED94D31EA1615BACEB56610332264630D42D0A36B1C
Content-Type: application/json
{
"buy_order": "415034240",
"authorization_code": "12345",
"capture_amount": 1000
}
Parámetros Transaction.capture
| Nombre tipo |
Descripción |
|---|---|
| token String |
Token de la transacción. Largo: 64. (Se envía en la URL, no en el body) |
| buy_order String |
Orden de compra de la transacción que se requiere capturar. Largo máximo: 26. La orden de compra puede tener: Números, letras, mayúsculas y minúsculas, y los signos |_=&%.,~:/?[+!@()>- . Los caracteres con signos no están soportados, como los acentos o signos no especificados. |
| authorization_code String |
Código de autorización de la transacción que se requiere capturar Largo máximo: 6. |
| capture_amount Decimal |
Monto que se desea capturar. Largo máximo: 17. |
Respuesta Transaction.capture
response.getAuthorizationCode();
response.getAuthorizationDate();
response.getCapturedAmount();
response.getResponseCode();
$response->getAuthorizationCode();
$response->getAuthorizationDate();
$response->getCapturedAmount();
$response->getResponseCode();
response.AuthorizationCode;
response.AuthorizationDate;
response.CapturedAmount;
response.ResponseCode;
response.authorization_code
response.authorization_date
response.captured_amount
response.response_code
## Versión 3.x del SDK
response['authorization_code']
response['authorization_date']
response['captured_amount']
response['response_code']
## Versión 2.x del SDK
response.authorization_code
response.authorization_date
response.captured_amount
response.response_code
response.authorization_code
response.authorization_date
response.captured_amount
response.response_code
200 OK
Content-Type: application/json
{
"token": "e074d38c628122c63e5c0986368ece22974d6fee1440617d85873b7b4efa48a3",
"authorization_code": "123456",
"authorization_date": "2019-03-20T20:18:20Z",
"captured_amount": 1000,
"response_code": 0
}
| Nombre tipo |
Descripción |
|---|---|
| token String |
Token de la transacción. Largo máximo: 64 |
| authorization_code String |
Código de autorización de la captura diferida. Largo máximo: 6 |
| authorization_date String |
Fecha y hora de la autorización. |
| captured_amount Decimal |
Monto capturado. Largo máximo: 6 |
| response_code Number |
Código de resultado de la captura. Si es exitoso es 0,de lo contrario la captura no fue realizada. Largo máximo: 2 |
En caso de error pueden aparecer los siguientes códigos exclusivos del método
Transaction.capture()
:
| Código | Descripción |
|---|---|
| 304 | Validación de campos de entrada nulos |
| 245 | Código de comercio no existe |
| 22 | El comercio no se encuentra activo |
| 316 | El comercio indicado no corresponde al certificado o no es hijo del comercio Mall en caso de transacciones MALL |
| 308 | Operación no permitida |
| 274 | Transacción no encontrada |
| 16 | La transacción no es de captura diferida |
| 292 | La transacción no está autorizada |
| 284 | Periodo de captura excedido |
| 310 | Transacción reversada previamente |
| 309 | Transacción capturada previamente |
| 311 | Monto a capturar excede el monto autorizado |
| 315 | Error del autorizador |
Webpay Plus Mall
Una transacción Mall Normal corresponde a una solicitud de autorización financiera de un conjunto de pagos con tarjetas de crédito o débito, en donde quién realiza el pago ingresa al sitio del comercio, selecciona productos o servicios, y el ingreso asociado a los datos de la tarjeta de crédito o débito lo realiza una única vez en forma segura en Webpay para el conjunto de pagos. Cada pago tendrá su propio resultado, autorizado o rechazado.
Revisa más detalles sobre esta modalidad en [la documentación](https://www.transbankdevelopers.cl/documentacion/webpay-plus#webpay-plus-mall)
Crear una transacción mall
Puedes revisar más detalles de esta operación en [su documentación](https://www.transbankdevelopers.cl/documentacion/webpay-plus#crear-una-transaccion-mall)
Para crear una transacción basta llamar al método Transaction.create()
Transaction.create() Mall
WebpayPlus.MallTransaction mallTransaction = WebpayPlus.MallTransaction.buildForIntegration("commerceCode", "APIKey");
MallTransactionCreateDetails mallDetails = MallTransactionCreateDetails.build()
.add(amountMallOne, commerceCodeStoreOne, buyOrderMallOne)
.add(amountMallTwo, commerceCodeStoreTwo, buyOrderMallTwo);
final WebpayPlusMallTransactionCreateResponse response = mallTransaction.create(buyOrder, sessionId, returnUrl, mallDetails);
$mallTransaction = MallTransaction::buildForIntegration($apiKey, $commerceCode);
$transaction_details = [
[
"amount" => 10000,
"commerce_code" => 'commerceCodeStoreOne',
"buy_order" => "ordenCompraDetalle1234"
],
[
"amount" =>12000,
"commerce_code" => 'commerceCodeStoreTwo',
"buy_order" => "ordenCompraDetalle4321"
],
];
$response = $mallTransaction->create($buy_order, $session_id, $return_url, $transaction_details);
MallTransaction mallTransaction = MallTransaction.buildForIntegration("commerceCode", "APIKey");
var transactionDetails = new List();
transactionDetails.Add(new TransactionDetail(
amountMallOne,
commerceCodeStoreOne,
buyOrderMallOne
));
transactionDetails.Add(new TransactionDetail(
amountMallTwo,
commerceCodeStoreTwo,
buyOrderMallTwo
));
var result = mallTransaction.Create(buyOrder, sessionId, returnUrl, transactionDetails);
@mall_transaction = Transbank::Webpay::WebpayPlus::MallTransaction.build_for_integration("commerceCode", "APIKey");
@transaction_details = [
{
amount: 10000,
commerce_code: "commerce_store_1",
buy_order: "ordenCompraDetalle1234"
},
{
amount: 12000,
commerce_code: "commerce_store_2",
buy_order: "ordenCompraDetalle4321"
},
];
@resp = @mall_transaction.create(
buy_order: @buy_order,
session_id: @session_id,
return_url: @return_url,
details: @transaction_details
);
mall_tx = MallTransaction.build_for_integration("commerceCode", "APIKey")
transaction_details = MallTransactionCreateDetails(
amount_child_1, commerce_store_1, buy_order_child_1
).add(
amount_child_2, commerce_store_2, buy_order_child_2
)
resp = mall_tx.create(
buy_order=buy_order,
session_id=session_id,
return_url=return_url,
details = transaction_details,
)
const mallTransaction = WebpayPlus.MallTransaction.buildForIntegration(
"commerceCode",
"APIKey"
);
let details = [
new TransactionDetail(amount, commerceCodeStoreOne, buyOrder),
new TransactionDetail(amount2, commerceCodeStoreTwo, buyOrder2),
];
const response = await mallTransaction.create(
buyOrder,
sessionId,
returnUrl,
details
);
POST /rswebpaytransaction/api/webpay/v1.2/transactions
Tbk-Api-Key-Id: 597055555535
Tbk-Api-Key-Secret: 579B532A7440BB0C9079DED94D31EA1615BACEB56610332264630D42D0A36B1C
Content-Type: application/json
{
"buy_order": "ordenCompra12345678",
"session_id": "sesion1234557545",
"return_url": "http://www.comercio.cl/webpay/retorno",
"details": [
{
"amount": 10000,
"commerce_code": 597055555536,
"buy_order": "ordenCompraDetalle1234"
},
{
"amount": 12000,
"commerce_code": 597055555537,
"buy_order": "ordenCompraDetalle4321"
},
]
}
Parámetros Transaction.create Mall
| Nombre tipo |
Descripción |
|---|---|
| buy_order String |
Es el código único de la orden de compra generada por el comercio mall. Este número debe ser único para cada transacción. Largo máximo: 26. La orden de compra puede tener: Números, letras, mayúsculas y minúsculas, y los signos |_=&%.,~:/?[+!@()>- . Los caracteres con signos no están soportados, como los acentos o signos no especificados. |
| session_id String |
Identificador de sesión, uso interno de comercio, este valor es devuelto al final de la transacción. Largo máximo: 61 |
| return_url String |
URL del comercio, a la cual Webpay redireccionará posterior al proceso de autorización Largo máximo: 256. |
| details Array |
Lista de objetos, uno por cada tienda diferente del mall que participa en la transacción. |
| details [].amount Decimal |
Monto de la transacción de una tienda del mall. Máximo 2 decimales para USD. Largo máximo: 10. |
| details [].commerce_code String |
Código comercio asignado por Transbank para la tienda perteneciente al mall a la cual corresponde esta transacción. Largo: 12. |
| details [].buy_order String |
Orden de compra de la tienda del mall. Este número debe ser único para cada transacción. Largo máximo: 26. La orden de compra puede tener: Números, letras, mayúsculas y minúsculas, y los signos |_=&%.,~:/?[+!@()>- .Los caracteres con signos no están soportados, como los acentos o signos no especificados. |
Respuesta Transaction.create() Mall
response.getToken();
response.getUrl();
$response->getToken();
$response->getUrl();
response.Token;
response.Url;
response.token
response.url
## Versión 3.x del SDK
response['token']
response['url']
## Versión 2.x del SDK
response.token
response.url
response.token
response.url
200 OK
Content-Type: application/json
{
"token": "e9d555262db0f989e49d724b4db0b0af367cc415cde41f500a776550fc5fddd3",
"url": "https://webpay3gint.transbank.cl/webpayserver/initTransaction"
}
| Nombre tipo |
Descripción |
|---|---|
| token String |
Token de la transacción. Largo: 64. |
| url String |
URL de formulario de pago Webpay. Largo máximo: 256. |
Confirmar una transacción mall
Puedes revisar más detalles de esta operación en [su documentación](https://www.transbankdevelopers.cl/documentacion/webpay-plus#confirmar-una-transaccion-mall)
Permite confirmar una tranascción y obtener el resultado de la transacción una vez que Webpay ha resueltosu autorización financiera.
Transaction.commit() Mall
WebpayPlus.MallTransaction mallTransaction = WebpayPlus.MallTransaction.buildForIntegration("commerceCode", "APIKey");
final WebpayPlusMallTransactionCommitResponse response = mallTransaction.commit(token);
$mallTransaction = MallTransaction::buildForIntegration($apiKey, $commerceCode);
$response = $mallTransaction->commit($token);
using Transbank.Webpay.WebpayPlus;
MallTransaction mallTransaction = MallTransaction.buildForIntegration("commerceCode", "APIKey");
var response = mallTransaction.Commit(token);
@mall_transaction = Transbank::Webpay::WebpayPlus::MallTransaction.build_for_integration("commerceCode", "APIKey");
@resp = @mall_transaction.commit(token: @token);
mall_tx = MallTransaction.build_for_integration("commerceCode", "APIKey")
resp = mall_tx.commit(token)
const mallTransaction = WebpayPlus.MallTransaction.buildForIntegration(
"commerceCode",
"APIKey"
);
const response = await mallTransaction.commit(token);
PUT /rswebpaytransaction/api/webpay/v1.2/transactions/{token}
Tbk-Api-Key-Id: 597055555535
Tbk-Api-Key-Secret: 579B532A7440BB0C9079DED94D31EA1615BACEB56610332264630D42D0A36B1C
Content-Type: application/json
Parámetros Transaction.commit Mall
| Nombre tipo |
Descripción |
|---|---|
| token String |
Token de la transacción. Largo: 64. (Se envía en la URL, no en el body) |
Respuesta Transaction.commit Mall
response.getAccountingDate();
response.getBuyOrder();
final CardDetail cardDetail = response.getCardDetail();
cardDetail.getCardNumber();
response.getSessionId();
response.getTransactionDate();
response.getVci();
final List<Detail> details = response.getDetails();
for (Detail detail : details) {
detail.getAmount();
detail.getAuthorizationCode();
detail.getBuyOrder();
detail.getCommerceCode();
detail.getInstallmentsNumber();
detail.getPaymentTypeCode();
detail.getResponseCode();
detail.getStatus();
}
$response->getAccountingDate();
$response->getBuyOrder();
$response->getCardDetail();
$response->getCardNumber(); // Solo en SDK 2.x
$response->getSessionId();
$response->getTransactionDate();
$response->getVci();
$details = $response->getDetails();
foreach($details as $detail){ // En SDk 2.x cada $detail es un Objeto TransactionDetails
$detail->getAmount();
$detail->getAuthorizationCode();
$detail->getBuyOrder();
$detail->getCommerceCode();
$detail->getInstallmentsNumber();
$detail->getPaymentTypeCode();
$detail->getResponseCode();
$detail->getStatus();
$detail->isApproved(); // Solo en SDK 2.x - Indica si esta sub transacción puede ser considerada como aprobada
}
$response->isApproved(); // Solo en SDK 2.x - Devuelve true si al menos una de las subtransacciones fue autorizada.
response.AccountingDate;
response.BuyOrder;
var cardDetail = response.CardDetail;
cardDetail.CardNumber;
response.SessionId;
response.TransactionDate;
response.Vci;
var details = response.Details;
foreach (var detail in details) {
detail.Amount;
detail.AuthorizationCode;
detail.BuyOrder;
detail.CommerceCode;
detail.InstallmentsNumber;
detail.PaymentTypeCode;
detail.ResponseCode;
detail.Status;
}
response.accounting_date
response.buy_order
card_detail = response.card_detail
card_detail.card_number
response.session_id
response.transaction_date
response.vci
details = response.details
details.each do |detail|
detail.amount
detail.authorization_code
detail.buy_order
detail.commerce_code
detail.installments_number
detail.payment_type_code
detail.response_code
detail.status
end
## Versión 3.x del SDK
response['accounting_date']
response['buy_order']
response['card_detail']
response['session_id']
response['transaction_date']
response['vci']
## Versión 2.x del SDK
response.accounting_date
response.buy_order
card_detail = response.card_detail
card_detail.card_number
response.session_id
response.transaction_date
response.vci
details = response.details
for detail in details:
detail.amount
detail.authorization_code
detail.buy_order
detail.commerce_code
detail.installments_number
detail.payment_type_code
detail.response_code
detail.status
response.accounting_date
response.buy_order
cardDetail = response.card_detail
cardDetail.card_number
response.session_id
response.transaction_date
response.vci
details = response.details
details.forEach(detail => {
detail.amount
detail.authorization_code
detail.buy_order
detail.commerce_code
detail.installments_number
detail.payment_type_code
detail.response_code
detail.status
});
200 OK
Content-Type: application/json
{
"buy_order": "415034240",
"card_detail": {
"card_number": "6623"
},
"accounting_date": "0321",
"transaction_date": "2019-03-21T15:43:48.523Z",
"details": [
{
"amount": 10000,
"status": "AUTHORIZED",
"authorization_code": "1213",
"payment_type_code": "VN",
"response_code": 0,
"installments_number": 0,
"commerce_code": "597055555536",
"buy_order": "505479072",
"status": "AUTHORIZED"
}]
}
| Nombre tipo |
Descripción |
|---|---|
| buy_order String |
Orden de compra del mall. Largo máximo: 26 |
| session_id String |
Identificador de sesión, el mismo enviado originalmente por el comercio en Transaction.create() . Largo máximo: 61. |
| card_detail carddetails |
Objeto que representa los datos de la tarjeta de crédito del tarjeta habiente. |
| card_detail.card_number String |
4 últimos números de la tarjeta de crédito del tarjetahabiente. Largo máximo: 16. |
| accouting_date String |
Fecha de la autorización. Largo: 4, formato MMDD |
| transaction_date String |
Fecha y hora de la autorización. Largo: 24, formato: ISO 8601 (Ej: yyyy-mm-ddTHH:mm:ss.xxxZ) |
| vci String |
Resultado de la autenticación del tarjetahabiente. Algunos de ellos son: TSY - Autenticación Exitosa TSN - Autenticación Rechazada NP - No Participa, sin autenticación U3 - Falla conexión, Autenticación Rechazada INV - Datos Inválidos A - Intentó CNP1 - Comercio no participa EOP - Error operacional BNA - BIN no adherido ENA - Emisor no adherido Para venta extranjera, estos son algunos de los códigos: TSYS (Autenticación exitosa Sin fricción. Resultado autenticación: Autenticación Existosa) TSAS (Intento, tarjeta no enrolada / emisor no disponible. Resultado autenticación: Autenticación Exitosa) TSNS (Fallido, no autenticado, denegado / no permite intentos. Resultado autenticación: Autenticación denegada) TSRS (Autenticación rechazada - sin fricción. Resultado autenticación: Autenticación rechazada) TSUS (Autenticación no se pudo realizar por problema técnico u otro motivo. Resultado autenticación: Autenticación fallida) TSCF (Autenticación con fricción (No aceptada por el comercio). Resultado autenticación: Autenticación incompleta) TSYF (Autenticación exitosa con fricción. Resultado autenticación: Autenticación exitosa) TSNF (No autenticado. Transacción denegada con fricción. Resultado autenticación: Autenticación denegada) TSUF (Autenticación con fricción no se pudo realizar por problema técnico u otro. Resultado autenticación: Autenticación fallida) NPC (Comercio no Participa. Resultado autenticación: Comercio/BIN no participa) NPB (BIN no participa. Resultado autenticación: Comercio/BIN no participa) NPCB (Comercio y BIN no participan. Resultado autenticación: Comercio/BIN no participa) SPCB (Comercio y BIN sí participan. Resultado autenticación: Autorización incompleta) Este campo es información adicional suplementaria al responseCode pero el comercio no debe validar este campo porque constantemente se agregan nuevos mecanismos de autenticación que se traducen en nuevos valores para este campo que no están necesariamente documentados. |
| details Array |
Lista con resultado de cada una de las transacciones enviados en Transaction.create() . |
| details [].authorization_code String |
Código de autorización de la transacción Largo máximo: 6 |
| details [].payment_type_code String |
VD = Venta Débito. VN = Venta Normal. VC = Venta en cuotas. SI = 3 cuotas sin interés. S2 = 2 cuotas sin interés. NC = N Cuotas sin interés VP = Venta Prepago. |
Number
0 = Transacción aprobada
Puedes revisar los códigos de respuesta de rechazo en el siguiente
[link](https://www.transbankdevelopers.cl/producto/webpay#codigos-de-respuesta-de-autorizacion)Formato número entero para transacciones en peso y decimal para transacciones en dólares.
Number
Number
String
String
String
Number
Obtener estado de una transacción mall
Puedes revisar más detalles de esta operación en [su documentación](https://www.transbankdevelopers.cl/documentacion/webpay-plus#obtener-estado-de-una-transaccion-mall)
Esta operación permite obtener el estado de la transacción en cualquier momento. En condiciones normales es probable que no se requiera ejecutar, pero en caso de ocurrir un error inesperado permite conocer el estado y tomar las acciones que correspondan.
Transaction.status() Mall
Obtiene resultado de transacción a partir de un token.
WebpayPlus.MallTransaction mallTransaction = WebpayPlus.MallTransaction.buildForIntegration("commerceCode", "APIKey");
final WebpayPlusMallTransactionStatusResponse response = mallTransaction.status(token);
$mallTransaction = MallTransaction::buildForIntegration($apiKey, $commerceCode);
$response = $mallTransaction->status($token);
MallTransaction mallTransaction = MallTransaction.buildForIntegration("commerceCode", "APIKey");
var response = mallTransaction.Status(token);
@mall_transaction = Transbank::Webpay::WebpayPlus::MallTransaction.build_for_integration("commerceCode", "APIKey");
@resp = @mall_transaction.status(token: @token);
mall_tx = MallTransaction.build_for_integration("commerceCode", "APIKey")
resp = mall_tx.status(token)
const mallTransaction = WebpayPlus.MallTransaction.buildForIntegration(
"commerceCode",
"APIKey"
);
const response = await mallTransaction.status(token);
GET /rswebpaytransaction/api/webpay/v1.2/transactions/{token}
Tbk-Api-Key-Id: 597055555535
Tbk-Api-Key-Secret: 579B532A7440BB0C9079DED94D31EA1615BACEB56610332264630D42D0A36B1C
Content-Type: application/json
Parámetros Transaction.status Mall
| Nombre tipo |
Descripción |
|---|---|
| token String |
Token de la transacción. Largo: 64. (Se envía en la URL, no en el body) |
Respuesta Transaction.status Mall
response.getAccountingDate();
response.getBuyOrder();
final CardDetail cardDetail = response.getCardDetail();
cardDetail.getCardNumber();
response.getSessionId();
response.getTransactionDate();
response.getVci();
final List<Detail> details = response.getDetails();
for (Detail detail : details) {
detail.getAmount();
detail.getAuthorizationCode();
detail.getBuyOrder();
detail.getCommerceCode();
detail.getInstallmentsNumber();
detail.getPaymentTypeCode();
detail.getResponseCode();
detail.getStatus();
}
$response->getAccountingDate();
$response->getBuyOrder();
$response->getCardDetail();
$response->getCardNumber(); // Solo en SDK 2.x
$response->getSessionId();
$response->getTransactionDate();
$response->getVci();
$details = $response->getDetails();
foreach($details as $detail){ // En SDk 2.x cada $detail es un Objeto TransactionDetails
$detail->getAmount();
$detail->getAuthorizationCode();
$detail->getBuyOrder();
$detail->getCommerceCode();
$detail->getInstallmentsNumber();
$detail->getPaymentTypeCode();
$detail->getResponseCode();
$detail->getStatus();
$detail->isApproved(); // Solo en SDK 2.x - Indica si esta sub transacción puede ser considerada como aprobada
}
$response->isApproved(); // Solo en SDK 2.x - Devuelve true si al menos una de las subtransacciones fue autorizada.
response.AccountingDate;
response.BuyOrder;
var cardDetail = response.CardDetail;
cardDetail.CardNumber;
response.SessionId;
response.TransactionDate;
response.Vci;
var details = response.Details;
foreach (var detail in details) {
detail.Amount;
detail.AuthorizationCode;
detail.BuyOrder;
detail.CommerceCode;
detail.InstallmentsNumber;
detail.PaymentTypeCode;
detail.ResponseCode;
detail.Status;
}
response.accounting_date
response.buy_order
card_detail = response.card_detail
card_detail.card_number
response.session_id
response.transaction_date
response.vci
details = response.details
details.each do |detail|
detail.amount
detail.authorization_code
detail.buy_order
detail.commerce_code
detail.installments_number
detail.payment_type_code
detail.response_code
detail.status
end
## Versión 3.x del SDK
response['accounting_date']
response['buy_order']
response['card_detail']
response['session_id']
response['transaction_date']
response['vci']
## Versión 2.x del SDK
response.accounting_date
response.buy_order
card_detail = response.card_detail
card_detail.card_number
response.session_id
response.transaction_date
response.vci
details = response.details
for detail in details:
detail.amount
detail.authorization_code
detail.buy_order
detail.commerce_code
detail.installments_number
detail.payment_type_code
detail.response_code
detail.status
response.accounting_date
response.buy_order
cardDetail = response.card_detail
cardDetail.card_number
response.session_id
response.transaction_date
response.vci
details = response.details
details.forEach(detail => {
detail.amount
detail.authorization_code
detail.buy_order
detail.commerce_code
detail.installments_number
detail.payment_type_code
detail.response_code
detail.status
});
200 OK
Content-Type: application/json
{
"buy_order": "415034240",
"card_detail": {
"card_number": "6623"
},
"accounting_date": "0321",
"transaction_date": "2019-03-21T15:43:48.523Z",
"vci": "TSY",
"details": [
{
"amount": 10000,
"status": "AUTHORIZED",
"authorization_code": "1213",
"payment_type_code": "VN",
"response_code": 0,
"installments_number": 0,
"commerce_code": "597055555536",
"buy_order": "505479072",
"status": "AUTHORIZED"
}]
}
| Nombre tipo |
Descripción |
|---|---|
| buy_order String |
Orden de compra del mall. Largo máximo: 26 |
| session_id String |
Identificador de sesión, el mismo enviado originalmente por el comercio en Transaction.create() . Largo máximo: 61. |
| card_detail carddetails |
Objeto que representa los datos de la tarjeta de crédito del tarjeta habiente. |
| card_detail.card_number String |
4 últimos números de la tarjeta de crédito del tarjetahabiente. Largo máximo: 16. |
| accouting_date String |
Fecha de la autorización. Largo: 4, formato MMDD |
| transaction_date String |
Fecha y hora de la autorización. Largo: 24, formato: ISO 8601 (Ej: yyyy-mm-ddTHH:mm:ss.xxxZ) |
| vci String |
Resultado de la autenticación del tarjetahabiente. Algunos de ellos son: TSY - Autenticación Exitosa TSN - Autenticación Rechazada NP - No Participa, sin autenticación U3 - Falla conexión, Autenticación Rechazada INV - Datos Inválidos A - Intentó CNP1 - Comercio no participa EOP - Error operacional BNA - BIN no adherido ENA - Emisor no adherido Para venta extranjera, estos son algunos de los códigos: TSYS (Autenticación exitosa Sin fricción. Resultado autenticación: Autenticación Existosa) TSAS (Intento, tarjeta no enrolada / emisor no disponible. Resultado autenticación: Autenticación Exitosa) TSNS (Fallido, no autenticado, denegado / no permite intentos. Resultado autenticación: Autenticación denegada) TSRS (Autenticación rechazada - sin fricción. Resultado autenticación: Autenticación rechazada) TSUS (Autenticación no se pudo realizar por problema técnico u otro motivo. Resultado autenticación: Autenticación fallida) TSCF (Autenticación con fricción (No aceptada por el comercio). Resultado autenticación: Autenticación incompleta) TSYF (Autenticación exitosa con fricción. Resultado autenticación: Autenticación exitosa) TSNF (No autenticado. Transacción denegada con fricción. Resultado autenticación: Autenticación denegada) TSUF (Autenticación con fricción no se pudo realizar por problema técnico u otro. Resultado autenticación: Autenticación fallida) NPC (Comercio no Participa. Resultado autenticación: Comercio/BIN no participa) NPB (BIN no participa. Resultado autenticación: Comercio/BIN no participa) NPCB (Comercio y BIN no participan. Resultado autenticación: Comercio/BIN no participa) SPCB (Comercio y BIN sí participan. Resultado autenticación: Autorización incompleta) Este campo es información adicional suplementaria al responseCode pero el comercio no debe validar este campo porque constantemente se agregan nuevos mecanismos de autenticación que se traducen en nuevos valores para este campo que no están necesariamente documentados. |
| details Array |
Lista con resultado de cada una de las transacciones enviados en Transaction.create() . |
| details [].authorization_code String |
Código de autorización de la transacción Largo máximo: 6 |
| details [].payment_type_code String |
VD = Venta Débito. VN = Venta Normal. VC = Venta en cuotas. SI = 3 cuotas sin interés. S2 = 2 cuotas sin interés. NC = N Cuotas sin interés VP = Venta Prepago. |
Number
0 = Transacción aprobada
Puedes revisar los códigos de respuesta de rechazo en el siguiente
[link](https://www.transbankdevelopers.cl/producto/webpay#codigos-de-respuesta-de-autorizacion)Formato número entero para transacciones en peso y decimal para transacciones en dólares.
Number
Number
String
String
String
Number
Reversar o anular una transaccion mall
Puedes revisar más detalles de esta operación en [su documentación](https://www.transbankdevelopers.cl/documentacion/webpay-plus#reversar-o-anular-una-transaccion-mall)
Este método permite a todo comercio habilitado reversar o anular una transacción que fue generada en Webpay Plus Mall.
Para anular una transacción se debe invocar al método Transaction.refund()
.
Transaction.refund() Mall
WebpayPlus.MallTransaction mallTransaction = WebpayPlus.MallTransaction.buildForIntegration("commerceCode", "APIKey");
final WebpayPlusTransactionRefundResponse response = mallTransaction.refund(token, childBuyOrder, commerceCodeStoreOne, amount);
$mallTransaction = MallTransaction::buildForIntegration($apiKey, $commerceCode);
$response = $mallTransaction->refund($token, $buy_order, $commerce_code, $amount);
MallTransaction mallTransaction = MallTransaction.buildForIntegration("commerceCode", "APIKey");
var response = mallTransaction.Refund(token, buyOrder, commerceCode, amount);
@mall_transaction = Transbank::Webpay::WebpayPlus::MallTransaction.build_for_integration("commerceCode", "APIKey");
@resp = @mall_transaction.refund(token: @token, buy_order: @child_buy_order, child_commerce_code: @commerce_store_1, amount: @amount);
mall_tx = MallTransaction.build_for_integration("commerceCode", "APIKey")
resp = mall_tx.refund(token, child_buy_order, commerce_store_1, amount)
const mallTransaction = WebpayPlus.MallTransaction.buildForIntegration(
"commerceCode",
"APIKey"
);
const response = await mallTransaction.refund(
token,
buyOrder,
commerceCodeStoreOne,
amount
);
POST /rswebpaytransaction/api/webpay/v1.2/transactions/{token}/refunds
Tbk-Api-Key-Id: 597055555535
Tbk-Api-Key-Secret: 579B532A7440BB0C9079DED94D31EA1615BACEB56610332264630D42D0A36B1C
Content-Type: application/json
{
"commerce_code": "597055555536",
"buy_order": "ordenCompra12345678",
"amount": 1000
}
Parámetros Transaction.refund Mall
| Nombre tipo |
Descripción |
|---|---|
| token String |
Token de la transacción. Largo: 64. (Se envía en la URL, no en el body) |
| buy_order String |
Orden de compra de la transacción que se requiere anular. Largo máximo: 26. |
| amount Formato número entero para transacciones en peso. Sólo en caso de dólar acepta dos decimales. |
Monto que se desea anular o reversar de la transacción. Largo máximo: 17. |
| commerce_code Number |
Código de comercio de la tienda mall que realizó la transacción. Largo: 12. |
Respuesta Transaction.refund Mall
En el caso de que la transacción corresponda a una Reversa solo se retorna el parámetro type (REVERSED).
response.getAuthorizationCode();
response.getAuthorizationDate();
response.getBalance();
response.getNullifiedAmount();
response.getResponseCode();
response.getType();
$response->getAuthorizationCode();
$response->getAuthorizationDate();
$response->getBalance();
$response->getNullifiedAmount();
$response->getResponseCode();
$response->getType();
response.AuthorizationCode;
response.AuthorizationDate;
response.Balance;
response.NullifiedAmount;
response.ResponseCode;
response.Type;
response.authorization_code
response.authorization_date
response.balance
response.nullified_amount
response.response_code
response.type
## Versión 3.x del SDK
response['authorization_code']
response['authorization_date']
response['balance']
response['nullified_amount']
response['response_code']
response['type']
## Versión 2.x del SDK
response.authorization_code
response.authorization_date
response.balance
response.nullified_amount
response.response_code
response.type
response.authorization_code
response.authorization_date
response.balance
response.nullified_amount
response.response_code
response.type
200 OK
Content-Type: application/json
{
"type": "NULLIFIED",
"authorization_code": "123456",
"authorization_date": "2019-03-20T20:18:20Z",
"nullified_amount": 1000.00,
"balance": 0.00,
"response_code": 0
}
| Nombre tipo |
Descripción |
|---|---|
| type String |
Tipo de reembolso (REVERSED o NULLIFIED). Si es REVERSED no se devolverán datos de la transacción (authorization code, etc). Largo máximo: 10 |
| authorization_code String |
(Solo si es NULLIFIED) Código de autorización de la anulación. Largo máximo: 6 |
| authorization_date String |
(Solo si es NULLIFIED) Fecha y hora de la autorización. |
| balance Decimal |
(Solo si es NULLIFIED) Saldo actualizado de la transacción (considera la venta menos el monto anulado). Largo máximo: 17 |
| nullified_amount Decimal |
(Solo si es NULLIFIED) Monto anulado. Largo máximo: 17 |
| response_code Number |
(Solo si es NULLIFIED) Código de resultado de la reversa/anulación. Si es exitoso es 0, de lo contrario la reversa/anulación no fue realizada. Largo máximo: 2 |
En caso de error pueden aparecer los siguientes códigos de error comunes para el método Transaction.refund()
:
| Código | Descripción |
|---|---|
| 304 | Validación de campos de entrada nulos |
| 245 | Código de comercio no existe |
| 22 | El comercio no se encuentra activo |
| 316 | El comercio indicado no corresponde al certificado o no es hijo del comercio MALL en caso de transacciones MALL |
| 308 | Operación no permitida |
| 274 | Transacción no encontrada |
| 16 | La transacción no permite anulación |
| 292 | La transacción no está autorizada |
| 284 | Periodo de anulación excedido |
| 310 | Transacción anulada previamente |
| 311 | Monto a anular excede el saldo disponible para anular |
| 312 | Error genérico para anulaciones |
| 315 | Error del autorizador |
| 53 | La transacción no permite anulación parcial de transacciones con cuotas |
Capturar una transacción mall
Puedes revisar más detalles de esta operación en [su documentación](https://www.transbankdevelopers.cl/documentacion/webpay-plus#capturar-una-transaccion-mall)
Permite solicitar a Webpay la captura diferida de una transacción con autorización y sin captura simultánea.
Transaction.capture()
WebpayPlus.MallTransaction mallTransaction = WebpayPlus.MallTransaction.buildForIntegration("commerceCode", "APIKey");
final WebpayPlusMallTransactionCaptureResponse response = mallTransaction.capture(token, commerceCodeStoreOne, childBuyOrder, authorizationCode, amount);
$mallTransaction = MallTransaction::buildForIntegration($apiKey, $commerceCode);
$response = $mallTransaction->capture($commerceCodeStoreOne, $token, $buyOrder, $authorizationCode, $captureAmount);
MallTransaction mallTransaction = MallTransaction.buildForIntegration("commerceCode", "APIKey");
var response = mallTransaction.Capture(token, commerceCodeStoreOne, buyOrder, authorizationCode, captureAmount);
@mall_transaction = Transbank::Webpay::WebpayPlus::MallTransaction.build_for_integration("commerceCode", "APIKey");
@resp = @mall_transaction.capture(child_commerce_code: @commerce_store_1, token: @token, buy_order: @buy_order, authorization_code: @authorization_code, capture_amount: @capture_amount);
mall_tx = MallTransaction.build_for_integration("commerceCode", "APIKey") resp = mall_tx.capture( token=token, capture_amount=amount, commerce_code=commerce_store_1, buy_order=buy_order, authorization_code=authorization_code )
const mallTransaction = WebpayPlus.MallTransaction.buildForIntegration(
"commerceCode",
"APIKey"
);
const response = await mallTransaction.capture(
token,
commerceCodeStoreOne,
buyOrder,
authorizationCode,
captureAmount
);
PUT /rswebpaytransaction/api/webpay/v1.2/transactions/{token}/capture
Tbk-Api-Key-Id: 597055555581
Tbk-Api-Key-Secret: 579B532A7440BB0C9079DED94D31EA1615BACEB56610332264630D42D0A36B1C
Content-Type: application/json
{
"commerce_code": "597055555582",
"buy_order": "your_buy_order_here",
"authorization_code": "your_authorization_code_here",
"capture_amount": 1000
}
Parámetros Transaction.capture
| Nombre tipo |
Descripción |
|---|---|
| token String |
Token de la transacción. Largo: 64. (Se envía en la URL, no en el body) |
| commerce_code Number |
Tienda hija (no usar el código de comercio mall) que realizó la transacción. Largo: 12. |
| buy_order String |
Orden de compra de la transacción que se requiere capturar. Largo máximo: 26. La orden de compra puede tener: Números, letras, mayúsculas y minúsculas, y los signos |_=&%.,~:/?[+!@()>- . Los caracteres con signos no están soportados, como los acentos o signos no especificados. |
| authorization_code String |
Código de autorización de la transacción que se requiere capturar Largo máximo: 6. |
| capture_amount Decimal |
Monto que se desea capturar. Largo máximo: 17. |
Respuesta Transaction.capture
response.getAuthorizationCode();
response.getAuthorizationDate();
response.getCapturedAmount();
response.getResponseCode();
$response->getAuthorizationCode();
$response->getAuthorizationCode();
$response->getAuthorizationDate();
$response->getCapturedAmount();
$response->getResponseCode();
response.AuthorizationCode;
response.AuthorizationDate;
response.CapturedAmount;
response.ResponseCode;
response.authorization_code
response.authorization_date
response.captured_amount
response.response_code
## Versión 3.x del SDK
response['authorization_code']
response['authorization_date']
response['captured_amount']
response['response_code']
## Versión 2.x del SDK
response.authorization_code
response.authorization_date
response.captured_amount
response.response_code
200 OK
Content-Type: application/json
{
"token": "e074d38c628122c63e5c0986368ece22974d6fee1440617d85873b7b4efa48a3",
"authorization_code": "123456",
"authorization_date": "2019-03-20T20:18:20Z",
"captured_amount": 1000,
"response_code": 0
}
| Nombre tipo |
Descripción |
|---|---|
| token String |
Token de la transacción. Largo máximo: 64 |
| authorization_code String |
Código de autorización de la captura diferida. Largo máximo: 6 |
| authorization_date String |
Fecha y hora de la autorización. |
| captured_amount Decimal |
Monto capturado. Largo máximo: 6 |
| response_code Number |
Código de resultado de la captura. Si es exitoso es 0,de lo contrario la captura no fue realizada. Largo máximo: 2 |
En caso de error pueden aparecer los siguientes códigos exclusivos del método
Transaction.capture()
:
| Código | Descripción |
|---|---|
| 304 | Validación de campos de entrada nulos |
| 245 | Código de comercio no existe |
| 22 | El comercio no se encuentra activo |
| 316 | El comercio indicado no corresponde al certificado o no es hijo del comercio Mall en caso de transacciones MALL |
| 308 | Operación no permitida |
| 274 | Transacción no encontrada |
| 16 | La transacción no es de captura diferida |
| 292 | La transacción no está autorizada |
| 284 | Periodo de captura excedido |
| 310 | Transacción reversada previamente |
| 309 | Transacción capturada previamente |
| 311 | Monto a capturar excede el monto autorizado |
| 315 | Error del autorizador |
Códigos y mensajes de error
Al realizar cualquier solicitud al API REST, además de los datos de respuesta, se incluirá uno de los siguientes códigos de estado de respuesta HTTP dependiendo del resultado obtenido:
Solicitud exitosa
Cuando la operación solicitada es ejecutada correctamente, se pueden recibir estos status HTTP:
| Código de estado HTTP | Descripción |
|---|---|
| 200 | La operación se ha ejecutado exitosamente |
| 204 | La operación DELETE se ha ejecutado exitosamente |
Códigos de error
Todos los errores reportados por la API REST de Webpay despliegan un mensaje JSON con una descripción del error.
{
"error_message": "token is required"
}
| Código de estado HTTP | Descripción |
|---|---|
| 400 | El mensaje JSON es inválido. Puedes ser que no corresponda a un mensaje bien estructurado o que contenga un campo no esperado. |
| 401 | No autorizado. API Key y/o API Secret inválidos |
| 404 | La transacción no ha sido encontrada. |
| 405 | Método no permitido. |
| 406 | No fue posible procesar la respuesta en el formato que el cliente indica. |
| 415 | Tipo de mensaje no permitido. |
| 422 | El requerimiento no ha podido ser procesado ya sea por validaciones de datos o por lógica de negocios. |
| 500 | Ha ocurrido un error inesperado. |
Puesta en Producción
Puedes revisar el proceso necesario para operar en el ambiente de producción en [la documentación](https://www.transbankdevelopers.cl/documentacion/como_empezar#puesta-en-produccion)
Configuración SDK
Los SDK deben configurarse explícitamente para apuntar al ambiente que quieras utilizar (producción / integración). Para esto puedes crear los objetos de 2 maneras:
-
Utilizar los métodos definidos para ello (
buildForIntegration
obuildForProduction
). -
Utilizar un objeto
Options
que contenga la configuración y pasarlo en el constructor de cada objeto.
Puede encontrar más información al respecto [en este link](https://www.transbankdevelopers.cl/documentacion/como_empezar#b-utilizando-los-sdk)
Configuración para producción utilizando los SDK
Si estas utilizando algún SDK oficial de Transbank, entonces debes seguir los siguientes pasos.
Revisa la [esta sección](https://www.transbankdevelopers.cl/documentacion/como_empezar#b-utilizando-los-sdk) de la documentación para ver el código necesario para configurar tu propio código de comercio y Api Key Secret.

# referencia_host-to-host-wifi.md

Source: https://www.transbankdevelopers.cl/referencia/host-to-host-wifi

Host to Host Pinpad Wifi
Protocolo de mensajería
Seguridad TLS 1.2
SSL (Secure Sockets Layer) o Capa de Conexiones Seguras. Es un protocolo que hace uso de certificados digitales para establecer comunicaciones seguras a través de red. Desde el 2015 ha sido sustituido por TLS (Transport Layer Security) el cual está basado en SSL y son totalmente compatibles.
Seguridad en la Red WI-FI del Comercio
En el caso de que la red del Comercio requiera usar conexiones por WI-FI se exige que la red sea una red cifrada *WPA2-PSK (AES).
Recomendaciones de seguridad para una red WI-FI: Cambiar regularmente la contraseña de red WI-FI
- Al cambiar regularmente la contraseña de red WI-FI evita que terceras personas puedan hacer uso de la red del comercio.
- Configurar la red WI-FI como “No visible” Al ocultar la red WI-FI se evita que personas externas al comercio puedan encontrar e intentar acceder a la red del comercio. Ahora cada vez que se intente conectar un nuevo dispositivo, será necesario colocar primero la *SSID, para posteriormente ingresar la contraseña
- Registrar y restringir las conexiones por MAC Al tener habilitadas las conexiones por MAC, se especifica que equipos pueden hacer uso de la red WI-FI, evitando que cualquier otro equipo haga uso de la red del comercio.
- Restringir el acceso a la “Configuración del Router” desde WI-FI Al restringir el acceso a la configuración del Router desde conexiones WI-FI se evita que desde dispositivos WIFI se pueda acceder a esta configuración y se modifiquen sus parámetros.
- Monitorear regularmente las conexiones WI-FI Los Router actuales permiten conocer los dispositivos que están conectados a la red WIFI. Es recomendable monitorear para poder evitar algún dispositivo que esté conectado sin autorización.
*WPA2-PSK (AES): Sistema de protección para redes inalámbricas WI-FI. Es el último estándar de encriptación WI-FI y AES es el más reciente algoritmo de cifrado.
*SSID: Difusión de un SSID de red. Un SSID es el nombre público de una red de área local inalámbrica (WLAN) que sirve para diferenciarla de otras redes inalámbricas en la zona. SSID es el nombre de la red que se especifica al configurar la red WI-Fi.
Archivo de implementación TLS
La implementación de TLS realizada es la de autenticación mutua two-way, es decir el PinPad valida a la caja y a la inversa. Para implementar TLS entre el Pinpad vx680 y la caja del comercio se requieren de los siguientes archivos:
Certificados TLS del Pinpad:
- Certificado cliente: "client.PEM": Certificado con el que se presenta al Servidor.
- Llave de validación del certificado de cliente: "client.key": Necesario para validar que el certificado cargado es el que corresponde.
- Certificado para validar el servidor: "CA.PEM": Para validar el certificado del Servidor.
Certificados TLS del Servidor (Caja del Comercio):
- Certificado servidor: "server.PEM": Certificado con el que se presenta al cliente.
- Llave de validación del certificado de servidor: "server.key": Llave privada usada para firmar.
- Certificado para validar el cliente: "CAClient.PEM": Para validar el certificado del cliente.
Implementación TLS
Se debe cifrar el canal de comunicación con la versión más reciente del protocolo de comunicación TLS. Se debe usar la autenticación doble (Two-way TLS) para darle mayor seguridad a proceso.
![Implementación TLS](https://www.transbankdevelopers.cl/public/slate-library/images/documentacion/host2host/implementacion-tls.png)
El cliente tiene la CA del certificado del servidor en su almacén de confianza. Durante el protocolo de enlace TLS, el cliente compara la CA certificado en su almacén de confianza con el envío del certificado desde el servidor para verificar la identidad del servidor. El servidor tiene la CA del certificado del cliente en su almacén de confianza. Durante el protocolo de enlace TLS, el servidor compara la CA en su almacén de confianza con el envío del certificado del cliente para verificar la identidad del cliente.
Dependiendo del lenguaje o plataforma, se debe especificar la ubicación de los “Almacenes de Certificados” (KeyStore y TrustStore). Dependiendo del lenguaje o plataforma se crea un KeyStore para el certificado y la llave privada del Servidor y un TrustStore para el “Certificado CA” del Pinpad.
//Especificamos el KeyStore que contiene el certificado del Servidor y la llave privada
KeyStore keyStore = KeyStore.getInstance("JKS");
keyStore.load(new FileInputStream("server/serverKeyStore.jks"),"servpass".toCharArray());
KeyManagerFactory kmf = KeyManagerFactory.getInstance(KeyManagerFactory.getDefaultAlgorithm());
kmf.init(keyStore, "servpass".toCharArray());
//Especificamos el TrustStore que contiene el Certificado CA del cliente
KeyStore trustedStore = KeyStore.getInstance("JKS");
trustedStore.load(new FileInputStream("server/serverTrustedCerts.jks"),"servpass".toCharArray());
TrustManagerFactory tmf = TrustManagerFactory.getInstance(TrustManagerFactory.getDefaultAlgorithm());
tmf.init(trustedStore);
//Creamos la instancia TLS
SSLContext sc = SSLContext.getInstance("TLSv1.2");
TrustManager[] trustManagers = tmf.getTrustManagers();
KeyManager[] keyManagers = kmf.getKeyManagers();
sc.init(keyManagers, trustManagers, null);
//se crea el socket que se usara para la comunicación
SSLServerSocketFactory ssf = sc.getServerSocketFactory();
serverSocket = (SSLServerSocket) ssf.createServerSocket(port);
try {
//Esperamos que el PINPAD se conecte
Socket aClient = serverSocket.accept();
System.out.println("client accepted");
aClient.setSoLinger(true, 1000);
aClient.setSoTimeout(10 * 1000);
//Leemos lo enviado desde el PINPAD
BufferedReader input = new BufferedReader(new InputStreamReader(aClient.getInputStream()));
String recibido = input.readLine();
System.out.println("Recibido " + recibido);
//Enviamos ACK al Pinpad
PrintWriter output = new PrintWriter(aClient.getOutputStream());
output.println("0004ACK ");
output.flush();
//Enviamos Comando al Pinpad
output.println("0025CONN|00|01|Texto línea 1|");
output.flush();
} catch (Exception e) {
e.printStackTrace();
}
Protocolo de comunicación TCP/IP
Este protocolo permite la comunicación entre un ECR (Electronic Cash Register) y un PINPAD a través de una red que soporte el protocolo TCP/IP. Es importante tener en consideración el control de errores sobre las funciones de TCP/IP para asegurar que cada uno de los mensajes llegue al destinatario y hacer gestión sobre los reintentos cuando sea necesario. El siguiente diagrama ejemplifica la construcción de los comandos en el protocolo TCP/IP.
![Protocolo TCP/IP](https://www.transbankdevelopers.cl/public/slate-library/images/documentacion/host2host/protocolo-tcp.png)
Donde:
- LARGO_DATA: 4 bytes indicando el largo del mensaje, sin incluir estos 4 bytes.
- DATA: Es el mensaje que se quiere enviar.
Diagrama genérico de secuencia de comandos
El diagrama que se describe corresponde a la generalización del comportamiento de cada uno de los comandos.
![Protocolo TCP/IP Caja a Pinpad](https://www.transbankdevelopers.cl/public/slate-library/images/documentacion/host2host/flujo-secuencia-wifi.png)
![Protocolo TCP/IP PinPad a Caja](https://www.transbankdevelopers.cl/public/slate-library/images/documentacion/host2host/flujo-secuencia-wifi-pinpad-caja.png)
Flujo de venta detallado
![Secuencia detallada venta](https://www.transbankdevelopers.cl/public/slate-library/images/documentacion/host2host/secuencia-detallada-venta-wifi.png)
Diagrama
![Diagrama detallada venta](https://www.transbankdevelopers.cl/public/slate-library/images/documentacion/host2host/diagrama-flujo-detallado-venta.png)
Ejemplo de venta:
0100|00|N|N|N|12100|CL|CR||0|0|
0110|00|2017111611350940|01|||||5197||MASTERCARD|MC|N| 4
0200|12100|0||0|0|2017111611350940|00|597044440001|S4HOST2HOST3DES1||||17111611361100
000000000754||0123456789ABCDEF|||||5197| v
0210|00|2017111611350940|0737|9.12S4HOST2HOST3DES1
171116113517FO00050000B000000000000012100P1Q0123456789ABCDEFa000000000000000000000000
00NU1711161136110000000000075400000000000000000CL0000000d597044440001e00h0010050081G3
F3308F4S0t74 0000000000000000326-478-322 15.30C
6-E051-I152-O0180152171116B8738FEAC1697887380000669B8C9262000000800000152000000012100
0000000000000014A78003040000716800000000000000FF-P0100224403020002
E0F8C826478322RA00000000410109-A1EL20212223242526272829VI0 6MC0 67DC0
6AX012345OTTP06TR01TE0 TM0 TC12TD12TJ12TH12T812T90
-B41205240-C2100-P000000000000-I0-J0-K000W0161111005CR 0000-
4F552D8E65F6056E543A481CDD07D2525E2D7347C32D2CA5756F176482684949FD0443BCB1235018CC0CD
DC7C0EA41BF| (
0500|2017111611350940|513|9.12S4HOST2HOST3DES1
171116113521FO00000005B000000000000012100D4EF600979
BGA1B5296BH0D9C83C5A59B574F7AF35145C606D5D4ID5879B9816C5A304236AB90B081A60A0P1Q012345
6789ABCDEFS0
T0000000000W0161111005CRCMC0000a00000000000003000000000000NU1711161136110000000000075
400000000000000000CL0000000d597044440001e00g
APROBADOh0010050081ptS4HOST2HOST3DES16-E051-I1529-A1EL20212223242526272829VI0 6MC0
67DC0 6AX012345OTTP06TR01TE0 TM0 TC12TD12TJ12TH12T812T90
-B11205243-C0000-P100000800000|
0510|00|2017111611350940|597044440001|S4HOST2HOST3DES1|0 |0000|600979
B|12100||00||5197|001005008|CREDITO||************5197|MC|171116|113521||||||||1|1|1|1
|0|05|CR|0|0|0000|SIN CUOTAS|||||||0000|||0000|||0000|||005|
APROBADO|N||0|1||001005008|Y|||
NOTA: Si por algún motivo el pinpad responde un comando en un formato que no corresponde (tipo de dato erróneo, largo incorrecto, separador incorrecto o faltante, etcétera) la caja debe solicitar reversa según el “flujo de ejecución de reversa a solicitud de la caja” detallado a continuación. Posteriormente se debe iniciar un nuevo flujo de venta.
Flujo ejecución de reversa a solicitud de la caja
La caja no tuvo respuesta de algún comando o no tuvo respuesta de un mensaje SPDH en vuelo, por lo tanto no pudo terminar una venta que inicio, luego no sabe si está aprobada o rechazada, en este caso debe solicitar una reversa al pinpad.
![Flujo reversa](https://www.transbankdevelopers.cl/public/slate-library/images/documentacion/host2host/reversa-caja.png)
Ejemplo de reversa:
0400|2019062813081650|
0410|00|2019062813081650|0643|9.07S4CAJAHOST000010
190628130853FT00000000B000000000000650000P1Q0123456789ABCDEFa000000150000000000000000
00NU2019062813091100100100000100000000000000000CL0000000d597044440001e00h0010030051G3
F27A500S0t74 0000000000000000326-018-973 18.21P
6-E071-I152-O0180152190628236E485C1DC23FC81980067116EE3A5C000000800000152000000650000
0000000000000110A04001220000000000000000000000FF-P0101221F03020002
00080826018973A00000000410109-A1EL20252627 VI123456MC123456DC
AX123456OTTP06TR1 TE0 TM0 TC12TD12TJ12TH12T812T90
-B41205240-C2100-P000000000000-I0-J1-K000-M1W0161111005CR 0000|
0500|2019062813081650|643|9.07S4CAJAHOST000010
190628130853FT00000000B000000000000650000P1Q0123456789ABCDEFa000000150000000000000000
00NU2019062813091100100100000100000000000000000CL0000000d597044440001e00h0010030051G3
F27A500S0t74 0000000000000000326-018-973 18.21P
6-E071-I152-O0180152190628236E485C1DC23FC81980067116EE3A5C000000800000152000000650000
0000000000000110A04001220000000000000000000000FF-P0101221F03020002
00080826018973A00000000410109-A1EL20252627 AX123456OTTP06TR1 TE0 TM0 TC12TD12TJ12TH12T812T90
-B41205240-C2100-P000000000000-I0-J1-K000-M1W0161111005CR 0000|
0510|00|2019062813081650|597044440001|S4CAJAHOST000010|||265404
B|650000||00||0003|001003005|CREDITO||************0003|
|190628|130853||||||||1|1|1|1|0|05|CR|0|0|0000|SIN
CUOTAS|||||||0000|||0000|||0000|||000|REVERSA APLICADA|N||0|1||001003005|Y|||
Diagrama Inicialización y conexión al PINPAD
![Diagrama inicialización y conexión](https://www.transbankdevelopers.cl/public/slate-library/images/documentacion/host2host/diagrama-inicializacion-y-conexion.png)
Flujo de ejecución de comandos al PINPAD
![Flujo de ejecución de comandos](https://www.transbankdevelopers.cl/public/slate-library/images/documentacion/host2host/flujo-comandos-pinpad-wifi.png)
Manejo de contexto
![Flujo de ejecución de comandos](https://www.transbankdevelopers.cl/public/slate-library/images/documentacion/host2host/manejo-de-contexto.png)
Descripción de comandos
0100 - Comando Lectura de tarjeta
Igual al Retail estándar vx805
0200 - Comando Requerimiento de venta/anulación
Igual al Retail estándar vx805
0400 - Comando Requerimiento de reversa
Igual al Retail estándar vx805
0500 - Comando Requerimiento de validación/actualización
Igual al Retail estándar vx805
0520 - Comando Requerimiento de validación respuesta de transacción
Este comando es un homologo al 500, donde caja entrega el mensaje spdh al pinpad, pero el pinpad cuando la transacción está aprobada oculta el mensaje en pantalla, si la transacción es rechazada se comporta igual al comando 510. Al finalizar la transacción caja debe enviar comando 1100 al pinpad con el mensaje que se requiere desplegar en pantalla (Aprobado).
Requerimiento
| DATO | LARGO | COMENTARIO | VALOR POR DEFECTO |
|---|---|---|---|
| LARGO_DATA | 4 | Valor numérico (0000 -> 9999) Indicando el largo del mensaje, sin incluir estos 4 bytes | |
| Comando | 4 | Valor 0520 | |
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
|
| Indicador de contexto | 16 | Valor alfanumérico Formato aaaammddhhmmssmm | |
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
|
| Largo mensaje | 4 | Valor Numérico | |
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
|
| Mensaje SPDH | 2048 | Valor alfanumérico (máximo) | |
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
Nota: No despliega glosa en pantalla del PINPAD ni actualiza parámetros
Respuesta
| DATO | LARGO | COMENTARIO | VALOR POR DEFECTO |
|---|---|---|---|
| LARGO_DATA | 4 | Valor numérico (0000 -> 9999) Indicando el largo del mensaje, sin incluir estos 4 bytes | |
| Comando | 4 | Valor 0530 | |
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
|
| Código Respuesta | 2 | Valor numérico De acuerdo a Tabla de códigos de respuesta decomandos | |
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
|
| Indicador de contexto | 16 | Valor alfanumérico Formato aaaammddhhmmssmm | |
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
|
| Código de comercio | 12 | Valor alfanumérico | |
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
|
| Terminal ID | 16 | Valor Alfanumérico Campo “t” mensaje SPDH |
|
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
|
| Número Ticket/Boleta | 20 | Valor alfanumérico Campo “S” mensaje SPDH |
|
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
|
| Empleado | 4 | Valor alfanumérico Campo “T” mensaje SPDH |
|
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
|
| Código Autorización | 8 | Valor Alfanumérico (máximo) Campo “F” mensaje SPDH |
|
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
|
| Monto | 18 | Valor numérico (máximo) Campo “B” mensaje SPDH |
|
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
|
| Monto vuelto | 18 | Valor numérico (máximo) | |
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
|
| Numero de Cuotas | 2 | Valor numérico Del campo “W” mensaje SPDH |
|
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
|
| Monto Cuota | 14 | Valor numérico Del campo “W” mensaje SPDH |
|
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
|
| Últimos 4 Dígitos Tarjeta | 4 | Valor Numérico | |
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
|
| Número Operación | 6 | Correlativo de transacción del terminal (máximo) | |
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
|
| Glosa Tipo de Tarjeta | 7 | Valor alfanumérico (máximo) Valor de glosa en Tabla tipo de tarjeta de acuerdo “Tipo de tarjeta” del campo “W” mensaje SPDH |
|
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
|
| Fecha Contable | 6 | Valor alfanumérico Se utiliza sólo si es transacción de Debito Del campo “a” mensaje SPDH |
|
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
|
| Número de Cuenta | 19 | Valor alfanumérico Número de tarjeta enmascarado para incluir en el voucher Campo “E” mensaje SPDH |
|
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
|
| Abreviación de la tarjeta | 2 | Valor alfanumérico Del campo “W” mensaje SPDH |
|
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
|
| Fecha Transacción | 6 | Formato AAMMDD Del encabezado mensaje SPDH | |
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
|
| Hora Transacción | 6 | Formato HHMMSS Del encabezado mensaje SPDH | |
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
|
| Campo Impresión | 8192 | Campo depende si la caja requiere voucher formateado (máximo) | |
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
|
| Transacción premiada | 1 | Valor numérico Posición 1, campo “f” mensaje SPDH (1: Entrega Pto. de Venta) (2: Entrega Diferida) |
(3: Devolución al Tarjeta Habiente) |
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
|
| Tipo promoción | 1 | Valor numérico Posición 2, campo “f” mensaje SPDH |
|
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
|
| Código promoción | 8 | Valor alfanumérico Posición 3-10, campo “f” mensaje SPDH |
|
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
|
| Nombre promoción | 21 | Valor alfanumérico Posición 11-31, campo “f” mensaje SPDH |
|
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
|
| Glosa vale premio | 62 | Valor alfanumérico Posición 32-93, campo “f” mensaje SPDH |
|
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
|
| Texto vale premio | 27 | Valor alfanumérico Posición 94-120, campo “f” mensaje SPDH |
|
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
|
| Flag permite cuotas | 1 | Valor numérico Del campo “W” mensaje SPDH |
0 |
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
|
| Flag de gracia | 1 | Valor numérico Del campo “W” mensaje SPDH |
0 |
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
|
| Flag C2C | 1 | Valor numérico Del campo “W” mensaje SPDH |
0 |
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
|
| Flag C3C | 1 | Valor numérico Del campo “W” mensaje SPDH |
0 |
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
|
| Flag NCuotas | 1 | Valor numérico Del campo “W” mensaje SPDH |
0 |
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
|
| Flag máximo de cuotas | 2 | Valor numérico Del campo “W” mensaje SPDH |
|
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
|
| Tipo de menú | 2 | Valor alfanumérico Del campo “W” mensaje SPDH |
|
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
|
| Indicador transacción con gracia | 1 | Valor numérico Del campo “W” mensaje SPDH |
|
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
|
| Tipo cuotas | 1 | Valor numérico Del campo “W” mensaje SPDH (1 : Normal) (3 : C3C o C2C) (4 : Cic o N-cuotas) |
|
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
|
| Tasa aplicada | 4 | Valor numérico Del campo “W” mensaje SPDH Solo se imprime en voucher si “Flag imprimir tasa = 1” |
|
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
|
| Glosa tipo cuota | 30 | Valor alfanumérico Del campo “W” mensaje SPDH (Glosa a imprimir en voucher) |
|
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
|
| Glosa tipo cuota 2 | 22 | Valor alfanumérico Del campo “W” mensaje SPDH (Glosa que se despliega en PINPAD) |
|
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
|
| Glosa promoción | 10 | Valor alfanumérico Del campo “W” mensaje SPDH |
|
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
|
| Id promoción | 8 | Valor alfanumérico Del campo “W” mensaje SPDH |
|
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
|
| Flag imprimir tasa | 1 | Valor numérico Del campo “W” mensaje SPDH |
|
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
|
| Periodo diferido | 3 | Valor numérico Del campo “W” mensaje SPDH |
|
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
|
| Diferido 1 periodo | 3 | Valor numérico Del campo “W” mensaje SPDH |
|
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
|
| Diferido 1 valor tasa | 4 | Valor numérico Del campo “W” mensaje SPDH |
|
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
|
| Diferido 1 valor cuota | 14 | Valor numérico Del campo “W” mensaje SPDH |
|
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
|
| Diferido 2 periodo | 3 | Valor numérico Del campo “W” mensaje SPDH |
|
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
|
| Diferido 2 valor tasa | 4 | Valor numérico Del campo “W” mensaje SPDH |
|
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
|
| Diferido 2 valor cuota | 14 | "Valor numérico Del campo “W” mensaje SPDH" |
|
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
|
| Diferido 3 periodo | 3 | Valor numérico Del campo “W” mensaje SPDH |
|
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
|
| Diferido 3 valor tasa | 4 | Valor numérico Del campo “W” mensaje SPDH |
|
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
|
| Diferido 3 valor cuota | 14 | Valor numérico Del campo “W” mensaje SPDH |
|
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
|
| Número de secuencia transacción original | 9 | Valor alfanumérico (máximo) Campo “i”. Sólo para anulaciones |
|
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
|
| Código respuesta Transbank | 3 | Valor Numérico | |
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
|
| Glosa respuesta Transbank | 48 | Valor alfanumérico (máximo) Campo “g” mensaje SPDH |
|
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
|
| Flag transacción con PIN | 1 | Valor alfanumérico (Y: Transacción autentificada con PIN) (N: Transacción autentificada por firma) |
|
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
|
| Nombre tarjetahabiente | 26 | Valor alfanumérico Sólo si “Flag transacción con PIN = N” |
|
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
|
| Flag tipo voucher | 1 | Valor numérico (0: Venta con PIN, sin firma, sin glosa) (1: Venta normal, con firma, con glosa) (2: Venta con PIN, con firma, sin glosa) (3: Venta normal, con firma, sin glosa) Posición 8, subcampo “B” campo “9” mensaje SPDH |
|
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
|
| Flag modalidad cuotas | 1 | Valor alfanumérico (0: Modalidad 3.1) (1: Modalidad nuevas cuotas) |
|
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
|
| Glosa transacción afecta a ahorro | 40 | Valor alfanumérico (máximo) (Se debe imprimir en el voucher cuando corresponda) |
|
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
|
| Número de secuencia | 9 | Valor numérico | |
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
|
| Flag mensaje terminal | 1 | Valor alfanumérico (Y: El mensaje es terminal y NO se debe enviar el mensaje SPDH de respuesta) (N: Se debe enviar el mensaje SPDH de respuesta) |
|
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
|
| Largo mensaje | 4 | Valor numérico | |
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
|
| Mensaje SPDH Venta/Reversa | 2048 | Valor alfanumérico (máximo) | |
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
0560 - Comando Requerimiento de validación respuesta de transacción
Este comando es un homologo al 540, donde la caja entrega el mensaje spdh al pinpad. La diferencia es que el comportamiento definido para el pinpad con este comando es de omitir la glosa de aprobado en pantalla.
La glosa que indica la aprobación de la transacción solo será mostrada en pantalla cuando el pinpad reciba el comando 1100 desde la caja, este comando debe incluir el código del mensaje que se requiere desplegar, para este caso Aprobado.
Cuando la caja requiera finalizar la aprobación de la transacción, una vez haya recibido el comando 570 con el flag terminal en Y, debe enviar el comando 1100 con el código de mensaje a mostrar en el pinpad.
Requerimiento
| DATO | LARGO | COMENTARIO | VALOR POR DEFECTO |
|---|---|---|---|
<STX> |
1 | Indica inicio de comando Valor Hexa 0x02 | STX |
| Comando | 4 | Valor 0560 | 560 |
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
|
| Indicador de contexto | 16 | Valor alfanumérico Id entregado por el pinpad por cada transacción |
|
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
|
| Largo mensaje | 4 | Valor Numérico | |
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
|
| Mensaje SPDH | 2048 | Valor alfanumérico (máximo) | |
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
|
| Nombre Comercio | 40 | Valor Alfanumérico Campo paramétrico en caja enviado al pinpad |
|
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
|
| Dirección Comercio | 40 | Valor Alfanumérico Campo paramétrico en caja enviado al pinpad |
|
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
|
| Comuna Comercio | 40 | Valor Alfanumérico Campo paramétrico en caja enviado al pinpad Puede ser comuna o ciudad |
|
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
|
<ETX> |
1 | Indica Fin de comando Valor Hexa 0x03 | ETX |
<LRC> |
1 | Byte resultado de la operación XOR del mensaje |
Timeout de espera por comando 560 de 125seg, ya que hay hasta 4 interacción con el usuario
Respuesta
| DATO | LARGO | COMENTARIO | VALOR POR DEFECTO | |
|---|---|---|---|---|
| 1 | Indica inicio de comando Valor Hexa 0x02 | STX | ||
| Comando | 4 | Valor 0570 | 570 | |
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
||
| Código Respuesta PinPad | 2 | "Valor numérico En caso de rechazo se debe desplegar en el punto de venta: RECHAZO PINPAD - De acuerdo a Tabla de códigos de respuesta de comandos" |
||
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
||
| Indicador de contexto | 16 | Valor alfanumérico Id entregado por el pinpad por cada transacción |
||
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
||
| Código de comercio | 12 | Valor numérico Código del comercio entregado por TBK y configurado en la caja, se imprime en voucher |
||
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
||
| Terminal ID | 16 | Valor Alfanumérico Dirección lógica entregada por TBK y configurada en la caja, se imprime en voucher |
||
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
||
| Número Ticket/Boleta | 20 | Valor alfanumérico Campo opcional, si viene se imprime en voucher si no viene se omite el campo |
||
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
||
| Empleado | 4 | Valor alfanumérico Campo opcional, si viene se imprime en voucher si no viene se omite el campo |
||
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
||
| Código Autorización | 8 | Valor Alfanumérico (máximo) Código de autorización de la transacción enviado por TBK ejemplo: [AB 12 C3] Se imprime lo que viene en el voucher |
||
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
||
| Monto | 18 | Valor numérico (máximo) Monto total autorizado (incluye el monto de la venta, propina, vuelto y donación según sea el caso) Se imprime en voucher |
||
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
||
| Monto vuelto | 18 | Valor numérico (máximo) Vuelto seleccionado por cliente, solo aplica en débito Se imprime en voucher |
||
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
||
| Numero de Cuotas | 2 | Valor numérico Cantidad de cuotas de la transacción (para ventas sin cuotas se informa “00”) Se imprime en voucher |
||
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
||
| Monto Cuota | 14 | Valor numérico Si el monto informado es vacío o 0 caja debe omitir la línea completa en el voucher. Se imprime en voucher si viene el campo |
||
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
||
| Últimos 4 Dígitos Tarjeta | 4 | Valor Numérico No se imprime |
||
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
||
| Número Operación | 9 | Correlativo de transacción del terminal También conocido como número de secuencia este campo se debe imprimir en voucher de venta y anulación. |
||
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
||
| Glosa Tipo de Tarjeta | 7 | Valor alfanumérico (máximo) Valor de glosa en Tabla tipo de tarjeta |
||
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
||
| Fecha Contable | 6 | Valor alfanumérico Se utiliza sólo si es transacción de Debito Caja no debe formatear (ej: DDAAMM), simplemente debe transferir el valor al voucher (XX/XX/XX) |
||
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
||
| Número de Cuenta | 19 | Valor alfanumérico Número de tarjeta enmascarado para incluir en el voucher |
||
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
||
| Abreviación de la tarjeta | 2 | Valor alfanumérico Valor a imprimir en el voucher |
||
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
||
| Fecha Transacción | 6 | Formato AAMMDD Valor a imprimir en el voucher |
||
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
||
| Hora Transacción | 6 | Formato HHMMSS Valor a imprimir en el voucher |
||
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
||
| Campo Impresión | 8192 | Campo depende si la caja requiere voucher formateado (máximo) En el comando 510 no se envía el voucher En el comando 550 se envía voucher siempre |
||
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
||
| Transacción premiada | 1 | Valor numérico 1 : transacción premiada En este caso caja debe imprimir voucher PEL además del de venta [vacío] : transacción sin premio |
||
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
||
| Tipo promoción | 1 | Valor numérico 1 : Entrega Pto. de Venta 2 : Entrega Diferida 3 : Devolución al Tarjeta Habiente |
||
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
||
| Código promoción | 8 | Valor alfanumérico Valor a imprimir en el voucher premiado |
||
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
||
| Nombre promoción | 21 | Valor alfanumérico Valor a imprimir en el voucher de premio |
||
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
||
| Glosa vale premio | 62 | Valor alfanumérico Valor a imprimir en el voucher de premio |
||
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
||
| Texto vale premio | 27 | Valor alfanumérico Valor a imprimir en el voucher de premio |
||
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
||
| Flag permite cuotas | 1 | Valor numérico Campo informativo de la configuración del comercio |
0 | |
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
||
| Flag de gracia | 1 | Valor numérico Campo informativo de la configuración del comercio |
0 | |
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
||
| Flag C2C | 1 | Valor numérico Campo informativo de la configuración del comercio |
0 | |
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
||
| Flag C3C | 1 | Valor numérico Campo informativo de la configuración del comercio |
0 | |
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
||
| Flag NCuotas | 1 | Valor numérico Campo informativo de la configuración del comercio |
0 | |
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
||
| Flag máximo de cuotas | 2 | Valor numérico Campo informativo de la configuración del comercio |
0 | |
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
||
| Tipo de menú | 2 | Valor alfanumérico Indicador del tipo de menú por el cual se realizó la transacción CR : CRÉDITO DB : DÉBITO PREPAGO NB : NO BANCARIA Valor de tipo en Tabla tipo de tarjeta Una venta hecha como débito puede ser autorizada como prepago |
||
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
||
| Indicador transacción con gracia | 1 | Valor numérico Indicador de modalidad de la transacción 0 transacción sin mes gracia 1 transacción con mes gracia |
||
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
||
| Tipo cuotas | 1 | Valor numérico 0 Sin cuotas 1 Cuotas normales 3 C3C o C2C 4 CIC o N-cuotas |
||
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
||
| Tasa aplicada | 4 | Valor numérico Solo se imprime en voucher si “Flag imprimir tasa = 1” |
||
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
||
| Glosa tipo cuota | 30 | Valor alfanumérico Glosa a imprimir en voucher Si el campo informado viene vacío caja debe omitir la línea en el voucher. |
||
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
||
| Glosa tipo cuota 2 | 22 | Valor alfanumérico Glosa que se despliega en pinpad |
||
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
||
| Glosa promoción | 10 | Valor alfanumérico Glosa que se despliega en pinpad |
||
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
||
| Id promoción | 10 | Valor alfanumérico Glosa que se despliega en pinpad |
||
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
||
| Flag imprimir tasa | 1 | Valor numérico [vacío] o 0 no imprime tasa aplicada 1 imprime tasa aplicada |
0 | |
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
||
| Periodo diferido | 3 | Valor numérico Periodo diferido seleccionado, valor a imprimir en voucher |
||
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
||
| Diferido 1 periodo | 3 | Valor numérico No utilizado |
||
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
||
| Diferido 1 valor tasa | 4 | Valor numérico No utilizado |
||
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
||
| Diferido 1 valor cuota | 14 | Valor numérico No utilizado |
||
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
||
| Diferido 2 periodo | 3 | Valor numérico No utilizado |
||
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
||
| Diferido 2 valor tasa | 4 | Valor numérico No utilizado |
||
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
||
| Diferido 2 valor cuota | 14 | Valor numérico No utilizado |
||
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
||
| Diferido 3 periodo | 3 | Valor numérico No utilizado |
||
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
||
| Diferido 3 valor tasa | 4 | Valor numérico No utilizado |
||
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
||
| Diferido 3 valor cuota | 14 | Valor numérico No utilizado |
||
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
||
| Número de secuencia transacción original | 9 | Valor alfanumérico (máximo) También conocido como número de operación original de la venta, No se está usando este campo, no se imprime |
||
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
||
| Código respuesta Transbank | 3 | Valor numérico Código de respuesta una vez finalizada la transacción. Se debe desplegar en el punto de venta. EJ: RESPUESTA TRANSBANK - |
||
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
||
| Glosa respuesta Transbank | 48 | Valor alfanumérico (máximo) Glosa que despliega el pinpad una vez finalizada la transacción. Se debe desplegar en el punto de venta. EJ: RESPUESTA TRANSBANK - |
||
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
||
| Flag transacción con PIN | 1 | Valor alfanumérico Y: Transacción autentificada con PIN N: Transacción autentificada por firma |
||
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
||
| Nombre tarjetahabiente | 26 | Valor alfanumérico Sólo imprimir si “Flag tipo voucher = 1, 2 ó 3” |
||
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
||
| Flag tipo voucher | 1 | Valor numérico Según el número recibido se debe imprimir voucher con o sin firma: 0 = Sin firma 1 o 2 o 3 = con firma Cabeceras de los voucher: Para ventas con crédito: “VENTA CREDITO” Para ventas con débito (siempre sin firma): “VENTA DEBITO” Para ventas con no bancaria: “VENTA NO BANCARIA” Para ventas con prepago (sin firma): “VENTA PREPAGO” Para anulaciones con crédito (sin firma): “ANULACION CREDITO” Para anulaciones con no bancaria (sin firma): “ANULACION NO BANCARIA” |
||
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
||
| Flag modalidad cuotas | 1 | Valor alfanumérico 0 : Modalidad 3.1 (No utilizado) 1: Modalidad cuotas 4.0 |
1 | |
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
||
| Glosa transacción afecta a ahorro | 40 | Valor alfanumérico (máximo) Se debe imprimir en el voucher cuando sea distinta de vacío Campo 9, subcampo D |
||
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
||
| Número de secuencia | 9 | Valor numérico No se está usando este campo, este no se imprime También conocido como número de operación |
||
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
||
| Flag mensaje terminal | 1 | Valor alfanumérico Y: El mensaje es terminal y NO se debe enviar el mensaje SPDH de respuesta N: Se debe enviar el mensaje SPDH de respuesta |
||
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
||
| Largo mensaje | 4 | Valor numérico | ||
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
||
| Mensaje SPDH Venta/Reversa | 2048 | Valor alfanumérico (máximo) | ||
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
||
| Propina | 18 | Valor numérico Monto Propina o Donación |
||
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
||
| Voucher de Rechazo | 1024 | Valor numérico Cuando transacción es declinada por EMV se debe imprimir un voucher especial. Si este campo viene vacío no se imprime, si viene con dato se imprime Este voucher se imprime solo, sin voucher de venta |
||
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
||
| Voucher PEL | 1024 | Valor alfanumérico Voucher de PEL si viene la caja debe imprimirlo, solo una vez junto al voucher de venta No se debe imprimir en duplicado Este voucher se imprime junto al de venta |
||
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
||
| LABEL - EMV | 32 | Valor alfanumérico Si el campo viene con datos caja debe incluirlo en el voucher en la posición indicada |
||
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
||
| RID - EMV | 32 | Valor alfanumérico Si el campo viene con datos caja debe incluirlo en el voucher en la posición indicada |
||
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
||
| Modelo pinpad | 6 | Valor numérico Caja debe incluirlo en el voucher ejemplo: VX805 Campo obligatorio |
||
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
||
| Versión de pinpad | 6 | Valor numérico Caja debe incluirlo en el voucher ejemplo: 12.34A Campo obligatorio |
||
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
||
| Saldo Prepago | 40 | Valor alfanumérico (máximo) Indica el saldo de una tarjeta de prepago la cual se debe imprimir en voucher cuando es venta de prepago y cuando viene el saldo. Nota: El Pinpad agrega esa glosa al voucher tal como viene en la mensajería. |
||
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
||
<ETX> |
1 | Indica Fin de comando Valor Hexa 0x03 | ETX | |
<LRC> |
1 | Byte resultado de la operación XOR del mensaje |
0600 - Solicitud comando Cierre batch
Igual al Retail estándar vx805
0700 - Validación comando Cierre batch
Igual al Retail estándar vx805
1100 - Comando despliegue mensaje
Con este comando la caja puede mostrar en pantalla del pinpad algunos mensajes predefinidos.
Requerimiento
| DATO | LARGO | COMENTARIO | VALOR POR DEFECTO | |
|---|---|---|---|---|
| LARGO_DATA | 4 | Valor numérico (0000 -> 9999) Indicando el largo del mensaje, sin incluir estos 4 bytes |
||
| Comando | 4 | Valor 1100 | ||
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
||
| Código mensaje | 4 | Valor Numérico Revisar: Tabla de código de mensajes | ||
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
||
| Timeout mensaje | 2 | Valor Numérico (00 -> 09) | ||
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
Respuesta
| DATO | LARGO | COMENTARIO | VALOR POR DEFECTO |
|---|---|---|---|
| LARGO_DATA | 4 | Valor numérico (0000 -> 9999) Indicando el largo del mensaje, sin incluir estos 4 bytes | |
| Comando | 4 | Valor 1110 | |
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
|
| Código respuesta | 2 | Valor numérico De acuerdo a Tabla de códigos de respuesta de comandos | |
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
CONN - Comando Conexión PINPAD – Caja
Comando enviado desde el PINPAD a la Caja de modo de establecer la conexión. La caja debe abrir un puerto de conexión el cual no debe ser cerrado en ningún momento.w
Requerimiento
| DATO | LARGO | COMENTARIO | VALOR POR DEFECTO |
|---|---|---|---|
| LARGO_DATA | 4 | Valor numérico (0000 -> 9999) Indicando el largo del mensaje, sin incluir estos 4 bytes | |
| Comando | 4 | Valor ‘CONN’ | |
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
|
| Número Serial | 15 | Valor alfanumérico Número serial del PINPAD | |
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
|
| Data | 20 | Valor alfanumérico (TRANSBANK VER. 4.01A) Identificador de la aplicación más la versión de la aplicación | Obligatorio |
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
Respuesta
| DATO | LARGO | COMENTARIO | VALOR POR DEFECTO | |
|---|---|---|---|---|
| LARGO_DATA | 4 | Valor numérico (0000 -> 9999) Indicando el largo del mensaje, sin incluir estos 4 bytes | Obligatorio | |
| Comando | 4 | Valor ‘CONN’ | Obligatorio | |
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
||
| Código Retorno | 2 | Valor numérico (00: Prompt de inicio) (01: Glosa de rechazo) | Obligatorio | |
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
||
| Número de Líneas | 2 | Valor numérico (00 -> 99) Cantidad de líneas de glosas a desplegar. | Obligatorio | |
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
||
| Glosa | 16 | Valor alfanumérico Glosa descripción de error. | Opcional | |
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
ECHO - Comando Echo Caja – PINPAD
Comando que permite a la Caja verificar que el PINPAD se encuentra conectado, identificarlo por su número de serie y versión de aplicación.
Requerimiento
| DATO | LARGO | COMENTARIO | VALOR POR DEFECTO |
|---|---|---|---|
| LARGO_DATA | 4 | Valor numérico (0000 -> 9999) Indicando el largo del mensaje, sin incluir estos 4 bytes | Obligatorio |
| Comando | 4 | Valor ‘ECHO’ | Obligatorio |
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
Respuesta
| DATO | LARGO | COMENTARIO | VALOR POR DEFECTO |
|---|---|---|---|
| LARGO_DATA | 4 | Valor numérico (0000 -> 9999) Indicando el largo del mensaje, sin incluir estos 4 bytes | Obligatorio |
| Comando | 4 | Valor ‘ECHO’ | Obligatorio |
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
|
| Código Retorno | 2 | Valor numérico (00: OK, Prompt de inicio) (01: NOK, Glosa de rechazo) | Obligatorio |
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
|
| Número Serial | 15 | Valor alfanumérico Número serial del PINPAD | Obligatorio |
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
|
| Data | 20 | Valor alfanumérico (TRANSBANK VER. 4.01A) Identificador de la aplicación más la versión de la aplicación | Obligatorio |
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
ISES - Comando Inicio de Sesión Caja- PINPAD
Este comando permite abrir una sesión con el PINPAD desde la Caja.
Requerimiento
| DATO | LARGO | COMENTARIO | VALOR POR DEFECTO |
|---|---|---|---|
| LARGO_DATA | 4 | Valor numérico (0000 -> 9999) Indicando el largo del mensaje, sin incluir estos 4 bytes | Obligatorio |
| Comando | 4 | Valor ‘ISES’ | Obligatorio |
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
Respuesta
| DATO | LARGO | COMENTARIO | VALOR POR DEFECTO |
|---|---|---|---|
| LARGO_DATA | 4 | Valor numérico (0000 -> 9999) Indicando el largo del mensaje, sin incluir estos 4 bytes | Obligatorio |
| Comando | 4 | Valor ‘ISES’ | Obligatorio |
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
|
| Código Retorno | 2 | Valor numérico (00: OK) (Otro: Error) | Obligatorio |
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
|
| Batería | 3 | Valor numérico (000 -> 100) Porcentaje de carga de batería. | Obligatorio |
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
FSES - Comando Fin de Sesión Caja – PINPAD
Este comando permite cerrar una sesión con el PINPAD desde la Caja.
Requerimiento
| DATO | LARGO | COMENTARIO | VALOR POR DEFECTO |
|---|---|---|---|
| LARGO_DATA | 4 | Valor numérico (0000 -> 9999) Indicando el largo del mensaje, sin incluir estos 4 bytes | Obligatorio |
| Comando | 4 | Valor ‘FSES’ | Obligatorio |
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
Respuesta
| DATO | LARGO | COMENTARIO | VALOR POR DEFECTO |
|---|---|---|---|
| LARGO_DATA | 4 | Valor numérico (0000 -> 9999) Indicando el largo del mensaje, sin incluir estos 4 bytes | Obligatorio |
| Comando | 4 | Valor ‘FSES’ | Obligatorio |
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
|
| Código Retorno | 2 | Valor numérico (00: OK) (Otro: Error) | Obligatorio |
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
VOUC - Comando Solicitud Impresión Voucher Caja – PINPAD
Requerimiento
| DATO | LARGO | COMENTARIO | VALOR POR DEFECTO | |
|---|---|---|---|---|
| LARGO_DATA | 4 | Valor numérico (0000 -> 9999) Indicando el largo del mensaje, sin incluir estos 4 bytes | Obligatorio | |
| Comando | 4 | Valor ‘VOUC’ | Obligatorio | |
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
||
| Time Out | 5 | Valor numérico (00000 -> 99999) Timeout del comando en milisegundos. | Obligatorio | |
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
||
| Glosa 1 | 16 | Valor alfanumérico Glosa a desplegar primera línea en pantalla. | Obligatorio | |
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
||
| Glosa 2 | 16 | Valor alfanumérico Glosa a desplegar segunda línea en pantalla. | Obligatorio | |
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
||
| Voucher a Imprimir | 4000 | Valor alfanumérico Voucher separado por “\n” para nueva línea, “\c” para corte de voucher | Obligatorio | |
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
Respuesta
| DATO | LARGO | COMENTARIO | VALOR POR DEFECTO |
|---|---|---|---|
| LARGO_DATA | 4 | Valor numérico (0000 -> 9999) Indicando el largo del mensaje, sin incluir estos 4 bytes | Obligatorio |
| Comando | 4 | Valor ‘VOUC’ | Obligatorio |
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
|
| Código Retorno | 2 | Valor numérico (00: Impresión OK) (01: Error en la impresión) | Obligatorio |
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
REIM - Comando Solicitud Reimpresión Último Voucher PINPAD – Caja
Comando enviado desde el PINPAD a la Caja de modo de que la caja envíe al PINPAD el Voucher de la última venta. Para enviar este comando se debe presionar en el PINPAD [ENTER] + [5]
Requerimiento
| DATO | LARGO | COMENTARIO | VALOR POR DEFECTO |
|---|---|---|---|
| LARGO_DATA | 4 | Valor numérico (0000 -> 9999) Indicando el largo del mensaje, sin incluir estos 4 bytes | Obligatorio |
| Comando | 4 | Valor ‘REIM’ | Obligatorio |
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
Respuesta
| DATO | LARGO | COMENTARIO | VALOR POR DEFECTO |
|---|---|---|---|
| LARGO_DATA | 4 | Valor numérico (0000 -> 9999) Indicando el largo del mensaje, sin incluir estos 4 bytes | Obligatorio |
| Comando | 4 | Valor ‘REIM’ | Obligatorio |
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
|
| Código Retorno | 2 | Valor numérico (00: Recibido OK) (01: No existe impresión disponible) | Obligatorio |
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
|
| Time Out | 5 | Valor numérico (00000 -> 99999) Timeout del comando en milisegundos. | Obligatorio |
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
|
| Glosa 1 | 16 | Valor alfanumérico Glosa a desplegar primera línea en pantalla. | Obligatorio |
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
|
| Glosa 2 | 16 | Valor alfanumérico Glosa a desplegar segunda línea en pantalla. | Obligatorio |
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
|
| Voucher a Imprimir | 4000 | Valor alfanumérico Voucher separado por \n para nueva línea, \c para corte de voucher |
Obligatorio |
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
REST - Comando Reset Socket Caja – PINPAD
Comando permite a la Caja realizar un reset al socket del PINPAD.
Requerimiento
| DATO | LARGO | COMENTARIO | VALOR POR DEFECTO |
|---|---|---|---|
| LARGO_DATA | 4 | Valor numérico (0000 -> 9999) Indicando el largo del mensaje, sin incluir estos 4 bytes | Obligatorio |
| Comando | 4 | Valor ‘REST’ | Obligatorio |
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
Respuesta
| DATO | LARGO | COMENTARIO | VALOR POR DEFECTO |
|---|---|---|---|
| LARGO_DATA | 4 | Valor numérico (0000 -> 9999) Indicando el largo del mensaje, sin incluir estos 4 bytes | Obligatorio |
| Comando | 4 | Valor ‘REST’ | Obligatorio |
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
|
| Código Retorno | 2 | Valor numérico (00: Recibido OK) (01: Error Mensaje) | Obligatorio |
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
LKEY - Comando Carga de Llave PINPAD – Caja
Comando ejecutado a través del menú del PINPAD, el cual permite solicitar a la caja una ‘Carga de llaves’ a la Caja. La transacción de carga de llaves debe ser construida tal como lo define el manual de “Especificaciones Técnicas”.
Requerimiento
| DATO | LARGO | COMENTARIO | VALOR POR DEFECTO |
|---|---|---|---|
| LARGO_DATA | 4 | Valor numérico (0000 -> 9999) Indicando el largo del mensaje, sin incluir estos 4 bytes | Obligatorio |
| Comando | 4 | Valor ‘LKEY’ | Obligatorio |
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
Respuesta
| DATO | LARGO | COMENTARIO | VALOR POR DEFECTO |
|---|---|---|---|
| LARGO_DATA | 4 | Valor numérico (0000 -> 9999) Indicando el largo del mensaje, sin incluir estos 4 bytes | Obligatorio |
| Comando | 4 | Valor ‘LKEY’ | Obligatorio |
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
|
| Código Retorno | 2 | Valor numérico (00: Recibido OK) (01: Error en carga de llaves) | Obligatorio |
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
0000 - Comando TEST PINPAD – Caja
Comando enviado desde el PINPAD hacia la Caja para mantener el socket abierto.
Requerimiento
| DATO | LARGO | COMENTARIO | VALOR POR DEFECTO |
|---|---|---|---|
| Comando | 4 | Valor ‘0000’ | Obligatorio |
Respuesta
| DATO | LARGO | COMENTARIO | VALOR POR DEFECTO |
|---|---|---|---|
| Comando | 4 | Valor ‘0000’ | Obligatorio |
CLSB - Comando Cierre Batch PINPAD – Caja
Comando ejecutado a través del menú del PINPAD, el cual permite indicar a la caja el envío de una solicitud de ‘Cierre batch’.
Requerimiento
| DATO | LARGO | COMENTARIO | VALOR POR DEFECTO |
|---|---|---|---|
| LARGO_DATA | 4 | Valor numérico (0000 -> 9999) Indicando el largo del mensaje, sin incluir estos 4 bytes | Obligatorio |
| Comando | 4 | Valor ‘CLSB’ | Obligatorio |
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
Respuesta
| DATO | LARGO | COMENTARIO | VALOR POR DEFECTO |
|---|---|---|---|
| LARGO_DATA | 4 | Valor numérico (0000 -> 9999) Indicando el largo del mensaje, sin incluir estos 4 bytes | Obligatorio |
| Comando | 4 | Valor ‘CLSB’ | Obligatorio |
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
|
| Código Retorno | 2 | Valor numérico (00: Recibido OK) (Otro: Error) | Obligatorio |
Separador |
1 | Valor ASCII: | Valor hexadecimal: 0x7c |
Otros datos
Tabla de marcas de tajetas
| Nombre | Abreviación |
|---|---|
| VISA | VI |
| MASTERCARD | MC |
| DINERS | DC |
| AMEX | AX |
| MAGNA | MG |
| PRESTO | TP |
| MAS | TM |
| CMR | TC |
| RIPLEY | TR |
| MAESTRO | MT |
| ELECTRON | EL |
| DEBITO | DB |
Tabla de tipo de tarjeta
| Código | Glosa |
|---|---|
| CR | CREDITO |
| DB | DEBITO |
| NB | NO BANCARIA |
| Null (vacío) | Se despliega Menú en PINPAD. |
Tabla de códigos de respuesta de comandos
| Código de respuesta | Glosa |
|---|---|
| 00 | RESPUESTA OK |
| 84 | NO EXISTE CODIGO DE MENSAJE |
| 86 | ERROR DE LECTURA. |
| 87 | PINPAD SIN MASTER KEY |
| 89 | TRANSACCIÓN DECLINADA POR LA TARJETA CHIP |
| 90 | TARJETA NO PERMITIDA PARA EL MODO SELECCIONADO |
| 91 | ERROR CANTIDAD DE CUOTAS |
| 92 | NO COINCIDE CON TARJETA DE PRIMER “TAPEO” |
| 93 | ERROR DE MONTO MÍNIMO |
| 94 | ERROR DE VALIDACIÓN MONTO VUELTO |
| 95 | ERROR ID DE CONTEXTO |
| 96 | NO COINCIDE LOS 4 ULTIMOS DIGITOS |
| 97 | LA TRANSACCIÓN NO PERMITE REVERSA |
| 98 | ERROR DE FORMATO DEL MENSAJE |
| 99 | CANCELACIÓN DEL COMANDO A TRAVÉS DE LA TECLA [CANCEL] / TIMEOUT |
Tabla de códigos de mensajes de despliegue en PINPAD
| Código de respuesta | Glosa |
|---|---|
| 0000 | APROBADO |
| 0001 | ERROR INTERNO DE MENSAJERIA |
| 0002 | ERROR INTERNO DE MENSAJERIA |
| 0003 | NIVEL DE BATERIA BAJO |
| 0004 | CANCELACION DE OPERACIÓN |
| 0005 | EMISOR NO DISPONIBLE |
| 0006 | TERMINAL NO DISPONIBLE |
| 0007 | NO HAY CONFIRMACION |
| 0008 | ERROR EN OPERACIÓN CON POS |
| 0009 | MAXIMO INTENTOS SUPERADOS CONEXIÓN SWITCH SERVER |
| 0010 | CANCELACION DE OPERACIÓN |
| 0011 | MEDIOS DE PAGO NO DISPONIBLES |
| 0014 | ERROR INTERNO DE SISTEMA |
| 0015 | ERROR INTERNO DE SISTEMA |
| 0016 | ERROR INTERNO DE MENSAJERIA |
| 0017 | ERROR INTERNO DE MENSAJERIA |
| 0018 | TRANSACCION DE VENTA INEXISTENTE |
| 0019 | TRANSACCION ORIGINAL NO ES UNA VENTA |
| 0020 | TRANSACCION ORIGINAL NO TERMINADA |
| 0021 | TRANSACCION PENDIENTE EMISOR |
| 0022 | MONTO A ANULAR MAYOR AL MONTO DE VENTA |
| 0023 | MONTO A ANULAR DISTINTO AL MONTO DE VENTA |
| 0024 | TARJETA NO PERMITIDA |
| 0025 | ERROR RESPUESTA TERMINAL |
| 0026 | ERROR RESPUESTA TERMINAL |

# referencia_host-to-host.md

Source: https://www.transbankdevelopers.cl/referencia/host-to-host

Host to Host
Protocolo de Comunicación Caja - POS
La comunicación se realiza a través de un puerto serial RS232
, a velocidades que van entre los 1200bps hasta 115200bps 8N1
es decir 8
bits de datos, N
ingún bit de paridad y 1
bit de parada.
![Diagrama de Comunicación Caja - POS](https://www.transbankdevelopers.cl/public/slate-library/images/referencia/posintegrado/diagrama-comunicacion-caja-pos.png)
| Termino | Descripción |
|---|---|
<STX> |
Indica el inicio de un mensaje (texto) Hex: 0x02 |
| DATOS | Corresponde al commando a enviar al POS o la respuesta de este |
<ETX> |
Indica el fin de un mensaje (texto) Hex: 0x03 |
LRC |
Es un byte que se concatena al final del mensaje <ETX> y se calcula realizando la operación XOR byte a byte de <DATOS> + <ETX> |
<ACK> |
Representa la recepción correcta del mensaje enviado Hex: 0x06 |
<NAK> |
Representa la incorrecta recepción del mensaje enviado, o que el LRC del mensaje recibido no corresponde con el enviado. Hex: 0x15 |
| Timeout1 | Es el tiempo de espera de la caja para recibir <ACK> /<NAK> por parte del POS Integrado antes de reintentar el envío del mensaje. |
| Timeout2 | Es el tiempo de espera de el POS para recibir <ACK> /<NAK> por parte de la Caja antes de reintentar el envío del mensaje de respuesta. |
Ejemplo de cálculo LRC
Dado el siguiente comando:
<STX>0200|123|<ETX>
Que en notación hexadecimal seria:
0x02 0x30 0x32 0x30 0x30 0x7C 0x31 0x32 0x33 0x7C 0x03
Para calcular el LRC
debemos omitir el inicio de texto <STX>
o 0x02
.
La operación entonces sería:
(((((((((0x30 XOR 0x32) XOR 0x30) XOR 0x30) XOR 0x7C) XOR 0x31) XOR 0x32) XOR 0x33) XOR 0x7C) XOR 0x03)
El resultado entonces seria 0x31
en hexadecimal o 1
en ASCII, por lo tanto, el mensaje completo para enviar al POS Integrado es:
<STX> DATOS <ETX> LRC
0x02 0x30 0x32 0x30 0x30 0x7C 0x31 0x32 0x33 0x7C 0x03 0x31
![Diagrama de Secuencia Venta](https://www.transbankdevelopers.cl/public/slate-library/images/referencia/posintegrado/diagrama-venta.png)
- La caja envía el requerimiento y espera como respuesta
<ACK>
/<NAK>
, en caso de que llegue un<NAK>
, debe reintentar el envío del requerimiento 2 veces. Si recibe un<ACK>
debe esperar la respuesta de la transacción. - El POS solicita los datos al usuario, y envía el requerimiento al Autorizador, en caso de ser aprobada, se guarda en Batch y se envía respuesta a la caja. En caso de ser rechazada se envía respuesta a la caja indicando el error. (
[Ver Tabla de Respuestas](https://www.transbankdevelopers.cl/referencia/posintegrado#tabla-de-respuestas)) - La caja al recibir la respuesta envía un
<ACK>
si el mensaje está correcto, o un<NAK>
para el caso en que elLRC
no corresponde. - El POS al recibir el
<ACK>
vuelve al inicio a esperar un nuevo comando, para el caso que recibe un<NAK>
vuelve a enviar la respuesta 2 veces más.
Solicitud de Venta
Diagrama de conexión
Conexión directa entre pinpad y caja
La caja del comercio y el pinpad se conectan a través de un cable de USB o SERIAL:
![Conexión entre pinpad y caja](https://www.transbankdevelopers.cl/public/slate-library/images/documentacion/host2host/conexion-directa-pinpad-caja.png)
Conexión pinpad bluetooth y caja
La caja del comercio y el pinpad se conectan a través de Bluetooth:
![Conexión pinpad bluetooth y caja](https://www.transbankdevelopers.cl/public/slate-library/images/documentacion/host2host/pinpad-bluetooth-caja.png)
Software de apoyo
Hay varios programas en internet para enviar comandos al puerto COM, uno que puede ayudarlo es:
Docklight
Protocolo de mensajería según tipo de comunicación
Seguridad TLS 1.2
SSL (Secure Sockets Layer) o Capa de Conexiones Seguras. Es un protocolo que hace uso de certificados
digitales para establecer comunicaciones seguras a través de red. Desde el 2015 ha sido sustituido por TLS (Transport Layer Security) el cual está basado en SSL y son totalmente compatibles.
La comunicación entre el pinpad y la caja no tiene seguridad, pero el comercio debe implementar seguridad interna en su red.
Seguridad en la Red WI-FI del Comercio
En el caso de que la red del Comercio requiera usar conexiones por WI-FI se exige que la red sea una red cifrada *WPA2-PSK (AES).
Recomendaciones se seguridad para una red WI-FI:
- Cambiar regularmente la contraseña de red WI-FI
Al cambiar regularmente la contraseña de red WI-FI evita que terceras personas puedan hacer uso de la red del comercio. - Configurar la red WI-FI como “No visible”
Al ocultar la red WI-FI se evita que personas externas al comercio puedan encontrar e intentar acceder a la red del comercio.
Ahora cada vez que se intente conectar un nuevo dispositivo, será necesario colocar primero la *SSID, para posteriormente ingresar la contraseña. - Registrar y restringir las conexiones por MAC
Al tener habilitadas las conexiones por MAC, se especifica que equipos pueden hacer uso de la red WI-FI, evitando que cualquier otro equipo haga uso de la red del comercio. - Restringir el acceso a la “Configuración del Router” desde WI-FI
Al restringir el acceso a la configuración del Router desde conexiones WI-FI se evita que desde dispositivos WIFI se pueda acceder a esta configuración y se modifiquen sus parámetros. - Monitorear regularmente las conexiones WI-FI
Los Router actuales permiten conocer los dispositivos que están conectados a la red WI-FI.
Es recomendable monitorear para poder evitar algún dispositivo que esté conectado sin autorización.
Protocolo de comunicación
El protocolo que usará el PINPAD es VISA II, sobre el que se enviarán los mensajes de requerimiento y respuesta. Conceptualmente se utiliza el siguiente formato:
![Protocolo de comunicación](https://www.transbankdevelopers.cl/public/slate-library/images/documentacion/host2host/protocolo-de-comunicacion.png)
Donde:
| TERMINO | DESCRIPCIÓN |
|---|---|
| INICIO COMANDO | Indica el inicio del mensaje (STX). |
| FIN COMANDO | Indica el fin del mensaje (ETX). |
| SEPARADOR CAMPO | Indica el separador de cada campo dentro de los comandos de requerimientos y respuestas. Valor ASCII “|” (valor Hexa 0x7c) |
| LRC | Es un byte que se concatena luego del <FIN COMANDO> y que se calcula realizando un XOR byte a byte del mensajes, el cual consta de: <DATA> + <FIN COMANDO> . |
| ACK | Lo envía el PINPAD o la caja como aviso de recepción OK para todos los comandos (valor Hexa 0x06). |
| NAK | Lo envía el PINPAD o la caja cuando el LRC calculado no corresponde al enviado para todos los comandos (valor Hexa 0x15). |
| Timeout1 ACK | Es el tiempo de espera del ACK o NAK para reintentar el envío del requerimiento por la caja. 10 segundos |
| Timeout 2 Resp | Es el tiempo de espera del ACK o NAK para reintentar el envío de la respuesta por el PINPAD. El tiempo depende de cada comando. |
| Timeout 3 ACK | Es el tiempo de espera del ACK o NAK para reintentar el envío de la respuesta por el PINPAD. 10 segundos |
| STX | Indica un INICIO del mensaje (valor Hexa 0x02). |
| ETX | Indica un FIN del mensaje (valor Hexa 0x03). |
| DATA | CAMPO₀|CAMPO₁|CAMPO₂|…|CAMPOn |
Diagrama genérico de secuencia de comandos
El diagrama que se describe corresponde a la generalización del comportamiento de cada uno de los comandos o mensajes enviados entre pinpad y caja.
![Secuencia de comandos entre Caja y PINPAD](https://www.transbankdevelopers.cl/public/slate-library/images/documentacion/host2host/secuencia-comandos-caja-pinpad.png)
ACK: cuando se recibió un mensaje válido, se va a procesar y responder con el mensaje o comando
correspondiente dentro del timeout definido.
NACK: cuando se recibió un mensaje no válido y no será procesado.
Diagrama muestra la evaluación del comando por parte del pinpad y caja, se recibe un comando se evalúa su estructura, si está ok, se responde ACK, no está conforme a la documentación se responde NACK.
Luego se valida la respuesta al código del comando, si 00 se procesa el comando si es distinto se termina por el código retornado.
![Flujo al recibir un comando](https://www.transbankdevelopers.cl/public/slate-library/images/documentacion/host2host/flujo-al-recibir-comando.png)
Administración ID de Contexto
Al iniciar una transacción el pinpad entrega un ID que debe ser utilizado por la caja en los próximos comandos, si el ID no coincide el pinpad rechazará el comando, a menos que sea el inicio de otra transacción.
Comando/campo donde la caja recibe el ID por parte del pinpad:
0110/Indicador de contexto
Flujo de ejecución de actualización de parámetro pinpad
Asumiendo que la caja tiene conexión con el pinpad, solicita al pinpad una actualización de parámetros de pinpad
![Flujo comandos actualización de parámetros pinpad](https://www.transbankdevelopers.cl/public/slate-library/images/documentacion/host2host/flujo-comandos-actualizacion-param-pinpad.png)
Ejemplo:
0610|00|0123456789ABCDEF|0523|9.11S4HOST2HOST3DES1 171116113320AO60050000Q0123456789ABCDEFa0010050000+0000000000000000000000+0000000000 000000000000+000000000000000000d597044440001h0010050071r;597044440001=9912?t74 0000000000000000326-478-322 15.30C S0000000000T0000000000W00700000009-A1EL20212223242526272829VI0 6MC0 67DC0 6AX012345OTTP06TR01TE0 TM0
TC12TD12TJ12TH12T812T90 -B01205240-C2100-P000000000000-I0-J0-K000-G33032131100000000 0000000000000000000000000000000000000000000000000000000000000000|
m
0700|496|9.11S4HOST2HOST3DES1 171116113324AO60000007H9EAC32471E58DF4C996725D34FF96F6DI8A2A30A556EBC3E68B496CE2116A F50FM0000000000000000Q0123456789ABCDEFW0071111005g APROBADOh0010050071l0010050000+0000000000000000000000+0000000000000000000000+0000000 00000000000tS4HOST2HOST3DES19-A1EL20212223242526272829VI0 6MC0 67DC0 6AX012345OTTP06TR01TE0 TM0 TC12TD12TJ12TH12T812T90 -B11205243-C0000-G330321311000000000000000200000000000001200 000000000000000000000400000000000002400-P100000800000|
Flujo de venta detallado
![Secuencia detallada de comandos de una venta](https://www.transbankdevelopers.cl/public/slate-library/images/documentacion/host2host/secuencia-detallada-comandos-venta.png)
![Diagrama de flujo detallado de comandos de una venta con respuesta con problema](https://www.transbankdevelopers.cl/public/slate-library/images/documentacion/host2host/comandos-venta-respuesta-con-problema.png)
- Para el caso de una respuesta del pinpad que esté fuera de lo especificado (tipo de dato erróneo, largo incorrecto, separador incorrecto o faltante, etc.) la caja debe interpretar que la transacción terminó con problema y luego solicitar reversa según el “flujo de ejecución de reversa a solicitud de la caja” detallado a continuación.
Si se desea reintentar la venta se debe iniciar un nuevo flujo de venta.
Ejemplo de venta:
0100|00|N|N|N|12100|CL|CR||0|0| 0110|00|2017111611350940|01|||||5197||MASTERCARD|MC|N| 4 0200|12100|0||0|0|2017111611350940|00|597044440001|S4HOST2HOST3DES1||||1711161136110 0000000000754||0123456789ABCDEF|||||5197| v
0210|00|2017111611350940|0737|9.12S4HOST2HOST3DES1 171116113517FO00050000B000000000000012100P1Q0123456789ABCDEFa00000000000000000000000 000NU1711161136110000000000075400000000000000000CL0000000d597044440001e00h0010050081 G3F3308F4S0t74 0000000000000000326-478-322 15.30C 6-E051-I152-O0180152171116B8738FEAC1697887380000669B8C926200000080000015200000001210 00000000000000014A78003040000716800000000000000FF-P0100224403020002 E0F8C826478322RA00000000410109-A1EL20212223242526272829VI0 6MC0 67DC0
6AX012345OTTP06TR01TE0
TC12TD12TJ12TH12T812T90 -B41205240-C2100-P000000000000-I0-J0-K000W0161111005CR 0000- 4F552D8E65F6056E543A481CDD07D2525E2D7347C32D2CA5756F176482684949FD0443BCB1235018CC0C DDC7C0EA41BF| (
TM0
0500|2017111611350940|513|9.12S4HOST2HOST3DES1 171116113521FO00000005B000000000000012100D4EF600979 BGA1B5296BH0D9C83C5A59B574F7AF35145C606D5D4ID5879B9816C5A304236AB90B081A60A0P1Q01234 56789ABCDEFS0 T0000000000W0161111005CRCMC0000a00000000000003000000000000NU171116113611000000000007 5400000000000000000CL0000000d597044440001e00g APROBADOh0010050081ptS4HOST2HOST3DES16-E051-I1529-A1EL20212223242526272829VI0 6MC0 67DC0 6AX012345OTTP06TR01TE0 TM0 TC12TD12TJ12TH12T812T90 -B11205243-C0000-P100000800000|
0510|00|2017111611350940|597044440001|S4HOST2HOST3DES1|0 |0000|600979 B|12100||00||5197|001005008|CREDITO||************5197|MC|171116|113521||||||||1|1|1| 1|0|05|CR|0|0|0000|SIN CUOTAS|||||||0000|||0000|||0000|||005| APROBADO|N||0|1||001005008|Y|||
Flujo de ejecución de reversa a solicitud de la caja
La caja no tuvo respuesta de algún comando o no tuvo respuesta de un mensaje SPDH en vuelo, por lo tanto no pudo terminar una venta que inicio, luego no sabe si está aprobada o rechazada, en este caso debe solicitar una reversa al pinpad.
![Reversa solicitada por la caja](https://www.transbankdevelopers.cl/public/slate-library/images/documentacion/host2host/reversa-solicitada-por-caja.png)
Para el comando 400 se consideran como Reversa Exitosa los siguientes mensajes:
| Comando | Observación |
|---|---|
| 510|89| | Deprecado desde la 18.2x |
| 510|85| | Deprecado desde la 18.2x |
| 510|00|...|Cualquier Código respuesta Transbank|… | Deprecado desde la 18.2x |
| 510|00|...|Código respuesta Transbank < 010|… | Respuesta optimizada en la 18.2x |
Ejemplo de reversa:
0400|2019062813081650|
0410|00|2019062813081650|0643|9.07S4CAJAHOST000010 190628130853FT00000000B000000000000650000P1Q0123456789ABCDEFa00000015000000000000000 000NU2019062813091100100100000100000000000000000CL0000000d597044440001e00h0010030051 G3F27A500S0t74 0000000000000000326-018-973 18.21P 6-E071-I152-O0180152190628236E485C1DC23FC81980067116EE3A5C0000008000001520000006500000000000000000110A04001220000000000000000000000FF-P0101221F03020002 00080826018973A00000000410109-A1EL20252627 VI123456MC123456DC AX123456OTTP06TR1 TE0 TM0 TC12TD12TJ12TH12T812T90 -B41205240-C2100-P000000000000-I0-J1-K000-M1W0161111005CR 0000|
0500|2019062813081650|643|9.07S4CAJAHOST000010 190628130853FT00000000B000000000000650000P1Q0123456789ABCDEFa00000015000000000000000 000NU2019062813091100100100000100000000000000000CL0000000d597044440001e00h0010030051 G3F27A500S0t74 0000000000000000326-018-973 18.21P 6-E071-I152-O0180152190628236E485C1DC23FC81980067116EE3A5C00000080000015200000065000 00000000000000110A04001220000000000000000000000FF-P0101221F03020002 00080826018973A00000000410109-A1EL20252627 VI123456MC123456DC AX123456OTTP06TR1 TE0 TM0 TC12TD12TJ12TH12T812T90 -B41205240-C2100-P000000000000-I0-J1-K000-M1W0161111005CR 0000|
0510|00|2019062813081650|597044440001|S4CAJAHOST000010|||265404 B|650000||00||0003|001003005|CREDITO||************0003| |190628|130853||||||||1|1|1|1|0|05|CR|0|0|0000|SIN CUOTAS|||||||0000|||0000|||0000|||000|REVERSA APLICADA|N||0|1||001003005|Y||| X
Con el 510 el pinpad muestra por pantalla “REVERSA APLICADA”.
Descripción de comandos
En este capítulo se detalla cada comando que se puede enviar al PINPAD. Para la comunicación serial es necesario indicar los caracteres de inicio y fin que se envían en cada comando, los que serán indicados por medio de la siguiente nomenclatura:
| CARÁCTER DE CONTROL | NOMENCLATURA |
|---|---|
<STX><DATA><ETX><LRC> |
STXETX |
A fin de mantener el mismo lenguaje en comunicación TCP-IP se mantienen estos caracteres STX, ETX y LRC.
Comandos ventas
Los comandos 0100, 0110, 0200, 0210, 0400, 0410, 0500, 0510 son Igual al Retail Estándar vx805 versión 15.2 para dejarlos en un solo documento se anexan acá:
0100 – 0110 Comando Lectura de tarjeta
En este punto la caja ya tiene construida la venta en su sistema, por lo cual ya cuenta con los datos
requeridos para iniciar el proceso de pago con Transbank con el comando 0100.
Desde este punto se debe registrar los datos de la transacción para ir complementando con los siguientes comandos, pues frente a alguna caída los datos están resguardados para solicitar reversa o finalmente imprimir el voucher con la transacción aprobada.
Requerimiento
| DATO | LARGO | COMENTARIO | VALOR POR DEFECTO |
|---|---|---|---|
<STX> |
1 | Indica el inicio de texto o comando valor hexadecimal: 0x02 |
STX |
Comando |
4 | valor ASCII: 0100 valor hexadecimal: 0x30 0x31 0x30 0x30 |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Local comercio OnUs |
2 | Valor Numérico 00 Comercio sin tarjetas propias 01-99 Comercios onus, TBK asigna un numero para lectura de tarjetas propias |
00 |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Entrega BIN |
1 | Valor alfanumérico (Y: Si) (N: No) Sirve para conocer el bin de la tarjeta y poder realizar algún descuento a la venta por convenio con el banco |
N |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Transacción offline |
1 | Valor alfanumérico (Y: Si) (N: No) Ya no está permitido su uso |
N |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Autoservicio |
1 | Valor alfanumérico (Y: Si) (N: No) |
N |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Monto |
18 | Valor numérico (máximo) Monto de Compra (sin propina, sin vuelto) Monto mínimo $50,00 o US$1,00 Incluye dos decimales. |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Código de moneda |
2 | Valor alfanumérico |CL| Pesos chilenos 152 |US| Dólares estadounidenses 840 |
CL |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Tipo de tarjeta |
2 | Valor alfanumérico Indicador del tipo de menú por el cual se realizó la transacción. |CR|: CRÉDITO |DB|: DÉBITO - PREPAGO |NB|: NO BANCARIA Valor de tipo en Tabla tipo de tarjeta Una venta hecha como debito puede ser autorizada como prepago |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Lista montos de vuelto |
60 | Valor numérico (máximo) Lista de montos de vuelto permitidos, separados por “;” Incluyen dos decimales, siempre se debe enviar las 4 opciones definidas por Transbank. Campo paramétrico por punto de venta. Sólo si “Tipo de tarjeta = DB” |
500000; 1000000; 2000000; 5000000; |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Monto vuelto |
18 | Valor numérico (máximo) |0|: No muestra menú en pinpad | | : ø Muestra menú consultando por vuelto Si |n| > 0 no se muestra menú. El valor debe corresponder a alguno enviado en el campo “Lista de montos de vuelto” Vuelto solo existe en débito, enviar 0 en crédito Campo c |
Ø |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Monto propina/donación |
9 | Valor numérico (máximo) Corresponde al monto propina o donación de la venta o anulación (incluye dos decimales) Importante: Si se desea pedir propina al Tarjeta Habiente y que este la confirme, se debe enviar este campo el valor en vacío (Ø ) Para las anulaciones se debe colocar el monto de la propina de la venta a anular, en caso de no tener propina colocar un cero (0). |
Ø |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
<ETX> |
1 | Indica el fin de texto o comando valor hexadecimal: 0x03 |
ETX |
<LRC> |
1 | Byte resultado de la operación XOR del mensaje |
Timeout máximo de espera por comando 110 de 35seg, ya que el PinPad espera 30seg a que el cliente opere tarjeta, por lo tanto a los 30 segundas si no se opera tarjeta, devuelve un 110|99.
Respuesta
| DATO | LARGO | COMENTARIO | VALOR POR DEFECTO |
|---|---|---|---|
<STX> |
1 | Indica inicio de texto o comando valor hexadecimal: 0x02 |
STX |
Comando |
4 | Valor ASCII: 0110 valor hexadecimal: 0x30 0x31 0x31 0x30 |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Código de respuesta PinPad |
2 | Valor Numérico En caso de rechazo se debe desplegar en el punto de venta: RECHAZO PINPAD - <XX> : <GLOSA> De acuerdo a
|
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Indicador de contexto |
16 | Valor alfanumérico Formato aaaammddhhmmssmm Es solo un ID, la fecha y hora en el pinpad puede estar desactualizada. |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Tipo de captura |
2 | Valor numérico Este campo será utilizado en el futuros |00| : B - Banda |01| : E . EMV c/contacto |02| : C - Contacless |03| : F - Fallback |04| : D - Digitada |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
TRACK I |
80 | Valor alfanumérico (máximo) Rellenados con blancos (0x20) a la derecha Si “Local comercio OnUs ≠ 00” Con pan encriptado se entrega 160 caracteres alfanuméricos que corresponde a 80 HEXA |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
TRACK II |
40 | Valor alfanumérico (máximo) Rellenados con blancos (0x20) a la derechaa Si “Local comercio OnUs ≠ 00” Con pan encriptado se entrega 80 caracteres alfanuméricos que corresponde a 40 HEXA |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
PAN SHA-1 |
40 | Valor alfanumérico PAN encriptado con algoritmo SHA-1 Si “Transacción offline = Y” |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
BIN |
6 | Valor Numérico Si “Entrega BIN = Y” o “Transacción offline = Y” |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
4 últimos dígitos |
4 | Valor Numérico | |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Nombre tarjetahabiente |
26 | Valor alfanumérico (máximo) | |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Nombre marca de la tarjeta |
20 | Valor alfanumérico (máximo) De acuerdo a
|
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Abreviación de la tarjeta |
2 | Valor alfanumérico De acuerdo a
|
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Flag solicita 4 últimos dígitos |
1 | Valor alfanumérico (Y: El punto de venta debe solicitar los 4ud) (N: El pinpad solicitará el ingreso de PIN) En caso de anulación no se ingresa pin, tampoco se solicita ingreso de 4ud. |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
<ETX> |
1 | Indica el fin de texto o comando valor hexadecimal: 0x03 |
ETX |
<LRC> |
1 | Byte resultado de la operación XOR del mensaje |
0200 – 0210 Comando Requerimiento de venta/anulación
Requerimiento
| DATO | LARGO | COMENTARIO | VALOR POR DEFECTO |
|---|---|---|---|
<STX> |
1 | Indica inicio de texto o comando valor hexadecimal: 0x02 |
STX |
Comando |
4 | Valor ASCII: 0200 valor hexadecimal: 0x30 0x32 0x30 0x30 |
0200 |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Monto |
18 | Valor alfanumérico (máximo) Monto de Compra (sin propina, sin vuelto) Monto mínimo $50,00 o US$1,00 Incluye dos decimales |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Número Ticket/Boleta |
10 | Valor alfanumérico Si comercio no utiliza este campo enviar el campo un cero |
0 |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Numero de Cuotas |
2 | Valor numérico Obligatorio si “Tipo de transacción = 01” Si la venta original fue sin cuotas se debe informar el valor 00 |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Campo Impresión |
1 | Valor numérico Indica si entrega voucher formateado 0: No envía voucher (utiliza comandos 500-510) 1: Envía voucher (utiliza comandos 540-550) |
1 |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Enviar Mensajes |
1 | Valor numérico Indica si el PINPAD debe enviar mensajes de estatus de la transacción 0: No envía mensajes (Valor por defecto) 1: Envía mensajes |
0 |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Indicador de contexto |
16 | Valor alfanumérico Id entregado por el pinpad por cada transacción |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Tipo de transacción |
2 | Valor numérico (00: Venta) (01: Anulación) |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Código de comercio |
12 | Valor numérico Código del comercio entregado por TBK y configurado en la caja. EJ: 597012345678 |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Terminal ID |
16 | Valor alfanumérico DDLL o Dirección lógica entregada por TBK y configurada en la caja en tabla de parametros. |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Monto cuotas |
9 | Valor numérico Obligatorio si Tipo de transacción = 01. Si la venta original fue sin cuotas se debe informar el valor “0” |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Producto |
1 | Valor numérico Obligatorio si Tipo de transacción = 01. Corresponde al campo “Tipo cuotas” del comando 0510 de la venta original |
Ø |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Número de empleado |
6 | Valor alfanumérico Campo sin uso enviar vacío siempre |
Ø |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Número único |
26 | Valor numérico Caja debe enviar el número único para imprimir en el voucher tanto en venta como anulación. Cada comercio puede definir un formato para el numero único, TBK entrega el siguiente ejemplo: AAAAMMDDHHMMSSLLLCCCXXXXXX Donde LLL es un número del local CCC es el número de la caja o punto de venta XXXXXX es un contador Campo a |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Código de dependiente (Empleado) |
4 | Valor numérico Campo de Empleado es opcional Si comercio no lo utiliza enviar el campo vacío |
Ø |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Índice interno del comercio |
16 | Valor alfanumérico (máximo) Campo que puede ser utilizado por el comercio para agregar información que le sirva a sus procesos internos, numero caja, vendedor, ID venta, etc. |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Código de autorización transacción original |
8 | Valor alfanumérico (máximo) Código de autorización de la venta original, obligatorio si es una anulación “Tipo de transacción= 01” |
Ø |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Número de secuencia transacción original |
9 | Valor alfanumérico (máximo) Número de secuencia de la venta original, obligatorio si es una anulación “Tipo de transacción= 01” También conocido como número de operación |
Ø |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Fecha transacción original |
6 | Formato AAMMDD Fecha de la venta original, obligatorio si es una anulación “Tipo de transacción = 01” |
Ø |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Hora transacción original |
6 | Formato HHMMSS Hora de la venta original, obligatorio si es una anulación “Tipo de transacción = 01” |
Ø |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
4 últimos dígitos |
4 | Valor numérico Si es una anulación “Tipo de transacción = 01”, se debe ingresar los 4ud de la venta original, contra este dato el pinpad comparará con la tarjeta deslizada para anular. Si “Tipo de transacción = 00” y “Flag solicita 4 últimos dígitos = Y” del comando 0110, se debe ingresar los 4ud de la tarjeta deslizada. |
Ø |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
<ETX> |
1 | Indica el fin de texto o comando valor hexadecimal: 0x03 |
ETX |
<LRC> |
1 | Byte resultado de la operación XOR del mensaje |
Timeout máximo de espera por comando 210 de 125seg, ya que hay hasta 4 interacción con el usuario.
Respuesta
| DATO | LARGO | COMENTARIO | VALOR POR DEFECTO |
|---|---|---|---|
<STX> |
1 | Indica inicio de texto o comando valor hexadecimal: 0x02 |
STX |
Comando |
4 | Valor ASCII: 0210 valor hexadecimal: 0x30 0x32 0x31 0x30 |
0210 |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Código de respuesta PinPad |
2 | Valor Numérico En caso de rechazo se debe desplegar en el punto de venta: RECHAZO PINPAD - <XX> : <GLOSA> De acuerdo a
|
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Indicador de contexto |
4 | Valor alfanumérico Id entregado por el pinpad por cada transacción |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Largo mensaje |
4 | Valor numérico | |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Mensaje SPDH |
2048 | Valor alfanumérico (máximo) | |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
<ETX> |
1 | Indica el fin de texto o comando valor hexadecimal: 0x03 |
ETX |
<LRC> |
1 | Byte resultado de la operación XOR del mensaje |
0400 – 0410 Comando Requerimiento de reversa
Si se requiere una reversa, la caja rescata el indicador de contexto que ha guardado de su última transacción (independiente del nivel de completitud de la transacción) y solicita al pinpad la reversa. El pinpad puede discriminar si solo se hizo lectura de tarjeta, o solo se hizo una consulta de cuotas, o si la venta está rechazada o aprobada.
Si el pinpad no está presente, debe mantener la reversa pendiente, hasta que el pinpad pueda responder.
Requerimiento
| DATO | LARGO | COMENTARIO | VALOR POR DEFECTO |
|---|---|---|---|
<STX> |
1 | Indica inicio de texto o comando valor hexadecimal: 0x02 |
STX |
Comando |
4 | Valor ASCII: 0400 valor hexadecimal: 0x30 0x34 0x30 0x30 |
0400 |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Indicador de contexto |
16 | Valor alfanumérico Id de la transacción que se quiere reversar |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
<ETX> |
1 | Indica el fin de texto o comando valor hexadecimal: 0x03 |
ETX |
<LRC> |
1 | Byte resultado de la operación XOR del mensaje |
Timeout máximo de espera por comando 410 de 20seg y no requiere interacción con tarjetabiente.
Respuesta
| DATO | LARGO | COMENTARIO | VALOR POR DEFECTO |
|---|---|---|---|
<STX> |
1 | Indica inicio de texto o comando valor hexadecimal: 0x02 |
STX |
Comando |
4 | Valor ASCII: 0410 valor hexadecimal: 0x30 0x34 0x31 0x30 |
0410 |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Código de respuesta PinPad |
2 | Valor numérico En caso de rechazo se debe desplegar en el punto de venta: RECHAZO PINPAD - <XX> : <GLOSA> De acuerdo a
|
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Indicador de contexto |
16 | Valor alfanumérico Id entregado por el pinpad por cada transacción |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Largo mensaje |
4 | Valor numérico | |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Mensaje SPDH |
2048 | Valor alfanumérico (máximo) | |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
<ETX> |
1 | Indica el fin de texto o comando valor hexadecimal: 0x03 |
ETX |
<LRC> |
1 | Byte resultado de la operación XOR del mensaje |
0500 – 0510 Comando Requerimiento de validación/actualización
En este comando 0510 la caja debe validar si la respuesta final (Flag terminal) y si está aprobada (Código respuesta Transbank) para luego imprimir. Si la transacción no es final (Flag terminal) debe renviar el mensaje spdh adjunto, no importa si la transacción está o no aprobada en este caso.
Requerimiento
| DATO | LARGO | COMENTARIO | VALOR POR DEFECTO |
|---|---|---|---|
<STX> |
1 | Indica inicio de texto o comando valor hexadecimal: 0x02 |
STX |
Comando |
4 | Valor ASCII: 0500 valor hexadecimal: 0x30 0x35 0x30 0x30 |
0500 |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Indicador de contexto |
16 | Valor alfanumérico Id entregado por el pinpad por cada transacción |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Largo mensaje |
4 | Valor numérico | |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Mensaje SPDH |
2048 | Valor alfanumérico (máximo) | |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
<ETX> |
1 | Indica el fin de texto o comando valor hexadecimal: 0x03 |
ETX |
<LRC> |
1 | Byte resultado de la operación XOR del mensaje |
Timeout máximo de espera por comando 510 de 125seg, ya que hay hasta 4 interacción con el usuario.
Respuesta
| DATO | LARGO | COMENTARIO | VALOR POR DEFECTO |
|---|---|---|---|
<STX> |
1 | Indica inicio de texto o comando valor hexadecimal: 0x02 |
STX |
Comando |
4 | Valor ASCII: 0510 valor hexadecimal: 0x30 0x35 0x31 0x30 |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Código de respuesta PinPad |
2 | Valor numérico En caso de rechazo se debe desplegar en el punto de venta: RECHAZO PINPAD - <XX> : <GLOSA> De acuerdo a
|
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Indicador de contexto |
16 | Valor alfanumérico Id entregado por el pinpad por cada transacción |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Código de comercio |
12 | Valor numérico Código del comercio entregado por TBK y configurado en la caja, se imprime en voucher |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Terminal ID |
16 | Valor alfanumérico Dirección lógica entregada por TBK y configurada en la caja, se imprime en voucher |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Número Ticket/Boleta |
20 | Valor alfanumérico Campo opcional, si viene se imprime en voucher si no viene se omite el campo |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Empleado |
4 | Valor alfanumérico Campo opcional, si viene se imprime en voucher si no viene se omite el campo |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Código Autorización |
8 | Valor alfanumérico (máximo) Código de autorización de la transacción enviado por TBK ejemplo: |AB 12 C3| Se imprime lo que viene en el voucher |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Monto |
18 | Valor numérico (máximo) Monto total autorizado (incluye el monto de la venta, propina, vuelto y donación según sea el caso) Se imprime en voucher |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Monto vuelto |
18 | Valor numérico (máximo) Vuelto seleccionado por cliente, solo aplica en debito Se imprime en voucher |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Numero de Cuotas |
2 | Valor numérico Cantidad de cuotas de la transacción (para ventas sin cuotas se informa “00”) Se imprime en voucher |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Monto cuota |
14 | Valor numérico Si el monto informado es vacío || o |0| caja debe omitir la línea completa en el voucher. Se imprime en voucher si viene el campo |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Últimos 4 Dígitos Tarjeta |
4 | Valor numérico No se imprime |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Número Operación |
9 | Correlativo de transacción del terminal También conocido como número de secuencia este campo se debe imprimir en voucher de venta y anulación. |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Glosa Tipo de Tarjeta |
7 | Valor alfanumérico (máximo) Valor de glosa en
|
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Fecha Contable |
6 | Valor alfanumérico Se utiliza sólo si es transacción de Debito Caja no debe formatear (ej: DDAAMM), simplemente debe transferir el valor al voucher (XX/XX/XX) |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Número de Cuenta |
19 | Valor alfanumérico Número de tarjeta enmascarado para incluir en el voucher |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Abreviación de la tarjeta |
2 | Valor alfanumérico Valor a imprimir en el voucher |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Fecha Transacción |
6 | Formato AAMMDD Valor a imprimir en el voucher |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Hora Transacción |
6 | Formato HHMMSS Valor a imprimir en el voucher |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Campo Impresión |
8192 | Campo depende si la caja requiere voucher formateado (máximo) En este comando no se envía el voucher. |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Transacción premiada |
1 | Valor numérico |1|: transacción premiada En este caso caja debe imprimir voucher PEL además del de venta ||: transacción sin premio |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Tipo promoción |
1 | Valor numérico |1|: Entrega Pto. de Venta |2|: Entrega Diferida |3|: Devolución al Tarjeta Habiente |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Código promoción |
8 | Valor alfanumérico Valor a imprimir en el voucher premiado |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Nombre promoción |
21 | Valor alfanumérico Valor a imprimir en el voucher de premio |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Glosa vale premio |
62 | Valor alfanumérico Valor a imprimir en el voucher de premio |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Texto vale premio |
27 | Valor alfanumérico Valor a imprimir en el voucher de premio |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Flag permite cuotas |
1 | Valor numérico Campo informativo de la configuración del comercio |
0 |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Flag de gracia |
1 | Valor numérico Campo informativo de la configuración del comercio |
0 |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Flag C2C |
1 | Valor numérico Campo informativo de la configuración del comercio |
0 |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Flag C3C |
1 | Valor numérico Campo informativo de la configuración del comercio |
0 |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Flag NCuotas |
1 | Valor numérico Campo informativo de la configuración del comercio |
0 |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Flag máximo de cuotas |
2 | Valor numérico Campo informativo de la configuración del comercio |
00 |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Tipo de menú |
2 | Valor alfanumérico Indicador del tipo de menú por el cual se realizó la transacción |CR| : CRÉDITO |DB| : DÉBITO PREPAGO |NB| : NO BANCARIA Valor de tipo en
Una venta hecha como debito puede ser autorizada como prepago |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Indicador transacción con gracia |
1 | Valor numérico Indicador de modalidad de la transacción |0| transacción sin mes gracia |1| transacción con mes gracia |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Tipo cuotas |
1 | Valor numérico |0| Sin cuotas |1| Cuotas normales |3| C3C o C2C |4| CIC o N-cuotas |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Tasa aplicada |
4 | Valor numérico Solo se imprime en voucher si “Flag imprimir tasa = 1” |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Glosa tipo cuota |
30 | Valor alfanumérico Glosa a imprimir en voucher Si el campo informado viene vacío “||” caja debe omitir la línea en el voucher. |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Glosa tipo cuota 2 |
22 | Valor alfanumérico Glosa que se despliega en pinpad |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Glosa promoción |
10 | Valor alfanumérico Glosa que se despliega en pinpad |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Id promoción |
10 | Valor alfanumérico Glosa que se despliega en pinpad |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Flag imprimir tasa |
1 | Valor numérico || o |0| no imprime tasa aplicada |1| imprime tasa aplicada |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Periodo diferido |
3 | Valor numérico Periodo diferido seleccionado, valor a imprimir en voucher |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Diferido 1 periodo |
3 | Valor numérico No utilizado |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Diferido 1 valor tasa |
4 | Valor numérico No utilizado |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Diferido 1 valor cuota |
14 | Valor numérico No utilizado |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Diferido 2 periodo |
3 | Valor numérico No utilizado |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Diferido 2 valor tasa |
4 | Valor numérico No utilizado |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Diferido 2 valor cuota |
14 | Valor numérico No utilizado |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Diferido 3 periodo |
3 | Valor numérico No utilizado |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Diferido 3 valor tasa |
4 | Valor numérico No utilizado |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Diferido 3 valor cuota |
14 | Valor numérico No utilizado |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Número de secuencia transacción original |
9 | Valor alfanumérico (máximo) También conocido como número de operación original de la venta. No se está usando este campo, no se imprime |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Código respuesta Transbank |
3 | Valor numérico Código de respuesta una vez finalizada la transacción. Se debe desplegar en el punto de venta. EJ: RESPUESTA TRANSBANK - <XXX> : <GLOSA> |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Glosa respuesta Transbank |
48 | Valor alfanumérico (máximo) Glosa que despliega el pinpad una vez finalizada la transacción. Se debe desplegar en el punto de venta. EJ: RESPUESTA TRANSBANK - <XXX> : <GLOSA> |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Flag transacción con PIN |
1 | Valor alfanumérico Y: Transacción autentificada con PIN N: Transacción autentificada por firma |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Nombre tarjetahabiente |
26 | Valor alfanumérico Sólo imprimir si “Flag tipo voucher = 1, 2 ó 3” |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Flag tipo voucher |
1 | Valor numérico Según el número recibido se debe imprimir voucher con o sin firma: |0| = Sin firma |1| o |2| o |3| = con firma Cabeceras de los voucher: Para ventas con crédito: “VENTA CREDITO” Para ventas con débito (siempre sin firma): “VENTA DEBITO” Para ventas con no bancaria: “VENTA NO BANCARIA” Para ventas con prepago (sin firma): “VENTA PREPAGO” Para anulaciones con crédito (sin firma):“ANULACION CREDITO” Para anulaciones con no bancaria (sin firma): “ANULACION NO BANCARIA” |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Flag modalidad cuotas |
1 | Valor alfanumérico 0: Modalidad 3.1 (No utilizado) 1: Modalidad cuotas 4.0 |
1 |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Glosa transacción afecta a ahorro |
40 | Valor alfanumérico (máximo) Se debe imprimir en el voucher cuando sea distinta de vacío Campo 9, subcampo D |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Número de secuencia |
9 | Valor numérico No se está usando este campo, este no se imprime También conocido como número de operación |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Flag mensaje terminal |
1 | Valor alfanumérico Y: El mensaje es terminal y NO se debe enviar el mensaje SPDH de respuesta N: Se debe enviar el mensaje SPDH de respuesta |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Largo mensaje |
4 | Valor numérico | |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Mensaje SPDH Venta/Reversa |
2048 | Valor alfanumérico (máximo) | |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
<ETX> |
1 | Indica el fin de texto o comando valor hexadecimal: 0x03 |
ETX |
<LRC> |
1 | Byte resultado de la operación XOR del mensaje |
0520 – 0530 Comando Requerimiento de validación/actualización
Solo para pinpad wifi retail estándar.
0540 – 0550 Comando Requerimiento de validación/actualización
En este comando 0540 la caja debe validar si la respuesta final (Flag terminal) y si está aprobada (Código respuesta Transbank) para luego imprimir. Si la transacción no es final (Flag terminal) debe renviar el mensaje spdh adjunto, no importa si la transacción está o no aprobada en este caso.
Entrega un voucher formateado para impresión y además soporta tarjetas de Prepago.
Requerimiento
| DATO | LARGO | COMENTARIO | VALOR POR DEFECTO |
|---|---|---|---|
<STX> |
1 | Indica inicio de texto o comando valor hexadecimal: 0x02 |
STX |
Comando |
4 | Valor ASCII: 0540 valor hexadecimal: 0x30 0x35 0x34 0x30 |
0540 |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Indicador de contexto |
16 | Valor alfanumérico Id entregado por el pinpad por cada transacción |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Largo mensaje |
4 | Valor Numérico | |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Mensaje SPDH |
2048 | Valor alfanumérico (máximo) | |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Nombre Comercio |
40 | Valor alfanumérico Campo paramétrico en caja enviado al pinpad |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Dirección Comercio |
40 | Valor alfanumérico Campo paramétrico en caja enviado al pinpad |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Comuna Comercio |
40 | Valor alfanumérico Campo paramétrico en caja enviado al pinpad Puede ser comuna o ciudad |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
<ETX> |
1 | Indica el fin de texto o comando valor hexadecimal: 0x03 |
ETX |
<LRC> |
1 | Byte resultado de la operación XOR del mensaje |
Timeout maximo de espera por comando 540 de 125seg, ya que hay hasta 4 interacción con el usuario.
Respuesta
| DATO | LARGO | COMENTARIO | VALOR POR DEFECTO |
|---|---|---|---|
<STX> |
1 | Indica inicio de texto o comando valor hexadecimal: 0x02 |
STX |
Comando |
4 | Valor ASCII: 0550 valor hexadecimal: 0x30 0x35 0x31 0x30 |
0550 |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Código de respuesta PinPad |
2 | Valor Numérico En caso de rechazo se debe desplegar en el punto de venta: RECHAZO PINPAD - <XX> : <GLOSA> De acuerdo a
|
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Indicador de contexto |
16 | Valor alfanumérico Id entregado por el pinpad por cada transacción |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Código de comercio |
12 | Valor numérico Código del comercio entregado por TBK y configurado en la caja, se imprime en voucher |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Terminal ID |
16 | Valor alfanumérico Dirección lógica entregada por TBK y configurada en la caja, se imprime en voucher |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Número Ticket/Boleta |
20 | Valor alfanumérico Campo opcional, si viene se imprime en voucher si no viene se omite el campo |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Empleado |
4 | Valor alfanumérico Campo opcional, si viene se imprime en voucher si no viene se omite el campo |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Código Autorización |
8 | Valor alfanumérico (máximo) Código de autorización de la transacción enviado por TBK ejemplo: |AB 12 C3| Se imprime lo que viene en el voucher |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Monto |
18 | Valor numérico (máximo) Monto total autorizado (incluye el monto de la venta, propina, vuelto y donación según sea el caso) Se imprime en voucher |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Monto vuelto |
18 | Valor numérico (máximo) Vuelto seleccionado por cliente, solo aplica en debito Se imprime en voucher |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Numero de Cuotas |
2 | Valor numérico Cantidad de cuotas de la transacción (para ventas sin cuotas se informa “00”) Se imprime en voucher |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Monto cuota |
14 | Valor numérico Si el monto informado es vacío || o |0| caja debe omitir la línea completa en el voucher. Se imprime en voucher si viene el campo |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Últimos 4 Dígitos Tarjeta |
4 | Valor numérico No se imprime |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Número Operación |
9 | Correlativo de transacción del terminal También conocido como número de secuencia este campo se debe imprimir en voucher de venta y anulación. |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Glosa Tipo de Tarjeta |
7 | Valor alfanumérico (máximo) Valor de glosa en
|
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Fecha Contable |
6 | Valor alfanumérico Se utiliza sólo si es transacción de Debito Caja no debe formatear (ej: DDAAMM), simplemente debe transferir el valor al voucher (XX/XX/XX) |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Número de Cuenta |
19 | Valor alfanumérico Número de tarjeta enmascarado para incluir en el voucher |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Abreviación de la tarjeta |
2 | Valor alfanumérico Valor a imprimir en el voucher |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Fecha Transacción |
6 | Formato AAMMDD Valor a imprimir en el voucher |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Hora Transacción |
6 | Formato HHMMSS Valor a imprimir en el voucher |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Campo Impresión |
8192 | Campo depende si la caja requiere voucher formateado (máximo) Se envía voucher siempre |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Transacción premiada |
1 | Valor numérico |1|: transacción premiada En este caso caja debe imprimir voucher PEL además del de venta ||: transacción sin premio |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Tipo promoción |
1 | Valor numérico |1|: Entrega Pto. de Venta |2|: Entrega Diferida |3|: Devolución al Tarjeta Habiente |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Código promoción |
8 | Valor alfanumérico Valor a imprimir en el voucher premiado |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Nombre promoción |
21 | Valor alfanumérico Valor a imprimir en el voucher de premio |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Glosa vale premio |
62 | Valor alfanumérico Valor a imprimir en el voucher de premio |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Texto vale premio |
27 | Valor alfanumérico Valor a imprimir en el voucher de premio |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Flag permite cuotas |
1 | Valor numérico Campo informativo de la configuración del comercio |
0 |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Flag de gracia |
1 | Valor numérico Campo informativo de la configuración del comercio |
0 |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Flag C2C |
1 | Valor numérico Campo informativo de la configuración del comercio |
0 |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Flag C3C |
1 | Valor numérico Campo informativo de la configuración del comercio |
0 |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Flag NCuotas |
1 | Valor numérico Campo informativo de la configuración del comercio |
0 |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Flag máximo de cuotas |
2 | Valor numérico Campo informativo de la configuración del comercio |
00 |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Tipo de menú |
2 | Valor alfanumérico Indicador del tipo de menú por el cual se realizó la transacción |CR| : CRÉDITO |DB| : DÉBITO PREPAGO |NB| : NO BANCARIA Valor de tipo en
Una venta hecha como debito puede ser autorizada como prepago |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Indicador transacción con gracia |
1 | Valor numérico Indicador de modalidad de la transacción |0| transacción sin mes gracia |1| transacción con mes gracia |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Tipo cuotas |
1 | Valor numérico |0| Sin cuotas |1| Cuotas normales |3| C3C o C2C |4| CIC o N-cuotas |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Tasa aplicada |
4 | Valor numérico Solo se imprime en voucher si “Flag imprimir tasa = 1” |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Glosa tipo cuota |
30 | Valor alfanumérico Glosa a imprimir en voucher Si el campo informado viene vacío “||” caja debe omitir la línea en el voucher. |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Glosa tipo cuota 2 |
22 | Valor alfanumérico Glosa que se despliega en pinpad |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Glosa promoción |
10 | Valor alfanumérico Glosa que se despliega en pinpad |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Id promoción |
10 | Valor alfanumérico Glosa que se despliega en pinpad |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Flag imprimir tasa |
1 | Valor numérico || o |0| no imprime tasa aplicada |1| imprime tasa aplicada |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Periodo diferido |
3 | Valor numérico Periodo diferido seleccionado, valor a imprimir en voucher |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Diferido 1 periodo |
3 | Valor numérico No utilizado |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Diferido 1 valor tasa |
4 | Valor numérico No utilizado |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Diferido 1 valor cuota |
14 | Valor numérico No utilizado |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Diferido 2 periodo |
3 | Valor numérico No utilizado |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Diferido 2 valor tasa |
4 | Valor numérico No utilizado |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Diferido 2 valor cuota |
14 | Valor numérico No utilizado |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Diferido 3 periodo |
3 | Valor numérico No utilizado |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Diferido 3 valor tasa |
4 | Valor numérico No utilizado |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Diferido 3 valor cuota |
14 | Valor numérico No utilizado |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Número de secuencia transacción original |
9 | Valor alfanumérico (máximo) También conocido como número de operación original de la venta. No se está usando este campo, no se imprime |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Código respuesta Transbank |
3 | Valor numérico Código de respuesta una vez finalizada la transacción. Se debe desplegar en el punto de venta. EJ: RESPUESTA TRANSBANK - <XXX> : <GLOSA> |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Glosa respuesta Transbank |
48 | Valor alfanumérico (máximo) Glosa que despliega el pinpad una vez finalizada la transacción. Se debe desplegar en el punto de venta. EJ: RESPUESTA TRANSBANK - <XXX> : <GLOSA> |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Flag transacción con PIN |
1 | Valor alfanumérico Y: Transacción autentificada con PIN N: Transacción autentificada por firma |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Nombre tarjetahabiente |
26 | Valor alfanumérico Sólo imprimir si “Flag tipo voucher = 1, 2 ó 3” |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Flag tipo voucher |
1 | Valor numérico Según el número recibido se debe imprimir voucher con o sin firma: |0| = Sin firma |1| o |2| o |3| = con firma Cabeceras de los voucher: Para ventas con crédito: “VENTA CREDITO” Para ventas con débito (siempre sin firma): “VENTA DEBITO” Para ventas con no bancaria: “VENTA NO BANCARIA” Para ventas con prepago (sin firma): “VENTA PREPAGO” Para anulaciones con crédito (sin firma):“ANULACION CREDITO” Para anulaciones con no bancaria (sin firma): “ANULACION NO BANCARIA” |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Flag modalidad cuotas |
1 | Valor alfanumérico 0: Modalidad 3.1 (No utilizado) 1: Modalidad cuotas 4.0 |
1 |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Glosa transacción afecta a ahorro |
40 | Valor alfanumérico (máximo) Se debe imprimir en el voucher cuando sea distinta de vacío Campo 9, subcampo D |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Número de secuencia |
9 | Valor numérico No se está usando este campo, este no se imprime También conocido como número de operación |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Flag mensaje terminal |
1 | Valor alfanumérico Y: El mensaje es terminal y NO se debe enviar el mensaje SPDH de respuesta N: Se debe enviar el mensaje SPDH de respuesta |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Largo mensaje |
4 | Valor numérico | |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Mensaje SPDH Venta/Reversa |
2048 | Valor alfanumérico (máximo) | |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Propina |
18 | Valor numérico Monto Propina o Donación |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Voucher de Rechazo |
1024 | Valor numérico Cuando transacción es declinada por EMV se debe imprimir un voucher especial. Si este campo viene vacío no se imprime, si viene con dato se imprime Este voucher se imprime solo, sin voucher de venta |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Voucher de PEL |
1024 | Valor alfanumérico Voucher de PEL si viene la caja debe imprimirlo, solo una vez junto al voucher de venta No se debe imprimir en duplicado Este voucher se imprime junto al de venta |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
LABEL - EMV |
32 | Valor alfanumérico Si el campo viene con datos caja debe incluirlo en el voucher en la posición indicada |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
RID - EMV |
32 | Valor alfanumérico Si el campo viene con datos caja debe incluirlo en el voucher en la posición indicada |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Modelo pinpad |
6 | Valor numérico Caja debe incluirlo en el voucher ejemplo: VX805 Campo obligatorio |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Versión de pinpad |
6 | Valor numérico Caja debe incluirlo en el voucher ejemplo: 12.34A Campo obligatorio |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Saldo Prepago |
40 | Valor alfanumérico (máximo) Indica el saldo de una tarjeta de prepago la cual se debe imprimir en voucher cuando es venta de prepago y cuando viene el saldo. Nota: El Pinpad agrega esa glosa al voucher tal como viene en la mensajería. |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
<ETX> |
1 | Indica el fin de texto o comando valor hexadecimal: 0x03 |
ETX |
<LRC> |
1 | Byte resultado de la operación XOR del mensaje |
0560 – 0570 Comando Requerimiento de validación/actualización
Solo para pinpad wifi retail estándar
0580 – 0590 Comando Requerimiento con capacidad Surcharge
En este comando 0580 la caja debe validar si la respuesta final (Flag terminal) y si está aprobada (Código respuesta Transbank) para luego imprimir. Si la transacción no es final (Flag terminal) debe renviar el mensaje SPDH adjunto, no importa si la transacción está o no aprobada en este caso. Entrega un voucher formateado para impresión. Además, soporta tarjetas de Prepago y Surcharge.
Requerimiento
| DATO | LARGO | COMENTARIO | VALOR POR DEFECTO |
|---|---|---|---|
<STX> |
1 | Indica inicio de texto o comando valor hexadecimal: 0x02 |
STX |
Comando |
4 | Valor ASCII: 0580 valor hexadecimal: 0x30 0x35 0x38 0x30 |
0580 |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Indicador de contexto |
16 | Valor alfanumérico Id entregado por el pinpad por cada transacción |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Largo mensaje |
4 | Valor Numérico | |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Mensaje SPDH |
2048 | Valor alfanumérico (máximo) | |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Nombre Comercio |
40 | Valor alfanumérico Campo paramétrico en caja enviado al pinpad |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Dirección Comercio |
40 | Valor alfanumérico Campo paramétrico en caja enviado al pinpad |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Comuna Comercio |
40 | Valor alfanumérico Campo paramétrico en caja enviado al pinpad Puede ser comuna o ciudad |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
<ETX> |
1 | Indica el fin de texto o comando valor hexadecimal: 0x03 |
ETX |
<LRC> |
1 | Byte resultado de la operación XOR del mensaje |
Timeout máximo de espera por comando 540 de 125seg, ya que hay hasta 4 interacción con el usuario.
Respuesta
| DATO | LARGO | COMENTARIO | VALOR POR DEFECTO |
|---|---|---|---|
<STX> |
1 | Indica inicio de texto o comando valor hexadecimal: 0x02 |
STX |
Comando |
4 | Valor ASCII: 0590 valor hexadecimal: 0x30 0x35 0x39 0x30 |
0590 |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Código de respuesta PinPad |
2 | Valor Numérico En caso de rechazo se debe desplegar en el punto de venta: RECHAZO PINPAD - <XX> : <GLOSA> De acuerdo a
|
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Indicador de contexto |
16 | Valor alfanumérico Id entregado por el pinpad por cada transacción |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Código de comercio |
12 | Valor numérico Código del comercio entregado por TBK y configurado en la caja, se imprime en voucher |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Terminal ID |
16 | Valor alfanumérico Dirección lógica entregada por TBK y configurada en la caja, se imprime en voucher |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Número Ticket/Boleta |
20 | Valor alfanumérico Campo opcional, si viene se imprime en voucher si no viene se omite el campo |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Empleado |
4 | Valor alfanumérico Campo opcional, si viene se imprime en voucher si no viene se omite el campo |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Código Autorización |
8 | Valor alfanumérico (máximo) Código de autorización de la transacción enviado por TBK ejemplo: |AB 12 C3| Se imprime lo que viene en el voucher |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Monto |
18 | Valor numérico (máximo) Monto total autorizado (incluye el monto de la venta, propina, vuelto y donación según sea el caso) Se imprime en voucher |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Monto vuelto |
18 | Valor numérico (máximo) Vuelto seleccionado por cliente, solo aplica en debito Se imprime en voucher |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Numero de Cuotas |
2 | Valor numérico Cantidad de cuotas de la transacción (para ventas sin cuotas se informa “00”) Se imprime en voucher |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Monto cuota |
14 | Valor numérico Si el monto informado es vacío || o |0| caja debe omitir la línea completa en el voucher. Se imprime en voucher si viene el campo |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Últimos 4 Dígitos Tarjeta |
4 | Valor numérico No se imprime |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Número Operación |
9 | Correlativo de transacción del terminal También conocido como número de secuencia este campo se debe imprimir en voucher de venta y anulación. |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Glosa Tipo de Tarjeta |
7 | Valor alfanumérico (máximo) Valor de glosa en
|
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Fecha Contable |
6 | Valor alfanumérico Se utiliza sólo si es transacción de Debito Caja no debe formatear (ej: DDAAMM), simplemente debe transferir el valor al voucher (XX/XX/XX) |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Número de Cuenta |
19 | Valor alfanumérico Número de tarjeta enmascarado para incluir en el voucher |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Abreviación de la tarjeta |
2 | Valor alfanumérico Valor a imprimir en el voucher |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Fecha Transacción |
6 | Formato AAMMDD Valor a imprimir en el voucher |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Hora Transacción |
6 | Formato HHMMSS Valor a imprimir en el voucher |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Campo Impresión |
8192 | Campo depende si la caja requiere voucher formateado (máximo) Se envía voucher siempre |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Transacción premiada |
1 | Valor numérico |1|: transacción premiada En este caso caja debe imprimir voucher PEL además del de venta ||: transacción sin premio |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Tipo promoción |
1 | Valor numérico |1|: Entrega Pto. de Venta |2|: Entrega Diferida |3|: Devolución al Tarjeta Habiente |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Código promoción |
8 | Valor alfanumérico Valor a imprimir en el voucher premiado |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Nombre promoción |
21 | Valor alfanumérico Valor a imprimir en el voucher de premio |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Glosa vale premio |
62 | Valor alfanumérico Valor a imprimir en el voucher de premio |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Texto vale premio |
27 | Valor alfanumérico Valor a imprimir en el voucher de premio |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Flag permite cuotas |
1 | Valor numérico Campo informativo de la configuración del comercio |
0 |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Flag de gracia |
1 | Valor numérico Campo informativo de la configuración del comercio |
0 |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Flag C2C |
1 | Valor numérico Campo informativo de la configuración del comercio |
0 |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Flag C3C |
1 | Valor numérico Campo informativo de la configuración del comercio |
0 |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Flag NCuotas |
1 | Valor numérico Campo informativo de la configuración del comercio |
0 |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Flag máximo de cuotas |
2 | Valor numérico Campo informativo de la configuración del comercio |
00 |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Tipo de menú |
2 | Valor alfanumérico Indicador del tipo de menú por el cual se realizó la transacción |CR| : CRÉDITO |DB| : DÉBITO PREPAGO |NB| : NO BANCARIA Valor de tipo en
Una venta hecha como debito puede ser autorizada como prepago |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Indicador transacción con gracia |
1 | Valor numérico Indicador de modalidad de la transacción |0| transacción sin mes gracia |1| transacción con mes gracia |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Tipo cuotas |
1 | Valor numérico |0| Sin cuotas |1| Cuotas normales |3| C3C o C2C |4| CIC o N-cuotas |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Tasa aplicada |
4 | Valor numérico Solo se imprime en voucher si “Flag imprimir tasa = 1” |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Glosa tipo cuota |
30 | Valor alfanumérico Glosa a imprimir en voucher Si el campo informado viene vacío “||” caja debe omitir la línea en el voucher. |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Glosa tipo cuota 2 |
22 | Valor alfanumérico Glosa que se despliega en pinpad |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Glosa promoción |
10 | Valor alfanumérico Glosa que se despliega en pinpad |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Id promoción |
10 | Valor alfanumérico Glosa que se despliega en pinpad |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Flag imprimir tasa |
1 | Valor numérico || o |0| no imprime tasa aplicada |1| imprime tasa aplicada |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Periodo diferido |
3 | Valor numérico Periodo diferido seleccionado, valor a imprimir en voucher |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Diferido 1 periodo |
3 | Valor numérico No utilizado |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Diferido 1 valor tasa |
4 | Valor numérico No utilizado |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Diferido 1 valor cuota |
14 | Valor numérico No utilizado |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Diferido 2 periodo |
3 | Valor numérico No utilizado |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Diferido 2 valor tasa |
4 | Valor numérico No utilizado |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Diferido 2 valor cuota |
14 | Valor numérico No utilizado |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Diferido 3 periodo |
3 | Valor numérico No utilizado |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Diferido 3 valor tasa |
4 | Valor numérico No utilizado |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Diferido 3 valor cuota |
14 | Valor numérico No utilizado |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Número de secuencia transacción original |
9 | Valor alfanumérico (máximo) También conocido como número de operación original de la venta. No se está usando este campo, no se imprime |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Código respuesta Transbank |
3 | Valor numérico Código de respuesta una vez finalizada la transacción. Se debe desplegar en el punto de venta. EJ: RESPUESTA TRANSBANK - <XXX> : <GLOSA> |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Glosa respuesta Transbank |
48 | Valor alfanumérico (máximo) Glosa que despliega el pinpad una vez finalizada la transacción. Se debe desplegar en el punto de venta. EJ: RESPUESTA TRANSBANK - <XXX> : <GLOSA> |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Flag transacción con PIN |
1 | Valor alfanumérico Y: Transacción autentificada con PIN N: Transacción autentificada por firma |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Nombre tarjetahabiente |
26 | Valor alfanumérico Sólo imprimir si “Flag tipo voucher = 1, 2 ó 3” |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Flag tipo voucher |
1 | Valor numérico Según el número recibido se debe imprimir voucher con o sin firma: |0| = Sin firma |1| o |2| o |3| = con firma Cabeceras de los voucher: Para ventas con crédito: “VENTA CREDITO” Para ventas con débito (siempre sin firma): “VENTA DEBITO” Para ventas con no bancaria: “VENTA NO BANCARIA” Para ventas con prepago (sin firma): “VENTA PREPAGO” Para anulaciones con crédito (sin firma):“ANULACION CREDITO” Para anulaciones con no bancaria (sin firma): “ANULACION NO BANCARIA” |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Flag modalidad cuotas |
1 | Valor alfanumérico 0: Modalidad 3.1 (No utilizado) 1: Modalidad cuotas 4.0 |
1 |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Glosa transacción afecta a ahorro |
40 | Valor alfanumérico (máximo) Se debe imprimir en el voucher cuando sea distinta de vacío Campo 9, subcampo D |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Número de secuencia |
9 | Valor numérico No se está usando este campo, este no se imprime También conocido como número de operación |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Flag mensaje terminal |
1 | Valor alfanumérico Y: El mensaje es terminal y NO se debe enviar el mensaje SPDH de respuesta N: Se debe enviar el mensaje SPDH de respuesta |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Largo mensaje |
4 | Valor numérico | |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Mensaje SPDH Venta/Reversa |
2048 | Valor alfanumérico (máximo) | |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Propina |
18 | Valor numérico Monto Propina o Donación |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Voucher de Rechazo |
1024 | Valor numérico Cuando transacción es declinada por EMV se debe imprimir un voucher especial. Si este campo viene vacío no se imprime, si viene con dato se imprime Este voucher se imprime solo, sin voucher de venta |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Voucher de PEL |
1024 | Valor alfanumérico Voucher de PEL si viene la caja debe imprimirlo, solo una vez junto al voucher de venta No se debe imprimir en duplicado Este voucher se imprime junto al de venta |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
LABEL - EMV |
32 | Valor alfanumérico Si el campo viene con datos caja debe incluirlo en el voucher en la posición indicada |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
RID - EMV |
32 | Valor alfanumérico Si el campo viene con datos caja debe incluirlo en el voucher en la posición indicada |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Modelo pinpad |
6 | Valor numérico Caja debe incluirlo en el voucher ejemplo: VX805 Campo obligatorio |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Versión de pinpad |
6 | Valor numérico Caja debe incluirlo en el voucher ejemplo: 12.34A Campo obligatorio |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Saldo Prepago |
40 | Valor alfanumérico (máximo) Indica el saldo de una tarjeta de prepago la cual se debe imprimir en voucher cuando es venta de prepago y cuando viene el saldo. Nota: El Pinpad agrega esa glosa al voucher tal como viene en la mensajería. |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Monto Surcharge |
12 | Valor numérico Monto asociado a Surcharge. Incluye 2 decimales. Si el monto informado es vacío || o |0| caja debe omitir la línea completa en el voucher. Se imprime en voucher si viene el campo. Para realizar posteriores anulaciones, este campo se debe sumar al monto total de la venta. |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Surcharge Idioma |
2 | Valor alfanumérico Se informa el idioma en que será emitido el voucher. ES: Español EN: Ingles |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
<ETX> |
1 | Indica el fin de texto o comando valor hexadecimal: 0x03 |
ETX |
<LRC> |
1 | Byte resultado de la operación XOR del mensaje |
Comandos actualización parámetros pinpad (cierre batch)
0600 - Solicitud comando actualización parámetros pinpad
El cierre batch es una transacción que sirve para cargar parámetros en el pinpad conforme a lo configurado en Transbank para el comercio (ej: código de servicio) Este cierre se debe ejecutar al iniciar el día, idealmente en forma automática. También puede ejecutarse en forma manual, y esto además sirve para verificar si hay comunicación con Transbank, el resultado debe ser una transacción aprobada que figura en pantalla de pinpad y en caja.
Requerimiento
| DATO | LARGO | COMENTARIO | VALOR POR DEFECTO |
|---|---|---|---|
<STX> |
1 | Indica inicio de texto o comando valor hexadecimal: 0x02 |
STX |
Comando |
4 | Valor ASCII: 0600 valor hexadecimal: 0x30 0x36 0x30 0x30 |
0600 |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Código de comercio |
12 | Valor numérico Código del comercio entregado por TBK y configurado en la caja. |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Terminal ID |
16 | Valor alfanumérico Dirección lógica entregada por TBK y configurada en la caja. |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Índice interno del comercio |
16 | Valor alfanumérico (máximo) Campo que puede ser utilizado por el comercio para agregar información que le sirva a sus procesos internos. |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
<ETX> |
1 | Indica el fin de texto o comando valor hexadecimal: 0x03 |
ETX |
<LRC> |
1 | Byte resultado de la operación XOR del mensaje |
Timeout máximo de espera por comando 610 de 20seg, no requiere interacción con tarjetabiente.
Respuesta
| DATO | LARGO | COMENTARIO | VALOR POR DEFECTO |
|---|---|---|---|
<STX> |
1 | Indica inicio de texto o comando valor hexadecimal: 0x02 |
STX |
Comando |
4 | Valor ASCII: 0610 valor hexadecimal: 0x30 0x36 0x31 0x30 |
0610 |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Código de respuesta |
2 | Valor Numérico En caso de rechazo se debe desplegar en el punto de venta: RECHAZO PINPAD - <XX> : <GLOSA> De acuerdo a
|
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Índice interno del comercio |
16 | Valor alfanumérico (máximo) Campo que puede ser utilizado por el comercio para agregar información que le sirva a sus procesos internos. |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Largo mensaje |
4 | Valor numérico | |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Mensaje SPDH Cierre batch |
2048 | Valor alfanumérico (máximo) | |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
<ETX> |
1 | Indica el fin de texto o comando valor hexadecimal: 0x03 |
ETX |
<LRC> |
1 | Byte resultado de la operación XOR del mensaje |
0700 - Validación comando actualización parámetros pinpad
Requerimiento
| DATO | LARGO | COMENTARIO | VALOR POR DEFECTO |
|---|---|---|---|
<STX> |
1 | Indica inicio de texto o comando valor hexadecimal: 0x02 |
STX |
Comando |
4 | Valor ASCII: 0700 valor hexadecimal: 0x30 0x37 0x30 0x30 |
0700 |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Largo mensaje |
4 | Valor numérico | |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Mensaje SPDH Cierre batch |
2048 | Valor alfanumérico (máximo) | |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
<ETX> |
1 | Indica el fin de texto o comando valor hexadecimal: 0x03 |
ETX |
<LRC> |
1 | Byte resultado de la operación XOR del mensaje |
Timeout máximo de espera por comando 710 de 20seg, no requiere interacción con tarjetabiente.
Respuesta
| DATO | LARGO | COMENTARIO | VALOR POR DEFECTO |
|---|---|---|---|
<STX> |
1 | Indica inicio de texto o comando valor hexadecimal: 0x02 |
STX |
Comando |
4 | Valor ASCII: 0710 valor hexadecimal: 0x30 0x37 0x31 0x30 |
0710 |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Código de respuesta |
2 | Valor Numérico En caso de rechazo se debe desplegar en el punto de venta: RECHAZO PINPAD - <XX> : <GLOSA> De acuerdo a
|
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Código respuesta Transbank |
3 | Valor Numérico Código de respuesta de TBK. Se debe desplegar en el punto de venta. |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Glosa respuesta Transbank |
48 | Valor alfanumérico (máximo) Glosa que despliega el pinpad una vez finalizada la transacción. Se debe desplegar en el punto de venta. |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Cantidad transacciones venta |
4 | Valor numérico | |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Monto transacciones venta |
18 | Valor numérico | |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Cantidad transacciones anulación |
4 | Valor numérico | |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Monto transacciones anulación |
18 | Valor numérico | |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
<ETX> |
1 | Indica el fin de texto o comando valor hexadecimal: 0x03 |
ETX |
<LRC> |
1 | Byte resultado de la operación XOR del mensaje |
Comandos de Ventas ONUS
0800 – 0810 Solicitud venta ONUS
Solo para retail con tarjetas propias
0900 – 0910 Validación venta ONUS
Solo para retail con tarjetas propias
ADMN - Comandos administrativos
Estos comandos por el momento solo están habilitados para los terminales autoservicio con equipos
Verifone ux300, ux100, ux400.
A continuación se describen los comandos administrativos, los cuales tienen campos mandatorios y otros no:
X = Obligatorio
O = Opcional
Z = en desuso
Eco CAJA - PINPAD
Comando enviado desde la Caja hacia el pinpad para verificar que el pinpad se encuentra conectado y disponible, debe ser enviando en un tiempo configurable en la caja por ejemplo cada 5 minutos. Este comando también sirve para establecer la conexión entre pinpad y caja. El pinpad abre un socket de conexión el cual no se cierra habitualmente, pero ante una nueva solicitud cierra el socket anterior y abre otro.
Requerimiento
| DATO | LARGO | COMENTARIO | REQUERIDO | VALOR POR DEFECTO |
|---|---|---|---|---|
<STX> |
1 | Indica inicio de texto o comando valor hexadecimal: 0x02 |
X | STX |
Comando |
4 | Valor: ADMN |
X | ADMN |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
X | | |
Tipo comando |
2 | Formato numérico 01: eco conexión pinpad 02: reiniciar pinpad 03: actualización de parámetros pinpad |
X | 01 |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
X | | |
Fecha |
8 | Fecha actual configurada en caja (AAAAMMDD) 20171231 | X | |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
X | | |
Hora |
6 | Hora en formato 24hr (HHMMSS) 246060 | X | |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
X | | |
Version de caja |
16 | Identifica la versión del punto de venta del comercio EJ: NEWPOS 123.456 |
X | |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
X | | |
Identificador de caja |
16 | Identifica al punto de venta del comercio EJ: sucursal 123 caja 456 |
X | |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
X | | |
<ETX> |
1 | Indica el fin de texto o comando valor hexadecimal: 0x03 |
X | STX |
<LRC> |
1 | Byte resultado de la operación XOR del mensaje | X | STX |
Respuesta
| DATO | LARGO | COMENTARIO | REQUERIDO | VALOR POR DEFECTO |
|---|---|---|---|---|
<STX> |
1 | Indica inicio de texto o comando valor hexadecimal: 0x02 |
X | STX |
Comando |
4 | Valor: ADMN |
X | ADMN |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
X | | |
Respuesta comando |
2 | Valor Numérico Código de respuesta al comando, de acuerdo a
|
X | |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
X | | |
Identificador PinPad |
20 | Valor alfanumérico Marca modelo pinpad EJ: VERIFONE UX300 |
X | |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
X | | |
Versión PinPad |
20 | Valor alfanumérico Versión de aplicativo cargado en pinpad ej: 15.20A TBK20171231 |
X | |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
X | | |
Número Serie PinPad |
20 | Valor alfanumérico Número de serie del PINPAD EJ: 123-123-123-123 |
X | |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
X | | |
Identificador de caja |
16 | Identifica al punto de venta del comercio EJ: sucursal 123 caja 456 |
X | |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
X | | |
Fecha |
8 | Fecha actual configurada en caja (AAAAMMDD) 20171231 | X | |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
X | | |
Hora |
6 | Hora en formato 24hr (HHMMSS) 246060 | X | |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
X | | |
<ETX> |
1 | Indica el fin de texto o comando valor hexadecimal: 0x03 |
X | STX |
<LRC> |
1 | Byte resultado de la operación XOR del mensaje | X | STX |
Reiniciar Pinpad (Caja - Pinpad)
Comando con el cual la caja solicita al pinpad que se reinicie, pinpad responde ok y reinicia. Este comando puede ser enviado por ejemplo todos los días a las 4:00AM no debe ser enviado al iniciar la caja o punto de venta del comercio ya que en ese instante se debe enviar la actualización de parámetros del pinpad o (cierre batch).
Requerimiento
| DATO | LARGO | COMENTARIO | REQUERIDO | VALOR POR DEFECTO |
|---|---|---|---|---|
<STX> |
1 | Indica inicio de texto o comando valor hexadecimal: 0x02 |
X | STX |
Comando |
4 | Valor: ADMN |
X | ADMN |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
X | | |
Tipo comando |
2 | Formato numérico 01: eco conexión pinpad 02: reiniciar pinpad 03: actualización de parámetros pinpad |
X | 02 |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
X | | |
Fecha |
8 | Fecha actual configurada en caja (AAAAMMDD) 20171231 | X | |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
X | | |
Hora |
6 | Hora en formato 24hr (HHMMSS) 246060 | X | |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
X | | |
<ETX> |
1 | Indica el fin de texto o comando valor hexadecimal: 0x03 |
X | STX |
<LRC> |
1 | Byte resultado de la operación XOR del mensaje | X | STX |
Respuesta
| DATO | LARGO | COMENTARIO | REQUERIDO | VALOR POR DEFECTO |
|---|---|---|---|---|
<STX> |
1 | Indica inicio de texto o comando valor hexadecimal: 0x02 |
X | STX |
Comando |
4 | Valor: ADMN |
X | ADMN |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
X | | |
Respuesta comando |
2 | Valor Numérico Código de respuesta al comando, de acuerdo a
|
X | |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
X | | |
Fecha |
8 | Fecha actual configurada en caja (AAAAMMDD) 20171231 | X | |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
X | | |
Hora |
6 | Hora en formato 24hr (HHMMSS) 246060 | X | |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
X | | |
<ETX> |
1 | Indica el fin de texto o comando valor hexadecimal: 0x03 |
X | STX |
<LRC> |
1 | Byte resultado de la operación XOR del mensaje | X | STX |
Actualización parámetros de Pinpad (Pinpad - Caja)
Comando con el cual el pinpad solicita a la caja gatillar una actualización de parámetros o cierre batch, mediante el flujo habitual (comandos 600-700), caja inicia el flujo estándar 600, 610, 700, 710.
Requerimiento
| DATO | LARGO | COMENTARIO | REQUERIDO | VALOR POR DEFECTO |
|---|---|---|---|---|
<STX> |
1 | Indica inicio de texto o comando valor hexadecimal: 0x02 |
X | STX |
Comando |
4 | Valor: ADMN |
X | ADMN |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
X | | |
Tipo comando |
2 | Formato numérico 01: eco conexión pinpad 02: reiniciar pinpad 03: actualización de parámetros pinpad |
X | 03 |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
X | | |
Fecha |
8 | Fecha actual configurada en caja (AAAAMMDD) 20171231 | X | |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
X | | |
Hora |
6 | Hora en formato 24hr (HHMMSS) 246060 | X | |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
X | | |
<ETX> |
1 | Indica el fin de texto o comando valor hexadecimal: 0x03 |
X | STX |
<LRC> |
1 | Byte resultado de la operación XOR del mensaje | X | STX |
Respuesta
| DATO | LARGO | COMENTARIO | REQUERIDO | VALOR POR DEFECTO |
|---|---|---|---|---|
<STX> |
1 | Indica inicio de texto o comando valor hexadecimal: 0x02 |
X | STX |
Comando |
4 | Valor: ADMN |
X | ADMN |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
X | | |
Respuesta comando |
2 | Valor Numérico Código de respuesta al comando, de acuerdo a
|
X | |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
X | | |
Fecha |
8 | Fecha actual configurada en caja (AAAAMMDD) 20171231 | X | |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
X | | |
Hora |
6 | Hora en formato 24hr (HHMMSS) 246060 | X | |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
X | | |
<ETX> |
1 | Indica el fin de texto o comando valor hexadecimal: 0x03 |
X | STX |
<LRC> |
1 | Byte resultado de la operación XOR del mensaje | X | STX |
1600 – 1610 Comando Lectura de Código de Barras
Importante: Los códigos de barra soportados por el pinpad e355 son: CODE39, CODE128, EAN y UPC. *Solo para el modelo que tiene lector de código de barras Verifone e355.
Comando para iniciar la captura de código de barra desde el Pinpad modelo E355.
Requerimiento
| DATO | LARGO | COMENTARIO | VALOR POR DEFECTO |
|---|---|---|---|
<STX> |
1 | Indica inicio de texto o comando valor hexadecimal: 0x02 |
STX |
Comando |
4 | Valor ASCII: 1600 valor hexadecimal: 0x31 0x36 0x30 0x30 |
1600 |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Timeout Comando |
2 | Valor numérico 01-99 Tiempo en segundos, para mantener la lectura de código de barra en el pinpad. |
20 |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Línea de Display 1 |
21 | Valor alfaumérico Primera línea de mensaje a Desplegar en el Pinpad para indicar el inicio de Lectura de Código de Barra. |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Línea de Display 2 |
21 | Valor alfaumérico Segunda línea de mensaje a Desplegar en el Pinpad para indicar el inicio de Lectura de Código de Barra. |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
<ETX> |
1 | Indica el fin de texto o comando valor hexadecimal: 0x03 |
ETX |
<LRC> |
1 | Byte resultado de la operación XOR del mensaje |
Timeout máximo de espera por comando 1610 es el configurado en la solicitud (1600), si se cumple este tiempo el Pinpad devuelve un 1610|99.
Respuesta
| DATO | LARGO | COMENTARIO | VALOR POR DEFECTO |
|---|---|---|---|
<STX> |
1 | Indica inicio de texto o comando valor hexadecimal: 0x02 |
STX |
Comando |
4 | Valor ASCII: 1610 valor hexadecimal: 0x31 0x36 0x31 0x30 |
1610 |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Código de respuesta |
2 | Valor Numérico En caso de rechazo se debe desplegar en el punto de venta: RECHAZO PINPAD - <XX> : <GLOSA> De acuerdo a
|
00 |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Código de Barra |
150 | 0 Valor alfanumérico largo variable Código de barra capturado por el pinpad |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
<ETX> |
1 | Indica el fin de texto o comando valor hexadecimal: 0x03 |
ETX |
<LRC> |
1 | Byte resultado de la operación XOR del mensaje |
Anexos
Tabla de Marcas
| NOMBRE MARCA DE TARJETA | ABREVIACIÓN DE TARJETA |
|---|---|
| VISA | VI |
| MASTERCARD | MC |
| DINERS | DC |
| AMEX | AX |
| DISCOVER | DS |
| MAGNA | MG |
| PRESTO | TP |
| MAS (cencosud) | TM |
| CMR | TC |
| RIPLEY | TR |
| MAESTRO | MT |
| ELECTRON | EL |
| DEBITO | DB |
| PREPAGO | PP |
Tabla de tipo de tarjeta
| CÓDIGO TIPO DE TARJETA | GLOSA TIPO DE TARJETA |
|---|---|
| CR | CREDITO |
| DB | DEBITO - PREPAGO |
| NB | NO BANCARIA |
| Null (vacío) | Se despliega Menú en PINPAD. |
Tabla de códigos de respuesta de pinpad a los comandos
Estos códigos de respuesta a los comandos enviado al pinpad, solo en caso de rechazo (distinto a 00), se deben desplegar en pantalla del punto de venta del comercio, en caso de problemas ayudan a identificar la causa.
| CÓDIGO DE RESPUESTA | GLOSA |
|---|---|
| 00 | RESPUESTA OK |
| -- | POR DEFINIR (CONSIDERAR COMO SI FUERA 99) |
| 81 | TIMEOUT POR MENOS DE 30 SEGUNDOS* |
| 82 | COMANDO NO VÁLIDO |
| 83 | NO EXISTE CÓDIGO DE MENSAJE |
| 84 | TARJETA NO SOPORTADA |
| 85 | REVERSA APLICADA |
| 86 | ERROR DE LECTURA |
| 87 | PINPAD SIN MASTER KEY |
| 88 | TARJETA NO PERMITE VENTA ONUS |
| 89 | TRANSACCIÓN DECLINADA POR LA TARJETA CHIP |
| 90 | TARJETA NO PERMITIDA PARA EL MODO SELECCIONADO |
| 91 | ERROR CANTIDAD DE CUOTAS |
| 92 | NO COINCIDE CON TARJETA DE PRIMER “TAPEO” |
| 93 | ERROR DE MONTO MÍNIMO |
| 94 | ERROR DE VALIDACIÓN MONTO VUELTO |
| 95 | ERROR ID DE CONTEXTO |
| 96 | NO COINCIDE LOS 4 ULTIMOS DIGITOS |
| 97 | LA TRANSACCIÓN NO PERMITE REVERSA |
| 98 | ERROR DE FORMATO DEL MENSAJE |
| 99 | CANCELACIÓN POR LA TECLA [CANCEL] / TIMEOUT |
*Valido para la versión del aplicativo configurado para Bencineras.
Algunos códigos de respuesta de los autorizadores
Estos son solo algunos de los códigos de respuestas de los autorizadores sean aprobadas o rechazadas, hay muchos más pero estos son los más comunes.
Al recibir respuesta de la transacción sea aprobada o rechazada, se debe desplegar los 3 dígitos y la glosa entregada en la pantalla del punto de venta del comercio, en caso de problemas ayudan a identificar la causa, sin tener que estar buscando log de la caja:
| CÓDIGO DE RESPUESTA | GLOSA |
|---|---|
| 000 - 009 | APROBADO |
| 050 | RECHAZO GENERAL DEL BANCO |
| 056 | PRODUCTO NO SOPORTADO |
| 064 | REINTENTE |
| 066 | PRODUCTO NO SOPORTADO |
| 076 | FONDOS INSUFICIENTES |
| 082 | EXCEDE MAXIMO |
| 083 | EXCEDE MAXIMO |
| 085 | FONDOS INSUFICIENTES |
| 087 | EXCEDE MAXIMO |
| 095 | EXCEDE MAXIMO |
| 105 | PRODUCTO NO SOPORTADO |
| 106 | EXCEDE MAXIMO |
| 107 | EXCEDE MAXIMO |
| 109 | EXCEDE MAXIMO |
| 110 | REINTENTE |
| 112 | EXCEDE MAXIMO |
| 150 | ERROR EN EL CÓDIGO DE COMERCIO O EN LA CAJA O EN EL AMBIENTE TBK |
| 201 | CLAVE INVALIDA |
| 202 | EXCEDE MAXIMO |
| 215 | EXCEDE MAXIMO |
| 217 | REINTENTE |
| 218 | REINTENTE |
| 219 | MENU INVALIDO |
| 251 | PRODUCTO NO SOPORTADO |
| 820 | ERROR EN LA DDLL O EN LA CAJA O EN AMBIENTE TBK |
| 908 | EXCEDE MAXIMO |
| 950 | COMERCIO MAL CONFIGURADO EN TBK |
| 964 | REINTENTE |
| 999 | RECHAZADO |
ANEXO ONUS
Protocolo de mensajería según tipo de comunicación
Protocolo de comunicación serial (Interface RS232)
IDÉNTICO AL ESTÁNDAR
Diagrama genérico de secuencia de comandos
IDÉNTICO AL ESTÁNDAR
Flujo de venta detallado
NO APLICA
Manejo de contexto
![Manejo de contexto](https://www.transbankdevelopers.cl/public/slate-library/images/documentacion/host2host/manejo-de-contexto-onus.png)
Descripción de comandos
En este capítulo se detalla cada comando que se puede enviar al PINPAD.
Para la comunicación serial es necesario indicar los caracteres de inicio y fin que se envían en cada comando, los que serán indicados por medio de la siguiente nomenclatura:
| CARÁCTER DE CONTROL | NOMENCLATURA |
|---|---|
<STX><DATA><ETX><LRC> |
STXETX |
A fin de mantener el mismo lenguaje en comunicación TCP-IP se mantienen estos caracteres STX, ETX y LRC.
Flujo comandos ONUS
![Flujo comandos Onus](https://www.transbankdevelopers.cl/public/slate-library/images/documentacion/host2host/flujo-comandos-onus.png)
La caja del comercio podría usar el comando 800 más de una vez incorporando el indicado de contexto, por ejemplo en la primera solo lee tarjeta, en la segunda solicita confirmar monto, en la tercera solicita pin. Lo ideal es que utilice un solo comando 800 para solicitar todo, leer tarjeta, confirmar monto y pedir pin.
0800 - Comando requerimiento venta/anulación
Con este comando la caja solicita al pinpad leer una tarjeta, confirmar monto y pedir pin. La caja pude hacer una solicitud con todos los requerimientos o varias solicitudes por separado.
Requerimiento
| DATO | LARGO | COMENTARIO | VALOR POR DEFECTO |
|---|---|---|---|
<STX> |
1 | Indica inicio de texto o comando valor hexadecimal: 0x02 |
STX |
Comando |
4 | Valor ASCII: 0800 (Obligatorio) valor hexadecimal: 0x30 0x38 0x30 0x30 |
0800 |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Indicador de contexto comando |
16 | Valor alfanumérico (opcional) Formato aaaammddhhmmssmm Es solo un ID, la fecha y hora en el pinpad puede estar desactualizada Si este comando proviene de otro y es parte de la misa transacción se debe mantener el ID |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Local comercio OnUs |
2 | Valor numérico (obligatorio) (00 -> 99) Cada local onus tiene su ID definido |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Working key track |
32 | Valor alfanumérico (opcional) Contiene la llave 3DES utilizada para encriptar el TRACK (ø: no encripta) |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Working key PIN |
32 | Valor alfanumérico (opcional) Contiene la llave 3DES utilizada para encriptar el TRACK (ø: no encripta) |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Monto |
18 | Valor numérico (obligatorio) (incluye dos decimales) Largo variable |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Lista montos de vuelto |
60 | Valor alfanumérico (opcional) Campo no utilizado por el momento enviar vacío Largo variable |
Ø |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Monto vuelto |
18 | Valor numérico (opcional) |0| Transacción sin vuelto Campo no utilizado por el momento enviar cero Largo variable |
0 |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Flag solicita confirma monto |
1 | Valor alfanumérico (obligatorio) |Y| Solicitar confirmar monto |N| No solicitar confirmar monto |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Glosa 1 confirma monto |
21 | Valor alfanumérico (opcional) Solo si “Solicita confirma monto = Y” Largo variable |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Glosa 2 confirma monto |
21 | Valor alfanumérico (opcional) Solo si “Solicita confirma monto = Y” Largo variable |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Glosa 3 confirma monto |
21 | Valor alfanumérico (opcional) Solo si “Solicita confirma monto = Y” Largo variable |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Glosa 4 confirma monto |
21 | Valor alfanumérico (opcional) Solo si “Solicita confirma monto = Y” Largo variable |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Indicador solicitud de autentificación |
2 | Valor numérico (obligatorio) |00| Pide PIN a todo evento |01| No pide PIN a menos que la tarjeta EMV lo indique |02| Pide PIN según código de servicio |03| Pide PIN según código de servicio, pero acepta pin nulo |04| No pide PIN nunca |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
<ETX> |
1 | Indica el fin de texto o comando valor hexadecimal: 0x03 |
ETX |
<LRC> |
1 | Byte resultado de la operación XOR del mensaje | LRC |
0810 - Comando requerimiento venta/anulación
Con este comando el pinpad entrega a la caja los datos obtenidos en la solicitud del comando 800, como los tracks de la tarjeta (en claro o encriptado), el pin ingresado (que siempre se entrega encriptado) y los datos de EMV que se deben enviar al autorizador ONUS.
Respuesta
| DATO | LARGO | COMENTARIO | VALOR POR DEFECTO |
|---|---|---|---|
<STX> |
1 | Indica inicio de texto o comando valor hexadecimal: 0x02 |
STX |
Comando |
4 | Valor ASCII: 0810 (Obligatorio) valor hexadecimal: 0x30 0x38 0x31 0x30 |
0810 |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Código de respuesta |
2 | Valor numérico De acuerdo a
|
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Indicador de contexto |
16 | Valor alfanumérico Formato aaaammddhhmmssmm Es solo un ID, la fecha y hora en el pinpad puede estar desactualizada |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Tipo de captura |
2 | Valor numérico |00| : B - Banda |01| : E . EMV c/contacto |02| : C - Contacless |03| : F - Fallback |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
TRACK I |
80 | Valor alfanumérico Este campo es opcional, por lo tanto puede contener datos o estar vacío. Si existen datos y es necesario se rellena con blancos (0x20) a la derecha Con pan encriptado se entrega 160 caracteres alfanuméricos que corresponde a 80 HEXA - Si el pinpad no logra leer un track1, este campo irá vacío. - Si el pinpad lee datos erróneos en el track1, este campo irá vacío. - Si se excede el largo máximo, este campo irá vacío. |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
TRACK II |
40 | Valor alfanumérico (máximo) El track2 es un valor requerido para cualquier venta, por lo tanto si no se logra leer o se lee errores, se entrega un error de lectura al comando. Si se obtiene correctamente el dato desde la tarjeta, se rellena con blancos (0x20) a la derecha si es necesario y se entrega. Con pan encriptado se entrega 80 caracteres alfanuméricos que corresponde a 40 HEXA |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
BIN |
6 | Valor numérico Seis primeros dígitos de la tarjeta |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
4 últimos dígitos |
4 | Valor numérico Cuatro últimos dígitos de la tarjeta |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Nombre tarjetahabiente |
26 | Valor alfanumérico Este dato se obtiene desde el track1, por lo tanto si no existe el track1, no se entrega el nombre del tarjetahabiente Largo variable |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Nombre marca de la tarjeta |
20 | Valor alfanumérico De acuerdo a
|
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Abreviación de la tarjeta |
2 | Valor alfanumérico De acuerdo a
|
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Pinblock |
16 | Valor alfanumérico PIN ingresado por el cliente pero encriptado con las llaves proporcionadas por la caja |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Criptograma |
999 | Valor alfanumérico Formato TLV ISO Contiene TAG y criptograma requerido por el emisor para autorizar transacciones realizadas con tecnología y seguridad EMV Largo variable |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
<ETX> |
1 | Indica el fin de texto o comando valor hexadecimal: 0x03 |
ETX |
<LRC> |
1 | Byte resultado de la operación XOR del mensaje | LRC |
0900 - Comando validación de respuesta autorizador
Con este comando la caja entrega al pinpad el resultado de la transacción respondida por el autorizador onus, sea aprobada o rechazada.
Además si la venta se hizo con chip se debe entregar el criptograma generado por el autorizador onus a la tarjeta que aún está insertada, para su evaluación.
A partir de la versión de pinpad 15.2 con este comando el pinpad además de mostrar en pantalla “RETIRE TARJETA” también emite un sonido de alerta.
Requerimiento
| DATO | LARGO | COMENTARIO | VALOR POR DEFECTO |
|---|---|---|---|
<STX> |
1 | Indica inicio de texto o comando valor hexadecimal: 0x02 |
STX |
Comando |
4 | Valor ASCII: 0900 (Obligatorio) valor hexadecimal: 0x30 0x39 0x30 0x30 |
0900 |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Indicador de contexto |
16 | Valor alfanumérico Formato aaaammddhhmmssmm Es solo un ID, la fecha y hora en el pinpad puede estar desactualizada Si este comando proviene de otro y es parte de la misa transacción se debe mantener el ID |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Flag valida criptograma |
1 | Valor alfanumérico |Y| Validar criptograma |N| No validar criptograma Solo aplica para transacciones con chip con contacto |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Glosa respuesta |
21 | Valor alfanumérico (máximo) Sólo si “Flag valida criptograma = N” Ejemplo: Aprobado / Rechazado / Reintente |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Criptograma |
999 | Valor alfanumérico Formato TLV ISO Formato TLV ISO Sólo si “Flag valida criptograma = Y” Este criptograma el pinpad entrega al chip de la tarjeta para validación. Podría resultar en una transacción declinada por la tarjeta para lo cual la caja debe solicitar reversa al autorizador ONUS |
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
<ETX> |
1 | Indica el fin de texto o comando valor hexadecimal: 0x03 |
ETX |
<LRC> |
1 | Byte resultado de la operación XOR del mensaje | LRC |
0910 - Comando validación de respuesta autorizador
Primero que nada este comando es la respuesta ok (o nook) al requerimiento del comando 900. El objetivo principal de este comando es que el Pinpad entregue el resultado de la evaluación del criptograma enviado por el autorizador, el resultado puede ser Aprobado o Declinado por la tarjeta, para que el caso de declinación, la caja reverse la venta aprobada.
Respuesta
| DATO | LARGO | COMENTARIO | VALOR POR DEFECTO |
|---|---|---|---|
<STX> |
1 | Indica inicio de texto o comando valor hexadecimal: 0x02 |
STX |
Comando |
4 | Valor ASCII: 0910 (Obligatorio) valor hexadecimal: 0x30 0x39 0x31 0x30 |
0910 |
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Código de respuesta |
2 | Valor numérico De acuerdo a
|
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
Glosa respuesta |
21 | Valor alfanumérico De acuerdo a
|
|
Separador |
1 | valor ASCII: | valor hexadecimal: 0x7c |
| |
<ETX> |
1 | Indica el fin de texto o comando valor hexadecimal: 0x03 |
ETX |
<LRC> |
1 | Byte resultado de la operación XOR del mensaje | LRC |
Anexos
Tabla de marcas
IDÉNTICO AL ESTÁNDAR
Tabla de tipo de tarjeta
IDÉNTICO AL ESTÁNDAR
Tabla de códigos de respuesta de comandos ONUS
Se detalla los códigos de respuesta adicionales para la modalidad OnUs
| CÓDIGO DE RESPUESTA | GLOSA |
|---|---|
| 00 | RESPUESTA OK |
| -- | Por definir (considerar como si fuera 99) |
| 83 | NO EXISTE CODIGO DE MENSAJE |
| 84 | TARJETA NO SOPORTADA |
| 85 | REVERSA APLICADA |
| 86 | ERROR DE LECTURA |
| 87 | PINPAD SIN MASTER KEY |
| 88 | TARJETA NO PERMITE VENTA ONUS |
| 89 | TRANSACCIÓN DECLINADA POR LA TARJETA CHIP |
| 90 | TARJETA NO PERMITIDA PARA EL MODO SELECCIONADO |
| 91 | ERROR CANTIDAD DE CUOTAS |
| 92 | NO COINCIDE CON TARJETA DE PRIMER “TAPEO” |
| 93 | ERROR DE MONTO MÍNIMO |
| 94 | ERROR DE VALIDACIÓN MONTO VUELTO |
| 95 | ERROR ID DE CONTEXTO |
| 96 | NO COINCIDE LOS 4 ULTIMOS DIGITOS |
| 97 | LA TRANSACCIÓN NO PERMITE REVERSA |
| 98 | ERROR DE FORMATO DEL MENSAJE |
| 99 | CANCELACIÓN POR LA TECLA [CANCEL] o TIMEOUT |
Código de local ONUS
Para soportar la utilización de transacciones no financieras que necesitan la lectura de tarjeta sin tener aún el monto1 se define un desplazamiento de 50 al código de local asociado al comercio OnUs, por ejemplo:
01 -> 51
| CÓDIGO DE LOCAL ONUS | CODIGO LOCAL ONUS TRANSACIONES NO FINANCIERAS |
|---|---|
| NN | 50+NN |

# referencia_oneclick.md

Source: https://www.transbankdevelopers.cl/referencia/oneclick

Oneclick
Ambientes y Credenciales
La API REST de Webpay está protegida para garantizar que solamente comercios autorizados por Transbank hagan uso de las operaciones disponibles. La seguridad esta implementada mediante los siguientes mecanismos:
- Canal seguro a través de TLSv1.2 para la comunicación del cliente con Webpay.
- Autenticación y autorización mediante el intercambio de headers
Tbk-Api-Key-Id
(código de comercio) yTbk-Api-Key-Secret
(llave secreta).
Ambiente de Producción
Las URLs de endpoints de producción están alojados dentro de
[https://webpay3g.transbank.cl/](https://webpay3g.transbank.cl/).
// Host: https://webpay3g.transbank.cl
// Host: https://webpay3g.transbank.cl
// Host: https://webpay3g.transbank.cl
# Host: https://webpay3g.transbank.cl
# Host: https://webpay3g.transbank.cl
Host: https://webpay3g.transbank.cl
Ambiente de Integración
Las URLs de endpoints de integración están alojados dentro de
[https://webpay3gint.transbank.cl/](https://webpay3gint.transbank.cl/).
// Host: https://webpay3gint.transbank.cl
// Host: https://webpay3gint.transbank.cl
// Host: https://webpay3gint.transbank.cl
# Host: https://webpay3gint.transbank.cl
# Host: https://webpay3g.transbank.cl
Host: https://webpay3gint.transbank.cl
Tarjetas y usuarios de prueba
Consulta [la documentación para conocer las tarjetas de prueba que funcionan en
el ambiente de integración](https://www.transbankdevelopers.cl/documentacion/como_empezar#ambientes).
Credenciales del comercio
// Tbk-Api-Key-Id: Código de comercio
// Tbk-Api-Key-Secret: Llave secreta
// Content-Type: application/json
// Tbk-Api-Key-Id: Código de comercio
// Tbk-Api-Key-Secret: Llave secreta
// Content-Type: application/json
# Tbk-Api-Key-Id: Código de comercio
# Tbk-Api-Key-Secret: Llave secreta
# Content-Type: application/json
# Tbk-Api-Key-Id: Código de comercio
# Tbk-Api-Key-Secret: Llave secreta
# Content-Type: application/json
Tbk-Api-Key-Id: Código de comercio
Tbk-Api-Key-Secret: Llave secreta
Content-Type: application/json
Todas las peticiones que hagas deben incluir el código de comercio y la llave secreta entregada por Transbank, actuando ambas como las credenciales que autorizan distintas operaciones.
Códigos de comercio
En la documentación puedes revisar [todos los códigos de comercio](https://www.transbankdevelopers.cl/documentacion/como_empezar#codigos-de-comercio) del ambiente de integración
Los SDKs ya incluyen esos códigos de comercio y llaves secretas que funcionan en el ambiente de integración, por lo que puedes obtener rápidamente una configuración lista para hacer tus primeras pruebas en dicho ambiente:
Oneclick Mall
Revisa la [documentación de Oneclick Mall](https://www.transbankdevelopers.cl/documentacion/oneclick) para tener más información sobre como funciona
el producto y tener más detalles sobre como realizar tu integración.
Crear una inscripción
Puedes revisar más detalles de esta operación en [su documentación](https://www.transbankdevelopers.cl/documentacion/oneclick#crear-una-inscripcion)
Permite comenzar con el proceso de inscripción.
Oneclick.MallInscription mallInscription = Oneclick.MallInscription.buildForIntegration("commerceCode", "APIKey");
final OneclickMallInscriptionStartResponse response = mallInscription.start(username, email, response_url);
$mallInscription = MallInscription::buildForIntegration($apiKey, $commerceCode);
$response = $mallInscription->start($username, $email, $response_url);
MallInscription mallInscription = MallInscription.buildForIntegration("commerceCode", "APIKey");
var response = mallInscription.Start(userName, email, returnUrl);
@mall_inscription = Transbank::Webpay::Oneclick::MallInscription.build_for_integration("commerceCode", "APIKey");
@resp = @mall_inscription.start(username: @username, email: @email, response_url: @response_url);
inscription = MallInscription.build_for_integration("commerceCode", "APIKey")
resp = inscription.start(username=user_name, email=email, response_url=response_url)
const inscription = Oneclick.MallInscription.buildForIntegration(
"commerceCode",
"APIKey"
);
const response = await inscription.start(username, email, responseUrl);
POST /rswebpaytransaction/api/oneclick/v1.2/inscriptions
Tbk-Api-Key-Id: 597055555541
Tbk-Api-Key-Secret: 579B532A7440BB0C9079DED94D31EA1615BACEB56610332264630D42D0A36B1C
Content-Type: application/json
{
"username": "juanperez",
"email": "juan.perez@gmail.com",
"response_url": "http://www.comercio.cl/return_inscription"
}
Parámetros Crear una inscripción
| Nombre tipo |
Descripción |
|---|---|
| username String |
Identificador del usuario registrado en el comercio. Largo máximo: 40. |
| email String |
Email del usuario registrado en el comercio. Largo máximo: 100. |
| response_url String |
URL del comercio a la cual Webpay redireccionará posterior al proceso de inscripción. Largo máximo: 255. |
Respuesta Crear una inscripción
response.getToken();
response.getUrlWebpay();
$response->getToken();
$response->getUrlWebpay();
response.Token;
response.UrlWebpay
response.token
response.url_webpay
## Versión 3.x del SDK
response['token']
response['url_webpay']
## Versión 2.x del SDK
response.token
response.url_webpay
response.token
response.url_webpay
200 OK
Content-Type: application/json
{
"token": "e128a9c24c0a3cbc09223973327b97c8c474f6b74be509196cce4caf162a016a",
"url_webpay": "https://webpay3g.transbank.cl/webpayserver/bp_inscription.cgi"
}
| Nombre tipo |
Descripción |
|---|---|
| token String |
Identificador, único, del proceso de inscripción. Largo: 64. |
| url_webpay String |
URL de Webpay para iniciar la inscripción. Largo: 255. |
Confirmar una inscripción
Permite finalizar el proceso de inscripción obteniendo el usuario tbk.
Más información en [la documentación](https://www.transbankdevelopers.cl/documentacion/oneclick).
Oneclick.MallInscription mallInscription = Oneclick.MallInscription.buildForIntegration("commerceCode", "APIKey");
final OneclickMallInscriptionFinishResponse response = mallInscription.finish(tbk_token);
$mallInscription = MallInscription::buildForIntegration($apiKey, $commerceCode);
$response = $mallInscription->finish($tbk_token);
MallInscription mallInscription = MallInscription.buildForIntegration("commerceCode", "APIKey");
var response = mallInscription.Finish(tbk_token);
@mall_inscription = Transbank::Webpay::Oneclick::MallInscription.build_for_integration("commerceCode", "APIKey");
@resp = @mall_inscription.finish(token: @tbk_token);
inscription = MallInscription.build_for_integration("commerceCode", "APIKey")
resp = inscription.finish(token=tbk_token)
const inscription = Oneclick.MallInscription.buildForIntegration(
"commerceCode",
"APIKey"
);
const response = await inscription.finish(token);
PUT /rswebpaytransaction/api/oneclick/v1.2/inscriptions/{token}
Tbk-Api-Key-Id: 597055555541
Tbk-Api-Key-Secret: 579B532A7440BB0C9079DED94D31EA1615BACEB56610332264630D42D0A36B1C
Content-Type: application/json
{
}
Parámetros Confirmar una inscripción
| Nombre tipo |
Descripción |
|---|---|
| token String |
Identificador del proceso de inscripción. Es entregado por Webpay en la respuesta del método Inscription.start() . (See envía en la URL, no en el body) |
Respuesta Confirmar una inscripción
response.getAuthorizationCode();
response.getCardType();
response.getCardNumber();
response.getResponseCode();
response.getTbkUser();
$response->getAuthorizationCode();
$response->getCardType();
$response->getCardNumber();
$response->getResponseCode();
$response->getTbkUser();
response.ResponseCode;
response.TransbankUser;
response.AuthorizationCode;
response.CardType;
response.CardNumber;
response.response_code
response.transbank_user
response.authorization_code
response.card_type
response.card_number
## Versión 3.x del SDK
response['response_code']
response['transbank_user']
response['authorization_code']
response['card_type']
response['card_number']
## Versión 2.x del SDK
response.response_code
response.transbank_user
response.authorization_code
response.card_type
response.card_number
response.response_code
response.transbank_user
response.authorization_code
response.card_type
response.card_number
200 OK
Content-Type: application/json
{
"response_code": 0,
"tbk_user": "b6bd6ba3-e718-4107-9386-d2b099a8dd42",
"authorization_code": "123456",
"card_type": "Visa",
"card_number": "XXXXXXXXXXXX6623"
}
| Nombre tipo |
Descripción |
|---|---|
| response_code Number |
Código de respuesta de la autorización. Largo: 2. Valores posibles: 0 = Transacción aprobada Puedes revisar los códigos de respuesta de rechazo en el siguiente
|
| tbk_user String |
Identificador único de la inscripción del cliente en Oneclick, que debe ser usado para realizar pagos o borrar la inscripción. Largo: 40. |
| authorization_code String |
Código que identifica la autorización de la inscripción. Largo: 6. |
| card_type cardType |
Indica el tipo de tarjeta inscrita por el cliente (Visa, AmericanExpress, MasterCard, Diners, Magna, Redcompra, Prepago). Largo: 15. |
| card_number String |
Últimos 4 dígitos de la tarjeta inscrito. |
Eliminar una inscripción
Puedes revisar más detalles de esta operación en [su documentación](https://www.transbankdevelopers.cl/documentacion/oneclick#eliminar-una-inscripcion)
Una vez finalizado el proceso de inscripción es posible eliminarla de ser necesario. Para esto debes usar el método llamado Inscription.remove()
.
Inscription.remove()
Permite eliminar un usuario enrolado a Oneclick Mall.
Oneclick.MallInscription mallInscription = Oneclick.MallInscription.buildForIntegration("commerceCode", "APIKey");
mallInscription.delete(tbkUser, username);
$mallInscription = MallInscription::buildForIntegration($apiKey, $commerceCode);
$response = $mallInscription->delete($tbkUser, $username);
MallInscription mallInscription = MallInscription.buildForIntegration("commerceCode", "APIKey");
var response = mallInscription.Delete(tbkUser, username);
@mall_inscription = Transbank::Webpay::Oneclick::MallInscription.build_for_integration("commerceCode", "APIKey");
@mall_inscription.delete(tbk_user: @tbkUser, username: @username);
inscription = MallInscription.build_for_integration("commerceCode", "APIKey")
inscription.delete(tbk_user=tbkUser, username=username)
const inscription = Oneclick.MallInscription.buildForIntegration( "commerceCode", "APIKey" ); const response = await inscription.delete(tbkUser, username);
DELETE /rswebpaytransaction/api/oneclick/v1.2/inscriptions
Tbk-Api-Key-Id: 597055555541
Tbk-Api-Key-Secret: 579B532A7440BB0C9079DED94D31EA1615BACEB56610332264630D42D0A36B1C
Content-Type: application/json
{
"tbk_user": "b6bd6ba3-e718-4107-9386-d2b099a8dd42",
"username": "juanperez",
}
Parámetros Eliminar una inscripción
| Nombre tipo |
Descripción |
|---|---|
| tbk_user String |
Identificador único de la inscripción del cliente (devuelto por Inscription.finish() ). Largo: 40. |
| username String |
Identificador del usuario en los sistemas del comercio (el mismo indicado en Inscription.start() ). Largo máximo: 40. |
Respuesta Eliminar una inscripción
Esta petición no posee cuerpo de respuesta, solo entrega un 204 cuando se realiza correctamente
// 204 OK
// 204 OK
// 204 OK
# 204 OK
# 204 OK
// 204 OK
204 OK
Content-Type: application/json
Autorizar una transacción
Puedes revisar más detalles de esta operación en [su documentación](https://www.transbankdevelopers.cl/documentacion/oneclick#autorizar-una-transaccion)
Una vez realizada la inscripción, el comercio puede usar el tbkUser
recibido
para realizar transacciones. Para eso debes usar el método Transaction.authorize()
.
Transaction.authorize()
Permite autorizar un pago.
Oneclick.MallTransaction mallTransaction = Oneclick.MallTransaction.buildForIntegration("commerceCode", "APIKey");
double amountOne = 10000;
String commerceCodeStoreOne = "597055555542";
String buyOrderMallOne = String.valueOf(new Random().nextInt(Integer.MAX_VALUE));
byte installmentNumberOne = 3;
double amountTwo = 50000;
String commerceCodeStoreTwo = "597055555543";
String buyOrderMallTwo = String.valueOf(new Random().nextInt(Integer.MAX_VALUE));
byte installmentNumberTwo = 3;
MallTransactionCreateDetails details = MallTransactionCreateDetails.build()
.add(amountOne, commerceCodeStoreOne, buyOrderMallOne, installmentNumberOne)
.add(amountTwo, commerceCodeStoreTwo, buyOrderMallTwo, installmentNumberTwo);
final OneclickMallTransactionAuthorizeResponse response = mallTransaction.authorize(username, tbkUser, buyOrder, details);
$mallTransaction = MallTransaction::buildForIntegration($apiKey, $commerceCode);
$parentBuyOrder = rand(100000, 999999999);
$details = [
[
"commerce_code" => "commerceCodeStoreOne",
"buy_order" => rand(100000, 999999999), // Tu propio buyOrder
"amount" => 50000,
"installments_number" => 1
],
[
"commerce_code" => "commerceCodeStoreTwo",
"buy_order" => rand(100000, 999999999), // Tu propio buyOrder
"amount" => 20000,
"installments_number" => 1
]
];
$response = $mallTransaction->authorize($username, $tbkUser, $parentBuyOrder, $details);
MallTransaction mallTransaction = MallTransaction.buildForIntegration("commerceCode", "APIKey");
var commerceCodeStoreOne = "597055555542";
var installmentsNumber = 1;
List details = new List();
details.Add(new PaymentRequest(commerceCodeStoreOne, childBuyOrder, amount, installmentsNumber));
var result = mallTransaction.Authorize(userName, tbkUser, buyOrder, details);
@mall_transaction = Transbank::Webpay::Oneclick::MallTransaction.build_for_integration("commerceCode", "APIKey");
@details =
[{
commerce_code: "commerce_store_1",
buy_order: "abcdef" + Time.now.to_i.to_s,
amount: 10000,
installments_number: 3
},
{
commerce_code: "commerce_store_2",
buy_order: "abcdef" + Time.now.to_i.to_s,
amount: 50000,
installments_number: 3
}];
end
@resp = @mall_transaction.authorize(username: @username, tbk_user: @tbkUser, parent_buy_order: @buy_order, details: @details);
transaction = MallTransaction.build_for_integration("commerceCode", "APIKey")
commerce_store_1 = "597055555542"
buy_order_child1 = str(random.randrange(1000000, 99999999))
installments_number1 = 3
amount1 = 10000
commerce_store_1 = "597055555543"
buy_order_child2 = str(random.randrange(1000000, 99999999))
installments_number2 = 4
amount2 = 50000
details = MallTransactionAuthorizeDetails(commerce_store_1, buy_order_child1, installments_number1, amount1).add(commerce_store_2, buy_order_child2, installments_number2, amount2)
resp = transaction.authorize(username= username, tbk_user= tbkUser, parent_buy_order= buy_order, details= details)
const transaction = Oneclick.MallTransaction.buildForIntegration( "commerceCode", "APIKey" ); const details = [ new TransactionDetail(amount, commerceCodeStoreOne, childBuyOrder), new TransactionDetail(amount2, commerceCodeStoreTwo, childBuyOrder2), ]; const response = await transaction.authorize( userName, tbkUser, buyOrder, details );
POST /rswebpaytransaction/api/oneclick/v1.2/transactions
Tbk-Api-Key-Id: 597055555541
Tbk-Api-Key-Secret: 579B532A7440BB0C9079DED94D31EA1615BACEB56610332264630D42D0A36B1C
Content-Type: application/json
{
"username": "juanperez",
"tbk_user": "b6bd6ba3-e718-4107-9386-d2b099a8dd42",
"buy_order": "ordenCompra123456789",
"details": [
{
"commerce_code": "597055555542",
"buy_order": "ordenCompra123445",
"amount": 1000,
"installments_number": 5
}]
}
Parámetros Autorizar un pago
| Nombre tipo |
Descripción |
|---|---|
| username String |
Identificador del usuario en los sistemas del comercio (el mismo indicado en Inscription.start() ). Largo máximo: 40. |
| tbk_user String |
Identificador único de la inscripción del cliente (devuelto por Inscription.finish() ). Largo: 40. |
| buy_order Number |
Es el código único de la orden de compra generada por el comercio mall. Este número debe ser único para cada transacción. Largo máximo: 26. La orden de compra puede tener: Números, letras, mayúsculas y minúsculas, y los signos |_=&%.,~:/?[+!@()>- . Los caracteres con signos no están soportados, como los acentos o signos no especificados. |
| details Array |
Lista de objetos, uno por cada tienda diferente del mall que participa en la transacción. |
| details [].commerce_code String |
Código comercio asignado por Transbank para la tienda perteneciente al mall a la cual corresponde esta transacción. Largo: 12. |
| details [].buy_order String |
Orden de compra de la tienda del mall. Este número debe ser único para cada transacción. Largo máximo: 26. La orden de compra puede tener: Números, letras, mayúsculas y minúsculas, y los signos |_=&%.,~:/?[+!@()>- . Los caracteres con signos no están soportados, como los acentos o signos no especificados. |
| details [].amount Decimal |
Monto de la transacción de pago. Largo máximo: 17. |
| details [].installments_number Number |
Cantidad de cuotas de la transacción de pago. Largo 2. No obligatorio. |
Respuesta Autorizar un pago
response.getAccountingDate();
response.getBuyOrder();
response.getTransactionDate();
final CardDetail cardDetail = response.getCardDetail();
cardDetail.getCardNumber();
final List<Detail> detailsResp = response.getDetails();
for (Detail detail : detailsResp) {
detail.getAmount();
detail.getAuthorizationCode();
detail.getBuyOrder();
detail.getCommerceCode();
detail.getInstallmentsNumber();
detail.getPaymentTypeCode();
detail.getStatus();
}
print_r($response);
$response->getAccountingDate();
$response->getBuyOrder();
$response->getTransactionDate();
$details = $response->getDetails();
foreach($details as $detail){
$detail->getAmount();
$detail->getAuthorizationCode();
$detail->getBuyOrder();
$detail->getCommerceCode();
$detail->getInstallmentsNumber();
$detail->getPaymentTypeCode();
$detail->getResponseCode();
$detail->getStatus();
}
// Transbank\Webpay\Oneclick\Responses\MallTransactionAuthorizeResponse Object
// (
// [buyOrder] => 433025339
// [sessionId] =>
// [cardNumber] => 6623
// [expirationDate] =>
// [accountingDate] => 0413
// [transactionDate] => 2021-04-13T22:59:53.767Z
// [details] => Array
// (
// [0] => Transbank\Webpay\Oneclick\Responses\TransactionDetail Object
// (
// [amount] => 50000
// [status] => AUTHORIZED
// [authorizationCode] => 1213
// [paymentTypeCode] => VN
// [responseCode] => 0
// [installmentsNumber] => 0
// [installmentsAmount] =>
// [commerceCode] => 597055555542
// [buyOrder] => 523485045
// )
// [1] => Transbank\Webpay\Oneclick\Responses\TransactionDetail Object
// (
// [amount] => 20000
// [status] => AUTHORIZED
// [authorizationCode] => 1213
// [paymentTypeCode] => VN
// [responseCode] => 0
// [installmentsNumber] => 0
// [installmentsAmount] =>
// [commerceCode] => 597055555543
// [buyOrder] => 224502696
// )
// )
// )
response.AccountingDate;
response.BuyOrder;
var cardDetail = response.CardDetail;
cardDetail.CardNumber;
response.TransactionDate;
var details = response.Details;
foreach (var detail in details) {
detail.Amount;
detail.AuthorizationCode;
detail.BuyOrder;
detail.CommerceCode;
detail.InstallmentsNumber;
detail.PaymentTypeCode;
detail.ResponseCode;
detail.Status;
}
response.accounting_date
response.buy_order
card_detail = response.card_detail
card_detail.card_number
response.transaction_date
details = response.details
details.each do |detail|
detail.amount
detail.authorization_code
detail.buy_order
detail.commerce_code
detail.installments_number
detail.payment_type_code
detail.response_code
detail.status
end
## Versión 3.x del SDK
response['accounting_date']
response['buy_order']
response['card_detail']
response['transaction_date']
response['details']
## Versión 2.x del SDK
response.accounting_date
response.buy_order
card_detail = response.card_detail
card_detail.card_number
response.transaction_date
details = response.details
for detail in details:
detail.amount
detail.authorization_code
detail.buy_order
detail.commerce_code
detail.installments_number
detail.payment_type_code
detail.response_code
detail.status
response.accounting_date
response.buy_order
cardDetail = response.card_detail
cardDetail.card_number
response.transaction_date
details = response.details
for(let detail of details) {
detail.amount
detail.authorization_code
detail.buy_order
detail.commerce_code
detail.installments_number
detail.payment_type_code
detail.response_code
detail.status
}
200 OK
Content-Type: application/json
{
"buy_order": "415034240",
"card_detail": {
"card_number": "6623"
},
"accounting_date": "0321",
"transaction_date": "2019-03-21T15:43:48.523Z",
"details": [
{
"amount": 500,
"status": "AUTHORIZED",
"authorization_code": "1213",
"payment_type_code": "VN",
"response_code": 0,
"installments_number": 0,
"commerce_code": "597055555542",
"buy_order": "505479072"
}]
}
| Nombre tipo |
Descripción |
|---|---|
| buy_order String |
Orden de compra de la tienda del mall. Este número debe ser único para cada transacción. Largo máximo: 26. La orden de compra puede tener: Números, letras, mayúsculas y minúsculas, y los signos |_=&%.,~:/?[+!@()>- . Los caracteres con signos no están soportados, como los acentos o signos no especificados. |
| card_detail cardDetail |
Objeto que contiene información de la tarjeta utilizado por el tarjetahabiente. |
| card_detail.card_number String |
Los últimos 4 dígitos de la tarjeta usada en la transacción. |
| accounting_date String |
Fecha contable de la autorización del pago. |
| transaction_date DateTime |
Fecha completa (timestamp) de la autorización del pago. ISO 8601 |
| details Array |
Lista con el resultado de cada transacción de las tiendas hijas. |
| details [].amount Decimal |
Monto de la transacción de pago. |
| details [].status String |
Estado de la transacción (INITIALIZED, AUTHORIZED, REVERSED, FAILED, NULLIFIED, PARTIALLY_NULLIFIED, CAPTURED). |
| details [].authorization_code String |
Código de autorización de la transacción de pago. |
| details [].payment_type_code String |
VD = Venta Débito. VP = Venta prepago VN = Venta Normal. VC = Venta en cuotas. SI = 3 cuotas sin interés. S2 = 2 cuotas sin interés. NC = N Cuotas sin interés |
Number
0 = Transacción aprobada
Puedes revisar los códigos de respuesta de rechazo en el siguiente
[link](https://www.transbankdevelopers.cl/producto/webpay#codigos-de-respuesta-de-autorizacion)Algunos códigos específicos para Oneclick son:
-96:
tbk_user
no existente -97: Límites Oneclick, máximo monto diario de pago excedido.
-98: Límites Oneclick, máximo monto de pago excedido
-99: Límites Oneclick, máxima cantidad de pagos diarios excedido.
Number
Number
String
Obtener estado de una transacción
Permite consultar el estado de pago realizado a través de Oneclick. Retorna el resultado de la autorización.
Puedes revisar más detalles de esta operación en [su documentación](https://www.transbankdevelopers.cl/documentacion/oneclick#obtener-estado-de-una-transaccion)
MallTransaction mallTransaction = MallTransaction.buildForIntegration("commerceCode", "APIKey");
final OneclickMallTransactionStatusResponse response = mallTransaction.status(buyOrder);
$mallTransaction = MallTransaction::buildForIntegration($apiKey, $commerceCode); $response = $mallTransaction->status($buyOrder);
MallTransaction mallTransaction = MallTransaction.buildForIntegration("commerceCode", "APIKey");
var result = mallTransaction.Status(buyOrder);
@mall_transaction = Transbank::Webpay::Oneclick::MallTransaction.build_for_integration("commerceCode", "APIKey");
@resp = @mall_transaction.status(buy_order: @buy_order);
transaction = MallTransaction.build_for_integration("commerceCode", "APIKey")
resp = transaction.status(buy_order)
const transaction = Oneclick.MallTransaction.buildForIntegration(
"commerceCode",
"APIKey"
);
const response = await transaction.status(token);
GET /rswebpaytransaction/api/oneclick/v1.2/transactions/{buyOrder}
Tbk-Api-Key-Id: 597055555541
Tbk-Api-Key-Secret: 579B532A7440BB0C9079DED94D31EA1615BACEB56610332264630D42D0A36B1C
Content-Type: application/json
Parámetros Consultar un pago realizado
| Nombre tipo |
Descripción |
|---|---|
| buy_order String |
Orden de compra de la transacción a consultar (se envía en la URL, no en el body). |
Respuesta Consultar un pago realizado
response.getAccountingDate();
response.getBuyOrder();
response.getTransactionDate();
final CardDetail cardDetail = response.getCardDetail();
cardDetail.getCardNumber();
final List<Detail> detailsResp = response.getDetails();
for (Detail detail : detailsResp) {
detail.getAmount();
detail.getAuthorizationCode();
detail.getBuyOrder();
detail.getCommerceCode();
detail.getInstallmentsNumber();
detail.getPaymentTypeCode();
detail.getStatus();
}
print_r($response);
$response->getAccountingDate();
$response->getBuyOrder();
$response->getTransactionDate();
$details = $response->getDetails();
foreach($details as $detail){
$detail->getAmount();
$detail->getAuthorizationCode();
$detail->getBuyOrder();
$detail->getCommerceCode();
$detail->getInstallmentsNumber();
$detail->getPaymentTypeCode();
$detail->getResponseCode();
$detail->getStatus();
}
// Transbank\Webpay\Oneclick\Responses\MallTransactionAuthorizeResponse Object
// (
// [buyOrder] => 433025339
// [sessionId] =>
// [cardNumber] => 6623
// [expirationDate] =>
// [accountingDate] => 0413
// [transactionDate] => 2021-04-13T22:59:53.767Z
// [details] => Array
// (
// [0] => Transbank\Webpay\Oneclick\Responses\TransactionDetail Object
// (
// [amount] => 50000
// [status] => AUTHORIZED
// [authorizationCode] => 1213
// [paymentTypeCode] => VN
// [responseCode] => 0
// [installmentsNumber] => 0
// [installmentsAmount] =>
// [commerceCode] => 597055555542
// [buyOrder] => 523485045
// )
// [1] => Transbank\Webpay\Oneclick\Responses\TransactionDetail Object
// (
// [amount] => 20000
// [status] => AUTHORIZED
// [authorizationCode] => 1213
// [paymentTypeCode] => VN
// [responseCode] => 0
// [installmentsNumber] => 0
// [installmentsAmount] =>
// [commerceCode] => 597055555543
// [buyOrder] => 224502696
// )
// )
// )
response.AccountingDate;
response.BuyOrder;
var cardDetail = response.CardDetail;
cardDetail.CardNumber;
response.SessionId;
response.TransactionDate;
response.Vci;
var details = response.Details;
foreach (var detail in details) {
detail.Amount;
detail.AuthorizationCode;
detail.BuyOrder;
detail.CommerceCode;
detail.InstallmentsNumber;
detail.PaymentTypeCode;
detail.ResponseCode;
detail.Status;
}
response.accounting_date
response.buy_order
card_detail = response.card_detail
card_detail.card_number
response.session_id
response.transaction_date
response.vci
details = response.details
details.each do |detail|
detail.amount
detail.authorization_code
detail.buy_order
detail.commerce_code
detail.installments_number
detail.payment_type_code
detail.response_code
detail.status
end
## Versión 3.x del SDK
response['accounting_date']
response['buy_order']
response['card_detail']
response['session_id']
response['transaction_date']
response['vci']
response['details']
## Versión 2.x del SDK
response.accounting_date
response.buy_order
card_detail = response.card_detail
card_detail.card_number
response.session_id
response.transaction_date
response.vci
details = response.details
for detail in details:
detail.amount
detail.authorization_code
detail.buy_order
detail.commerce_code
detail.installments_number
detail.payment_type_code
detail.response_code
detail.status
response.accounting_date
response.buy_order
cardDetail = response.card_detail
cardDetail.card_number
response.session_id
response.transaction_date
response.vci
details = response.details
for(detail on details) {
detail.amount
detail.authorization_code
detail.buy_order
detail.commerce_code
detail.installments_number
detail.payment_type_code
detail.response_code
detail.status
}
200 OK
Content-Type: application/json
{
"buy_order": "415034240",
"card_detail": {
"card_number": "6623"
},
"accounting_date": "0321",
"transaction_date": "2019-03-21T15:43:48.523Z",
"details": [
{
"amount": 500,
"status": "AUTHORIZED",
"authorization_code": "1213",
"payment_type_code": "VN",
"response_code": 0,
"installments_number": 0,
"commerce_code": "597055555542",
"buy_order": "505479072"
}]
}
| Nombre tipo |
Descripción |
|---|---|
| buy_order String |
Orden de compra generada por el comercio padre. |
| card_detail cardDetail |
Objeto que contiene información de la tarjeta utilizado por el tarjetahabiente. |
| card_detail.card_number String |
Los últimos 4 dígitos de la tarjeta usada en la transacción. |
| accounting_date String |
Fecha contable de la autorización del pago. |
| transaction_date DateTime |
Fecha completa (timestamp) de la autorización del pago. Largo: 24, formato: ISO 8601 (Ej: yyyy-mm-ddTHH:mm:ss.xxxZ) |
| details Array |
Lista con el resultado de cada transacción de las tiendas hijas. |
| details [].amount Decimal |
Monto de la sub-transacción de pago. |
| details [].status String |
Estado de la transacción (INITIALIZED, AUTHORIZED, REVERSED, FAILED, NULLIFIED, PARTIALLY_NULLIFIED, CAPTURED). |
| details [].authorization_code String |
Código de autorización de la sub-transacción de pago. |
| details [].payment_type_code String |
VD = Venta Débito. VP = Venta prepago VN = Venta Normal. VC = Venta en cuotas. SI = 3 cuotas sin interés. S2 = 2 cuotas sin interés. NC = N Cuotas sin interés |
Number
0 (cero) es aprobado. Valores posibles:
0 = Transacción aprobada
Puedes revisar los códigos de respuesta de rechazo en el siguiente
[link](https://www.transbankdevelopers.cl/producto/webpay#codigos-de-respuesta-de-autorizacion)Algunos códigos específicos para Oneclick son:
-96:
tbk_user
no existente -97: Límites Oneclick, máximo monto diario de pago excedido.
-98: Límites Oneclick, máximo monto de pago excedido
-99: Límites Oneclick, máxima cantidad de pagos diarios excedido.
Number
Number
String
Decimal
Reversar o anular una transacción
Puedes revisar más detalles de esta operación en [su documentación](https://www.transbankdevelopers.cl/documentacion/oneclick#reversar-o-anular-una-transaccion)
MallTransaction mallTransaction = MallTransaction.buildForIntegration("commerceCode", "APIKey");
final OneclickMallTransactionRefundResponse response = mallTransaction.refund(buyOrder, commerceCodeStoreOne, childBuyOrder, amount);
$mallTransaction = MallTransaction::buildForIntegration($apiKey, $commerceCode);
$response = $mallTransaction$->refund($buyOrder, $commerceCodeStoreOne, $childBuyOrder, $amount);
MallTransaction mallTransaction = MallTransaction.buildForIntegration("commerceCode", "APIKey");
var result = mallTransaction.Refund(buyOrder, commerceCodeStoreOne, childBuyOrder, amount);
@mall_transaction = Transbank::Webpay::Oneclick::MallTransaction.build_for_integration("commerceCode", "APIKey");
@resp = @mall_transaction.refund(buy_order: @buy_order, child_commerce_code: @commerce_store_1, child_buy_order: @child_buy_order, amount: @amount);
transaction = MallTransaction.build_for_integration("commerceCode", "APIKey")
resp = transaction.refund(buy_order, commerce_store_1, child_buy_order, amount)
const transaction = Oneclick.MallTransaction.buildForIntegration(
"commerceCode",
"APIKey"
);
const response = await transaction.refund(
buyOrder,
commerceCodeStoreOne,
buyOrderChild,
amount
);
POST /rswebpaytransaction/api/oneclick/v1.2/transactions/{buyOrder}/refunds
Tbk-Api-Key-Id: 597055555541
Tbk-Api-Key-Secret: 579B532A7440BB0C9079DED94D31EA1615BACEB56610332264630D42D0A36B1C
Content-Type: application/json
{
"commerce_code": "597055555542",
"detail_buy_order": "ordenCompra12345",
"amount": 1000
}
Parámetros Reversar o Anular
| Nombre tipo |
Descripción |
|---|---|
| buy_order String |
Orden de compra de la transacción a reversar o anular. Se envía en la URL, no en el body. Largo máximo: 26. |
| commerce_code String |
Código de comercio hijo. Largo máximo: 12. |
| detail_buy_order String |
Orden de compra hija de la transacción a reversar o anular. Largo máximo: 26. |
| amount Formato número entero para transacciones en peso. Sólo en caso de dólar acepta dos decimales. |
Monto que se desea anular o reversar de la transacción. Largo máximo: 17 |
Respuesta Reversar o Anular
En el caso de que la transacción corresponda a una Reversa solo se retorna el parámetro type (REVERSED).
response.getAuthorizationCode();
response.getAuthorizationDate();
response.getBalance();
response.getNullifiedAmount();
response.getResponseCode();
response.getType();
$response->getAuthorizationCode();
$response->getAuthorizationDate();
$response->getBalance();
$response->getNullifiedAmount();
$response->getResponseCode();
$response->getType();
response.AuthorizationCode;
response.AuthorizationDate;
response.Balance;
response.NullifiedAmount;
response.ResponseCode;
response.Type;
response.authorization_code
response.authorization_date
response.balance
response.nullified_amount
response.response_code
response.type
## Versión 3.x del SDK
response['authorization_code']
response['authorization_date']
response['captured_amount']
response['response_code']
## Versión 2.x del SDK
response.authorization_code
response.authorization_date
response.captured_amount
response.response_code
response.authorization_code
response.authorization_date
response.balance
response.nullified_amount
response.response_code
response.type
200 OK
Content-Type: application/json
{
"type": "NULLIFIED",
"authorization_code": "123456",
"authorization_date": "2019-03-20T20:18:20Z",
"nullified_amount": 1000.00,
"balance": 0.00,
"response_code": 0
}
En caso de una reversa no devuelve más información
{
"type": "REVERSED",
}
| Nombre tipo |
Descripción |
|---|---|
| type String |
Tipo de reembolso, REVERSED o NULLIFIED, si es REVERSED no se devolverán datos de la transacción (authorization code, etc). Largo máximo: 10 |
| authorization_code String |
(Solo si es NULLIFIED) Código de autorización. Largo máximo: 6 |
| authorization_date ISO8601 |
(Solo si es NULLIFIED) Fecha de la autorización de la transacción. |
| nullified_amount Decimal |
(Solo si es NULLIFIED) Monto anulado. Largo máximo: 17 |
| balance Decimal |
(Solo si es NULLIFIED) Monto restante de la transacción de pago original: monto inicial – monto anulado. Largo máximo: 17 |
| response_code Number |
(Solo si es NULLIFIED) Código del resultado del pago, donde: 0 (cero) es aprobado. Largo máximo: 2 |
| buy_order String |
(Solo si es NULLIFIED) Orden de compra generada por el comercio hijo para la transacción de pago. Largo máximo: 26. |
Captura diferida de una transacción
Revisa más detalles sobre esta modalidad en [la documentación](https://www.transbankdevelopers.cl/documentacion/oneclick#capturar-una-transaccion)
MallTransaction mallTransaction = MallTransaction.buildForIntegration("commerceCode", "APIKey");
final OneclickMallTransactionCaptureResponse response = mallTransaction.capture(commerceCodeStoreOne, childBuyOrder, authorizationCode, amount);
$mallTransaction = MallTransaction::buildForIntegration($apiKey, $commerceCode);
$response = $mallTransaction$->capture($commerceCodeStoreOne, $child_buy_order, $authorization_code, $amount);
MallTransaction mallTransaction = MallTransaction.buildForIntegration("commerceCode", "APIKey");
var result = mallTransaction.Capture(commerceCodeStoreOne, ChildbuyOrder, authorizationCode, amount);
@mall_transaction = Transbank::Webpay::Oneclick::MallTransaction.build_for_integration("commerceCode", "APIKey");
@resp = @mall_transaction.capture(child_commerce_code: @commerce_store_1, child_buy_order: @buy_order, authorization_code: @authorization_code, amount: @capture_amount);
transaction = MallTransaction.build_for_integration("commerceCode", "APIKey")
response = transaction.capture(commerce_store_1, child_buy_order, authorization_code, amount)
const transaction = Oneclick.MallTransaction.buildForIntegration(
"commerceCode",
"APIKey"
);
const response = await transaction.capture(
commerceCodeStoreOne,
buyOrder,
authorizationCode,
amount
);
PUT /rswebpaytransaction/api/oneclick/v1.2/transactions/capture
Tbk-Api-Key-Id: 597055555547
Tbk-Api-Key-Secret: 579B532A7440BB0C9079DED94D31EA1615BACEB56610332264630D42D0A36B1C
Content-Type: application/json
{
"commerce_code": 597055555548,
"buy_order": "OCDT12345678",
"capture_amount": 50,
"authorization_code": "1213"
}
Parámetros Captura Diferida
| Nombre tipo |
Descripción |
|---|---|
| commerce_code Number |
Tienda hija que realizó la transacción. Largo: 6. |
| buy_order String |
Orden de compra de la transacción que se requiere capturar. Largo máximo: 26. La orden de compra puede tener: Números, letras, mayúsculas y minúsculas, y los signos |_=&%.,~:/?[+!@()>- . Los caracteres con signos no están soportados, como los acentos o signos no especificados. |
| capture_amount Decimal |
Monto que se desea capturar. Largo máximo: 17. |
| authorization_code String |
Código de autorización de la transacción que se requiere capturar Largo máximo: 6. |
Respuesta Captura Diferida
response.getAuthorizationCode();
response.getAuthorizationDate();
response.getCapturedAmount();
response.getResponseCode();
$response->getAuthorizationCode();
$response->getAuthorizationDate();
$response->getCapturedAmount();
$response->getResponseCode();
response.AuthorizationCode;
response.AuthorizationDate;
response.CapturedAmount;
response.ResponseCode;
response.authorization_code
response.authorization_date
response.captured_amount
response.response_code
## Versión 3.x del SDK
response['authorization_code']
response['authorization_date']
response['captured_amount']
response['response_code']
## Versión 2.x del SDK
# Esta función aun no se encuentra disponible en el SDK
response.authorization_code
response.authorization_date
response.captured_amount
response.response_code
200 OK
Content-Type: application/json
{
"authorization_code": "152759",
"authorization_date": "2020-04-03T01:49:50.181Z",
"captured_amount": 50,
"response_code": 0
}
| Nombre tipo |
Descripción |
|---|---|
| authorization_code String |
Código de autorización de la captura diferida. Largo máximo: 6 |
| authorization_date String |
Fecha y hora de la autorización. |
| captured_amount Decimal |
Monto capturado. Largo máximo: 6 |
| response_code Number |
Código de resultado de la captura. Si es exitoso es 0,de lo contrario la captura no fue realizada. Largo máximo: 2 |
Códigos y mensajes de error
Al realizar cualquier solicitud al API REST, además de los datos de respuesta, se incluirá uno de los siguientes códigos de estado de respuesta HTTP dependiendo del resultado obtenido:
Solicitud exitosa
Cuando la operación solcitada es ejecutada correctamente, se pueden recibir estos status HTTP:
| Código de estado HTTP | Descripción |
|---|---|
| 200 | La operación se ha ejecutado exitosamente |
| 204 | La operación DELETE se ha ejecutado exitosamente |
Códigos de error
Todos los errores reportados por la API REST de Webpay despliegan un mensaje JSON con una descripción del error.
{
"error_message": "token is required"
}
| Código de estado HTTP | Descripción |
|---|---|
| 400 | El mensaje JSON es inválido. Puedes ser que no corresponda a un mensaje bien estructurado o que contenga un campo no esperado. |
| 401 | No autorizado. API Key y/o API Secret inválidos |
| 404 | La transacción no ha sido encontrada. |
| 405 | Método no permitido. |
| 406 | No fue posible procesar la respuesta en el formato que el cliente indica. |
| 415 | Tipo de mensaje no permitido. |
| 422 | El requerimiento no ha podido ser procesado ya sea por validaciones de datos o por lógica de negocios. |
| 500 | Ha ocurrido un error inesperado. |
Puesta en Producción
Una vez que el comercio determine que ha finalizado su integración, se debe realizar un
[proceso de validación](https://www.transbankdevelopers.cl/referencia/webpay#proceso-de-validacion).Una vez que Transbank confirme que la información enviada por formulario es correcta (no aplica para plugins), se enviará al comercio la confirmación y se generará su API Key Secret, que en conjunto con el código de comercio, permiten operar en producción.
Cuando recibas el correo, será necesario
[cambiar la configuración del e-commerce para funcionar en producción](#configuracion-para-produccion-utilizando-los-sdk)Con la configuración del ambiente de producción ya lista, será necesario realizar una compra de $50 para validar el correcto funcionamiento.
Configuración para producción utilizando los SDK
Si estas utilizando algún SDK oficial de Transbank, entonces debes seguir los siguientes pasos.
- Asignar el código de comercio productivo, entregado por Transbank al momento de contratar el producto.
Oneclick.MallInscription mallInscription = Oneclick.MallInscription.buildForProduction("commerceCode", "APIKey");
Oneclick.MallTransaction mallTransaction = Oneclick.MallTransaction.buildForProduction("commerceCode", "APIKey");
$mallInscription = MallInscription::buildForProduction($apiKey, $commerceCode);
$mallTransaction = MallTransaction::buildForProduction($apiKey, $commerceCode);
MallInscription mallInscription = MallInscription.buildForProduction("commerceCode", "APIKey");
MallTransaction mallTransaction = MallTransaction.buildForProduction("commerceCode", "APIKey");
@mall_inscription = Transbank::Webpay::Oneclick::MallInscription.build_for_production("commerceCode", "APIKey");
@mall_transaction = Transbank::Webpay::Oneclick::MallTransaction.build_for_production("commerceCode", "APIKey");
inscription = MallInscription.build_for_production("commerceCode", "APIKey")
transaction = MallTransaction.build_for_production("commerceCode", "APIKey")
const inscription = Oneclick.MallInscription.buildForProduction(
"commerceCode",
"APIKey"
);
const transaction = Oneclick.MallTransaction.buildForProduction(
"commerceCode",
"APIKey"
);
200 OK
Content-Type: application/json
{
"authorization_code": "152759",
"authorization_date": "2020-04-03T01:49:50.181Z",
"captured_amount": 50,
"response_code": 0
}
// Esta función aun no se encuentra disponible en el SDK
# Esta función aun no se encuentra disponible en el SDK
# Esta función aun no se encuentra disponible en el SDK
const Oneclick = require('transbank-sdk').Oneclick; // CommonJS
import { Oneclick } from 'transbank-sdk'; // ES6 Modules
Oneclick.commerceCode = 'TU_CODIGO_DE_COMERCIO';
- Configuración del secreto compartido.
// Para Oneclick
Oneclick.setApiKey('TU_API_KEY');
// Esta función aun no se encuentra disponible en el SDK
# Esta función aun no se encuentra disponible en el SDK
# Esta función aun no se encuentra disponible en el SDK
const Oneclick = require('transbank-sdk').Oneclick; // CommonJS
import { Oneclick } from 'transbank-sdk'; // ES6 Modules
Oneclick.apiKey = 'TU_API_KEY';
- Selección del ambiente productivo.
// Para Oneclick
Oneclick.setIntegrationType(IntegrationType.LIVE);
// Esta función aun no se encuentra disponible en el SDK
# Esta función aun no se encuentra disponible en el SDK
# Esta función aun no se encuentra disponible en el SDK
const Oneclick = require('transbank-sdk').Oneclick; // CommonJS
const Environment = require('transbank-sdk').Environment // CommonJS
import { Oneclick, Environment } from 'transbank-sdk'; // ES6 Modules
Oneclick.environment = Environment.Production;
Alternativamente algunos SDK ofrecen un método para configurar directamente a producción
// Esta función aun no se encuentra disponible en el SDK
// Esta función aun no se encuentra disponible en el SDK
# Esta función aun no se encuentra disponible en el SDK
# Esta función aun no se encuentra disponible en el SDK
const Oneclick = require('transbank-sdk').Oneclick; // CommonJS
import { Oneclick } from 'transbank-sdk'; // ES6 Modules
Oneclick.configureForProduction('TU_CODIGO_DE_COMERCIO', 'TU_API_KEY');

# referencia_patpasscomercio.md

Source: https://www.transbankdevelopers.cl/referencia/patpasscomercio

Patpass Rest
Patpass Comercio
Ambientes y credenciales
La API REST de Patpass está protegida para garantizar que solamente comercios autorizados por Transbank hagan uso de las operaciones disponibles. La seguridad esta implementada mediante los siguientes mecanismos:
- Canal seguro a través de TLSv1.2 para la comunicación del cliente con Webpay.
- Autenticación y autorización mediante el intercambio de headers
Commercecode
yAuthorization
.
Ambiente de Producción
Las URLs de endpoints de producción están alojados dentro de
[https://www.pagoautomaticocontarjetas.cl//](https://www.pagoautomaticocontarjetas.cl//).
// Host: https://www.pagoautomaticocontarjetas.cl/
// Host: https://www.pagoautomaticocontarjetas.cl/
// Host: https://www.pagoautomaticocontarjetas.cl/
# Host: https://www.pagoautomaticocontarjetas.cl/
# Host: https://www.pagoautomaticocontarjetas.cl/
Host: https://www.pagoautomaticocontarjetas.cl/
// Host: https://pagoautomaticocontarjetas.cl/
Ambiente de Integración
Las URLs de endpoints de integración están alojados dentro de
[https://pagoautomaticocontarjetasint.transbank.cl//](https://pagoautomaticocontarjetasint.transbank.cl//).
Consulta [la documentación para conocer las
tarjetas de prueba que funcionan en
el ambiente de integración](https://www.transbankdevelopers.cl/documentacion/como_empezar#ambientes).
// Host: https://pagoautomaticocontarjetasint.transbank.cl/
// Host: https://pagoautomaticocontarjetasint.transbank.cl/
// Host: https://pagoautomaticocontarjetasint.transbank.cl/
# Host: https://pagoautomaticocontarjetasint.transbank.cl/
# Host: https://pagoautomaticocontarjetasint.transbank.cl/
// Host: https://pagoautomaticocontarjetasint.transbank.cl/
Host: https://pagoautomaticocontarjetasint.transbank.cl/
Credenciales del Comercio
// Commercecode: 28299257
// Authorization: cxxXQgGD9vrVe4M41FIt
// Commercecode: 28299257
// Authorization: cxxXQgGD9vrVe4M41FIt
// Commercecode: 28299257
// Authorization: cxxXQgGD9vrVe4M41FIt
# Commercecode: 28299257
# Authorization: cxxXQgGD9vrVe4M41FIt
# Commercecode: 28299257
# Authorization: cxxXQgGD9vrVe4M41FIt
// Commercecode: 28299257
// Authorization: cxxXQgGD9vrVe4M41FIt
Commercecode: 28299257
Authorization: cxxXQgGD9vrVe4M41FIt
Content-Type: application/json
Iniciar Inscripción
Para iniciar una inscripción debes llamar al método Inscription.start
Inscription.start()
Permite gatillar el inicio del proceso de inscripción. Los datos ingresados serán precargados en el formulario al momento de mostrarse.
// Versión 3.x del SDK
PatpassComercio.Inscription inscription = new PatpassComercio.Inscription(new PatpassOptions(IntegrationCommerceCodes.PATPASS_COMERCIO, IntegrationApiKeys.PATPASS_COMERCIO, IntegrationType.TEST));
final PatpassComercioInscriptionStartResponse response = inscription.start(url,
name,
firstLastName,
secondLastName,
rut,
serviceId,
finalUrl,
maxAmount,
phoneNumber,
mobileNumber,
patpassName,
personEmail,
commerceEmail,
address,
city);
// Versión 2.x del SDK
final PatpassComercioInscriptionStartResponse response = PatpassComercio.Inscription.start(
'http://misitio.cl/finalizar_suscripcion', // URL
'Diego', // Nombre
'Sanchez', // Primer apellido
'Valdovinos', // Segundo apellido
'12345678-9', // Rut
'323123', // Id de servicio
'http://misitio.cl/voucher', // URL Final
0, // Monto máximo
'57508624', // Teléfono fijo
'57508624', // Teléfono celular
'Help - 8050014', // Nombre PatPass
'persona@test.cl', // Email Persona
'comercio@test.cl', // Email Comercio
'Merced 156, Santiago, Chile', // Dirección
'Santiago' // Ciudad
);
$response = PatpassComercio\Inscription::start(
'http://misitio.cl/finalizar_suscripcion', // URL
'Diego', // Nombre
'Sanchez', // Primer apellido
'Valdovinos', // Segundo apellido
'12345678-9', // Rut
'323123', // Id de servicio
'http://misitio.cl/voucher', // URL Final
0, // Monto máximo
'57508624', // Teléfono fijo
'57508624', // Teléfono celular
'Help - 8050014', // Nombre PatPass
'persona@test.cl', // Email Persona
'comercio@test.cl', // Email Comercio
'Merced 156, Santiago, Chile', // Dirección
'Santiago' // Ciudad
);
// Versión 4.x del SDK
var inscription = new Inscription(new Options(IntegrationCommerceCodes.PATPASS_COMERCIO, IntegrationApiKeys.PATPASS_COMERCIO, PatpassComercioIntegrationType.Test));
var result = inscription.Start(
url: 'http://misitio.cl/finalizar_suscripcion',
name: 'Diego',
fLastname: 'Sanchez',
sLastname: 'Valdovinos',
rut: '12345678-9',
serviceId: '323123',
finalUrl: 'http://misitio.cl/voucher',
maxAmount: 0,
phoneNumber: '57508624',
mobileNumber: '57508624',
patpassName: 'Help - 8050014',
personEmail: 'persona@test.cl',
commerceEmail: 'comercio@test.cl',
address: 'Merced 156, Santiago, Chile',
city: 'Santiago'
);
// Versión 3.x del SDK
var response = Inscription.Start(
url: 'http://misitio.cl/finalizar_suscripcion',
name: 'Diego',
fLastname: 'Sanchez',
sLastname: 'Valdovinos',
rut: '12345678-9',
serviceId: '323123',
finalUrl: 'http://misitio.cl/voucher',
maxAmount: 0,
phoneNumber: '57508624',
mobileNumber: '57508624',
patpassName: 'Help - 8050014',
personEmail: 'persona@test.cl',
commerceEmail: 'comercio@test.cl',
address: 'Merced 156, Santiago, Chile',
city: 'Santiago'
);
@url = "https://callback_url/resultado/de/la/transaccion"
@name = "Nombre"
@first_last_name = "Primer Apellido"
@second_last_name = "Segundo Apellido"
@rut = "11111111-1"
@service_id = "Identificador del servicio unico de suscripción"
@final_url = "https://callback/final/comprobante/transacción"
@max_amount = 10000; # monto máximo de la suscripció
@phone_number = "numero telefono fijo de suscrito"
@mobile_number = "numero de telefono móvil de suscrito"
@patpass_name = "Nombre asignado a la suscripción"
@person_email = "Correo de suscrito"
@commerce_email = "Correo de comercio"
@address = "Dirección de Suscrito"
@city = "Ciudad de suscrito"
## Versión 2.x del SDK
@inscription = Transbank::Patpass::PatpassComercio::Inscription.new()
@resp = @inscription.start(
@url,
@name,
@first_last_name,
@second_last_name,
@rut,
@service_id,
@final_url,
@max_amount,
@phone_number,
@mobile_number,
@patpass_name,
@person_email,
@commerce_email,
@address,
@city
)
## Versión 1.x del SDK
@resp = Transbank::Patpass::PatpassComercio::Inscription::start(
url: @url,
name: @name,
first_last_name: @first_last_name,
second_last_name: @second_last_name,
rut: @rut,
service_id: @service_id,
final_url: @final_url,
max_amount: @max_amount,
phone_number: @phone_number,
mobile_number: @mobile_number,
patpass_name: @patpass_name,
person_email: @person_email,
commerce_email: @commerce_email,
address: @address,
city: @city
)
return_url = "https://callback_url/resultado/de/la/transaccion"
name = "Nombre"
first_last_name = "Primer Apellido"
second_last_name = "Segundo Apellido"
rut = "11111111-1"
service_id = "Identificador del servicio unico de suscripción"
final_url = "https://callback/final/comprobante/transacción"
max_amount = 10000; # monto máximo de la suscripció
phone_number = "numero telefono fijo de suscrito"
mobile_number = "numero de telefono móvil de suscrito"
patpass_name = "Nombre asignado a la suscripción"
person_email = "Correo de suscrito"
commerce_mail = "Correo de comercio"
address = "Dirección de Suscrito"
city = "Ciudad de suscrito"
## Versión 3.x del SDK
ins = Inscription(PatpassComercioOptions(IntegrationCommerceCodes.PATPASS_COMERCIO, IntegrationApiKeys.PATPASS_COMERCIO, IntegrationType.TEST))
resp = ins.start(return_url, name, first_last_name, second_last_name, rut, service_id, None,
max_amount, phone_number, mobile_number, patpass_name,
person_email, commerce_mail, address, city)
## Versión 2.x del SDK
resp = Inscription.start(return_url, name, first_last_name, second_last_name, rut, service_id, final_url,
max_amount, phone_number, mobile_number, patpass_name,
person_email, commerce_mail, address, city)
var returnUrl = "https://callback_url/resultado/de/la/transaccion"
var name = "Nombre";
var firstLastName = "Primer Apellido";
var secondLastName = "Segundo Apellido";
var rut = 11111111-1;;
var serviceId = "Identificador del servicio único de suscripción";
var finalUrl = "https://callback/final/comprobante/transaccion";
var maxAmount = 10000; // Monto máximo de la suscripción
var phoneNumber = "Número teléfono fijo de suscrito";
var mobileNumber = "Número teléfono móvil de suscrito";
var patpassName = "Nombre asignado a la suscripción";
var personEmail = "Correo de suscrito";
var commerceEmail = "Correo de comercio";
var address = "Dirección de suscrito";
var city = "Ciudad de suscrito";
const response = await new PatpassComercio.Inscription().start(
returnUrl,
name,
firstLastName,
secondLastName,
rut,
serviceId,
finalUrl,
maxAmount,
phoneNumber,
mobileNumber,
patpassName,
personEmail,
commerceEmail,
address,
city
);
POST restpatpass/v1/services/patInscription
Commercecode: 28299257
Authorization: cxxXQgGD9vrVe4M41FIt
Content-Type: application/json
{
"url": "http://misitio.cl/finalizar_suscripcion",
"nombre": "Diego",
"pApellido": "Sanchez",
"sApellido": "Valdovinos",
"rut": "12345678-9",
"serviceId": "323123",
"finalUrl": "http://misitio.cl/voucher",
"commerceCode": "28299257",
"montoMaximo": "",
"telefonoFijo": "57508624",
"telefonoCelular": "57508624",
"nombrePatPass": "Help - 8050014",
"correoPersona": "persona@test.cl",
"correoComercio": "comercio@test.cl",
"direccion": "Merced 156, Santiago, Chile",
"ciudad": "Santiago"
}
Parámetros Inscription.start
| Nombre tipo |
Descripción |
|---|---|
| url String |
URL de retorno del comercio (no permite 'localhost' ni '127.0.0.1') |
| firstName String |
Nombre del tarjetahabiente |
| fLastname String |
Apellido paterno del tarjetahabiente |
| sLastname String |
Apellido materno del tarjetahabiente |
| rut String |
Rut del tarjetahabiente (solo rut válidos o '11111111-1' para pruebas) |
| serviceId String |
ID del servicio del tarjetahabiente |
| finalUrl String |
Url final de la inscripción (no permite 'localhost' ni '127.0.0.1') |
| maxAmount String |
Monto máximo del PAT a inscribir |
| phoneNumber String |
Teléfono fijo del tarjetahabiente |
| mobileNumber String |
Teléfono celular del tarjetahabiente |
| patPassName String |
Nombre del PAT |
| userEmail String |
Correo al tarjetahabiente con la suscripción |
| commerceEmail String |
Correo para el comercio con el comprobante de suscripción |
| userAddress String |
Dirección del tarjetahabiente |
| userCity String |
Ciudad del tarjetahabiente |
Respuesta Inscription.start
response.getToken();
response.getUrl();
$response->token;
$response->url;
response.Token;
response.Url;
response.token
response.url
response.token;
response.url;
## Versión 3.x del SDK
response['token']
respone['url']
## Versión 2.x del SDK
response.token
respone.url
| Nombre tipo |
Descripción |
|---|---|
| token xs:string |
Token de la transacción. Largo: 64. |
| url xs:string |
URL de formulario de pago Patpass Comercio. Largo máximo: 256. |
Mensajes de error
| Código | Descripción |
|---|---|
| -1 | Error interno |
| -101 | URL final incorrecta |
| -102 | URL retorno incorrecta |
| -103 | Nombre Incorrecto |
| -104 | Apellido Paterno incorrecto |
| -105 | Apellido Materno incorrecto |
| -106 | Rut inválido |
| -107 | Id de Servicio incorrecto |
| -108 | Código de comercio inválido |
| -109 | Monto tope inválido |
| -110 | Headers de autentificación requeridos |
| -111 | Headers de autentificación erróneos |
La respuesta de este método se debe utilizar para crear un campo de nombre
tokenComercio
en un formulario, al cual se le asigna el valor de token
y debe
ser enviado a url
.
<form action="<Insertar URL aquí>" method="post" name="tokenForm">
<input type="hidden" name="tokenComercio" value="<Insertar token aquí>">
<input type="submit" class="btn btn-success" value="Inscribirse en Patpass Comercio">
</form>
<form method="POST" action="$res['url']">
<input type="hidden" name="tokenComercio" value="$res['token']"/>
<input type="submit" value="Iniciar inscripcion"/>
</form>
<form method="POST" action="@ViewBag.Url">
<input type="hidden" name="tokenComercio" value="@ViewBag.Token"/>
<input type="submit"value="Iniciar inscripcion"/>
</form>
<form action="${model.url}" method="post" name="tokenForm">
<input type="hidden" name="tokenComercio" value="${model.tbk_token}"/>
<input type="submit" class="btn btn-success" value="Iniciar inscripcion"/>
</form>
<form action="<%= @resp.url %>"method="post">
<input type="hidden" name="tokenComercio" value="<%= @resp.token %>"/>
<input type="submit"> value="Iniciar inscripcion"/>
</form>
<form action="{ { response.url } }"method="POST">
<input type="hidden" name="tokenComercio" value="{ { response.token } }"/>
<input type="submit"> value="Iniciar inscripcion"/>
</form>
<form action="${response.url}"method="POST">
<input type="hidden" name="tokenComercio" value="${response.token}"/>
<input type="submit"> value="Iniciar inscripcion"/>
</form>
Estado de una Inscripción
Para finalizar el proceso de inscripción se debe llamar a Inscription.status
Inscription.status
Este método permite finalizar el proceso de inscripción del PAT asociado al token que se generó en la inscripción
La respuesta del método contiene el estado y la URL para desplegar el voucher.
// Versión 3.x del SDK
PatpassComercio.Inscription inscription = new PatpassComercio.Inscription(new PatpassOptions(IntegrationCommerceCodes.PATPASS_COMERCIO, IntegrationApiKeys.PATPASS_COMERCIO, IntegrationType.TEST));
final PatpassComercioTransactionStatusResponse response = inscription.status(token);
// Versión 2.x del SDK
final PatpassComercioTransactionStatusResponse response =
PatpassComercio.Transaction.status(token);
$response = PatpassComercio\Inscription::getStatus($token);
// Versión 4.x del SDK
var inscription = new Inscription(new Options(IntegrationCommerceCodes.PATPASS_COMERCIO, IntegrationApiKeys.PATPASS_COMERCIO, PatpassComercioIntegrationType.Test));
var response = inscription.Status(token);
// Versión 3.x del SDK
var response = Inscription.Status(token);
## Versión 2.x del SDK
@inscription = Transbank::Patpass::PatpassComercio::Inscription.new()
@resp = @inscription.status(token: @token)
## Versión 1.x del SDK
@response = Transbank::Patpass::PatpassComercio::Inscription::status(token)
## Versión 3.x del SDK
ins = Inscription(PatpassComercioOptions(IntegrationCommerceCodes.PATPASS_COMERCIO, IntegrationApiKeys.PATPASS_COMERCIO, IntegrationType.TEST))
resp = ins.status(token)
## Versión 2.x del SDK
resp = Inscription.status(token)
const j_token = request.body.j_token;
const response = await new PatpassComercio.Inscription().status(j_token);
POST restpatpass/v1/services/status
Commercecode: 28299257
Authorization: cxxXQgGD9vrVe4M41FIt
Content-Type: application/json
{
"token": "21383fe8ba4c4cdd9e18518daf4e9bcbaffd9e8e3ad4ec36f66ae2b4e80cc4b5"
}
Parámetros Inscription.status
Nombre
tipo | Descripción
token
String | Token entregado al iniciar inscripción
Respuesta Inscription.status
response.getVoucherUrl();
response.isAuthorized();
$response->$status;
$response->$urlVoucher;
response.Status;
response.UrlVoucher;
response.status
response.voucher_url
response.authorized;
response.voucherUrl;
## Versión 3.x del SDK
response['status']
respone['voucher_url']
## Versión 2.x del SDK
response.status
response.voucher_url
| Nombre tipo |
Descripción |
|---|---|
| authorized string |
Boolean representa estado de la transacción. |
| voucherUrl string |
URL para mostrar el voucher. Largo máximo: 256. |
La respuesta de este método se debe utilizar para crear un campo de nombre
tokenComercio
en un formulario, al cual se le asigna el valor de token
y debe
ser enviado a voucherUrl
.
<form action="<Insertar URL aquí>" method="post" name="tokenForm">
<input type="hidden" name="tokenComercio" value="<Insertar token aquí>">
<input type="submit" class="btn btn-success" value="Inscribirse en Patpass Comercio">
</form>
<form method="POST" action="$res['voucherUrl']">
<input type="hidden" name="tokenComercio" value="$res['token']"/>
<input type="submit" value="Ver voucher"/>
</form>
<form method="POST" action="@ViewBag.voucherUrl">
<input type="hidden" name="tokenComercio" value="@ViewBag.Token"/>
<input type="submit"value="Ver voucher"/>
</form>
<form action="${model.voucherUrl}" method="post" name="tokenForm">
<input type="hidden" name="tokenComercio" value="${model.tbk_token}"/>
<input type="submit" class="btn btn-success" value="Ver voucher"/>
</form>
<form action="<%= @resp.voucherUrl %>"method="post">
<input type="hidden" name="tokenComercio" value="<%= @resp.token %>"/>
<input type="submit"> value="Ver voucher"/>
</form>
<form action="{ { response.voucherUrl } }"method="POST">
<input type="hidden" name="tokenComercio" value="{ { response.token } }"/>
<input type="submit"> value="Ver voucher"/>
</form>
<form action="${response.voucherUrl}"method="POST">
<input type="hidden" name="tokenComercio" value="${response.token}"/>
<input type="submit"> value="Ver voucher"/>
</form>

# referencia_posautoservicio.md

Source: https://www.transbankdevelopers.cl/referencia/posautoservicio

POS Autoservicio
Protocolo de Comunicación
La comunicación a través de una puerta serial RS232
tiene velocidades
que van
desde los 1200 Bps hasta 115200 Bps (8N1
). La velocidad inicial del POS es de
19200 Bps 8N1
.
La comunicación a través del puerto USB, esta con velocidad de 115200 Bps
(8N1
).
Si cambia el tipo de comunicación de serial a USB, quedará seteada
automáticamente a la velocidad anteriormente descrita.
![Diagrama de Comunicación](https://www.transbankdevelopers.cl/public/slate-library/images/referencia/posautoservicio/diagrama-comunicacion-caja-pos.png)
Flujo de comunicación
| Termino | Descripción |
|---|---|
ACK |
Lo envía el POS o la caja como aviso de recepción OK. Hex: 0x06
|
NAK |
Lo envía el POS o la caja cuando el LRC calculado no
corresponde al enviado.Hex: 0x15
|
| Timeout1 |
Es el tiempo de espera del ACK o NAK para reintentar
el envío del requerimiento por la caja y la respuesta desde el POS.
|
LRC |
Es un byte que se concatena luego del <FIN COMANDO> y que se
calcula realizando un XOR byte a byte del mensaje, el cual consta
de:
<DATA> + <FIN COMANDO> .
|
| Timeout2 |
Es el tiempo de espera de la respuesta por la caja luego de recibir
el ACK del requerimiento.
|
STX |
Indica el INICIO del mensaje Hex: 0x02
|
ETX |
Indica el FIN del mensaje Hex: 0x03
|
Ejemplo de calculo LRC
Para este protocolo, el LRC se calcula sobre el contenido y el fin de texto, excluyendo el inicio de texto (<STX>).
Comando de ejemplo:
<STX>0200|123|<ETX>
Desglose Hexadecimal:
<STX>: 0x02
(Se omite del cálculo)Datos (0200|123|): 0x30 0x32 0x30 0x30 0x7C 0x31 0x32 0x33 0x7C
<ETX> : 0x03
Operación (XOR): Se realiza la operación XOR ( ^ ) byte a byte desde el primer dato hasta el
(0x30 ^ 0x32 ^ 0x30 ^ 0x30 ^ 0x7C ^ 0x31 ^ 0x32 ^ 0x33 ^ 0x7C ^ 0x03) = 0x31
Resultado: El LRC calculado es 0x31 (hexadecimal) o 1 (ASCII). Por lo tanto, el mensaje completo para enviar al POS Integrado es:
<STX> DATOS <ETX> LRC
0x02 0x30 0x32 0x30 0x30 0x7C 0x31 0x32 0x33 0x7C 0x03 0x31
Ojo: En la respuesta que entrega el POS Autoservicio, el LRC calculado considera el inicio de texto (<STX>). Por lo tanto, la operación cambia a la siguiente forma
Operación (XOR):(0x02 ^ 0x30 ^ 0x32 ^ 0x30 ^ 0x30 ^ 0x7C ^ 0x31 ^ 0x32 ^ 0x33 ^ 0x7C ^ 0x03) = 0x33
Resultado: El LRC calculado es 0x33 (hexadecimal) o 3 (ASCII). Por lo tanto, el mensaje completo para enviar al POS Integrado es:
<STX> DATOS <ETX> LRC
0x02 0x30 0x32 0x30 0x30 0x7C 0x31 0x32 0x33 0x7C 0x03 0x33
Primeros pasos
Listar puertos disponibles
import cl.transbank.pos.POSAutoservicio;
//...
POSAutoservicio pos = new POSAutoservicio();
List<String> ports = pos.listPorts();
using Transbank.POSAutoservicio;
//...
List<string> ports = POSIntegrado.Instance.ListPorts();
pos.listPorts().then( (ports) => {
console.log(ports);
}).catch( (err) => {
console.log('Ocurrió un error inesperado', err);
});
Puedes utilizar la función específica de cada uno de los SDK, para identificar los puertos y seleccionar el que se haya conectado al POS.
Abrir un puerto serial
import cl.transbank.pos.POSAutoservicio;
//...
POSAutoservicio pos = new POSAutoservicio();
String port = "COM4";
int baudRate = 19200;
pos.openPort(port, baudRate);
using Transbank.POSAutoservicio;
//...
string portName = "COM3";
POSAutoservicio.Instance.OpenPort(portName);
let portName = "/dev/tty.usbserial-1410"; // Ejemplo en MAC
let portName = "COM4"; // Ejemplo en caso de Windows
pos.connect(portName).then( (response) => {
console.log('Conectado correctamente');
}).catch( (err) => {
console.log('Ocurrió un error inesperado', err);
});
Para abrir un puerto serial y comunicarte con el POS Autoservicio, necesitarás el nombre del puerto. También necesitarás el baudrate al cual está configurado el puerto serial del POS Autoservicio (por defecto es 19200).
Si el puerto no puede ser abierto, se lanzará una excepción
TransbankException
en .NET y Java.
Cerrar un puerto serial
import cl.transbank.pos.POSAutoservicio;
//...
POSAutoservicio pos = new POSAutoservicio();
pos.closePort();
using Transbank.POSAutoservicio;
//...
POSAutoservicio.Instance.ClosePort();
pos.disconnect().then( (response) => {
console.log('Puerto desconectado correctamente');
}).catch( (err) => {
console.log('Ocurrió un error inesperado', err);
});
Al finalizar el uso del POS, o si se desea desconectar de la Caja se debe liberar el puerto serial abierto anteriormente.
Mensajes
Mensaje de Venta
Este comando es enviado por la caja para solicitar la ejecución de una venta. Los siguientes parámetros deben ser enviados desde la caja:
Monto
: Monto en pesos informados al POS. Este parámetro es remitido a Transbank para realizar la autorización.Número Ticket/Boleta
: Número de la operación de venta.Campo impresión
: Indica si el POS debe devolver un voucher formateado.Enviar Mensaje
: Indica al POS si debe enviar a la caja de mensajes de estatus de la transacción mientras se realiza la venta.
import cl.transbank.pos.POSAutoservicio;
import cl.transbank.pos.responses.autoservicio.*;
//...
POSAutoservicio pos = new POSAutoservicio();
SaleResponse response = pos.sale(amount, ticket, true);
using Transbank.POSAutoservicio;
using Transbank.Responses.CommonResponses;
using Transbank.Responses.AutoservicioResponse;
//...
Task<SaleResponse> response = POSAutoservicio.Instance.Sale(amount, ticket, true);
pos.sale(1500, '12423').then( (response) => {
console.log('Sale finalizado. Respuesta', response);
}).catch( (err) => {
console.log('Ocurrió un error inesperado', err);
});
{
"Function": 210,
"ResponseCode": 0,
"ResponseMessage": "Aprobado",
"Commerce Code": 550062700310,
"Terminal Id": "ABC1234C",
"Ticket": "ABC123",
"Authorization Code": "XZ123456",
"Amount": 15000,
"Last 4 Digits": 6677,
"Operation Number": 60,
"Card Type": "CR",
"Accounting Date": "28/10/2019 22:35:12",
"Account Number": "30000000000",
"Card Brand": "AX",
"Real Date": "28/10/2019 22:35:12",
"Printing Field:": List<string>,
"Shares Type": 3,
"Shares Number": 3,
"Shares Amount": 5000,
"Shares Type Gloss": " "
}
![Diagrama de Secuencia Venta](https://www.transbankdevelopers.cl/public/slate-library/images/referencia/posautoservicio/diagrama-venta.png)
-
La caja envía el requerimiento y espera como respuesta
<ACK>
/<NAK>
, en caso de que llegue un<NAK>
, debe reintentar el envío del requerimiento 2 veces. Si recibe un<ACK>
debe esperar la respuesta de la transacción. - El POS solicita los datos al usuario, y envía el requerimiento al Autorizador, en caso de ser aprobada, se guarda en Batch y se envía respuesta a la caja. En caso de ser rechazada se envía respuesta a la caja indicando el error.
- La caja al recibir la respuesta envía un
<ACK>
si el mensaje está correcto, o un<NAK>
para el caso en que elLRC
no corresponde. - El POS al recibir el
<ACK>
vuelve al inicio a esperar un nuevo comando, para el caso que recibe un<NAK>
vuelve a enviar la respuesta 2 veces más.
Solicitud de Venta
| DATO | LARGO | Comentario |
|---|---|---|
<STX> |
1 |
Indica el inicio de texto o comando valor hexadecimal: 0x02
|
Comando |
4 |
valor ASCII: 0200 valor hexadecimal: 0x30 0x32 0x30 0x30
|
Separador de campo |
1 |
valor ASCII: | valor hexadecimal: 0x7c
|
Monto |
9 | Valor Numérico que debe ser convertido a hexadecimal. |
Separador de campo |
1 |
valor ASCII: | valor hexadecimal: 0x7c
|
Número de ticket / boleta |
20 | Valor ASCII, Número de boleta o ticket, que debe ser convertido a hexadecimal |
Separador de campo |
1 |
valor ASCII: | valor hexadecimal: 0x7c
|
Campo impresión |
1 | Indica si entrega voucher formateado 1 = Sí, 0 = No |
Separador de campo |
1 |
valor ASCII: | valor hexadecimal: 0x7c
|
Enviar mensajes |
1 |
Indica al POS si debe enviar mensajes intermedios o de estado de la
transacción 1: Envía Mensajes 0: No envía mensajes |
<ETX> |
1 |
Indica el fin de texto o comando valor hexadecimal: 0x03
|
<LRC> |
1 | Resultado del cálculo del LRC del mensaje |
Respuesta de Venta
| DATO | LARGO | COMENTARIO |
|---|---|---|
<STX> |
1 |
Indica inicio de texto o comando valor hexadecimal: 0x02
|
Comando |
4 |
Valor ASCII: 0210 valor hexadecimal: 0x30 0x32 0x31 0x30
|
Separador de campo |
1 |
valor ASCII: | valor hexadecimal: 0x7c
|
Código Respuesta |
2 | Valor Numérico |
Separador de campo |
1 |
valor ASCII: | valor hexadecimal: 0x7c
|
Código de comercio |
12 | Valor Numérico |
Separador de campo |
1 |
valor ASCII: | valor hexadecimal: 0x7c
|
Terminal ID |
8 | Valor Alfanumérico |
Separador de campo |
1 |
valor ASCII: | valor hexadecimal: 0x7c
|
Número de ticket / boleta |
20 | Valor Alfanumérico |
Separador de campo |
1 |
valor ASCII: | valor hexadecimal: 0x7c
|
Código de Autorización |
6 | Valor Alfanumérico (opcional) |
Separador de campo |
1 |
valor ASCII: | valor hexadecimal: 0x7c
|
Monto |
9 | Valor Numérico |
Separador de campo |
1 |
valor ASCII: | valor hexadecimal: 0x7c
|
Últimos 4 dígitos tarjeta |
4 | Valor Numérico |
Separador de campo |
1 |
valor ASCII: | valor hexadecimal: 0x7c
|
Número de operación |
6 | Correl |
Separador de campo |
1 |
valor ASCII: | valor hexadecimal: 0x7c
|
Tipo de Tarjeta |
2 |
CR: Crédito DB: Débito |
Separador de campo |
1 |
valor ASCII: | valor hexadecimal: 0x7c
|
Fecha Contable |
6 | Valor ASCII. Se utiliza si es tarjeta de Débito |
Separador de campo |
1 |
valor ASCII: | valor hexadecimal: 0x7c
|
Número de Cuenta |
19 | Valor ASCII. Se utiliza si es tarjeta de Débito |
Separador de campo |
1 |
valor ASCII: | valor hexadecimal: 0x7c
|
Abreviación Tarjeta |
2 |
Ejemplo: VI = VISA MC = Mastercard |
Separador de campo |
1 |
valor ASCII: | valor hexadecimal: 0x7c
|
Fecha transacción |
8 | Formato: DDMMAAAA |
Separador de campo |
1 |
valor ASCII: | valor hexadecimal: 0x7c
|
Hora transacción |
6 | Formato: HHMMSS |
Separador de campo |
1 (opcional) |
valor ASCII: | valor hexadecimal: 0x7c
|
Campo impresión |
Variable (opcional) | Campo depende si la caja requiere voucher formateado |
Separador de campo |
1 (opcional) |
valor ASCII: | valor hexadecimal: 0x7c
|
Tipo cuota |
2 (opcional) |
Campo correspondiente al tipo de cuota.
Depende si el comercio cuenta con el
producto cuotas contratado. Valores: 01 = cuota normal 03 = cuota contado 04 = n cuotas |
Separador de campo |
1 (opcional) |
valor ASCII: | valor hexadecimal: 0x7c
|
Número cuota |
2 (opcional) |
Campo correspondiente al número de cuota.
Depende si comercio cuenta con el
producto cuotas contratado. Valores; 02 = 2 cuotas 03 = 3 uotas xx = xx cuotas |
Separador de campo |
1 (opcional) |
valor ASCII: | valor hexadecimal: 0x7c
|
Monto cuota |
12 máximo (opcional) | Campo correspondiente al monto de cuota. Depende si comercio cuenta con el producto cuotas contratado. |
Separador de campo |
1 (opcional) |
valor ASCII: | valor hexadecimal: 0x7c
|
Glosa tipo cuota |
30 (máximo) | Campo correspondiente a la glosa del tipo de cuota. Depende si comercio cuenta con el producto cuotas contratado. |
<ETX> |
1 |
Indica el fin de texto o comando valor hexadecimal: 0x03
|
LRC |
1 | Resultado del calculo del LRC del mensaje |
Ejemplo
Requerimiento:
<STX>0200|10000||1|0<ETX><LRC>
Respuesta:
<STX>0210|00|597033311777|V1700005||395561|000010000|1679|
000054|CR|||VI|2610 2018|145117| COMPROBANTE DE VENTA CON PIN PAGO EN CUOTAS
TARJETA DE CREDITO Pruebas UX100 Desa Huerfanos 770 Piso 8
Santiago 597033311777-U18.1A1 FECHA HORA TERMINAL26/10/18
14:51:17 V1700005 NUMERO DE TARJETA B-VI************1679
TOTAL: $ 10.000NUMERO DE CUOTAS: 02TIPO DE CUOTAS: CUOTAS
SIN INTERESVALOR CUOTA 1: $ 5.000VALOR CUOTA 2: $ 5.000NUMERO DE
BOLETA: NUMERO DE OPERACION: 000054CODIGO DE AUTORIZACION:
395561 GRACIAS POR SU COMPRA ACEPTO PAGAR SEGÚN
CONTRATO CON EMISOR |01|03|5000|CUOTAS SIN INTERES
<ETX><LRC>
Mensaje de venta multicódigo
Este comando es enviado por la caja para solicitar la ejecución de una venta para los distintos códigos de comercio asociados en el POS. Solo los códigos de comercios virtuales o hijos pueden realizar ventas, el código de comercio del POS es distinto y no puede realizar ventas. Los siguientes parámetros deben ser enviados desde la caja:
Monto
: Monto en pesos informados al POS. Este parámetro es remitido a Transbank para realizar la autorización.Número Ticket/Boleta
: Número de la operación de venta.Campo Impresión
: Indica si el POS debe devolver un voucher formateado.Enviar Mensaje
: Indica al POS si debe enviar a la caja mensajes de estatus de la transacción mientras se realiza la venta.Comercio prestador
: Código de comercio que ejecutará la venta.
import cl.transbank.pos.POSAutoservicio;
import cl.transbank.pos.responses.autoservicio.*;
POSAutoservicio pos = new POSAutoservicio();
MultiCodeSaleResponse response = pos.multiCodeSale(amount, ticket, commerceCode, true, true);
using Transbank.POSAutoservicio;
using Transbank.Responses.CommonResponse;
using Transbank.Responses.AutoservicioResponse;
Task<MultiCodeSaleResponse> response = POSAutoservicio.Instance.MultiCodeSale(amount, ticket, commerceCode, true, true);
// No Disponible
Solicitud de Venta Multicódigo
| DATO | LARGO | Comentario |
|---|---|---|
<STX> |
1 |
Indica el inicio de texto o comando valor hexadecimal: 0x02
|
Comando |
4 |
valor ASCII: 0270 valor hexadecimal: 0x30 0x32 0x37 0x30
|
Separador de campo |
1 |
valor ASCII: | valor hexadecimal: 0x7c
|
Monto |
9 | Valor numérico que debe ser convertido a hexadecimal. |
Separador de campo |
1 |
valor ASCII: | valor hexadecimal: 0x7c
|
Número de ticket / boleta |
20 | Valor ASCII, Número de boleta o ticket, que debe ser convertido a hexadecimal |
Separador de campo |
1 |
valor ASCII: | valor hexadecimal: 0x7c
|
Campo impresión |
1 | Indica si entrega voucher formateado 1 = Sí, 0 = No |
Separador de campo |
1 |
valor ASCII: | valor hexadecimal: 0x7c
|
Enviar mensajes |
1 |
Indica al POS si debe enviar mensajes intermedios o de estado de la transacción 1: Envía Mensajes 0: No envía mensajes |
Separador de campo |
1 |
valor ASCII: | valor hexadecimal: 0x7c
|
Comercio prestador |
12 | Valor que indica el código de comercio del prestador |
<ETX> |
1 |
Indica el fin de texto o comando valor hexadecimal: 0x03 .
|
LRC |
1 | Resultado del calculo del LRC del mensaje. |
Respuesta
| DATO | LARGO | COMENTARIO |
|---|---|---|
<STX> |
1 |
Indica inicio de texto o comando valor hexadecimal: 0x02
|
Comando |
4 |
Valor ASCII: 0271 valor hexadecimal: 0x30 0x32 0x37 0x31
|
Separador de campo |
1 |
valor ASCII: | valor hexadecimal: 0x7c
|
Código Respuesta |
2 | Valor Numérico |
Separador de campo |
1 |
valor ASCII: | valor hexadecimal: 0x7c
|
Código de comercio |
12 | Valor Numérico |
Separador de campo |
1 |
valor ASCII: | valor hexadecimal: 0x7c
|
Terminal ID |
8 | Valor Alfanumérico |
Separador de campo |
1 |
valor ASCII: | valor hexadecimal: 0x7c
|
Número de ticket / boleta |
20 | Valor Alfanumérico |
Separador de campo |
1 |
valor ASCII: | valor hexadecimal: 0x7c
|
Código de Autorización |
6 | Valor Alfanumérico (opcional) |
Separador de campo |
1 |
valor ASCII: | valor hexadecimal: 0x7c
|
Monto |
9 | Valor Numérico |
Separador de campo |
1 |
valor ASCII: | valor hexadecimal: 0x7c
|
Últimos 4 dígitos tarjeta |
4 | Valor Numérico |
Separador de campo |
1 |
valor ASCII: | valor hexadecimal: 0x7c
|
Número de operación |
6 | Correl |
Separador de campo |
1 |
valor ASCII: | valor hexadecimal: 0x7c
|
Tipo de Tarjeta |
2 |
CR: Crédito DB: Débito |
Separador de campo |
1 |
valor ASCII: | valor hexadecimal: 0x7c
|
Fecha Contable |
6 | Valor ASCII. Se utiliza si es tarjeta de débito |
Separador de campo |
1 |
valor ASCII: | valor hexadecimal: 0x7c
|
Número de cuenta |
19 | Valor ASCII. Se utiliza si es tarjeta de débito |
Separador de campo |
1 |
valor ASCII: | valor hexadecimal: 0x7c
|
Abreviación tarjeta |
2 | Ejemplo: VI=VISA, MC=Mastercard |
Separador de campo |
1 |
valor ASCII: | valor hexadecimal: 0x7c
|
Fecha transacción |
8 | Formato: DDMMAAAA |
Separador de campo |
1 |
valor ASCII: | valor hexadecimal: 0x7c
|
Hora transacción |
6 | Formato: HHMMSS |
Separador de campo |
1 |
valor ASCII: | valor hexadecimal: 0x7c
|
Comercio Prestador |
12 | Valor que indica el código de comercio del prestador |
Separador de campo |
1 (opcional) |
valor ASCII: | valor hexadecimal: 0x7c
|
Campo impresión |
Variable (opcional) | Campo depende si la caja requiere voucher formateado |
Separador de campo |
1 (opcional) |
valor ASCII: | valor hexadecimal: 0x7c
|
Tipo cuota |
2 (opcional) |
Campo correspondiente al tipo de cuota.
Depende si el comercio cuenta con el
producto cuotas contratado. Valores: 01 = cuota normal 03 = cuota contado 04 = n cuotas |
Separador de campo |
1 (opcional) |
valor ASCII: | valor hexadecimal: 0x7c
|
Número cuota |
2 (opcional) |
Campo correspondiente al número de cuota.
Depende si comercio cuenta con el
producto cuotas contratado. Valores; 02 = 2 cuotas 03 = 3 uotas xx = xx cuotas |
Separador de campo |
1 (opcional) |
valor ASCII: | valor hexadecimal: 0x7c
|
Monto cuota |
12 máximo (opcional) | Campo correspondiente al monto de cuota. Depende si comercio cuenta con el producto cuotas contratado. |
Separador de campo |
1 (opcional) |
valor ASCII: | valor hexadecimal: 0x7c
|
Glosa tipo cuota |
30 (máximo) | Campo correspondiente a la glosa del tipo de cuota. Depende si comercio cuenta con el producto cuotas contratado. |
<ETX> |
1 |
Indica el fin de texto o comando valor hexadecimal: 0x03
|
LRC |
1 | Resultado del calculo del LRC del mensaje |
Ejemplo
Requerimiento:
<STX>0270|25000|123456|1|0|597001600402<ETX><LRC>
Respuesta:
<STX>0271|00|597001600402|653UX003|123456|831679|
000026001|2383|000039|CR||| AX|25112020|145014|597001600403|
****************************************
AVISO DE PREMIO ****************************************
PRUEBA TITULO LARGO 597001600403 25/11/2020
PEL3DTHMONTO FELICITACIONES
USTED SE HA GANADO XYX H2H PEL 3 -
PREMIO COMIENZA Y TERMINA CON - PEL 3 H2H XYX
EQUIVALENTES A : 1500 CODIGO DEL PREMIO 831679-
00014340 ESTE VALOR SERA ABONADO EN
SU ESTADO DE CUENTA SIGUIENTE O SUBSIGUIENTE
COMPROBANTE DE VENTA PAGO EN CUOTAS TARJETA DE CREDITO
PRUEBA TITULO LARGO Multicomercio Paraiso Springfield
597001600402-U20.1V1 597001600403 FECHA HORA
TERMINAL25/11/20 14:50:14 653UX003 NUMERO DE TARJETA
C-AX***********2383 AMEX A000000025010402TOTAL: $
26.001NUMERO DE CUOTAS : 06TIPO DE CUOTAS : CUOTAS SIN INTERESMONTO
CUOTA : $ 4.336TASA INTERES : 0,00%NUMERO DE BOLETA:
123456NUMERO DE OPERACION: 000039CODIGO DE AUTORIZACION: 831679
GRACIAS POR SU COMPRA ACEPTO PAGAR SEGÚN CONTRATO CON EMISOR
TRANSACCION PREMIADA CODIGO DEL PREMIO :00014340
|04|06|4336|CUOTAS SIN INTERES
<ETX><LRC>
Mensaje de Última Venta
Comando enviado por la caja solicitando al POS los datos de la última venta guardada en memoria, teniendo como dato relevante en la respuesta el número de ticket o boleta.
Este comando debe ser utilizado por la caja para el caso en que no recibe respuesta al comando de venta, y validará el campo ticket o boleta contra el número de ticket asignado al cobro de la transacción, en caso que los números comparados sean distintos, la caja debe reintentar el cobro ejecutando nuevamente de la transacción de venta, para el caso en que coinciden, significa que el cobro ya fue realizado.
import cl.transbank.pos.POSAutoservicio;
import cl.transbank.pos.responses.autoservicio.*;
POSAutoservicio pos = new POSAutoservicio();
LastSaleResponse lastSaleResponse = pos.lastSale();
using Transbank.POSAutoservicio;
using Transbank.Responses.AutoservicioResponse;
Task<LastSaleResponse> response = POSAutoservicio.Instance.LastSale();
POS.getLastSale().then( (response) => {
console.log('getLastSale ejecutado. Respuesta: ', response);
}).catch( (err) => {
console.log('Ocurrió un error inesperado', err);
});
{
"Function": 260,
"ResponseCode": 0,
"ResponseMessage": "Aprobado",
"Commerce Code": 550062700310,
"Terminal Id": "ABC1234C",
"Ticket": "AB123",
"Authorization Code": "XZ123456",
"Amount": 15000,
"Last 4 Digits": 6677,
"Operation Number": 60,
"Card Type": "CR",
"Accounting Date": "28/10/2019 22:35:12",
"Account Number": "300000000",
"Card Brand": "AX",
"Real Date": "28/10/2019 22:35:12",
"Printing Field": List<string>,
"Shares Type": 3,
"Shares Number": 3,
"Shares Amount": 5000,
"Shares Type Gloss": " "
}
![Diagrama de Secuencia Última Venta](https://www.transbankdevelopers.cl/public/slate-library/images/referencia/posautoservicio/diagrama-ultima-venta.png)
-
La caja envía el requerimiento y espera como respuesta
<ACK>
. Si recibe un<ACK>
la caja debe esperar la respuesta del POS, en caso de recibir un<NAK>
debe reintentar enviando el comando 2 veces. -
Una vez recibida la respuesta, la caja calcula el
<LRC>
(especificado más adelante en el protocolo de comunicación) del mensaje y lo compara con el recibido, si coinciden la caja envía un<ACK>
al POS dando por finalizado el comando, en caso contrario envía un<NAK>
, y vuelve a esperar la respuesta del POS.
Solicitud de Última venta
| DATO | LARGO | Comentario |
|---|---|---|
<STX> |
1 |
Indica el inicio de texto o comando valor hexadecimal: 0x02
|
Comando |
4 |
valor ASCII: 0250 valor hexadecimal: 0x30 0x32 0x35 0x30
|
Separador de campo |
1 |
valor ASCII: | valor hexadecimal: 0x7c
|
Campo impresión |
1 | Indica si entrega voucher formateado 1 = Sí, 0 = No |
<ETX> |
1 |
Indica el fin de texto o comando valor hexadecimal: 0x03 .
|
LRC |
1 | Resultado del calculo del LRC del mensaje. |
Respuesta
| DATO | LARGO | COMENTARIO |
|---|---|---|
<STX> |
1 |
Indica inicio de texto o comando valor hexadecimal: 0x02
|
Comando |
4 |
Valor ASCII: 0260 valor hexadecimal: 0x30 0x32 0x36 0x30
|
Separador de campo |
1 |
valor ASCII: | valor hexadecimal: 0x7c
|
Código Respuesta |
2 | Valor Numérico |
Separador de campo |
1 |
valor ASCII: | valor hexadecimal: 0x7c
|
Código de comercio |
12 | Valor Numérico |
Separador de campo |
1 |
valor ASCII: | valor hexadecimal: 0x7c
|
Terminal ID |
8 | Valor Alfanumérico |
Separador de campo |
1 |
valor ASCII: | valor hexadecimal: 0x7c
|
Número de ticket / boleta |
20 | Valor Alfanumérico |
Separador de campo |
1 |
valor ASCII: | valor hexadecimal: 0x7c
|
Código de Autorización |
6 | Valor Alfanumérico (opcional) |
Separador de campo |
1 |
valor ASCII: | valor hexadecimal: 0x7c
|
Monto |
9 | Valor Numérico |
Separador de campo |
1 |
valor ASCII: | valor hexadecimal: 0x7c
|
Últimos 4 dígitos tarjeta |
4 | Valor Numérico |
Separador de campo |
1 |
valor ASCII: | valor hexadecimal: 0x7c
|
Número de operación |
6 | Correl |
Separador de campo |
1 |
valor ASCII: | valor hexadecimal: 0x7c
|
Tipo de Tarjeta |
2 |
CR: Crédito DB: Débito |
Separador de campo |
1 |
valor ASCII: | valor hexadecimal: 0x7c
|
Fecha Contable |
6 | Valor ASCII. Se utiliza si es tarjeta de débito |
Separador de campo |
1 |
valor ASCII: | valor hexadecimal: 0x7c
|
Número de cuenta |
19 | Valor ASCII. Se utiliza si es tarjeta de débito |
Separador de campo |
1 |
valor ASCII: | valor hexadecimal: 0x7c
|
Abreviación tarjeta |
2 | Ejemplo: VI=VISA, MC=Mastercard |
Separador de campo |
1 |
valor ASCII: | valor hexadecimal: 0x7c
|
Fecha transacción |
8 | Formato: DDMMAAAA |
Separador de campo |
1 |
valor ASCII: | valor hexadecimal: 0x7c
|
Hora transacción |
6 | Formato: HHMMSS |
Separador de campo |
1 (opcional) |
valor ASCII: | valor hexadecimal: 0x7c
|
Campo impresión |
Variable (opcional) | Campo depende si la caja requiere voucher formateado |
Separador de campo |
1 (opcional) |
valor ASCII: | valor hexadecimal: 0x7c
|
Tipo cuota |
2 (opcional) |
Campo correspondiente al tipo de cuota.
Depende si el comercio cuenta con el
producto cuotas contratado. Valores: 01 = cuota normal 03 = cuota contado 04 = n cuotas |
Separador de campo |
1 (opcional) |
valor ASCII: | valor hexadecimal: 0x7c
|
Número cuota |
2 (opcional) |
Campo correspondiente al número de cuota.
Depende si comercio cuenta con el
producto cuotas contratado. Valores; 02 = 2 cuotas 03 = 3 uotas xx = xx cuotas |
Separador de campo |
1 (opcional) |
valor ASCII: | valor hexadecimal: 0x7c
|
Monto cuota |
12 máximo (opcional) | Campo correspondiente al monto de cuota. Depende si comercio cuenta con el producto cuotas contratado. |
Separador de campo |
1 (opcional) |
valor ASCII: | valor hexadecimal: 0x7c
|
Glosa tipo cuota |
30 (máximo) | Campo correspondiente a la glosa del tipo de cuota. Depende si comercio cuenta con el producto cuotas contratado. |
<ETX> |
1 |
Indica el fin de texto o comando valor hexadecimal: 0x03
|
<LRC> |
1 | Resultado del calculo del LRC del mensaje |
Ejemplo
Requerimiento:
<STX>0250|1<ETX><LRC>
Respuesta:
<STX>0260|00|597033311777|V1700005||389169|000005360|1679|000055|
CR|||VI|2610 2018|145255| COMPROBANTE DE VENTA CON PIN TARJETA DE CREDITO
Pruebas UX100 Desa Huerfanos 770 Piso 8 Santiago
597033311777-U18.1A1 *** DUPLICADO *** FECHA HORA
TERMINAL26/10/18 14:52:55 V1700005 NUMERO DE TARJETA
B-VI************1679 TOTAL: $ 5.360NUMERO DE BOLETA:
NUMERO DE OPERACION: 000055CODIGO DE AUTORIZACION: 389169
GRACIAS POR SU COMPRA ACEPTO PAGAR SEGÚN CONTRATO CON EMISOR
|00|00||<ETX><LRC>
Mensaje de Cierre
Esta es una transacción administrativa que se debe ejecutar diariamente o como mínimo una vez a la semana. Esta transacción es gatillada por la caja, y no recibe parámetros, el POS ejecuta la transacción de cierre contra la caja, enviando como parámetro el tipo de impresión (0=Parámetros de impresión, 1=voucher formateado). Como respuesta a la caja se enviará un aprobado o rechazado, y los datos de impresión del voucher para el caso en que fuera aprobado.
import cl.transbank.pos.POSAutoservicio;
import cl.transbank.pos.responses.autoservicio.*;
POSAutoservicio pos = new POSAutoservicio();
CloseResponse response = pos.close();
using Transbank.POSAutoservicio;
using Transbank.Responses.AutoservicioResponse;
Task<CloseResponse> response = POSAutoservicio.Instance.Close();
pos.closeDay().then( (response) => {
console.log('closeDay ejecutado. Respuesta: ', response);
}).catch( (err) => {
console.log('Ocurrió un error inesperado', err);
});
{
"FunctionCode": 510,
"ResponseCode": 0,
"ResponseMessage": "Aprobado",
"Success": true,
"CommerceCode": 550062700310,
"TerminalId": "ABC1234C",
"Printing Field": List<string>
}
![Diagrama de Cierre](https://www.transbankdevelopers.cl/public/slate-library/images/referencia/posautoservicio/diagrama-cierre.png)
-
La caja envía el requerimiento y espera como respuesta
<ACK>
/<NAK>
, en caso de que llegue un<NAK>
, debe reintentar el envío del requerimiento 2 veces. Si recibe un<ACK>
debe esperar la respuesta de la transacción. - El POS envía requerimiento al Autorizador, en caso de ser aprobada, se ejecuta un reinicio del contador de transacciones en el autorizador y se envía respuesta a la caja. En caso de ser rechazada se envía respuesta a la caja indicando el estado del rechazo.
- La caja al recibir la respuesta envía un
<ACK>
al POS si el mensaje está correcto, o un<NAK>
para el caso en que elLRC
no corresponde. - El POS al recibir el
<ACK>
vuelve al inicio a esperar un nuevo comando, para el caso que recibe un<NAK>
vuelve a enviar la respuesta 2 veces más.
Solicitud de cierre
| DATO | LARGO | Comentario |
|---|---|---|
<STX> |
1 |
Indica el inicio de texto o comando Valor hexadecimal: 0x02
|
Comando |
4 |
Valor ASCII: 0500 Valor hexadecimal: 0x30 0x35 0x30 0x30
|
Separador de campo |
1 |
Valor ASCII: | Valor hexadecimal: 0x7c
|
Campo impresión |
1 | Indica si entrega voucher formateado |
<ETX> |
1 |
Indica el fin de texto o comando Valor hexadecimal: 0x03
|
<LRC> |
1 | Resultado del cálculo del LRC del mensaje |
Respuesta
| DATO | LARGO | COMENTARIO |
|---|---|---|
<STX> |
1 |
Indica inicio de texto o comando Valor hexadecimal: 0x02
|
Comando |
4 |
Valor ASCII: 0510 Valor hexadecimal: 0x30 0x35 0x31 0x30
|
Separador de campo |
1 |
Valor ASCII: | Valor hexadecimal: 0x7c
|
Código Respuesta |
2 | Valor Numérico |
Separador de campo |
1 |
Valor ASCII: | Valor hexadecimal: 0x7c
|
Código de comercio |
12 | Valor Numérico |
Separador de campo |
1 |
Valor ASCII: | Valor hexadecimal: 0x7c
|
Terminal ID |
8 | Valor Alfanumérico |
Separador de campo |
1 |
Valor ASCII: | Valor hexadecimal: 0x7c
|
Campo Impresión |
Variable (opcional) | Campo depende si la caja requiere voucher formateado |
<ETX> |
1 |
Indica el fin de texto o comando Valor hexadecimal: 0x03
|
<LRC> |
1 | Resultado del cálculo del LRC del mensaje |
Ejemplo
Requerimiento:
<STX>0500|0<ETX><LRC>
Respuesta:
<STX>0510|00|597029414300|70000537<ETX><LRC>
Mensaje de Carga de Llaves
Esta transacción permite al Aplicativo de caja del comercio requerir y cargar nuevas llaves Working Key, desde Transbank. Su uso debe ser limitado como prueba de comunicación IP para validar conectividad hacia el exterior.
import cl.transbank.pos.POSAutoservicio;
import cl.transbank.pos.responses.common.*;
POSAutoservicio pos = new POSAutoservicio();
LoadKeysResponse response = pos.loadKeys();
using Transbank.POSAutoservicio;
using Transbank.Responses.CommonResponses;
Task<LoadKeysResponse> response = POSAutoservicio.Instance.LoadKeys();
pos.loadKeys().then( (response) => {
console.log('loadKeys ejecutado. Respuesta: ', response);
}).catch( (err) => {
console.log('Ocurrió un error inesperado', err);
});
{
"FunctionCode": 810,
"ResponseCode": 0,
"ResponseMessage": "Aprobado",
"Success": true,
"Commerce Code": 550062700310,
"Terminal Id": "ABC1234C"
}
![Diagrama de Carga de Llaves](https://www.transbankdevelopers.cl/public/slate-library/images/referencia/posautoservicio/diagrama-carga-llaves.png)
-
La caja envía el requerimiento y espera como respuesta
<ACK>
/<NAK>
, en caso de que llegue un<NAK>
, debe reintentar el envío del requerimiento 2 veces. Si recibe un<ACK>
debe esperar la respuesta de la transacción. - El POS envía requerimiento al Autorizador. En caso de ser aprobada se guarda nueva llave y se envía respuesta a la caja. En caso de ser rechazada se envía respuesta a la caja indicando el estado de rechazo.
-
La caja al recibir la respuesta envía un
<ACK>
al POS si el mensaje está correcto, o un<NAK>
para el caso en que el<LRC>
no corresponda. -
El POS al recibir el
<ACK>
desde la caja vuelve al inicio a esperar un nuevo comando, para el caso que recibe un<NAK>
vuelve a enviar la respuesta 2 veces más.
Solicitud de Carga de Llaves
| DATO | LARGO | Comentario |
|---|---|---|
<STX> |
1 |
Indica el inicio de texto o comando Valor hexadecimal: 0x02
|
Comando |
4 |
Valor ASCII: 0800 Valor hexadecimal: 0x30 0x38 0x30 0x30
|
<ETX> |
1 |
Indica el fin de texto o comando Valor hexadecimal: 0x03
|
<LRC> |
1 | Resultado del cálculo del LRC del mensaje |
Respuesta
| DATO | LARGO | COMENTARIO |
|---|---|---|
<STX> |
1 |
Indica inicio de texto o comando Valor hexadecimal: 0x02
|
Comando |
4 |
Valor ASCII: 0810 Valor hexadecimal: 0x30 0x38 0x31 0x30
|
Separador de campo |
1 |
Valor ASCII: | Valor hexadecimal: 0x7c
|
Código Respuesta |
2 | Valor Numérico |
Separador de campo |
1 |
Valor ASCII: | Valor hexadecimal: 0x7c
|
Código de comercio |
12 | Valor Numérico |
Separador de campo |
1 |
Valor ASCII: | Valor hexadecimal: 0x7c
|
Terminal ID |
8 | Valor Alfanumérico |
<ETX> |
1 |
Indica el fin de texto o comando Valor hexadecimal: 0x03
|
<LRC> |
1 | Resultado del cálculo del LRC del mensaje |
Ejemplo
Requerimiento:
<STX>0800<ETX><LRC>
Respuesta:
<STX>0810|00|597029414300|70000537<ETX><LRC>
Mensaje de Poll
Este mensaje es enviado por la caja para saber si el POS está conectado.
import cl.transbank.pos.POSAutoservicio;
POSAutoservicio pos = new POSAutoservicio();
boolean pollResult = pos.poll();
using Transbank.POSAutoservicio;
Task<bool> connected = POSAutoservicio.Instance.Poll();
pos.poll().then( (res) => {
console.log('Resultado ejecución: ', res);
}).catch( (err) => {
console.log('Ocurrió un error inesperado', err);
});
True
![Diagrama Poll](https://www.transbankdevelopers.cl/public/slate-library/images/referencia/posautoservicio/diagrama-poll.png)
-
La caja envía el requerimiento y espera como respuesta
<ACK>
. Si recibe un<ACK>
indica que el POS está funcionando y listo para recibir un comando. -
En caso de no recibir el
<ACK>
, indica existe algún tipo de problema con la comunicación entre la caja y el POS, y debe reintentar enviando el comando de POLLING al menos 3 veces.
Solicitud de poll
| DATO | LARGO | Comentario |
|---|---|---|
<STX> |
1 |
Indica el inicio de texto o comando Valor hexadecimal: 0x02
|
Comando |
4 |
Valor ASCII: 0100 Valor hexadecimal: 0x30 0x31 0x30 0x30
|
<ETX> |
1 |
Indica el fin de texto o comando Valor hexadecimal: 0x03
|
<LRC> |
1 | Resultado del cálculo del LRC del mensaje |
Respuesta
| DATO | LARGO | COMENTARIO |
|---|---|---|
<ACK> |
1 |
Comando recibido OK Valor hexadecimal: 0x06
|
Ejemplo
Requerimiento:
<STX>0100<ETX><LRC>
Respuesta:
<ACK>
Mensaje de Inicialización
Esta es una transacción administrativa que se utiliza para cargar los parámetros y aplicativo en el terminal de autoservicio de Transbank. Es usada por los técnicos al realizar la instalación de los equipos en el comercio. Previo a la ejecución de esta transacción, es necesario realizar una transacción de cierre. Debido a que la transacción de Inicialización tiene un tiempo superior a una venta normal y el tiempo en que el POS queda fuera de comunicación con la caja es variable, se dividió en 2 comandos:
- Transacción de Inicialización: Indica la acción.
- Respuesta de Inicialización: Utilizado para conocer el resultado de la acción.
Posterior a la ejecución del comando de Inicialización, el módulo de auto atención del comercio, enviará un comando
“Polling” para saber si el POS está activo o no. Una vez que se encuentre activo (enviando como
respuesta un <ACK>
) el módulo de auto atención enviará el comando: respuesta de Inicialización
donde se responderá si la acción fue exitosa o no. En caso de que la inicialización no fuera exitosa el
POS podrá seguir realizando ventas sin los parámetros actualizados.
-
La caja envía el requerimiento y espera como respuesta
<ACK>
/<NAK>
, en caso de que llegue un<NAK>
, debe reintentar el envío del requerimiento 2 veces. Si recibe un<ACK>
debe esperar la respuesta de la transacción. - El POS envía requerimiento al Autorizador. En caso de ser aprobada se guarda nueva llave y se envía respuesta a la caja. En caso de ser rechazada se envía respuesta a la caja indicando el estado de rechazo.
-
La caja al recibir la respuesta envía un
<ACK>
al POS si el mensaje está correcto, o un<NAK>
para el caso en que el<LRC>
no corresponda. -
El POS al recibir el
<ACK>
desde la caja vuelve al inicio a esperar un nuevo comando, para el caso que recibe un<NAK>
vuelve a enviar la respuesta 2 veces más.
Transacción de inicialización
import cl.transbank.pos.POSAutoservicio;
POSAutoservicio pos = new POSAutoservicio();
boolean pollResult = pos.initialization();
Transacción de inicialización
using Transbank.POSAutoservicio;
Task<bool> initialized = POSAutoservicio.Instance.Initialization();
Transacción de inicialización
pos.initialization().then( (res) => {
console.log('Resultado ejecución: ', res);
}).catch( (err) => {
console.log('Ocurrió un error inesperado', err);
});
Solicitud de inicialización
| DATO | LARGO | Comentario |
|---|---|---|
<STX> |
1 |
Indica el inicio de texto o comando Valor hexadecimal: 0x02
|
Comando |
4 |
Valor ASCII: 0070 Valor hexadecimal: 0x30 0x30 0x37 0x30
|
<ETX> |
1 |
Indica el fin de texto o comando Valor hexadecimal: 0x03
|
<LRC> |
1 | Resultado del cálculo del LRC del mensaje |
Respuesta
| DATO | LARGO | COMENTARIO |
|---|---|---|
<ACK> |
1 |
Comando recibido OK Valor hexadecimal: 0x06
|
Ejemplo
Requerimiento:
<STX>0070<ETX><LRC>
Respuesta:
<ACK>
Transacción de respuesta inicialización
import cl.transbank.pos.POSAutoservicio;
import cl.transbank.pos.responses.autoservicio.*;
POSAutoservicio pos = new POSAutoservicio();
InitializationResponse response = pos.initializationResponse();
Transacción de respuesta inicialización
using Transbank.POSAutoservicio;
using Transbank.Responses.AutoservicioResponse;
Task<InitializationResponse> response =
POSAutoservicio.Instance.InitializationResponse();
Transacción de respuesta inicialización
POS.initializationResponse().then( (res) => {
console.log('Resultado ejecución: ', res);
}).catch( (err) => {
console.log('Ocurrió un error inesperado', err);
});
{
"FunctionCode": 1080,
"ResponseCode": 0,
"ResponseMessage": "Aprobado",
"Success": true,
"Real Date": "28/10/2019 22:35:12"
}
Solicitud de respuesta de inicialización
| DATO | LARGO | Comentario |
|---|---|---|
<STX> |
1 |
Indica el inicio de texto o comando Valor hexadecimal: 0x02
|
Comando |
4 |
Valor ASCII: 0080 Valor hexadecimal: 0x30 0x30 0x38 0x30
|
<ETX> |
1 |
Indica el fin de texto o comando Valor hexadecimal: 0x03
|
<LRC> |
1 | Resultado del cálculo del LRC del mensaje |
Respuesta
| DATO | LARGO | COMENTARIO |
|---|---|---|
<STX> |
1 |
Indica inicio de texto o comando Valor hexadecimal: 0x02
|
Comando |
4 |
Valor ASCII: 1080 Valor hexadecimal: 0x31 0x30 0x38 0x30
|
Separador de campo |
1 |
Valor ASCII: | Valor hexadecimal: 0x7c
|
Código Respuesta |
2 | Valor Numérico |
Separador de campo |
1 |
Valor ASCII: | Valor hexadecimal: 0x7c
|
Fecha transacción |
8 | Formato: DDMMAAAA |
Separador de campo |
1 |
valor ASCII: | valor hexadecimal: 0x7c
|
Hora transacción |
6 | Formato: HHMMSS |
<ETX> |
1 |
Indica el fin de texto o comando Valor hexadecimal: 0x03
|
<LRC> |
1 | Resultado del cálculo del LRC del mensaje |
Ejemplo
Requerimiento:
<STX>0080<ETX><LRC>
Respuesta:
<STX>1080|90|27022016|120628<ETX><LRC>
Vouchers
Los voucher serán generados por el POS para los casos en que la caja lo indique en el comando de venta, así como también para los duplicados, anulaciones y cierres. Cada línea contendrá 40 caracteres, los que se concatenan en un solo buffer que será enviado en campo de impresión en la respuesta a transacciones de venta y cierre. La caja al recibir este buffer debe considerar que cada 40 caracteres conforman una línea de impresión. Con relación al largo del Voucher, este dependerá del tipo de transacción a imprimir.
Ejemplos
| Transacción Venta en Promoción | Reporte de Cierre del Terminal |
|---|---|
![]() |
![]() |
|
Caracteres máximos permitidos Ancho: 40 Largo: 29 |
Caracteres máximos permitidos Ancho: 40 Largo: 18 |
Tabla de Respuestas
| Respuesta | Código |
|---|---|
| Aprobado | 00 |
| Rechazado | 01 |
| Autorizador no Responde | 02 |
| Conexión Fallo | 03 |
| Transacción ya fue anulada | 04 |
| No existe transacción para anular | 05 |
| Tarjeta no soportada | 06 |
| Transacción cancelada | 07 |
| No puede Anular Transacción Débito | 08 |
| Error Lectura Tarjeta | 09 |
| Monto menor al mínimo permitido | 10 |
| No existe venta | 11 |
| Transacción No Soportada | 12 |
| Debe ejecutar cierre | 13 |
| Error Encriptando PAN (BCYCLE) | 14 |
| Error Operando con Débito (BCYCLE) | 15 |
| Solicitando Conformar Monto | 80 |
| Solicitando Ingreso de Clave | 81 |
| Enviando transacción al Autorizador | 82 |
| Selección menú crédito/redcompra | 83 |
| Opere tarjeta | 84 |
| Selección de cuotas | 85 |
| Ingreso de cuotas | 86 |
| Confirmación de cuotas | 87 |
| Aceptar consulta cuotas | 88 |
| Opción mes de gracia | 89 |
| Inicialización Exitosa | 90 |
| Inicialización Fallida | 91 |
| Lector no Conectado | 92 |
| Consultando cuota al Autorizador | 93 |
Toda transacción cuyo código de respuesta sea distinto de '0' será considerada como un rechazo. Por secreto bancario, el detalle de la causa del rechazo no será entregado al comercio.

# referencia_transaccion-completa.md

Source: https://www.transbankdevelopers.cl/referencia/transaccion-completa

Transacción Completa
Ambientes y Credenciales
La API REST de Webpay está protegida para garantizar que solamente comercios autorizados por Transbank hagan uso de las operaciones disponibles. La seguridad esta implementada mediante los siguientes mecanismos:
- Canal seguro a través de TLSv1.2 para la comunicación del cliente con Webpay.
- Autenticación y autorización mediante el intercambio de headers
Tbk-Api-Key-Id
(código de comercio) yTbk-Api-Key-Secret
(llave secreta).
Ambiente de Producción
Las URLs de endpoints de producción están alojados dentro de
[https://webpay3g.transbank.cl/](https://webpay3g.transbank.cl/).
// Host: https://webpay3g.transbank.cl
// Host: https://webpay3g.transbank.cl
// Host: https://webpay3g.transbank.cl
# Host: https://webpay3g.transbank.cl
# Host: https://webpay3g.transbank.cl
Host: https://webpay3g.transbank.cl
// Host: https://webpay3g.transbank.cl
Ambiente de Integración
Las URLs de endpoints de integración están alojados dentro de
[https://webpay3gint.transbank.cl/](https://webpay3gint.transbank.cl/).
// Host: https://webpay3gint.transbank.cl
// Host: https://webpay3gint.transbank.cl
// Host: https://webpay3gint.transbank.cl
# Host: https://webpay3gint.transbank.cl
# Host: https://webpay3g.transbank.cl
Host: https://webpay3gint.transbank.cl
// Host: https://webpay3gint.transbank.cl
Tarjetas y usuarios de prueba
Consulta [la documentación para conocer las tarjetas de prueba que funcionan en
el ambiente de integración](https://www.transbankdevelopers.cl/documentacion/como_empezar#ambientes).
Credenciales del Comercio
// Tbk-Api-Key-Id: Código de comercio
// Tbk-Api-Key-Secret: Llave secreta
// Content-Type: application/json
// Tbk-Api-Key-Id: Código de comercio
// Tbk-Api-Key-Secret: Llave secreta
// Content-Type: application/json
// Tbk-Api-Key-Id: Código de comercio
// Tbk-Api-Key-Secret: Llave secreta
// Content-Type: application/json
# Tbk-Api-Key-Id: Código de comercio
# Tbk-Api-Key-Secret: Llave secreta
# Content-Type: application/json
# Tbk-Api-Key-Id: Código de comercio
# Tbk-Api-Key-Secret: Llave secreta
# Content-Type: application/json
Tbk-Api-Key-Id: Código de comercio
Tbk-Api-Key-Secret: Llave secreta
Content-Type: application/json
// Tbk-Api-Key-Id: Código de comercio
// Tbk-Api-Key-Secret: Llave secreta
// Content-Type: application/json
Todas las peticiones que hagas deben incluir el código de comercio y la llave secreta entregada por Transbank, actuando ambas como las credenciales que autorizan distintas operaciones.
Códigos de comercio
En la documentación puedes revisar [todos los códigos de comercio](https://www.transbankdevelopers.cl/documentacion/como_empezar#codigos-de-comercio) del ambiente de integración
Los SDKs ya incluyen esos códigos de comercio y llaves secretas que funcionan en el ambiente de integración, por lo que puedes obtener rápidamente una configuración lista para hacer tus primeras pruebas en dicho ambiente.
Transacción Completa
Crear una Transacción Completa
Puedes revisar más detalles de esta operación en [su documentación](https://www.transbankdevelopers.cl/documentacion/transaccion-completa#crear-una-transaccion)
Para crear una transacción completa basta llamar al método Transaction.create()
Transaction.create()
Permite inicializar una transacción completa en Webpay. Como respuesta a la invocación se genera un token que representa en forma única una transacción.
FullTransaction tx = new FullTransaction(new WebpayOptions(IntegrationCommerceCodes.TRANSACCION_COMPLETA, IntegrationApiKeys.WEBPAY, IntegrationType.TEST));
FullTransactionCreateResponse response = tx.create(buyOrder, sessionId, amount, cvv, cardNumber, cardExpirationDate);
$option = new Options($apiKey, $commerceCode, Options::ENVIRONMENT_PRODUCTION);
$transaction = new Transaction($option);
$response = $transaction->create(
$buy_order,
$session_id,
$amount,
$cvv,
$card_number,
$card_expiration_date
);
var tx = new FullTransaction(new Options(IntegrationCommerceCodes.TRANSACCION_COMPLETA, IntegrationApiKeys.WEBPAY, IntegrationType.TEST));
var response = tx.Create(
buyOrder: buy_order,
sessionId: session_id,
amount: amount,
cvv: cvv,
cardNumber: card_number,
cardExpirationDate: card_expiration_date);
@options = Transbank::Webpay::Options.new("commerceCode", "APIKey", :integration)
@transaction = Transbank::Webpay::TransaccionCompleta::Transaction.new(@options)
@resp = @transaction.create(buy_order: @buy_order, session_id: @session_id, amount: @amount, cvv: @cvv, card_number: @card_number, card_expiration_date: @card_expiration_date)
tx = Transaction(WebpayOptions(IntegrationCommerceCodes.TRANSACCION_COMPLETA, IntegrationApiKeys.WEBPAY, IntegrationType.TEST))
resp = tx.create(
buy_order: buy_order, session_id: session_id, amount: amount, cvv: cvv,
card_number: card_number, card_expiration_date: card_expiration_date
)
POST /rswebpaytransaction/api/webpay/v1.2/transactions
Tbk-Api-Key-Id: 597055555530
Tbk-Api-Key-Secret: 579B532A7440BB0C9079DED94D31EA1615BACEB56610332264630D42D0A36B1C
Content-Type: application/json
{
"buy_order": "ordenCompra12345678",
"session_id": "sesion1234564",
"amount": 10000,
"cvv": 123,
"card_number": "4239000000000000",
"card_expiration_date": "22/10"
}
const tx = new TransaccionCompleta.Transaction(
new Options(
IntegrationCommerceCodes.TRANSACCION_COMPLETA,
IntegrationApiKeys.WEBPAY,
Environment.Integration
)
);
const response = await tx.create(
buyOrder,
sessionId,
amount,
cvv,
cardNumber,
cardExpirationDate
);
Parámetros Transaction.create
| Nombre tipo |
Descripción |
|---|---|
| buy_order String |
Orden de compra de la tienda. Este número debe ser único para cada transacción. Largo máximo: 26. La orden de compra puede tener: Números, letras, mayúsculas y minúsculas, y los signos |_=&%.,~:/?[+!@()>- .Los caracteres con signos no están soportados, como los acentos o signos no especificados. |
| session_id String |
Identificador de sesión, uso interno de comercio, este valor es devuelto al final de la transacción. Largo máximo: 61 |
| amount Decimal |
Monto de la transacción. Máximo 2 decimales para USD. Largo máximo: 17 |
| cvv String |
(Opcional) Código que se utiliza como método de seguridad en transacciones en las que la tarjeta no está físicamente presente. Largo máximo: 4. No se debe enviar para comercios con la opción sin cvv habilitada. |
| card_number String |
Número de tarjeta. Largo máximo: 16 |
| card_expiration_date String |
Fecha de expiración de la tarjeta con la que se realiza la transacción. Largo máximo: 5 |
Respuesta Transaction.create
response.getToken();
$response->getToken();
response.Token;
response.token
## Versión 3.x del SDK
response['token']
## Versión 2.x del SDK
response.token
200 OK
Content-Type: application/json
{
"token": "e074d38c628122c63e5c0986368ece22974d6fee1440617d85873b7b4efa48a3",
}
response.token
| Nombre tipo |
Descripción |
|---|---|
| token String |
Token de la transacción. Largo: 64. |
Modalidad sin cvv
Para modalidad del producto Transacción completa sin CVV
, este campo no debe ser enviado.
200 OK
Content-Type: application/json
{
"buy_order": "ordenCompra12345678",
"session_id": "sesion1234564",
"amount": 10000,
"card_number": "4239000000000000",
"card_expiration_date": "22/10"
}
Consulta de cuotas
Para consultar el valor de las cuotas que pagará el tarjeta habiente en una
transacción completa, es necesario llamar al método Transaction.installments()
Transaction.installments()
Operación que permite obtener el monto de la cuota a partir del número de cuotas. El id de la consulta que selecciona el tarjetahabiente debe ser informado en la invocación de la confirmación.
FullTransaction tx = new FullTransaction(new WebpayOptions(IntegrationCommerceCodes.TRANSACCION_COMPLETA, IntegrationApiKeys.WEBPAY, IntegrationType.TEST));
final FullTransactionInstallmentResponse response = tx.installments(token, installmentsNumber);
$option = new Options($apiKey, $commerceCode, Options::ENVIRONMENT_PRODUCTION);
$transaction = new Transaction($option);
$response = $transaction->installments(
$token,
$installmentsNumber
);
var tx = new FullTransaction(new Options(IntegrationCommerceCodes.TRANSACCION_COMPLETA, IntegrationApiKeys.WEBPAY, IntegrationType.TEST));
var response = tx.Installments(
token,
installments_number);
@options = Transbank::Webpay::Options.new("commerceCode", "APIKey", :integration)
@transaction = Transbank::Webpay::TransaccionCompleta::Transaction.new(@options)
@resp = @transaction.installments(token: @token, installments_number: @installments_number )
tx = Transaction(WebpayOptions(IntegrationCommerceCodes.TRANSACCION_COMPLETA, IntegrationApiKeys.WEBPAY, IntegrationType.TEST))
resp = tx.installments(token=token, installments_number=installments_number)
const tx = new TransaccionCompleta.Transaction(
new Options(
IntegrationCommerceCodes.TRANSACCION_COMPLETA,
IntegrationApiKeys.WEBPAY,
Environment.Integration
)
);
const response = await tx.installments(token, installmentsNumber);
POST /rswebpaytransaction/api/webpay/v1.2/transactions/{token}/installments
Tbk-Api-Key-Id: 597055555530
Tbk-Api-Key-Secret: 579B532A7440BB0C9079DED94D31EA1615BACEB56610332264630D42D0A36B1C
Content-Type: application/json
{
"installments_number": 10
}
Parámetros Transaction.installments
| Nombre tipo |
Descripción |
|---|---|
| token String |
Token de la transacción. Largo: 64. (Se envía en la URL, no en el body) |
| installments_number Number |
Cantidad de cuotas. Largo máximo: 2 |
Respuesta Transaction.installments
response.getInstallmentsAmount();
response.getIdQueryInstallments();
DeferredPeriod deferredPeriod = response.getDeferredPeriods()[0];
deferredPeriod.getAmount();
deferredPeriod.getPeriod();
$response->getInstallmentsAmount();
$response->getIdQueryInstallments();
$response->getDeferredPeriods();
response.InstallmentsAmount;
respone.IdQueryInstallments;
response.DeferredPeriods;
response.installments_amount
response.id_query_installments
response.deferred_periods
## Versión 3.x del SDK
response['installments_amount']
response['id_query_installments']
response['deferred_periods']
## Versión 2.x del SDK
response.installments_amount
response.id_query_installments
response.deferred_periods
response.installments_amount
response.id_query_installments
response.deferred_periods
Si el comercio no tiene configurado periodos diferidos, la respuesta de deferred_periods
será []
:
200 OK
Content-Type: application/json
{
"installments_amount": 3334,
"id_query_installments": 11,
"deferred_periods": [
{
"amount": 1000,
"period": 1
}
]
}
| Nombre tipo |
Descripción |
|---|---|
| installments_amount String |
Monto de cada cuota. Largo: 17. |
| id_query_installments String |
Identificador de las cuotas. Largo: 19. |
| deferred_periods Array |
Arreglo con periodos diferidos. |
| deferred_periods [].amount String |
Monto. Largo: 17. |
| deferred_periods [].period String |
Índice de periodo. Largo: 2. |
Confirmación de la transacción
Una vez iniciada la transacción y consultado el monto de las cuotas, puedes
confirmar y obtener el resultado de una transacción completa usando el metodo
Transaction.commit()
.
Transaction.commit()
Operación que permite confirmar una transacción. Retorna el estado de la transacción.
FullTransaction tx = new FullTransaction(new WebpayOptions(IntegrationCommerceCodes.TRANSACCION_COMPLETA, IntegrationApiKeys.WEBPAY, IntegrationType.TEST));
final FullTransactionCommitResponse response = tx.commit(token, idQueryInstallments, deferredPeriodIndex, gracePeriod);
$option = new Options($apiKey, $commerceCode, Options::ENVIRONMENT_PRODUCTION);
$transaction = new Transaction($option);
$response = $transaction->commit(
$token,
$idQueryInstallments,
$deferredPeriodIndex,
$gracePeriod
);
var tx = new FullTransaction(new Options(IntegrationCommerceCodes.TRANSACCION_COMPLETA, IntegrationApiKeys.WEBPAY, IntegrationType.TEST));
var response = tx.Commit(token, idQueryInstallments, deferredPeriodsIndex, gracePeriods);
@options = Transbank::Webpay::Options.new("commerceCode", "APIKey", :integration)
@transaction = Transbank::Webpay::TransaccionCompleta::Transaction.new(@options)
@resp = @transaction.commit(
token: @token,
id_query_installments: @id_query_installments,
deferred_period_index: @deferred_period_index,
grace_period: @grace_period
)
tx = Transaction(WebpayOptions(IntegrationCommerceCodes.TRANSACCION_COMPLETA, IntegrationApiKeys.WEBPAY, IntegrationType.TEST))
resp = tx.commit(token=token,
id_query_installments=id_query_installments,
deferred_period_index=deferred_period_index,
grace_period=grace_period)
const tx = new TransaccionCompleta.Transaction(
new Options(
IntegrationCommerceCodes.TRANSACCION_COMPLETA,
IntegrationApiKeys.WEBPAY,
Environment.Integration
)
);
const response = await tx.commit(
token,
idQueryInstallments,
deferredPeriodIndex,
gracePeriod
);
PUT /rswebpaytransaction/api/webpay/v1.2/transactions/{token}
Tbk-Api-Key-Id: 597055555530
Tbk-Api-Key-Secret: 579B532A7440BB0C9079DED94D31EA1615BACEB56610332264630D42D0A36B1C
Content-Type: application/json
{
"id_query_installments": 15,
"deferred_period_index": 1,
"grace_period": false
}
Parámetros Transaction.commit
| Nombre tipo |
Descripción |
|---|---|
| token String |
Token de la transacción. Largo: 64. (Se envía en la URL, no en el body) |
| id_query_installments Number |
(Opcional) Identificador de cuota. Largo máximo: 19. Solo enviar si el pago es en cuotas |
| deferred_period_index Number |
(Opcional) Cantidad de periodo diferido. Largo máximo: 2. Solo enviar si el pago es en cuotas |
| grace_period Boolean |
(Opcional) Indicador de periodo de gracia. Solo enviar si el pago es en cuotas |
Respuesta Transaction.commit
response.getAccountingDate();
response.getAmount();
response.getAuthorizationCode();
response.getBuyOrder();
CardDetail cardDetail = response.getCardDetail();
cardDetail.getCardNumber();
response.getInstallmentsAmount();
response.getInstallmentsNumber();
response.getPaymentCodeType();
response.getResponseCode();
response.getSessionId();
response.getTransactionDate();
$response->getAccountingDate();
$response->getAmount();
$response->getAuthorizationCode();
$response->getBuyOrder();
$cardDetail = $response->getCardDetail();
$cardDetail->getCardNumber();
$response->getInstallmentsAmount();
$response->getInstallmentsNumber();
$response->getPaymentCodeType();
$response->getResponseCode();
$response->getSessionId();
$response->getTransactionDate();
response.AccountingDate;
response.Amount;
response.AuthorizationCoda;
response.BuyOrder;
var cardDetail = response.CardDetail;
cardDetail.CardNumber;
response.InstallmentsAmount;
response.InstallmentsNumber;
response.PaymentTypeCode;
response.ResponseCode;
response.SessionId;
response.Status;
response.TransactionDate;
response.amount
response.status
response.buy_order
response.session_id
response.card_number
response.accounting_date
response.transaction_date
response.authorization_code
response.payment_type_code
response.response_code
response.installments_number
response.installments_amount
response.balance
## Versión 3.x del SDK
response['amount']
response['status']
response['buy_order']
response['session_id']
response['card_number']
response['accounting_date']
response['transaction_date']
response['authorization_code']
response['payment_type_code']
response['response_code']
response['installments_number']
response['installments_amount']
response['balance']
## Versión 2.x del SDK
response.amount
response.status
response.buy_order
response.session_id
response.card_number
response.accounting_date
response.transaction_date
response.authorization_code
response.payment_type_code
response.response_code
response.installments_number
response.installments_amount
response.balance
200 OK
Content-Type: application/json
{
"amount": 10000,
"status": "AUTHORIZED",
"buy_order": "ordenCompra12345678",
"session_id": "sesion1234557545",
"card_detail": {
"card_number": "1234"
},
"accounting_date": "0320",
"transaction_date": "2019-03-20T20:18:20Z",
"authorization_code": "877550",
"payment_type_code": "VN",
"response_code": 0,
"installments_number": 0,
"installmentsAmount": 0
}
response.amount
response.status
response.buy_order
response.session_id
response.card_number
response.accounting_date
response.transaction_date
response.authorization_code
response.payment_type_code
response.response_code
response.installments_number
response.installments_amount
response.balance
| Nombre tipo |
Descripción |
|---|---|
| amount Number |
Monto de la transacción. Sólo en caso de dolar acepta dos decimales. Largo máximo: 17 |
| status String |
Estado de la transacción (INITIALIZED, AUTHORIZED, REVERSED, FAILED, NULLIFIED, PARTIALLY_NULLIFIED, CAPTURED). Largo máximo: 64 |
| buy_order String |
Número de orden de compra. Largo máximo: 26 |
| session_id String |
ID de sesión de la compra. Largo máximo: 61 |
| card_detail cardDetail |
Objeto que contiene información de la tarjeta utilizado por el tarjetahabiente. |
| card_detail.card_number String |
Los últimos 4 dígitos de la tarjeta usada en la transacción. Largo máximo: 19 |
| accounting_date String |
Fecha contable de la transacción en formato MMYY. |
| transaction_date ISO8601 |
Fecha de la transacción. |
| authorization_code String |
Código de autorización de la transacción de pago. Largo máximo: 6 |
| payment_type_code String |
Indica el tipo de tarjeta utilizada. Largo máximo: 2 VD = Venta Débito. VN = Venta Normal. VP = Venta Prepago. VC = Venta en cuotas. SI = 3 cuotas sin interés. S2 = 2 cuotas sin interés. NC = N Cuotas sin interés |
| response_code Number |
Código de respuesta de la autorización. Valores posibles: 0 = Transacción aprobada Puedes revisar los códigos de respuesta de rechazo en el siguiente
|
| installments_amount Number |
Monto de la cuota. Se envía solo si tiene valor cuota. Largo máximo: 17 |
| installments_number Number |
Número de cuotas de la transacción. Largo máximo: 2 |
| prepaid_balance Number |
Saldo de la tarjeta de prepago. Se envía solo si se informa saldo. Largo máximo: 17 |
Consultar estado de una transacción completa
Esta operación permite obtener el estado de la transacción en cualquier momento. En condiciones normales es probable que no se requiera ejecutar, pero en caso de ocurrir un error inesperado permite conocer el estado y tomar las acciones que correspondan.
Transaction.status()
Obtiene resultado de transacción a partir de un token.
FullTransaction tx = new FullTransaction(new WebpayOptions(IntegrationCommerceCodes.TRANSACCION_COMPLETA, IntegrationApiKeys.WEBPAY, IntegrationType.TEST));
final FullTransactionStatusResponse response = tx.status(token);
$option = new Options($apiKey, $commerceCode, Options::ENVIRONMENT_PRODUCTION);
$transaction = new Transaction($option);
$response = $transaction->status($token_ws);
var tx = new FullTransaction(new Options(IntegrationCommerceCodes.TRANSACCION_COMPLETA, IntegrationApiKeys.WEBPAY, IntegrationType.TEST));
var response = tx.Status(token);
@options = Transbank::Webpay::Options.new("commerceCode", "APIKey", :integration)
@transaction = Transbank::Webpay::TransaccionCompleta::Transaction.new(@options)
@resp = @transaction.status(token: @token)
tx = Transaction(WebpayOptions(IntegrationCommerceCodes.TRANSACCION_COMPLETA, IntegrationApiKeys.WEBPAY, IntegrationType.TEST))
resp = tx.status(token=token)
const tx = new TransaccionCompleta.Transaction(
new Options(
IntegrationCommerceCodes.TRANSACCION_COMPLETA,
IntegrationApiKeys.WEBPAY,
Environment.Integration
)
);
const response = await tx.status(token);
GET /rswebpaytransaction/api/webpay/v1.2/transactions/{token}
Tbk-Api-Key-Id: 597055555530
Tbk-Api-Key-Secret: 579B532A7440BB0C9079DED94D31EA1615BACEB56610332264630D42D0A36B1C
Content-Type: application/json
Parámetros Transaction.status
| Nombre tipo |
Descripción |
|---|---|
| token String |
Token de la transacción. Largo: 64. (Se envía en la URL, no en el body) |
Respuesta Transaction.status
response.getAccountingDate();
response.getAmount();
response.getAuthorizationCode();
response.getBuyOrder();
CardDetail cardDetail = response.getCardDetail();
cardDetail.getCardNumber();
response.getInstallmentsAmount();
response.getInstallmentsNumber();
response.getPaymentCodeType();
response.getResponseCode();
response.getSessionId();
response.getTransactionDate();
$response->getAccountingDate();
$response->getAmount();
$response->getAuthorizationCode();
$response->getBuyOrder();
$cardDetail = $response->getCardDetail();
$cardDetail->getCardNumber();
$response->getInstallmentsAmount();
$response->getInstallmentsNumber();
$response->getPaymentCodeType();
$response->getResponseCode();
$response->getSessionId();
$response->getTransactionDate();
response.AccountingDate;
response.Amount;
response.AuthorizationCoda;
response.BuyOrder;
var cardDetail = response.CardDetail;
cardDetail.CardNumber;
response.InstallmentsAmount;
response.InstallmentsNumber;
response.PaymentTypeCode;
response.ResponseCode;
response.SessionId;
response.Status;
response.TransactionDate;
response.amount
response.status
response.buy_order
response.session_id
response.card_number
response.accounting_date
response.transaction_date
response.authorization_code
response.payment_type_code
response.response_code
response.installments_number
response.installments_amount
response.balance
## Versión 3.x del SDK
response['amount']
response['status']
response['buy_order']
response['session_id']
response['card_number']
response['accounting_date']
response['transaction_date']
response['authorization_code']
response['payment_type_code']
response['response_code']
response['installments_number']
response['installments_amount']
response['balance']
## Versión 2.x del SDK
response.amount
response.status
response.buy_order
response.session_id
response.card_number
response.accounting_date
response.transaction_date
response.authorization_code
response.payment_type_code
response.response_code
response.installments_number
response.installments_amount
response.balance
200 OK
Content-Type: application/json
{
"amount": 10000,
"status": "AUTHORIZED",
"buy_order": "ordenCompra12345678",
"session_id": "sesion1234557545",
"card_detail": {
"card_number": "1234"
},
"accounting_date": "0320",
"transaction_date": "2019-03-20T20:18:20Z",
"authorization_code": "877550",
"payment_type_code": "VN",
"response_code": 0,
"installments_number": 0
}
response.amount
response.status
response.buy_order
response.session_id
response.card_number
response.accounting_date
response.transaction_date
response.authorization_code
response.payment_type_code
response.response_code
response.installments_number
response.installments_amount
response.balance
| Nombre tipo |
Descripción |
|---|---|
| amount Number |
Monto de la transacción. Sólo en caso de dolar acepta dos decimales. Largo máximo: 17 |
| status String |
Estado de la transacción (INITIALIZED, AUTHORIZED, REVERSED, FAILED, NULLIFIED, PARTIALLY_NULLIFIED, CAPTURED). Largo máximo: 64 |
| buy_order String |
Número de orden de compra. Largo máximo: 26 |
| session_id String |
ID de sesión de la compra. Largo máximo: 61 |
| card_detail cardDetail |
Objeto que contiene información de la tarjeta utilizado por el tarjetahabiente. |
| card_detail.card_number String |
Los últimos 4 dígitos de la tarjeta usada en la transacción. Largo máximo: 19 |
| accounting_date String |
Fecha contable de la transacción. |
| transaction_date ISO8601 |
Fecha de la transacción. |
| authorization_code String |
Código de autorización de la transacción de pago. Largo máximo: 6 |
| payment_type_code String |
Indica el tipo de tarjeta utilizada. Largo máximo: 2 VD = Venta Débito. VN = Venta Normal. VP = Venta Prepago. VC = Venta en cuotas. SI = 3 cuotas sin interés. S2 = 2 cuotas sin interés. NC = N Cuotas sin interés |
| response_code Number |
Código de respuesta de la autorización. Valores posibles: 0 = Transacción aprobada Puedes revisar los códigos de respuesta de rechazo en el siguiente
|
| installments_number Number |
Número de cuotas de la transacción. Largo máximo: 2 |
| installments_amount Number |
Monto de la cuota. Se envía solo si tiene valor cuota. Largo máximo 17 |
| balance Number |
Monto restante. Largo máximo: 17. Este campo solo viene cuando la transacción fue anulada |
| prepaid_balance Number |
Saldo de la tarjeta de prepago. Se envía solo si se informa saldo. Largo máximo: 17 |
Reversar o Anular un pago Transacción Completa
Puedes [leer más sobre la anulación en la información del
producto Webpay](https://www.transbankdevelopers.cl/producto/webpay#anulaciones) para conocer
más detalles y restricciones.
Para anular una transacción se debe invocar al método Transaction.refund()
.
Transaction.refund()
Permite solicitar a Webpay la anulación de una transacción realizada previamente y que se encuentre vigente.
FullTransaction tx = new FullTransaction(new WebpayOptions(IntegrationCommerceCodes.TRANSACCION_COMPLETA, IntegrationApiKeys.WEBPAY, IntegrationType.TEST));
final FullTransactionRefundResponse response = tx.refund(token, amount);
$option = new Options($apiKey, $commerceCode, Options::ENVIRONMENT_PRODUCTION);
$transaction = new Transaction($option);
$response = $transaction->refund($token, $amount);
var tx = new FullTransaction(new Options(IntegrationCommerceCodes.TRANSACCION_COMPLETA, IntegrationApiKeys.WEBPAY, IntegrationType.TEST));
var response = tx.Refund(token, amount);
@options = Transbank::Webpay::Options.new("commerceCode", "APIKey", :integration)
@transaction = Transbank::Webpay::TransaccionCompleta::Transaction.new(@options)
@resp = @transaction.refund(token: @token, amount: @amount)
tx = Transaction(WebpayOptions(IntegrationCommerceCodes.TRANSACCION_COMPLETA, IntegrationApiKeys.WEBPAY, IntegrationType.TEST))
resp = tx.refund(token=token, amount=amount)
const tx = new TransaccionCompleta.Transaction(
new Options(
IntegrationCommerceCodes.TRANSACCION_COMPLETA,
IntegrationApiKeys.WEBPAY,
Environment.Integration
)
);
const response = await tx.refund(token, amount);
POST /rswebpaytransaction/api/webpay/v1.2/transactions/{token}/refunds
Tbk-Api-Key-Id: 597055555530
Tbk-Api-Key-Secret: 579B532A7440BB0C9079DED94D31EA1615BACEB56610332264630D42D0A36B1C
Content-Type: application/json
{
"amount": 1000
}
Parámetros Transaction.refund
| Nombre tipo |
Descripción |
|---|---|
| token String |
Token de la transacción. Largo: 64. (Se envía en la URL, no en el body) |
| amount Formato número entero para transacciones en peso. Sólo en caso de dólar acepta dos decimales. |
Monto que se desea anular o reversar de la transacción. Largo máximo: 17. |
Respuesta Transaction.refund
En el caso de que la transacción corresponda a una Reversa solo se retorna el parámetro type (REVERSED).
response.getType();
response.getAuthorizationCode();
response.getAuthorizationDate();
response.getNullifiedAmount();
response.getBalance();
response.getResponse();
$response->getType();
$response->getAuthorizationCode();
$response->getAuthorizationDate();
$response->getNullifiedAmount();
$response->getBalance();
$response->getResponse();
response.AuthorizationCode;
response.AuthorizationDate;
response.Balance;
response.NullifiedAmount;
response.ResponseCode;
response.Type;
response.type
response.authorization_code
response.authorization_date
response.nullified_amount
response.balance
response.response_code
## Versión 3.x del SDK
response['type']
response['authorization_code']
response['authorization_date']
response['nullified_amount']
response['balance']
response['response_code']
## Versión 2.x del SDK
response.type
response.authorization_code
response.authorization_date
response.nullified_amount
response.balance
response.response_code
200 OK
Content-Type: application/json
{
"type": "NULLIFY",
"authorization_code": "123456",
"authorization_date": "2019-03-20T20:18:20Z",
"nullified_amount": 1000.00,
"balance": 0.00,
"response_code": 0
}
response.type
response.authorization_code
response.authorization_date
response.nullified_amount
response.balance
response.response_code
| Nombre tipo |
Descripción |
|---|---|
| type String |
Tipo de reembolso (REVERSE. NULLIFY). Largo máximo: 10 |
| authorization_code String |
Código de autorización de la anulación. Largo máximo: 6. Solo viene en caso de anulación. |
| authorization_date String |
Fecha y hora de la autorización. Solo viene en caso de anulación. |
| nullified_amount Decimal |
Monto anulado. Largo máximo: 17. Solo viene en caso de anulación. |
| balance Decimal |
Saldo actualizado de la transacción (considera la venta menos el monto anulado). Largo máximo: 17. Solo viene en caso de anulación. |
| response_code Number |
Código de resultado de la anulación. Si es exitoso es 0, de lo contrario la anulación no fue realizada. Largo máximo: 2. Solo viene en caso de anulación. |
Captura Diferida
Los comercios que están configurados para operar con captura diferida deben ejecutar el método de captura para realizar el cargo al tarjetahabiente.
Ejecutar captura diferida Transacción Completa
Puedes [leer más sobre la captura en la información del
producto Webpay](https://www.transbankdevelopers.cl/producto/webpay#autorizacion-y-captura)
para conocer más detalles y restricciones.
Para realizar esa captura explícita debe usarse el método Transaction.capture()
Transaction.capture()
Permite solicitar a Webpay la captura diferida de una transacción con autorización y sin captura simultánea.
PUT /rswebpaytransaction/api/webpay/v1.2/transactions/{token}/capture
Tbk-Api-Key-Id: 597055555531
Tbk-Api-Key-Secret: 579B532A7440BB0C9079DED94D31EA1615BACEB56610332264630D42D0A36B1C
Content-Type: application/json
{
"buy_order": "415034240",
"authorization_code": "12345",
"capture_amount": 1000
}
FullTransaction tx = new FullTransaction(new WebpayOptions(IntegrationCommerceCodes.TRANSACCION_COMPLETA, IntegrationApiKeys.WEBPAY, IntegrationType.TEST));
final FullTransactionCaptureResponse response = tx.capture(token, buyOrder, authorizationCode, captureAmount);
$option = new Options($apiKey, $commerceCode, Options::ENVIRONMENT_PRODUCTION);
$transaction = new Transaction($option);
$response = $transaction->capture($token, $buyOrder, $authorizationCode, $captureAmount);
var tx = new FullTransaction(new Options(IntegrationCommerceCodes.TRANSACCION_COMPLETA, IntegrationApiKeys.WEBPAY, IntegrationType.TEST));
var response = tx.Capture(token, buyOrder, authorizationCode, captureAmount);
@options = Transbank::Webpay::Options.new("commerceCode", "APIKey", :integration)
@transaction = Transbank::Webpay::TransaccionCompleta::Transaction.new(@options)
@resp = @transaction.capture(
token: @token,
buy_order: @buy_order,
authorization_code: @authorization_code,
capture_amount: @capture_amount
)
tx = Transaction(WebpayOptions(IntegrationCommerceCodes.TRANSACCION_COMPLETA, IntegrationApiKeys.WEBPAY, IntegrationType.TEST))
resp = tx.capture(token, buy_order, authorization_code, capture_amount)
const tx = new TransaccionCompleta.Transaction(
new Options(
IntegrationCommerceCodes.TRANSACCION_COMPLETA,
IntegrationApiKeys.WEBPAY,
Environment.Integration
)
);
const response = await tx.capture(token, buyOrder, authorizationCode, amount);
Parámetros Transaction.capture
| Nombre tipo |
Descripción |
|---|---|
| token String |
Token de la transacción. Largo: 64. (Se envía en la URL, no en el body) |
| buy_order String |
Orden de compra de la transacción que se requiere capturar. Largo máximo: 26. La orden de compra puede tener: Números, letras, mayúsculas y minúsculas, y los signos |_=&%.,~:/?[+!@()>- . Los caracteres con signos no están soportados, como los acentos o signos no especificados. |
| authorization_code String |
Código de autorización de la transacción que se requiere capturar Largo máximo: 6. |
| capture_amount Decimal |
Monto que se desea capturar. Largo máximo: 17. |
Respuesta Transaction.capture
200 OK
Content-Type: application/json
{
"authorization_code": "123456",
"authorization_date": "2019-03-20T20:18:20Z",
"captured_amount": 1000,
"response_code": 0
}
response.authorization_code
response.authorization_date
response.captured_amount
response.response_code
$response->getAuthorizationCode();
$response->getAuthorizationDate();
$response->getCapturedAmount();
$response->getResponseCode();
response.authorization_code
response.authorization_date
response.captured_amount
response.response_code
## Versión 3.x del SDK
response['authorization_code']
response['authorization_date']
response['captured_amount']
response['response_code']
## Versión 2.x del SDK
response.token
response.authorization_code
response.authorization_date
response.captured_amount
response.response_code
response.getAuthorizationCode();
response.getAuthorizationDate();
response.getCapturedAmount();
response.getResponseCode();
| Nombre tipo |
Descripción |
|---|---|
| authorization_code String |
Código de autorización de la captura diferida. Largo máximo: 6 |
| authorization_date String |
Fecha y hora de la autorización. |
| captured_amount Decimal |
Monto capturado. Largo máximo: 6 |
| response_code Number |
Código de resultado de la captura. Si es exitoso es 0,de lo contrario la captura no fue realizada. Largo máximo: 2 |
En caso de error pueden aparecer los siguientes códigos exclusivos del método
Transaction.capture()
:
| Código | Descripción |
|---|---|
| 304 | Validación de campos de entrada nulos |
| 245 | Código de comercio no existe |
| 22 | El comercio no se encuentra activo |
| 316 | El comercio indicado no corresponde al certificado o no es hijo del comercio Mall en caso de transacciones MALL |
| 308 | Operación no permitida |
| 274 | Transacción no encontrada |
| 16 | La transacción no es de captura diferida |
| 292 | La transacción no está autorizada |
| 284 | Periodo de captura excedido |
| 310 | Transacción reversada previamente |
| 309 | Transacción capturada previamente |
| 311 | Monto a capturar excede el monto autorizado |
| 315 | Error del autorizador |
Transacción Completa Mall
Puedes revisar más detalles de esta operación en [su documentación](https://www.transbankdevelopers.cl/documentacion/transaccion-completa#)
Crear una Transacción Completa Mall
Para crear una Transacción Completa Mall basta llamar al método Transaction.create()
Transaction.create() Completa Mall
Permite inicializar una transacción Completa Mall en Webpay. Como respuesta a la invocación se genera un token que representa en forma única una transacción.
MallFullTransaction tx = new MallFullTransaction(new WebpayOptions(IntegrationCommerceCodes.TRANSACCION_COMPLETA, IntegrationApiKeys.WEBPAY, IntegrationType.TEST));
MallTransactionCreateDetails transactionDetails = MallTransactionCreateDetails.build()
.add(amountMallOne, commerceCodeStoreOne, buyOrderMallOne, installmentsNumberMallOne)
.add(amountMallTwo, commerceCodeStoreTwo, buyOrderMallTwo, installmentsNumberMallTwo);
MallFullTransactionCreateResponse response = tx.create(buyOrder, sessionId, cardNumber, cardExpirationDate, transactionDetails);
$transaction_details = [
[
'amount' => 10000,
'commerce_code' => "commerceCodeStoreOne",
'buy_order' => '123456789'
],
[
'amount' => 12000,
'commerce_code' => "commerceCodeStoreTwo",
'buy_order' => '123456790'
],
];
$option = new Options($apiKey, $commerceCode, Options::ENVIRONMENT_PRODUCTION);
$transaction = new MallTransaction($option);
$response = $transaction->create(
$buyOrder,
$sessionId,
$cardNumber,
$cardExpirationDate,
$transaction_details,
$cvv);
var tx = new MallFullTransaction(new Options(IntegrationCommerceCodes.TRANSACCION_COMPLETA_MALL, IntegrationApiKeys.WEBPAY, IntegrationType.TEST));
var details = new List();
details.Add(new CreateDetails(amountMallOne, commerceCodeStoreOne, buyOrderMallOne));
details.Add(new CreateDetails(amountMallTwo, commerceCodeStoreTwo, buyOrderMallTwo));
var response = tx.Create(
buyOrder: buy_order,
sessionId: session_id,
cardNumber: card_number,
cardExpirationDate: card_expiration_date,
details,
cvv: cvv
);
@options = Transbank::Webpay::Options.new("commerceCode", "APIKey", :integration)
@tx = Transbank::Webpay::TransaccionCompleta::Transaction.new(@options)
@resp = @tx.create(buy_order: @buy_order, session_id: @session_id, card_number: @card_number, card_expiration_date: @card_expiration_date, @details, cvv: @cvv)
tx = MallTransaction(WebpayOptions(IntegrationCommerceCodes.TRANSACCION_COMPLETA_MALL, IntegrationApiKeys.WEBPAY, IntegrationType.TEST))
details = [
{
'commerce_code': 'commerce_store_1',
'buy_order': '123456789',
'amount': 10000
},
{
'commerce_code': 'commerce_store_1',
'buy_order': '123456790',
'amount': 12000
}
]
resp = tx.create(
buy_order=buy_order,
session_id=session_id,
card_number=card_number,
card_expiration_date=card_expiration_date,
details=details,
cvv=None
)
const tx = new TransaccionCompleta.MallTransaction(
new Options(
IntegrationCommerceCodes.TRANSACCION_COMPLETA_MALL,
IntegrationApiKeys.WEBPAY,
Environment.Integration
)
);
const details = [
new TransactionDetail(amount, commerceCodeStoreOne, childBuyOrder),
new TransactionDetail(amount2, commerceCodeStoreTwo, childBuyOrder2),
];
const response = await tx.create(
parentBuyOrder,
sessionId,
cardNumber,
cardExpirationDate,
details,
cvv
);
POST /rswebpaytransaction/api/webpay/v1.2/transactions
Tbk-Api-Key-Id: 597055555551
Tbk-Api-Key-Secret: 579B532A7440BB0C9079DED94D31EA1615BACEB56610332264630D42D0A36B1C
Content-Type: application/json
{
"buy_order": "ordenCompra12345678",
"session_id": "sesion1234564",
"card_number": "4239000000000000",
"cvv": 123,
"card_expiration_date": "22/10",
"details": [
{
"amount": 10000,
"commerce_code": "597055555552",
"buy_order": "123456789"
},
{
"amount": 10000,
"commerce_code": "597055555553",
"buy_order": "123456790"
}
]
}
Parámetros Transaction.create Completa Mall
| Nombre tipo |
Descripción |
|---|---|
| buy_order String |
Es el código único de la orden de compra generada por el comercio mall. Este número debe ser único para cada transacción. Largo máximo: 26. La orden de compra puede tener: Números, letras, mayúsculas y minúsculas, y los signos |_=&%.,~:/?[+!@()>- . Los caracteres con signos no están soportados, como los acentos o signos no especificados. |
| session_id String |
Identificador de sesión, uso interno de comercio, este valor es devuelto al final de la transacción. Largo máximo: 61 |
| card_number String |
Número de la tarjeta con la que se debe hacer la transacción. Largo máximo: 19 |
| cvv String |
(Opcional) Código que se utiliza como método de seguridad en transacciones en las que la tarjeta no está físicamente presente. Largo máximo: 4. No se debe enviar para comercios con la opción sin cvv habilitada. |
| card_expiration_date String |
Fecha de expiración de la tarjeta con la que se realiza la transacción. Largo máximo: 5 |
| details Array |
Lista de objetos, uno por cada tienda diferente del mall que participa en la transacción. |
| details [].amount Decimal |
Monto de la transacción de una tienda del mall. Máximo 2 decimales para USD. Largo máximo: 17. |
| details [].commerce_code String |
Código comercio asignado por Transbank para la tienda perteneciente al mall a la cual corresponde esta transacción. Largo: 12. |
| details [].buy_order String |
Orden de compra de la tienda del mall. Este número debe ser único para cada transacción. Largo máximo: 26. La orden de compra puede tener: Números, letras, mayúsculas y minúsculas, y los signos |_=&%.,~:/?[+!@()>- . Los caracteres con signos no están soportados, como los acentos o signos no especificados. |
Respuesta Transaction.create Completa Mall
response.getToken();
$response->getToken();
response.Token;
response.token
## Versión 3.x del SDK
response['token']
## Versión 2.x del SDK
response.token
200 OK
Content-Type: application/json
{
"token": "e074d38c628122c63e5c0986368ece22974d6fee1440617d85873b7b4efa48a3",
}
response.token
| Nombre tipo |
Descripción |
|---|---|
| token String |
Token identificador de la transacción. Largo: 64. |
Consulta de cuotas Completa Mall
Para consultar el valor de las cuotas que pagará el tarjeta habiente en cada transacción dentro transacción Completa Mall, es necesario llamar al método Transaction.installments()
Transaction.installments() Completa Mall
Operación que permite obtener el monto de la cuota a partir del número de cuotas. El id de la consulta que selecciona el tarjetahabiente debe ser informado en la invocación de la confirmación.
MallFullTransaction tx = new MallFullTransaction(new WebpayOptions(IntegrationCommerceCodes.TRANSACCION_COMPLETA, IntegrationApiKeys.WEBPAY, IntegrationType.TEST));
MallFullTransactionInstallmentsDetails installmentsDetails =
MallFullTransactionInstallmentsDetails.build().add(commerceCodeStoreOne, buyOrder, installmentsNumber);
final MallFullTransactionInstallmentsResponse response = tx.installments(token, installmentsDetails);
$option = new Options($apiKey, $commerceCode, Options::ENVIRONMENT_PRODUCTION);
$transaction = new MallTransaction($option);
$installments_details = [
[
'commerce_code' => 'commerceCodeStoreOne',
'buy_order' => '123456789',
'installments_number' => 2
],
[
'commerce_code' => 'commerceCodeStoreTwo',
'buy_order' => '123456790',
'installments_number' => 2
],
];
$response = $transaction->installments($token, $installments_details);
var tx = new MallFullTransaction(new Options(IntegrationCommerceCodes.TRANSACCION_COMPLETA_MALL, IntegrationApiKeys.WEBPAY, IntegrationType.TEST));
var details = new List();
details.Add(new CreateDetails(amountMallOne, commerceCodeStoreOne, buyOrderMallOne));
details.Add(new CreateDetails(amountMallTwo, commerceCodeStoreTwo, buyOrderMallTwo));
var response = tx.Installments(
token, details
);
@options = Transbank::Webpay::Options.new("commerceCode", "APIKey", :integration)
@tx = Transbank::Webpay::TransaccionCompleta::Transaction.new(options)
@installment_details = [
{
commerce_code: 'commerce_store_1',
buy_order: '123456789',
installments_number: 2
},
{
commerce_code: 'commerce_store_2',
buy_order: '123456790',
installments_number: 2
},
]
@resp = @tx.installments(token, installment_details)
tx = MallTransaction(WebpayOptions(IntegrationCommerceCodes.TRANSACCION_COMPLETA_MALL, IntegrationApiKeys.WEBPAY, IntegrationType.TEST))
details = [
{
'commerce_code': 'commerce_store_1',
'buy_order': '123456789',
'installments_number': 2
},
{
'commerce_code': 'commerce_store_2',
'buy_order': '123456790',
'installments_number': 2
}
]
resp = tx.installments(token=token, details=details)
const tx = new TransaccionCompleta.MallTransaction(
new Options(
IntegrationCommerceCodes.TRANSACCION_COMPLETA_MALL,
IntegrationApiKeys.WEBPAY,
Environment.Integration
)
);
const details = [
new InstallmentDetail(
commerceCodeStoreOne,
childBuyOrder,
installmentsNumber
),
new InstallmentDetail(
commerceCodeStoreTwo,
childBuyOrder2,
installmentsNumber2
),
];
const response = await tx.installments(token, details);
POST /rswebpaytransaction/api/webpay/v1.2/transactions/{token}/installments
Tbk-Api-Key-Id: 597055555551
Tbk-Api-Key-Secret: 579B532A7440BB0C9079DED94D31EA1615BACEB56610332264630D42D0A36B1C
Content-Type: application/json
{
"commerce_code": 597055555552,
"buy_order": "123456789",
"installments_number": 10
}
Parámetros Transaction.installments Completa Mall
| Nombre tipo |
Descripción |
|---|---|
| token String |
Token de la transacción. Largo: 64. (Se envía en la URL, no en el body) |
| commerce_code String |
Código comercio asignado por Transbank para la tienda perteneciente al mall a la cual corresponde esta transacción. Largo: 12 |
| buy_order String |
Orden de compra de la tienda del mall. Largo máximo: 26 |
| installments_number Number |
Cantidad de cuotas. Largo máximo: 2 |
Respuesta Transaction.installments Completa Mall
response.getInstallmentsAmount();
response.getIdQueryInstallments();
DeferredPeriod deferredPeriod = response.getDeferredPeriods()[0];
deferredPeriod.getAmount();
deferredPeriod.getPeriod();
$firstResponse = $response[0];
$firstResponse->getInstallmentsAmount();
$firstResponse->getIdQueryInstallments();
$deferredPeriods = $firstResponse->getDeferredPeriods();
if (isset($deferredPeriods[0])) {
$deferredPeriod = $deferredPeriods[0];
$deferredPeriod->getAmount();
$deferredPeriod->getPeriod();
}
response.InstallmentsAmount;
response.IdQueryInstallments;
var deferredPeriod = response.DeferredPeriods[0];
deferredPeriod.Amount;
deferredPeriod.Period;
response.installments_amount
response.id_query_installments
deferred_period = response.deferred_periods[0]
deferred_period.amount
deferred_period.period
## Versión 3.x del SDK
response['installments_amount']
response['id_query_installments']
response['deferred_periods']
## Versión 2.x del SDK
response.installments_amount
response.id_query_installments
deferred_period = response.deferred_periods[0]
deferred_period.amount
deferred_period.period
200 OK
Content-Type: application/json
{
"installments_amount": 3334,
"id_query_installments": 11,
"deferred_periods": [
{
"amount": 1000,
"period": 1
}
]
}
response.installment_amount
response.id_query_installment
deferred_period = response.deferred_periods[0]
deferred_period.amount
deferred_period.period
| Nombre tipo |
Descripción |
|---|---|
| installments_amount String |
Monto de cada cuota. Largo: 17. |
| id_query_installments String |
Identificador de las cuotas. Largo: 19. |
| deferred_periods Array |
Arreglo con periodos diferidos. |
| deferred_periods [].amount String |
Monto. Largo: 17. |
| deferred_periods [].period String |
Índice de periodo. Largo: 2. |
Confirmación de la transacción Completa Mall
Una vez iniciada la transacción y consultado el monto de las cuotas por cada subtransacción, puedes confirmar y obtener el resultado de una transacción completa usando el metodo Transaction.commit()
.
Transaction.commit() Completa Mall
Operación que permite confirmar una transacción. Retorna el estado de la transacción.
MallFullTransaction tx = new MallFullTransaction(new WebpayOptions(IntegrationCommerceCodes.TRANSACCION_COMPLETA, IntegrationApiKeys.WEBPAY, IntegrationType.TEST));
MallTransactionCommitDetails details = MallTransactionCommitDetails.build().add(
commerceCodeStoreOne,buyOrder,idQueryInstallments,deferredPeriodIndex,gracePeriod
);
final MallFullTransactionCommitResponse response = tx.commit(token, details);
$option = new Options($apiKey, $commerceCode, Options::ENVIRONMENT_PRODUCTION);
$transaction = new MallTransaction($option);
$details = [
[
'commerce_code' => 'commerceCodeStoreOne',
'buy_order' => '123456789',
'id_query_installments' => $firstInstallmentResponse->getIdQueryInstallments(),
'deferred_period_index' => null,
'grace_period' => false
],
[
'commerce_code' => 'commerceCodeStoreTwo',
'buy_order' => '123456790',
'id_query_installments' => $secondInstallmentResponse->getIdQueryInstallments(),
'deferred_period_index' => null,
'grace_period' => false
]
];
$response = $transaction->commit($token, $details);
var tx = new MallFullTransaction(new Options(IntegrationCommerceCodes.TRANSACCION_COMPLETA_MALL, IntegrationApiKeys.WEBPAY, IntegrationType.TEST));
var transactionDetails = new List();
transactionDetails.Add(new MallCommitDetails(
commerceCodeStoreOne,
buyOrderMallOne,
idQueryInstallmentsOne,
deferredPeriodIndexOne,
gracePeriodOne
));
transactionDetails.Add(new MallCommitDetails(
commerceCodeStoreTwo,
buyOrderMallTwo,
idQueryInstallmentsTwo,
deferredPeriodIndexTwo,
gracePeriodTwo
));
var response = tx.Commit(
token, transactionDetails
);
@options = Transbank::Webpay::Options.new("commerceCode", "APIKey", :integration)
@tx = Transbank::Webpay::TransaccionCompleta::Transaction.new(options)
@details = [
{
commerce_code: 'commerce_store_1',
buy_order: 'ordenCompra1234',
id_query_installments: 12,
deferred_period_index: 1,
grace_period: false
},
{
commerce_code: 'commerce_store_2',
buy_order: 'ordenCompra12345',
id_query_installments: 12,
deferred_period_index: 1,
grace_period: false
}
]
@resp = @tx.commit(token: token, details: details)
tx = MallTransaction(WebpayOptions(IntegrationCommerceCodes.TRANSACCION_COMPLETA_MALL, IntegrationApiKeys.WEBPAY, IntegrationType.TEST))
details = [
{
"commerce_code": 'commerce_store_1',
"buy_order": 'ordenCompra1234',
"id_query_installments": 12,
"deferred_period_index": 1,
"grace_period": false
},
{
"commerce_code": 'commerce_store_2',
"buy_order": 'ordenCompra12345',
"id_query_installments": 12,
"deferred_period_index": 1,
"grace_period": false
}
]
resp = tx.commit(
token=token, details=details
)
const tx = new TransaccionCompleta.MallTransaction(
new Options(
IntegrationCommerceCodes.TRANSACCION_COMPLETA_MALL,
IntegrationApiKeys.WEBPAY,
Environment.Integration
)
);
let commitDetails = [
new CommitDetail(commerceCodeStoreOne, childBuyOrder),
new CommitDetail(commerceCodeStoreTwo, childBuyOrder2),
];
const response = await tx.commit(token, commitDetails);
PUT /rswebpaytransaction/api/webpay/v1.2/transactions/{token}
Tbk-Api-Key-Id: 597055555551
Tbk-Api-Key-Secret: 579B532A7440BB0C9079DED94D31EA1615BACEB56610332264630D42D0A36B1C
Content-Type: application/json
{
"details": [
{
"commerce_code": 597055555552,
"buy_order": "ordenCompra1234",
"id_query_installments": 12,
"deferred_period_index": 1,
"grace_period": false
}
]
}
print_r($response);
//Transbank\TransaccionCompleta\Responses\MallTransactionCommitResponse Object
//(
// [buyOrder] => buyOrder1
// [cardDetail] => Array
// (
// [card_number] => 6623
// )
//
// [accountingDate] => 0414
// [transactionDate] =>
// [details] => Array
// (
// [0] => Array
// (
// [amount] => 10000
// [status] => AUTHORIZED
// [authorization_code] => 1213
// [payment_type_code] => S2
// [response_code] => 0
// [installments_amount] => 5000
// [installments_number] => 2
// [commerce_code] => 597055555574
// [buy_order] => 123456789
// )
//
// [1] => Array
// (
// [amount] => 12000
// [status] => AUTHORIZED
// [authorization_code] => 1213
// [payment_type_code] => S2
// [response_code] => 0
// [installments_amount] => 5000
// [installments_number] => 2
// [commerce_code] => 597055555575
// [buy_order] => 123456790
// )
//
// )
//
//)
Parámetros Transaction.commit Completa Mall
| Nombre tipo |
Descripción |
|---|---|
| token String |
Token de la transacción. Largo: 64. (Se envía en la URL, no en el body) |
| details details |
Listado con las transacciones mall. |
| commerce_code String |
Código comercio asignado por Transbank para la tienda perteneciente al mall a la cual corresponde esta transacción. Largo máximo: 12 |
| buy_order String |
Orden de compra de la tienda del mall. Largo máximo: 26 |
| id_query_installments Number |
(Opcional) Identificador de cuota. Largo máximo: 19. Solo enviar si el pago es en cuotas |
| deferred_period_index Number |
(Opcional) Cantidad de periodo diferido. Largo máximo: 2. Solo enviar si el pago es en cuotas |
| grace_period Boolean |
(Opcional) Indicador de periodo de gracia. Solo enviar si el pago es en cuotas |
Respuesta Transaction.commit Completa Mall
response.getBuyOrder();
response.getCardNumber();
response.getAccountingDate();
response.getTransactionDate();
Detail detail = response.getDetails()[0];
detail.getAuthorizationCode();
detail.getPaymentCodeType();
detail.getResponseCode();
detail.getInstallmentsAmount();
detail.getInstallmentsNumber();
detail.getAmount();
detail.getCommerceCode();
detail.getBuyOrder();
detail.getStatus();
detail.getBalance();
$response->getBuyOrder();
$response->getCardNumber();
$response->getAccountingDate();
$response->getTransactionDate();
$detail = $response->getDetails()[0];
$detail->getAuthorizationCode();
$detail->getPaymentTypeCode();
$detail->getResponseCode();
$detail->getInstallmentsAmount();
$detail->getInstallmentsNumber();
$detail->getAmount();
$detail->getCommerceCode();
$detail->getBuyOrder();
$detail->getStatus();
response.BuyOrder;
response.CardNumber;
response.AccountingDate;
response.TransactionDate;
detail = response.Details[0];
detail.AuthorizationCode;
detail.PaymentCodeType;
detail.ResponseCode;
detail.InstallmentsAmount;
detail.InstallmentsNumber;
detail.Amount;
detail.CommerceCode;
detail.BuyOrder;
detail.Status;
detail.Balance;
response.buy_order
response.card_number
response.accounting_date
response.transaction_date
detail = response.details[0]
detail.authorization_code
detail.payment_code_type
detail.response_code
detail.installments_amount
detail.installments_number
detail.amount
detail.commerce_code
detail.buy_order
detail.status
detail.balance
## Versión 3.x del SDK
response['buy_order']
response['card_number']
response['accounting_date']
response['transaction_date']
response['details']
## Versión 2.x del SDK
response.buy_order
response.card_number
response.accounting_date
response.transaction_date
detail = response.details[0]
detail.authorization_code
detail.payment_code_type
detail.response_code
detail.installments_amount
detail.installments_number
detail.amount
detail.commerce_code
detail.buy_order
detail.status
detail.balance
200 OK
Content-Type: application/json
{
"buy_order": "415034240",
"card_detail": {
"card_number": "6623"
},
"accounting_date": "0321",
"transaction_date": "2019-03-21T15:43:48.523Z",
"details": [
{
"amount": 500,
"status": "AUTHORIZED",
"authorization_code": "1213",
"payment_type_code": "VN",
"response_code": 0,
"installments_number": 0,
"commerce_code": "597055555552",
"buy_order": "505479072"
}
]
}
response.buy_order
response.card_number
response.accounting_date
response.transaction_date
detail = response.details[0]
detail.authorization_code
detail.payment_code_type
detail.response_code
detail.installments_amount
detail.installments_number
detail.amount
detail.commerce_code
detail.buy_order
detail.status
detail.balance
| Nombre tipo |
Descripción |
|---|---|
| buy_order String |
Orden de compra del mall. Largo máximo: 26 |
| card_detail carddetails |
Objeto que representa los datos de la tarjeta de crédito del tarjeta habiente. |
| card_detail.card_number String |
4 últimos números de la tarjeta de crédito del tarjetahabiente. Largo máximo: 19. |
| accounting_date String |
Fecha de la autorización. Largo: 4, formato MMYY |
| transaction_date String |
Fecha y hora de la autorización. formato: ISO8601 |
| details Array |
Lista con resultado de cada una de las transacciones enviadas. |
| details [].amount Number |
Monto de la transacción. Largo máximo: 17 Acepta decimales en caso de ser operación en dolares |
| details [].status String |
Estado de la transacción (INITIALIZED, AUTHORIZED, REVERSED, FAILED, NULLIFIED, PARTIALLY_NULLIFIED, CAPTURED). Largo máximo: 64 |
| details [].authorization_code String |
Código de autorización de la transacción Largo máximo: 6 |
| details [].payment_type_code String |
VN = Venta Normal. VC = Venta en cuotas. SI = 3 cuotas sin interés. S2 = 2 cuotas sin interés. NC = N Cuotas sin interés. VD = Venta Débito. VP = Venta Prepago. |
Number
0 = Transacción aprobada
Puedes revisar los códigos de respuesta de rechazo en el siguiente
[link](https://www.transbankdevelopers.cl/producto/webpay#codigos-de-respuesta-de-autorizacion)Number
Number
String
String
Number
Largo máximo 17
Consultar estado de una Transacción Completa Mall
Esta operación permite obtener el estado de la transacción Completa Mall en cualquier momento. En condiciones normales es probable que no se requiera ejecutar, pero en caso de ocurrir un error inesperado permite conocer el estado y tomar las acciones que correspondan.
Transaction.status() Completa Mall
Obtiene resultado de transacción a partir de un token.
MallFullTransaction tx = new MallFullTransaction(new WebpayOptions(IntegrationCommerceCodes.TRANSACCION_COMPLETA, IntegrationApiKeys.WEBPAY, IntegrationType.TEST));
final MallFullTransactionStatusResponse response = tx.status(tokenWs);
$option = new Options($apiKey, $commerceCode, Options::ENVIRONMENT_PRODUCTION);
$transaction = new MallTransaction($option);
$response = $transaction->status(token);
var tx = new MallFullTransaction(new Options(IntegrationCommerceCodes.TRANSACCION_COMPLETA_MALL, IntegrationApiKeys.WEBPAY, IntegrationType.TEST));
var response = tx.Status(token);
@options = Transbank::Webpay::Options.new("commerceCode", "APIKey", :integration)
@tx = Transbank::Webpay::TransaccionCompleta::Transaction.new(options)
@resp = @tx.status(token)
tx = MallTransaction(WebpayOptions(IntegrationCommerceCodes.TRANSACCION_COMPLETA_MALL, IntegrationApiKeys.WEBPAY, IntegrationType.TEST))
resp = tx.status(token)
const tx = new TransaccionCompleta.MallTransaction(
new Options(
IntegrationCommerceCodes.TRANSACCION_COMPLETA_MALL,
IntegrationApiKeys.WEBPAY,
Environment.Integration
)
);
const response = await tx.status(token);
GET /rswebpaytransaction/api/webpay/v1.2/transactions/{token}
Tbk-Api-Key-Id: 597055555551
Tbk-Api-Key-Secret: 579B532A7440BB0C9079DED94D31EA1615BACEB56610332264630D42D0A36B1C
Content-Type: application/json
Parámetros Transaction.status Completa Mall
| Nombre tipo |
Descripción |
|---|---|
| token String |
Token de la transacción. Largo: 64. (Se envía en la URL, no en el body) |
Respuesta Transaction.status Completa Mall
response.getBuyOrder();
response.getCardNumber();
response.getAccountingDate();
response.getTransactionDate();
Detail detail = response.getDetails()[0];
detail.getAuthorizationCode();
detail.getPaymentCodeType();
detail.getResponseCode();
detail.getInstallmentsAmount();
detail.getInstallmentsNumber();
detail.getAmount();
detail.getCommerceCode();
detail.getBuyOrder();
detail.getStatus();
detail.getBalance();
$response->getBuyOrder();
$response->getCardNumber();
$response->getAccountingDate();
$response->getTransactionDate();
$detail = $response->getDetails()[0];
$detail->getAuthorizationCode();
$detail->getPaymentTypeCode();
$detail->getResponseCode();
$detail->getInstallmentsAmount();
$detail->getInstallmentsNumber();
$detail->getAmount();
$detail->getCommerceCode();
$detail->getBuyOrder();
$detail->getStatus();
response.BuyOrder;
response.CardNumber;
response.AccountingDate;
response.TransactionDate;
detail = response.Details[0];
detail.AuthorizationCode;
detail.PaymentCodeType;
detail.ResponseCode;
detail.InstallmentsAmount;
detail.InstallmentsNumber;
detail.Amount;
detail.CommerceCode;
detail.BuyOrder;
detail.Status;
detail.Balance;
response.buy_order
response.card_number
response.accounting_date
response.transaction_date
detail = response.details[0]
detail.authorization_code
detail.payment_code_type
detail.response_code
detail.installments_amount
detail.installments_number
detail.amount
detail.commerce_code
detail.buy_order
detail.status
detail.balance
## Versión 3.x del SDK
response['buy_order']
response['card_number']
response['accounting_date']
response['transaction_date']
response['details']
## Versión 2.x del SDK
response.buy_order
response.card_number
response.accounting_date
response.transaction_date
detail = response.details[0]
detail.authorization_code
detail.payment_code_type
detail.response_code
detail.installments_amount
detail.installments_number
detail.amount
detail.commerce_code
detail.buy_order
detail.status
detail.balance
200 OK
Content-Type: application/json
{
"buy_order": "415034240",
"card_detail": {
"card_number": "6623"
},
"accounting_date": "0321",
"transaction_date": "2019-03-21T15:43:48.523Z",
"details": [
{
"amount": 500,
"status": "AUTHORIZED",
"authorization_code": "1213",
"payment_type_code": "VN",
"response_code": 0,
"installments_number": 0,
"commerce_code": "597055555552",
"buy_order": "505479072"
}
]
}
response.buy_order
response.card_number
response.accounting_date
response.transaction_date
detail = response.details[0]
detail.authorization_code
detail.payment_code_type
detail.response_code
detail.installments_amount
detail.installments_number
detail.amount
detail.commerce_code
detail.buy_order
detail.status
detail.balance
| Nombre tipo |
Descripción |
|---|---|
| buy_order String |
Orden de compra del mall. Largo máximo: 26 |
| card_detail carddetails |
Objeto que representa los datos de la tarjeta de crédito del tarjeta habiente. |
| card_detail.card_number String |
4 últimos números de la tarjeta de crédito del tarjetahabiente. Largo máximo: 19. |
| accouting_date String |
Fecha de la autorización. Largo: 4, formato MMDD |
| transaction_date String |
Fecha y hora de la autorización. Largo: 6, formato: ISO8601 |
| details Array |
Lista con resultado de cada una de las transacciones enviadas. |
| details [].amount Number |
Monto de la transacción. Largo máximo: 17 Acepta decimales en caso de ser operación en dolares |
| details [].status String |
Estado de la transacción (INITIALIZED, AUTHORIZED, REVERSED, FAILED, NULLIFIED, PARTIALLY_NULLIFIED, CAPTURED). Largo máximo: 64 |
| details [].authorization_code String |
Código de autorización de la transacción Largo máximo: 6 |
| details [].payment_type_code String |
VN = Venta Normal. VC = Venta en cuotas. SI = 3 cuotas sin interés. S2 = 2 cuotas sin interés. NC = N Cuotas sin interés. VD = Venta Débito. VP = Venta Prepago. |
Number
0 = Transacción aprobada
Puedes revisar los códigos de respuesta de rechazo en el siguiente
[link](https://www.transbankdevelopers.cl/producto/webpay#codigos-de-respuesta-de-autorizacion)Number
Number
String
String
Number
Number
Largo máximo 17
Anulación Transacción Completa Mall
Permite generar el reembolso del total o parte del monto de una transacción completa. Dependiendo de la siguiente lógica de negocio la invocación a esta operación generará una reversa o una anulación:
- Si se especifica un valor en el campo “amount” se ejecutará siempre una anulación.
- Si se supera el tiempo máximo para ejecutar una reversa se ejecutará una anulación.
- Si no se ha dado ninguno de los casos anteriores se ejecutará una reversa.
Transaction.refund() Completa Mall
Permite solicitar a Webpay la anulación de una transacción realizada previamente y que se encuentre vigente.
MallFullTransaction tx = new MallFullTransaction(new WebpayOptions(IntegrationCommerceCodes.TRANSACCION_COMPLETA, IntegrationApiKeys.WEBPAY, IntegrationType.TEST));
final MallFullTransactionRefundResponse response = tx.refund(token, buyOrder, commerceCodeStoreOne, amount);
$option = new Options($apiKey, $commerceCode, Options::ENVIRONMENT_PRODUCTION);
$transaction = new MallTransaction($option);
$response = $transaction->refund(
$token,
$childBuyOrder,
$commerceCodeStoreOne,
$amount
);
var tx = new MallFullTransaction(new Options(IntegrationCommerceCodes.TRANSACCION_COMPLETA_MALL, IntegrationApiKeys.WEBPAY, IntegrationType.TEST));
var response = tx.Refund(
token,
buyOrder,
commerceCodeStoreOne,
amount
);
@options = Transbank::Webpay::Options.new("commerceCode", "APIKey", :integration)
@tx = Transbank::Webpay::TransaccionCompleta::Transaction.new(options)
@resp = @tx.refund(
token: token,
buy_order: child_buy_order,
commerce_code_child: commerce_store_1,
amount: amount
)
tx = MallTransaction(WebpayOptions(IntegrationCommerceCodes.TRANSACCION_COMPLETA_MALL, IntegrationApiKeys.WEBPAY, IntegrationType.TEST))
resp = tx.refund(token: token, child_buy_order: child_buy_order, child_commerce_code: commerce_store_1, amount: amount)
const tx = new TransaccionCompleta.MallTransaction(
new Options(
IntegrationCommerceCodes.TRANSACCION_COMPLETA_MALL,
IntegrationApiKeys.WEBPAY,
Environment.Integration
)
);
const response = await tx.refund(token, buyOrder, commerceCodeStoreOne, amount);
POST /rswebpaytransaction/api/webpay/v1.2/transactions/{token}/refunds
Tbk-Api-Key-Id: 597055555551
Tbk-Api-Key-Secret: 579B532A7440BB0C9079DED94D31EA1615BACEB56610332264630D42D0A36B1C
Content-Type: application/json
{
"buy_order": "415034240",
"commerce_code": "597055555552",
"amount": 1000
}
Parámetros Transaction.refund Completa Mall
| Nombre tipo |
Descripción |
|---|---|
| token String |
Token de la transacción. Largo: 64. (Se envía en la URL, no en el body) |
| buy_order String |
Orden de compra de la transacción que se requiere capturar. Largo máximo: 26. |
| commerce_code Number |
Tienda hija que realizó la transacción. Largo: 12. |
| amount Formato número entero para transacciones en peso. Sólo en caso de dólar acepta dos decimales. |
Monto que se desea anular o reversar de la transacción. Largo máximo: 17 |
Respuesta Transaction.refund Completa Mall
En el caso de que la transacción corresponda a una Reversa solo se retorna el parámetro type (REVERSED).
response.getType();
response.getAuthorizationCode();
response.getAuthorizationDate();
response.getNullifiedAmount();
response.getBalance();
response.getResponseCode();
$response->getType();
$response->getAuthorizationCode();
$response->getAuthorizationDate();
$response->getNullifiedAmount();
$response->getBalance();
$response->getResponseCode();
response.Type;
response.AuthorizationCode;
response.AuthorizationDate;
response.NullifiedAmount;
response.Balance;
response.ResponseCode;
response.type
response.authorization_code
response.authorization_date
response.nullified_amount
response.balance
response.response_code
## Versión 3.x del SDK
response['type']
response['authorization_code']
response['authorization_date']
response['nullified_amount']
response['balance']
response['response_code']
## Versión 2.x del SDK
response.type
response.authorization_code
response.authorization_date
response.nullified_amount
response.balance
response.response_code
200 OK
Content-Type: application/json
{
"type": "NULLIFY",
"authorization_code": "123456",
"authorization_date": "2019-03-20T20:18:20Z",
"nullified_amount": 1000.00,
"balance": 0.00,
"response_code": 0
}
response.type
response.authorization_code
response.authorization_date
response.nullified_amount
response.balance
response.response_code
| Nombre tipo |
Descripción |
|---|---|
| type String |
Tipo de reembolso (REVERSE o NULLIFY). Si es REVERSE no se devolverán datos de la transacción. Largo máximo: 10 |
| authorization_code String |
Código de autorización de la anulación. Largo máximo: 6. Solo viene en caso de anulación. |
| authorization_date String |
Fecha y hora de la autorización. Solo viene en caso de anulación. |
| nullified_amount Decimal |
Monto anulado. Largo máximo: 17. Solo viene en caso de anulación. |
| balance Decimal |
Saldo actualizado de la transacción (considera la venta menos el monto anulado). Largo máximo: 17. Solo viene en caso de anulación. |
| response_code Number |
Código del resultado del pago. Si es exitoso es 0, de lo contrario el pago no fue realizado. Largo máximo: 2. Solo viene en caso de anulación. |
Captura Diferida mall
Los comercios que están configurados para operar con captura diferida deben ejecutar el método de captura para realizar el cargo al tarjetahabiente.
Ejecutar captura diferida mall
Puedes [leer más sobre la captura en la información del
producto Webpay](https://www.transbankdevelopers.cl/producto/webpay#autorizacion-y-captura)
para conocer más detalles y restricciones.
Para realizar esa captura explícita debe usarse el método Transaction.capture()
Transaction.capture()
Los SDKs permiten indicar opcionalmente el código de comercio de la transacción a capturar, para soportar la captura en comercios Webpay Plus Mall o Transacción Completa Mall. En comercios sin modalidad Mall no es necesario especificar el código de comercio, ya que se usa el indicado en la configuración.
PUT /rswebpaytransaction/api/webpay/v1.2/transactions/{token}/capture
Tbk-Api-Key-Id: 597055555531
Tbk-Api-Key-Secret: 579B532A7440BB0C9079DED94D31EA1615BACEB56610332264630D42D0A36B1C
Content-Type: application/json
{
"commerce_code": "597055555531",
"buy_order": "415034240",
"authorization_code": "12345",
"capture_amount": 1000
}
@options = Transbank::Webpay::Options.new("commerceCode", "APIKey", :integration)
@tx = Transbank::Webpay::TransaccionCompleta::Transaction.new(options)
@resp = @tx.capture(
token: token,
commerce_code: commerce_store_1,
buy_order: buy_order,
authorization_code: authorization_code,
amount: capture_amount
)
$option = new Options($apiKey, $commerceCode, Options::ENVIRONMENT_PRODUCTION);
$transaction = new MallTransaction($option);
$response = $transaction->capture($token, $commerceCodeStoreOne, $buyOrder, $authorizationCode, $captureAmount);
const tx = new TransaccionCompleta.MallTransaction(
new Options(
IntegrationCommerceCodes.TRANSACCION_COMPLETA_MALL,
IntegrationApiKeys.WEBPAY,
Environment.Integration
)
);
const response = await tx.capture(
token,
commerceCodeStoreOne,
childBuyOrder,
authorizationCode,
captureAmount
);
var tx = new MallFullTransaction(new Options(IntegrationCommerceCodes.TRANSACCION_COMPLETA_MALL, IntegrationApiKeys.WEBPAY, IntegrationType.TEST));
var response = tx.Capture(
token,
commerceCodeStoreOne,
buyOrder,
authorizationCode,
captureAmount
);
tx = MallTransaction(WebpayOptions(IntegrationCommerceCodes.TRANSACCION_COMPLETA_MALL, IntegrationApiKeys.WEBPAY, IntegrationType.TEST))
resp = tx.capture(token, commerce_store_1, child_buy_order, authorization_code, capture_amount)
MallFullTransaction tx = new MallFullTransaction(new WebpayOptions(IntegrationCommerceCodes.TRANSACCION_COMPLETA, IntegrationApiKeys.WEBPAY, IntegrationType.TEST));
final MallFullTransactionCaptureResponse response = tx.capture(token, commerceCodeStoreOne, buyOrder, authorizationCode, captureAmount);
Parámetros Transaction.capture
| Nombre tipo |
Descripción |
|---|---|
| token String |
Token de la transacción. Largo: 64. (Se envía en la URL, no en el body) |
| commerce_code Number |
(Opcional, solo usar en caso Mall) Tienda hija que realizó la transacción. Largo: 12. |
| buy_order String |
Orden de compra de la transacción que se requiere capturar. Largo máximo: 26. La orden de compra puede tener: Números, letras, mayúsculas y minúsculas, y los signos |_=&%.,~:/?[+!@()>- . Los caracteres con signos no están soportados, como los acentos o signos no especificados. |
| authorization_code String |
Código de autorización de la transacción que se requiere capturar Largo máximo: 6. |
| capture_amount Decimal |
Monto que se desea capturar. Largo máximo: 17. |
Respuesta Transaction.capture
200 OK
Content-Type: application/json
{
"authorization_code": "123456",
"authorization_date": "2019-03-20T20:18:20Z",
"captured_amount": 1000,
"response_code": 0
}
$response->getAuthorizationCode();
$response->getAuthorizationDate();
$response->getCapturedAmount();
$response->getResponseCode();
response.authorization_code
response.authorization_date
response.captured_amount
response.response_code
response.getAuthorizationCode();
response.getAuthorizationDate();
response.getCapturedAmount();
response.getResponseCode();
response.authorization_code
response.authorization_date
response.captured_amount
response.response_code
## Versión 3.x del SDK
response['authorization_code']
response['authorization_date']
response['captured_amount']
response['response_code']
## Versión 2.x del SDK
response.token
response.authorization_code
response.authorization_date
response.captured_amount
response.response_code
| Nombre tipo |
Descripción |
|---|---|
| authorization_code String |
Código de autorización de la captura diferida. Largo máximo: 6 |
| authorization_date String |
Fecha y hora de la autorización. |
| captured_amount Decimal |
Monto capturado. Largo máximo: 6 |
| response_code Number |
Código de resultado de la captura. Si es exitoso es 0,de lo contrario la captura no fue realizada. Largo máximo: 2 |
En caso de error pueden aparecer los siguientes códigos exclusivos del método
Transaction.capture()
:
| Código | Descripción |
|---|---|
| 304 | Validación de campos de entrada nulos |
| 245 | Código de comercio no existe |
| 22 | El comercio no se encuentra activo |
| 316 | El comercio indicado no corresponde al certificado o no es hijo del comercio Mall en caso de transacciones MALL |
| 308 | Operación no permitida |
| 274 | Transacción no encontrada |
| 16 | La transacción no es de captura diferida |
| 292 | La transacción no está autorizada |
| 284 | Periodo de captura excedido |
| 310 | Transacción reversada previamente |
| 309 | Transacción capturada previamente |
| 311 | Monto a capturar excede el monto autorizado |
| 315 | Error del autorizador |
Códigos y mensajes de error
Al realizar cualquier solicitud al API REST, además de los datos de respuesta, se incluirá uno de los siguientes códigos de estado de respuesta HTTP dependiendo del resultado obtenido:
Solicitud exitosa
Cuando la operación solcitada es ejecutada correctamente, se pueden recibir estos status HTTP:
| Código de estado HTTP | Descripción |
|---|---|
| 200 | La operación se ha ejecutado exitosamente |
| 204 | La operación DELETE se ha ejecutado exitosamente |
Códigos de error
Todos los errores reportados por la API REST de Webpay despliegan un mensaje JSON con una descripción del error.
{
"error_message": "token is required"
}
| Código de estado HTTP | Descripción |
|---|---|
| 400 | El mensaje JSON es inválido. Puedes ser que no corresponda a un mensaje bien estructurado o que contenga un campo no esperado. |
| 401 | No autorizado. API Key y/o API Secret inválidos |
| 404 | La transacción no ha sido encontrada. |
| 405 | Método no permitido. |
| 406 | No fue posible procesar la respuesta en el formato que el cliente indica. |
| 415 | Tipo de mensaje no permitido. |
| 422 | El requerimiento no ha podido ser procesado ya sea por validaciones de datos o por lógica de negocios. |
| 500 | Ha ocurrido un error inesperado. |
Puesta en Producción
Puedes revisar el proceso necesario para operar en el ambiente de producción en [la documentación](https://www.transbankdevelopers.cl/documentacion/como_empezar#puesta-en-produccion)
Configuración para producción utilizando los SDK
Si estas utilizando algún SDK oficial de Transbank, entonces debes seguir los siguientes pasos.
Revisa [esta sección](https://www.transbankdevelopers.cl/documentacion/como_empezar#b-utilizando-los-sdk) de la documentación para ver el código necesario para configurar tu propio código de comercio y Api Key Secret.

# referencia_webpay.md

Source: https://www.transbankdevelopers.cl/referencia/webpay

Webpay Plus
Ambientes y Credenciales
La API REST de Webpay está protegida para garantizar que solamente comercios autorizados por Transbank hagan uso de las operaciones disponibles. La seguridad esta implementada mediante los siguientes mecanismos:
- Canal seguro a través de TLSv1.2 para la comunicación del cliente con Webpay.
- Autenticación y autorización mediante el intercambio de headers
Tbk-Api-Key-Id
(código de comercio) yTbk-Api-Key-Secret
(llave secreta).
Ambiente de Producción
Las URLs de endpoints de producción están alojados dentro de
[https://webpay3g.transbank.cl/](https://webpay3g.transbank.cl/).
// Host: https://webpay3g.transbank.cl
// Host: https://webpay3g.transbank.cl
// Host: https://webpay3g.transbank.cl
# Host: https://webpay3g.transbank.cl
# Host: https://webpay3g.transbank.cl
Host: https://webpay3g.transbank.cl
Ambiente de Integración
Las URLs de endpoints de integración están alojados dentro de
[https://webpay3gint.transbank.cl/](https://webpay3gint.transbank.cl/).
// Host: https://webpay3gint.transbank.cl
// Host: https://webpay3gint.transbank.cl
// Host: https://webpay3gint.transbank.cl
# Host: https://webpay3gint.transbank.cl
# Host: https://webpay3g.transbank.cl
Host: https://webpay3gint.transbank.cl
Consulta [la documentación para conocer las tarjetas de prueba que funcionan en
el ambiente de integración](https://www.transbankdevelopers.cl/documentacion/como_empezar#ambientes).
Credenciales del Comercio
// Tbk-Api-Key-Id: Código de comercio
// Tbk-Api-Key-Secret: Llave secreta
// Content-Type: application/json
// Tbk-Api-Key-Id: Código de comercio
// Tbk-Api-Key-Secret: Llave secreta
// Content-Type: application/json
// Tbk-Api-Key-Id: Código de comercio
// Tbk-Api-Key-Secret: Llave secreta
// Content-Type: application/json
# Tbk-Api-Key-Id: Código de comercio
# Tbk-Api-Key-Secret: Llave secreta
# Content-Type: application/json
# Tbk-Api-Key-Id: Código de comercio
# Tbk-Api-Key-Secret: Llave secreta
# Content-Type: application/json
Tbk-Api-Key-Id: Código de comercio
Tbk-Api-Key-Secret: Llave secreta
Content-Type: application/json
Todas las peticiones que hagas deben incluir el código de comercio y la llave secreta entregada por Transbank, actuando ambas como las credenciales que autorizan distintas operaciones.
Códigos de comercio
En la documentación puedes revisar [todos los códigos de comercio](https://www.transbankdevelopers.cl/documentacion/como_empezar#codigos-de-comercio) del ambiente de integración
Los SDKs ya incluyen esos códigos de comercio y llaves secretas que funcionan en el ambiente de integración, por lo que puedes obtener rápidamente una configuración lista para hacer tus primeras pruebas en dicho ambiente:
WebpayPlus.Transaction tx = new WebpayPlus.Transaction(new WebpayOptions(IntegrationCommerceCodes.WEBPAY_PLUS, IntegrationApiKeys.WEBPAY, IntegrationType.TEST));
use Transbank\Webpay\Options;
use Transbank\Webpay\WebpayPlus\Transaction;
$option = new Options($apiKey, $commerceCode, Options::ENVIRONMENT_INTEGRATION);
$transaction = new Transaction($option);
var tx = new Transaction(new Options(IntegrationCommerceCodes.WEBPAY_PLUS, IntegrationApiKeys.WEBPAY, WebpayIntegrationType.Test));
@tx = Transbank::Webpay::WebpayPlus::Transaction.new(::Transbank::Common::IntegrationCommerceCodes::WEBPAY_PLUS, ::Transbank::Common::IntegrationApiKeys::WEBPAY, :integration)
tx = Transaction(WebpayOptions(IntegrationCommerceCodes.WEBPAY_PLUS, IntegrationApiKeys.WEBPAY, IntegrationType.TEST))
const tx = new WebpayPlus.Transaction(
new Options(
IntegrationCommerceCodes.WEBPAY_PLUS,
IntegrationApiKeys.WEBPAY,
Environment.Integration)
);
Tbk-Api-Key-Id: 597055555532
Tbk-Api-Key-Secret: 579B532A7440BB0C9079DED94D31EA1615BACEB56610332264630D42D0A36B1C
Webpay Plus
Una transacción de autorización normal (o transacción normal), corresponde a una solicitud de autorización financiera de un pago con tarjetas de crédito o débito, en donde quién realiza el pago ingresa al sitio del comercio, selecciona productos o servicio, y el ingreso asociado a los datos de la tarjeta de crédito, débito o prepago lo realiza en forma segura en Webpay.
Flujo en caso de éxito y abortar un pago
Revisa [la documentación](https://www.transbankdevelopers.cl/documentacion/webpay-plus#flujo-en-caso-de-exito) de Webpay plus para revisar los diferentes flujos de pago posibles.
Crear una transacción
Puedes revisar más detalles de esta operación en [su documentación](https://www.transbankdevelopers.cl/documentacion/webpay-plus#crear-una-transaccion)
Permite inicializar una transacción en Webpay. Como respuesta a la invocación se genera un token que representa en forma única una transacción.
Para crear una transacción basta llamar al método Transaction.create()
WebpayPlus.Transaction transaction = WebpayPlus.Transaction.buildForIntegration("commerceCode", "APIKey");
final WebpayPlusTransactionCreateResponse response = transaction.create(buyOrder, sessionId, amount, returnUrl);
$transaction = Transaction::buildForIntegration($apiKey, $commerceCode);
$response = $transaction->create($buy_order, $session_id, $amount, $return_url);
Transaction transaction = Transaction.buildForIntegration("commerceCode", "APIKey");
var response = transaction.Create(buyOrder, sessionId, amount, returnUrl);
@transaction = Transbank::Webpay::WebpayPlus::Transaction.build_for_integration("commerceCode", "APIKey");
@resp = @transaction.create(
buy_order: @buy_order,
session_id: @session_id,
amount: @amount,
return_url: @return_url
);
tx = Transaction.build_for_integration("commerceCode", "APIKey")
resp = tx.create(buy_order, session_id, amount, return_url)
const transaction = WebpayPlus.Transaction.buildForIntegration(
"commerceCode",
"APIKey"
);
const response = await transaction.create(
buyOrder,
sessionId,
amount,
returnUrl
);
POST /rswebpaytransaction/api/webpay/v1.2/transactions
Tbk-Api-Key-Id: 597055555532
Tbk-Api-Key-Secret: 579B532A7440BB0C9079DED94D31EA1615BACEB56610332264630D42D0A36B1C
Content-Type: application/json
{
"buy_order": "ordenCompra12345678",
"session_id": "sesion1234557545",
"amount": 10000,
"return_url": "http://www.comercio.cl/webpay/retorno"
}
Parámetros Transaction.create
| Nombre tipo |
Descripción |
|---|---|
| buy_order String |
Orden de compra de la tienda. Este número debe ser único para cada transacción. Largo máximo: 26. La orden de compra puede tener: Números, letras, mayúsculas y minúsculas, y los signos |_=&%.,~:/?[+!@()>- . Los caracteres con signos no están soportados, como los acentos o signos no especificados. |
| session_id String |
Identificador de sesión, uso interno de comercio, este valor es devuelto al final de la transacción. Largo máximo: 61 |
| amount Decimal |
Monto de la transacción. Máximo 2 decimales para USD. Largo máximo: 17 |
| return_url String |
URL del comercio, a la cual Webpay redireccionará posterior al proceso de autorización. Largo máximo: 256 |
Respuesta Transaction.create
response.getUrl();
response.getToken();
// Puedes obtener la URL y el token devuelo utilizando estos métodos del objeto de respuesta:
$response->getUrl();
$response->getToken();
response.Url;
response.Token;
response.url
response.token
## Versión 3.x del SDK
response['url']
response['token']
## Versión 2.x del SDK
response.url
response.token
response.url
response.token
200 OK
Content-Type: application/json
{
"token": "e9d555262db0f989e49d724b4db0b0af367cc415cde41f500a776550fc5fddd3",
"url": "https://webpay3gint.transbank.cl/webpayserver/initTransaction"
}
| Nombre tipo |
Descripción |
|---|---|
| token String |
Token de la transacción. Largo: 64. |
| url String |
URL de formulario de pago Webpay. Largo máximo: 255. |
Confirmar una transacción
Puedes revisar más detalles de esta operación en [su documentación](https://www.transbankdevelopers.cl/documentacion/webpay-plus#confirmar-una-transaccion)
Permite confirmar y obtener el resultado de la transacción una vez que Webpay ha resuelto su autorización financiera.
Cuando el comercio retoma el control mediante return_url
debes confirmar y obtener
el resultado de una transacción usando el método Transaction.commit()
.
WebpayPlus.Transaction transaction = WebpayPlus.Transaction.buildForIntegration("commerceCode", "APIKey");
final WebpayPlusTransactionCommitResponse response = transaction.commit(token);
$transaction = Transaction::buildForIntegration($apiKey, $commerceCode);
$response = $transaction->commit($token);
Transaction transaction = Transaction.buildForIntegration("commerceCode", "APIKey");
var response = transaction.Commit(token);
@transaction = Transbank::Webpay::WebpayPlus::Transaction.build_for_integration("commerceCode", "APIKey");
@resp = @transaction.commit(token: @token);
tx = Transaction.build_for_integration("commerceCode", "APIKey")
resp = tx.commit(token)
const transaction = WebpayPlus.Transaction.buildForIntegration(
"commerceCode",
"APIKey"
);
const response = await transaction.commit(token);
PUT /rswebpaytransaction/api/webpay/v1.2/transactions/{token}
Tbk-Api-Key-Id: 597055555532
Tbk-Api-Key-Secret: 579B532A7440BB0C9079DED94D31EA1615BACEB56610332264630D42D0A36B1C
Content-Type: application/json
Parámetros Transaction.commit
| Nombre tipo |
Descripción |
|---|---|
| token String |
Token de la transacción. Largo: 64. (Se envía en la URL, no en el body) |
Respuesta Transaction.commit
response.getVci();
response.getAmount();
response.getStatus();
response.getBuyOrder();
response.getSessionId();
response.getCardDetail().getCardNumber();
response.getAccountingDate();
response.getTransactionDate();
response.getAuthorizationCode();
response.getPaymentTypeCode();
response.getResponseCode();
response.getInstallmentsAmount();
response.getInstallmentsNumber();
response.getBalance();
$response->getVci();
$response->getAmount();
$response->getStatus();
$response->getBuyOrder();
$response->getSessionId();
$response->getCardDetail();
$response->getAccountingDate();
$response->getTransactionDate();
$response->getAuthorizationCode();
$response->getPaymentTypeCode();
$response->getResponseCode();
$response->getInstallmentsAmount();
$response->getInstallmentsNumber();
$response->getBalance();
response.Vci;
response.Amount;
response.Status;
response.BuyOrder;
response.SessionId;
response.CardDetail;
response.AccountingDate;
response.TransactionDate;
response.AuthorizationCode;
response.PaymentTypeCode;
response.ResponseCode;
response.InstallmentsAmount;
response.InstallmentsNumber;
response.Balance;
response.vci
response.amount
response.status
response.buy_order
response.session_id
response.card_detail
response.accounting_date
response.transaction_date
response.authorization_code
response.payment_type_code
response.response_code
response.installments_amount
response.installments_number
response.balance
## Versión 3.x del SDK
response['vci']
response['amount']
response['status']
response['buy_order']
response['session_id']
response['card_detail']
response['accounting_date']
response['transaction_date']
response['authorization_code']
response['payment_type_code']
response['response_code']
response['installments_amount']
response['installments_number']
response['balance']
## Versión 2.x del SDK
response.vci
response.amount
response.status
response.buy_order
response.session_id
response.card_detail
response.accounting_date
response.transaction_date
response.authorization_code
response.payment_type_code
response.response_code
response.installments_amount
response.installments_number
response.balance
response.vci
response.amount
response.status
response.buy_order
response.session_id
response.card_detail
response.accounting_date
response.transaction_date
response.authorization_code
response.payment_type_code
response.response_code
response.installments_amount
response.installments_number
response.balance
200 OK
Content-Type: application/json
{
"vci": "TSY",
"amount": 10000,
"status": "AUTHORIZED",
"buy_order": "ordenCompra12345678",
"session_id": "sesion1234557545",
"card_detail": {
"card_number": "6623"
},
"accounting_date": "0522",
"transaction_date": "2019-05-22T16:41:21.063Z",
"authorization_code": "1213",
"payment_type_code": "VN",
"response_code": 0,
"installments_number": 0
}
| Nombre tipo |
Descripción |
|---|---|
| vci String |
Resultado de la autenticación del tarjetahabiente. Algunos de ellos son: TSY - Autenticación Exitosa TSN - Autenticación Rechazada NP - No Participa, sin autenticación U3 - Falla conexión, Autenticación Rechazada INV - Datos Inválidos A - Intentó CNP1 - Comercio no participa EOP - Error operacional BNA - BIN no adherido ENA - Emisor no adherido Para venta extranjera, estos son algunos de los códigos: TSYS (Autenticación exitosa Sin fricción. Resultado autenticación: Autenticación Existosa) TSAS (Intento, tarjeta no enrolada / emisor no disponible. Resultado autenticación: Autenticación Exitosa) TSNS (Fallido, no autenticado, denegado / no permite intentos. Resultado autenticación: Autenticación denegada) TSRS (Autenticación rechazada - sin fricción. Resultado autenticación: Autenticación rechazada) TSUS (Autenticación no se pudo realizar por problema técnico u otro motivo. Resultado autenticación: Autenticación fallida) TSCF (Autenticación con fricción (No aceptada por el comercio). Resultado autenticación: Autenticación incompleta) TSYF (Autenticación exitosa con fricción. Resultado autenticación: Autenticación exitosa) TSNF (No autenticado. Transacción denegada con fricción. Resultado autenticación: Autenticación denegada) TSUF (Autenticación con fricción no se pudo realizar por problema técnico u otro. Resultado autenticación: Autenticación fallida) NPC (Comercio no Participa. Resultado autenticación: Comercio/BIN no participa) NPB (BIN no participa. Resultado autenticación: Comercio/BIN no participa) NPCB (Comercio y BIN no participan. Resultado autenticación: Comercio/BIN no participa) SPCB (Comercio y BIN sí participan. Resultado autenticación: Autorización incompleta) Este campo es información adicional suplementaria al responseCode pero el comercio no debe validar este campo porque constantemente se agregan nuevos mecanismos de autenticación que se traducen en nuevos valores para este campo que no están necesariamente documentados. |
| amount Decimal |
Formato número entero para transacciones en peso y decimal para transacciones en dólares. Largo máximo: 17 |
| status String |
Estado de la transacción (INITIALIZED, AUTHORIZED, REVERSED, FAILED, NULLIFIED, PARTIALLY_NULLIFIED, CAPTURED). Largo máximo: 64 |
| buy_order String |
Orden de compra de la tienda indicado en Transaction.create() . Largo máximo: 26 |
| session_id String |
Identificador de sesión, el mismo enviado originalmente por el comercio en Transaction.create() . Largo máximo: 61. |
| card_detail carddetails |
Objeto que representa los datos de la tarjeta de crédito del tarjeta habiente. |
| card_detail.card_number String |
4 últimos números de la tarjeta de crédito del tarjetahabiente. Largo máximo: 19. |
| accounting_date String |
Fecha de la autorización. Largo: 4, formato MMDD |
| transaction_date String |
Fecha y hora de la autorización. Largo: 24, formato: ISO 8601 (Ej: yyyy-mm-ddTHH:mm:ss.xxxZ) |
| authorization_code String |
Código de autorización de la transacción Largo máximo: 6 |
| payment_type_code String |
VD = Venta Débito. VN = Venta Normal. VC = Venta en cuotas. SI = 3 cuotas sin interés. S2 = 2 cuotas sin interés. NC = N Cuotas sin interés VP = Venta Prepago. |
Number
0 = Transacción aprobada
Puedes revisar los códigos de respuesta de rechazo en el siguiente
[link](https://www.transbankdevelopers.cl/producto/webpay#codigos-de-respuesta-de-autorizacion)Number
Number
Number
Obtener estado de una transacción
Puedes revisar más detalles de esta operación en [su documentación](https://www.transbankdevelopers.cl/documentacion/webpay-plus#obtener-estado-de-una-transaccion)
Esta operación permite obtener el estado de la transacción en cualquier momento. En condiciones normales es probable que no se requiera ejecutar, pero en caso de ocurrir un error inesperado permite conocer el estado y tomar las acciones que correspondan.
Transaction.status()
WebpayPlus.Transaction transaction = WebpayPlus.Transaction.buildForIntegration("commerceCode", "APIKey");
final WebpayPlusTransactionStatusResponse response = transaction.status(token);
$transaction = Transaction::buildForIntegration($apiKey, $commerceCode);
$response = $transaction->status($token);
using Transbank.Webpay.WebpayPlus;
Transaction transaction = Transaction.buildForIntegration("commerceCode", "APIKey");
var response = transaction.status(token);
@transaction = Transbank::Webpay::WebpayPlus::Transaction.build_for_integration("commerceCode", "APIKey");
@resp = @transaction.status(token: @token);
tx = Transaction.build_for_integration("commerceCode", "APIKey")
resp = tx.status(token)
const transaction = WebpayPlus.Transaction.buildForIntegration(
"commerceCode",
"APIKey"
);
const response = await transaction.status(token);
GET /rswebpaytransaction/api/webpay/v1.2/transactions/{token}
Tbk-Api-Key-Id: 597055555532
Tbk-Api-Key-Secret: 579B532A7440BB0C9079DED94D31EA1615BACEB56610332264630D42D0A36B1C
Content-Type: application/json
Parámetros Transaction.status
| Nombre tipo |
Descripción |
|---|---|
| token String |
Token de la transacción. Largo: 64. (Se envía en la URL, no en el body) |
Respuesta Transaction.status
response.getVci();
response.getAmount();
response.getStatus();
response.getBuyOrder();
response.getSessionId();
response.getCardDetail().getCardNumber();
response.getAccountingDate();
response.getTransactionDate();
response.getAuthorizationCode();
response.getPaymentTypeCode();
response.getResponseCode();
response.getInstallmentsAmount();
response.getInstallmentsNumber();
response.getBalance();
$response->getVci();
$response->getAmount();
$response->getStatus();
$response->getBuyOrder();
$response->getSessionId();
$response->getCardDetail();
$response->getAccountingDate();
$response->getTransactionDate();
$response->getAuthorizationCode();
$response->getPaymentTypeCode();
$response->getResponseCode();
$response->getInstallmentsAmount();
$response->getInstallmentsNumber();
$response->getBalance();
response.Vci;
response.Amount;
response.Status;
response.BuyOrder;
response.SessionId;
response.CardDetail;
response.AccountingDate;
response.TransactionDate;
response.AuthorizationCode;
response.PaymentTypeCode;
response.ResponseCode;
response.InstallmentsAmount;
response.InstallmentsNumber;
response.Balance;
response.vci
response.amount
response.status
response.buy_order
response.session_id
response.card_detail
response.accounting_date
response.transaction_date
response.authorization_code
response.payment_type_code
response.response_code
response.installments_amount
response.installments_number
response.balance
## Versión 3.x del SDK
response['vci']
response['amount']
response['status']
response['buy_order']
response['session_id']
response['card_detail']
response['accounting_date']
response['transaction_date']
response['authorization_code']
response['payment_type_code']
response['response_code']
response['installments_amount']
response['installments_number']
response['balance']
## Versión 2.x del SDK
response.vci
response.amount
response.status
response.buy_order
response.session_id
response.card_detail
response.accounting_date
response.transaction_date
response.authorization_code
response.payment_type_code
response.response_code
response.installments_amount
response.installments_number
response.balance
response.vci
response.amount
response.status
response.buy_order
response.session_id
response.card_detail
response.accounting_date
response.transaction_date
response.authorization_code
response.payment_type_code
response.response_code
response.installments_amount
response.installments_number
response.balance
200 OK
Content-Type: application/json
{
"vci": "TSY",
"amount": 10000,
"status": "AUTHORIZED",
"buy_order": "ordenCompra12345678",
"session_id": "sesion1234557545",
"card_detail": {
"card_number": "6623"
},
"accounting_date": "0522",
"transaction_date": "2019-05-22T16:41:21.063Z",
"authorization_code": "1213",
"payment_type_code": "VN",
"response_code": 0,
"installments_number": 0
}
| Nombre tipo |
Descripción |
|---|---|
| vci String |
Resultado de la autenticación del tarjetahabiente. Algunos de ellos son: TSY - Autenticación Exitosa TSN - Autenticación Rechazada NP - No Participa, sin autenticación U3 - Falla conexión, Autenticación Rechazada INV - Datos Inválidos A - Intentó CNP1 - Comercio no participa EOP - Error operacional BNA - BIN no adherido ENA - Emisor no adherido Para venta extranjera, estos son algunos de los códigos: TSYS (Autenticación exitosa Sin fricción. Resultado autenticación: Autenticación Existosa) TSAS (Intento, tarjeta no enrolada / emisor no disponible. Resultado autenticación: Autenticación Exitosa) TSNS (Fallido, no autenticado, denegado / no permite intentos. Resultado autenticación: Autenticación denegada) TSRS (Autenticación rechazada - sin fricción. Resultado autenticación: Autenticación rechazada) TSUS (Autenticación no se pudo realizar por problema técnico u otro motivo. Resultado autenticación: Autenticación fallida) TSCF (Autenticación con fricción (No aceptada por el comercio). Resultado autenticación: Autenticación incompleta) TSYF (Autenticación exitosa con fricción. Resultado autenticación: Autenticación exitosa) TSNF (No autenticado. Transacción denegada con fricción. Resultado autenticación: Autenticación denegada) TSUF (Autenticación con fricción no se pudo realizar por problema técnico u otro. Resultado autenticación: Autenticación fallida) NPC (Comercio no Participa. Resultado autenticación: Comercio/BIN no participa) NPB (BIN no participa. Resultado autenticación: Comercio/BIN no participa) NPCB (Comercio y BIN no participan. Resultado autenticación: Comercio/BIN no participa) SPCB (Comercio y BIN sí participan. Resultado autenticación: Autorización incompleta) Este campo es información adicional suplementaria al responseCode pero el comercio no debe validar este campo porque constantemente se agregan nuevos mecanismos de autenticación que se traducen en nuevos valores para este campo que no están necesariamente documentados. |
| amount Formato número entero para transacciones en peso y decimal para transacciones en dólares. |
Monto de la transacción. Largo máximo: 17 |
| status String |
Estado de la transacción (INITIALIZED, AUTHORIZED, REVERSED, FAILED, NULLIFIED, PARTIALLY_NULLIFIED, CAPTURED). Largo máximo: 64 |
| buy_order String |
Orden de compra de la tienda indicado en Transaction.create() . Largo máximo: 26 |
| session_id String |
Identificador de sesión, el mismo enviado originalmente por el comercio en Transaction.create() . Largo máximo: 61. |
| card_detail carddetails |
Objeto que representa los datos de la tarjeta de crédito del tarjeta habiente. |
| card_detail.card_number String |
4 últimos números de la tarjeta de crédito del tarjetahabiente. Largo máximo: 19. |
| accounting_date String |
Fecha de la autorización. Largo: 4, formato MMDD |
| transaction_date String |
Fecha y hora de la autorización. Largo: 24, formato: ISO 8601 (Ej: yyyy-mm-ddTHH:mm:ss.xxxZ) |
| authorization_code String |
Código de autorización de la transacción Largo máximo: 6 |
| payment_type_code String |
VD = Venta Débito. VN = Venta Normal. VC = Venta en cuotas. SI = 3 cuotas sin interés. S2 = 2 cuotas sin interés. NC = N Cuotas sin interés VP = Venta Prepago. |
Number
0 = Transacción aprobada
Puedes revisar los códigos de respuesta de rechazo en el siguiente
[link](https://www.transbankdevelopers.cl/producto/webpay#codigos-de-respuesta-de-autorizacion)Number
Number
Number
Reversar o Anular un pago
Puedes revisar más detalles de esta operación en [su documentación](https://www.transbankdevelopers.cl/documentacion/webpay-plus#reversar-o-anular-una-transaccion)
Para anular una transacción se debe invocar al método Transaction.refund()
.
Transaction.refund()
Los SDKs permiten indicar opcionalmente el código de comercio de la transacción a anular, para soportar la anulación en comercios Webpay Plus Mall. En comercios Webpay Plus, no es necesario especificar el código de comercio pues se usa el indicado en la configuración.
WebpayPlus.Transaction transaction = WebpayPlus.Transaction.buildForIntegration("commerceCode", "APIKey");
final WebpayPlusTransactionRefundResponse response = transaction.refund(token, amount);
$transaction = Transaction::buildForIntegration($apiKey, $commerceCode);
$response = $transaction->refund($token, $amount);
Transaction transaction = Transaction.buildForIntegration("commerceCode", "APIKey");
var response = transaction.Refund(token, refundAmount);
@transaction = Transbank::Webpay::WebpayPlus::Transaction.build_for_integration("commerceCode", "APIKey");
@resp = @transaction.refund(token: @token, amount: @amount);
tx = Transaction.build_for_integration("commerceCode", "APIKey")
resp = tx.refund(token, amount)
const transaction = WebpayPlus.Transaction.buildForIntegration(
"commerceCode",
"APIKey"
);
const response = await transaction.refund(token, amount);
POST /rswebpaytransaction/api/webpay/v1.2/transactions/{token}/refunds
Tbk-Api-Key-Id: 597055555532
Tbk-Api-Key-Secret: 579B532A7440BB0C9079DED94D31EA1615BACEB56610332264630D42D0A36B1C
Content-Type: application/json
{
"amount": 1000
}
Parámetros Transaction.refund
| Nombre tipo |
Descripción |
|---|---|
| token String |
Token de la transacción. Largo: 64. (Se envía en la URL, no en el body) |
| amount Formato número entero para transacciones en peso. Sólo en caso de dólar acepta dos decimales. |
Monto que se desea anular o reversar de la transacción. Largo máximo: 17. |
Respuesta Transaction.refund
En el caso de que la transacción corresponda a una Reversa solo se retorna el parámetro type (REVERSED).
response.getAuthorizationCode();
response.getAuthorizationDate();
response.getBalance();
response.getNullifiedAmount();
response.getResponseCode();
response.getType();
// Puedes obtener los datos de la respuesta usando cualquiera de estos métedos del objeto de respuesta:
$response->getAuthorizationCode();
$response->getAuthorizationDate();
$response->getBalance();
$response->getNullifiedAmount();
$response->getResponseCode();
$response->getType();
response.AuthorizationCode;
response.AuthorizationDate;
response.Balance;
response.NullifiedAmount;
response.ResponseCode;
response.Type;
response.authorization_code;
response.authorization_date;
response.balance;
response.nullified_amount;
response.response_code;
response.type;
## Versión 3.x del SDK
response['authorization_code']
response['authorization_date']
response['balance']
response['nullified_amount']
response['response_code']
response['type']
## Versión 2.x del SDK
response.authorization_code
response.authorization_date
response.balance
response.nullified_amount
response.response_code
response.type
response.authorization_code
response.authorization_date
response.balance
response.nullified_amount
response.response_code
response.type
200 OK
Content-Type: application/json
{
"type": "NULLIFIED",
"authorization_code": "123456",
"authorization_date": "2019-03-20T20:18:20Z",
"nullified_amount": 1000.00,
"balance": 0.00,
"response_code": 0
}
| Nombre tipo |
Descripción |
|---|---|
| type String |
Tipo de reembolso (REVERSED o NULLIFIED). Si es REVERSED no se devolverán datos de la transacción (authorization code, etc). Largo máximo: 10 |
| authorization_code String |
(Solo si es NULLIFIED) Código de autorización de la anulación. Largo máximo: 6 |
| authorization_date String |
(Solo si es NULLIFIED) Fecha y hora de la autorización. |
| balance Decimal |
(Solo si es NULLIFIED) Saldo actualizado de la transacción (considera la venta menos el monto anulado). Largo máximo: 17 |
| nullified_amount Decimal |
(Solo si es NULLIFIED) Monto anulado. Largo máximo: 17 |
| response_code Number |
(Solo si es NULLIFIED) Código de resultado de la reversa/anulacion. Si es exitoso es 0, de lo contrario la reversa/anulación no fue realizada Largo Máximo: 2 |
En caso de error pueden aparecer los siguientes códigos de error comunes para el método Transaction.refund()
:
| Código | Descripción |
|---|---|
| 304 | Validación de campos de entrada nulos |
| 245 | Código de comercio no existe |
| 22 | El comercio no se encuentra activo |
| 316 | El comercio indicado no corresponde al certificado o no es hijo del comercio MALL en caso de transacciones MALL |
| 308 | Operación no permitida |
| 274 | Transacción no encontrada |
| 16 | La transacción no permite anulación |
| 292 | La transacción no está autorizada |
| 284 | Periodo de anulación excedido |
| 310 | Transacción anulada previamente |
| 311 | Monto a anular excede el saldo disponible para anular |
| 312 | Error genérico para anulaciones |
| 315 | Error del autorizador |
| 53 | La transacción no permite anulación parcial de transacciones con cuotas |
Capturar una transacción
Puedes revisar más detalles de esta operación en [su documentación](https://www.transbankdevelopers.cl/documentacion/webpay-plus#capturar-una-transaccion)
Permite solicitar a Webpay la captura diferida de una transacción con autorización y sin captura simultánea.
Transaction.capture()
WebpayPlus.Transaction transaction = WebpayPlus.Transaction.buildForIntegration("commerceCode", "APIKey");
final WebpayPlusTransactionCaptureResponse response = transaction.capture(token, buyOrder, authorizationCode, amount);
use Transbank\Webpay\WebpayPlus\Transaction;
$transaction = Transaction::buildForIntegration($apiKey, $commerceCode);
$response = $transaction->capture($token, $buyOrder, $authCode, $amount);
Transaction transaction = Transaction.buildForIntegration("commerceCode", "APIKey");
var response = transaction.capture(token, buyOrder, authorizationCode, amount);
@transaction = Transbank::Webpay::WebpayPlus::Transaction.build_for_integration("commerceCode", "APIKey");
@resp = @transaction.capture(
token: @token,
buy_order: @buy_order,
authorization_code: @auth_code,
amount: @amount
);
tx = Transaction.build_for_integration("commerceCode", "APIKey")
resp = tx.capture(
token=token, buy_order=buy_order, authorization_code=authorization_code, capture_amount=amount
)
const transaction = WebpayPlus.Transaction.buildForIntegration(
"commerceCode",
"APIKey"
);
const response = await tx.capture(
token,
buyOrder,
authorizationCode,
captureAmount
);
PUT /rswebpaytransaction/api/webpay/v1.2/transactions/{token}/capture
Tbk-Api-Key-Id: 597055555540
Tbk-Api-Key-Secret: 579B532A7440BB0C9079DED94D31EA1615BACEB56610332264630D42D0A36B1C
Content-Type: application/json
{
"buy_order": "415034240",
"authorization_code": "12345",
"capture_amount": 1000
}
Parámetros Transaction.capture
| Nombre tipo |
Descripción |
|---|---|
| token String |
Token de la transacción. Largo: 64. (Se envía en la URL, no en el body) |
| buy_order String |
Orden de compra de la transacción que se requiere capturar. Largo máximo: 26. La orden de compra puede tener: Números, letras, mayúsculas y minúsculas, y los signos |_=&%.,~:/?[+!@()>- . Los caracteres con signos no están soportados, como los acentos o signos no especificados. |
| authorization_code String |
Código de autorización de la transacción que se requiere capturar Largo máximo: 6. |
| capture_amount Decimal |
Monto que se desea capturar. Largo máximo: 17. |
Respuesta Transaction.capture
response.getAuthorizationCode();
response.getAuthorizationDate();
response.getCapturedAmount();
response.getResponseCode();
$response->getAuthorizationCode();
$response->getAuthorizationDate();
$response->getCapturedAmount();
$response->getResponseCode();
response.AuthorizationCode;
response.AuthorizationDate;
response.CapturedAmount;
response.ResponseCode;
response.authorization_code
response.authorization_date
response.captured_amount
response.response_code
## Versión 3.x del SDK
response['authorization_code']
response['authorization_date']
response['captured_amount']
response['response_code']
## Versión 2.x del SDK
response.authorization_code
response.authorization_date
response.captured_amount
response.response_code
response.authorization_code
response.authorization_date
response.captured_amount
response.response_code
200 OK
Content-Type: application/json
{
"token": "e074d38c628122c63e5c0986368ece22974d6fee1440617d85873b7b4efa48a3",
"authorization_code": "123456",
"authorization_date": "2019-03-20T20:18:20Z",
"captured_amount": 1000,
"response_code": 0
}
| Nombre tipo |
Descripción |
|---|---|
| token String |
Token de la transacción. Largo máximo: 64 |
| authorization_code String |
Código de autorización de la captura diferida. Largo máximo: 6 |
| authorization_date String |
Fecha y hora de la autorización. |
| captured_amount Decimal |
Monto capturado. Largo máximo: 6 |
| response_code Number |
Código de resultado de la captura. Si es exitoso es 0,de lo contrario la captura no fue realizada. Largo máximo: 2 |
En caso de error pueden aparecer los siguientes códigos exclusivos del método
Transaction.capture()
:
| Código | Descripción |
|---|---|
| 304 | Validación de campos de entrada nulos |
| 245 | Código de comercio no existe |
| 22 | El comercio no se encuentra activo |
| 316 | El comercio indicado no corresponde al certificado o no es hijo del comercio Mall en caso de transacciones MALL |
| 308 | Operación no permitida |
| 274 | Transacción no encontrada |
| 16 | La transacción no es de captura diferida |
| 292 | La transacción no está autorizada |
| 284 | Periodo de captura excedido |
| 310 | Transacción reversada previamente |
| 309 | Transacción capturada previamente |
| 311 | Monto a capturar excede el monto autorizado |
| 315 | Error del autorizador |
Webpay Plus Mall
Una transacción Mall Normal corresponde a una solicitud de autorización financiera de un conjunto de pagos con tarjetas de crédito o débito, en donde quién realiza el pago ingresa al sitio del comercio, selecciona productos o servicios, y el ingreso asociado a los datos de la tarjeta de crédito o débito lo realiza una única vez en forma segura en Webpay para el conjunto de pagos. Cada pago tendrá su propio resultado, autorizado o rechazado.
Revisa más detalles sobre esta modalidad en [la documentación](https://www.transbankdevelopers.cl/documentacion/webpay-plus#webpay-plus-mall)
Crear una transacción mall
Puedes revisar más detalles de esta operación en [su documentación](https://www.transbankdevelopers.cl/documentacion/webpay-plus#crear-una-transaccion-mall)
Para crear una transacción basta llamar al método Transaction.create()
Transaction.create() Mall
WebpayPlus.MallTransaction mallTransaction = WebpayPlus.MallTransaction.buildForIntegration("commerceCode", "APIKey");
MallTransactionCreateDetails mallDetails = MallTransactionCreateDetails.build()
.add(amountMallOne, commerceCodeStoreOne, buyOrderMallOne)
.add(amountMallTwo, commerceCodeStoreTwo, buyOrderMallTwo);
final WebpayPlusMallTransactionCreateResponse response = mallTransaction.create(buyOrder, sessionId, returnUrl, mallDetails);
$mallTransaction = MallTransaction::buildForIntegration($apiKey, $commerceCode);
$transaction_details = [
[
"amount" => 10000,
"commerce_code" => 'commerceCodeStoreOne',
"buy_order" => "ordenCompraDetalle1234"
],
[
"amount" =>12000,
"commerce_code" => 'commerceCodeStoreTwo',
"buy_order" => "ordenCompraDetalle4321"
],
];
$response = $mallTransaction->create($buy_order, $session_id, $return_url, $transaction_details);
MallTransaction mallTransaction = MallTransaction.buildForIntegration("commerceCode", "APIKey");
var transactionDetails = new List();
transactionDetails.Add(new TransactionDetail(
amountMallOne,
commerceCodeStoreOne,
buyOrderMallOne
));
transactionDetails.Add(new TransactionDetail(
amountMallTwo,
commerceCodeStoreTwo,
buyOrderMallTwo
));
var result = mallTransaction.Create(buyOrder, sessionId, returnUrl, transactionDetails);
@mall_transaction = Transbank::Webpay::WebpayPlus::MallTransaction.build_for_integration("commerceCode", "APIKey");
@transaction_details = [
{
amount: 10000,
commerce_code: "commerce_store_1",
buy_order: "ordenCompraDetalle1234"
},
{
amount: 12000,
commerce_code: "commerce_store_2",
buy_order: "ordenCompraDetalle4321"
},
];
@resp = @mall_transaction.create(
buy_order: @buy_order,
session_id: @session_id,
return_url: @return_url,
details: @transaction_details
);
mall_tx = MallTransaction.build_for_integration("commerceCode", "APIKey")
transaction_details = MallTransactionCreateDetails(
amount_child_1, commerce_store_1, buy_order_child_1
).add(
amount_child_2, commerce_store_2, buy_order_child_2
)
resp = mall_tx.create(
buy_order=buy_order,
session_id=session_id,
return_url=return_url,
details = transaction_details,
)
const mallTransaction = WebpayPlus.MallTransaction.buildForIntegration(
"commerceCode",
"APIKey"
);
let details = [
new TransactionDetail(amount, commerceCodeStoreOne, buyOrder),
new TransactionDetail(amount2, commerceCodeStoreTwo, buyOrder2),
];
const response = await mallTransaction.create(
buyOrder,
sessionId,
returnUrl,
details
);
POST /rswebpaytransaction/api/webpay/v1.2/transactions
Tbk-Api-Key-Id: 597055555535
Tbk-Api-Key-Secret: 579B532A7440BB0C9079DED94D31EA1615BACEB56610332264630D42D0A36B1C
Content-Type: application/json
{
"buy_order": "ordenCompra12345678",
"session_id": "sesion1234557545",
"return_url": "http://www.comercio.cl/webpay/retorno",
"details": [
{
"amount": 10000,
"commerce_code": 597055555536,
"buy_order": "ordenCompraDetalle1234"
},
{
"amount": 12000,
"commerce_code": 597055555537,
"buy_order": "ordenCompraDetalle4321"
},
]
}
Parámetros Transaction.create Mall
| Nombre tipo |
Descripción |
|---|---|
| buy_order String |
Es el código único de la orden de compra generada por el comercio mall. Este número debe ser único para cada transacción. Largo máximo: 26. La orden de compra puede tener: Números, letras, mayúsculas y minúsculas, y los signos |_=&%.,~:/?[+!@()>- . Los caracteres con signos no están soportados, como los acentos o signos no especificados. |
| session_id String |
Identificador de sesión, uso interno de comercio, este valor es devuelto al final de la transacción. Largo máximo: 61 |
| return_url String |
URL del comercio, a la cual Webpay redireccionará posterior al proceso de autorización Largo máximo: 256. |
| details Array |
Lista de objetos, uno por cada tienda diferente del mall que participa en la transacción. |
| details [].amount Decimal |
Monto de la transacción de una tienda del mall. Máximo 2 decimales para USD. Largo máximo: 10. |
| details [].commerce_code String |
Código comercio asignado por Transbank para la tienda perteneciente al mall a la cual corresponde esta transacción. Largo: 12. |
| details [].buy_order String |
Orden de compra de la tienda del mall. Este número debe ser único para cada transacción. Largo máximo: 26. La orden de compra puede tener: Números, letras, mayúsculas y minúsculas, y los signos |_=&%.,~:/?[+!@()>- .Los caracteres con signos no están soportados, como los acentos o signos no especificados. |
Respuesta Transaction.create() Mall
response.getToken();
response.getUrl();
$response->getToken();
$response->getUrl();
response.Token;
response.Url;
response.token
response.url
## Versión 3.x del SDK
response['token']
response['url']
## Versión 2.x del SDK
response.token
response.url
response.token
response.url
200 OK
Content-Type: application/json
{
"token": "e9d555262db0f989e49d724b4db0b0af367cc415cde41f500a776550fc5fddd3",
"url": "https://webpay3gint.transbank.cl/webpayserver/initTransaction"
}
| Nombre tipo |
Descripción |
|---|---|
| token String |
Token de la transacción. Largo: 64. |
| url String |
URL de formulario de pago Webpay. Largo máximo: 256. |
Confirmar una transacción mall
Puedes revisar más detalles de esta operación en [su documentación](https://www.transbankdevelopers.cl/documentacion/webpay-plus#confirmar-una-transaccion-mall)
Permite confirmar una tranascción y obtener el resultado de la transacción una vez que Webpay ha resueltosu autorización financiera.
Transaction.commit() Mall
WebpayPlus.MallTransaction mallTransaction = WebpayPlus.MallTransaction.buildForIntegration("commerceCode", "APIKey");
final WebpayPlusMallTransactionCommitResponse response = mallTransaction.commit(token);
$mallTransaction = MallTransaction::buildForIntegration($apiKey, $commerceCode);
$response = $mallTransaction->commit($token);
using Transbank.Webpay.WebpayPlus;
MallTransaction mallTransaction = MallTransaction.buildForIntegration("commerceCode", "APIKey");
var response = mallTransaction.Commit(token);
@mall_transaction = Transbank::Webpay::WebpayPlus::MallTransaction.build_for_integration("commerceCode", "APIKey");
@resp = @mall_transaction.commit(token: @token);
mall_tx = MallTransaction.build_for_integration("commerceCode", "APIKey")
resp = mall_tx.commit(token)
const mallTransaction = WebpayPlus.MallTransaction.buildForIntegration(
"commerceCode",
"APIKey"
);
const response = await mallTransaction.commit(token);
PUT /rswebpaytransaction/api/webpay/v1.2/transactions/{token}
Tbk-Api-Key-Id: 597055555535
Tbk-Api-Key-Secret: 579B532A7440BB0C9079DED94D31EA1615BACEB56610332264630D42D0A36B1C
Content-Type: application/json
Parámetros Transaction.commit Mall
| Nombre tipo |
Descripción |
|---|---|
| token String |
Token de la transacción. Largo: 64. (Se envía en la URL, no en el body) |
Respuesta Transaction.commit Mall
response.getAccountingDate();
response.getBuyOrder();
final CardDetail cardDetail = response.getCardDetail();
cardDetail.getCardNumber();
response.getSessionId();
response.getTransactionDate();
response.getVci();
final List<Detail> details = response.getDetails();
for (Detail detail : details) {
detail.getAmount();
detail.getAuthorizationCode();
detail.getBuyOrder();
detail.getCommerceCode();
detail.getInstallmentsNumber();
detail.getPaymentTypeCode();
detail.getResponseCode();
detail.getStatus();
}
$response->getAccountingDate();
$response->getBuyOrder();
$response->getCardDetail();
$response->getCardNumber(); // Solo en SDK 2.x
$response->getSessionId();
$response->getTransactionDate();
$response->getVci();
$details = $response->getDetails();
foreach($details as $detail){ // En SDk 2.x cada $detail es un Objeto TransactionDetails
$detail->getAmount();
$detail->getAuthorizationCode();
$detail->getBuyOrder();
$detail->getCommerceCode();
$detail->getInstallmentsNumber();
$detail->getPaymentTypeCode();
$detail->getResponseCode();
$detail->getStatus();
$detail->isApproved(); // Solo en SDK 2.x - Indica si esta sub transacción puede ser considerada como aprobada
}
$response->isApproved(); // Solo en SDK 2.x - Devuelve true si al menos una de las subtransacciones fue autorizada.
response.AccountingDate;
response.BuyOrder;
var cardDetail = response.CardDetail;
cardDetail.CardNumber;
response.SessionId;
response.TransactionDate;
response.Vci;
var details = response.Details;
foreach (var detail in details) {
detail.Amount;
detail.AuthorizationCode;
detail.BuyOrder;
detail.CommerceCode;
detail.InstallmentsNumber;
detail.PaymentTypeCode;
detail.ResponseCode;
detail.Status;
}
response.accounting_date
response.buy_order
card_detail = response.card_detail
card_detail.card_number
response.session_id
response.transaction_date
response.vci
details = response.details
details.each do |detail|
detail.amount
detail.authorization_code
detail.buy_order
detail.commerce_code
detail.installments_number
detail.payment_type_code
detail.response_code
detail.status
end
## Versión 3.x del SDK
response['accounting_date']
response['buy_order']
response['card_detail']
response['session_id']
response['transaction_date']
response['vci']
## Versión 2.x del SDK
response.accounting_date
response.buy_order
card_detail = response.card_detail
card_detail.card_number
response.session_id
response.transaction_date
response.vci
details = response.details
for detail in details:
detail.amount
detail.authorization_code
detail.buy_order
detail.commerce_code
detail.installments_number
detail.payment_type_code
detail.response_code
detail.status
response.accounting_date
response.buy_order
cardDetail = response.card_detail
cardDetail.card_number
response.session_id
response.transaction_date
response.vci
details = response.details
details.forEach(detail => {
detail.amount
detail.authorization_code
detail.buy_order
detail.commerce_code
detail.installments_number
detail.payment_type_code
detail.response_code
detail.status
});
200 OK
Content-Type: application/json
{
"buy_order": "415034240",
"card_detail": {
"card_number": "6623"
},
"accounting_date": "0321",
"transaction_date": "2019-03-21T15:43:48.523Z",
"details": [
{
"amount": 10000,
"status": "AUTHORIZED",
"authorization_code": "1213",
"payment_type_code": "VN",
"response_code": 0,
"installments_number": 0,
"commerce_code": "597055555536",
"buy_order": "505479072",
"status": "AUTHORIZED"
}]
}
| Nombre tipo |
Descripción |
|---|---|
| buy_order String |
Orden de compra del mall. Largo máximo: 26 |
| session_id String |
Identificador de sesión, el mismo enviado originalmente por el comercio en Transaction.create() . Largo máximo: 61. |
| card_detail carddetails |
Objeto que representa los datos de la tarjeta de crédito del tarjeta habiente. |
| card_detail.card_number String |
4 últimos números de la tarjeta de crédito del tarjetahabiente. Largo máximo: 16. |
| accouting_date String |
Fecha de la autorización. Largo: 4, formato MMDD |
| transaction_date String |
Fecha y hora de la autorización. Largo: 24, formato: ISO 8601 (Ej: yyyy-mm-ddTHH:mm:ss.xxxZ) |
| vci String |
Resultado de la autenticación del tarjetahabiente. Algunos de ellos son: TSY - Autenticación Exitosa TSN - Autenticación Rechazada NP - No Participa, sin autenticación U3 - Falla conexión, Autenticación Rechazada INV - Datos Inválidos A - Intentó CNP1 - Comercio no participa EOP - Error operacional BNA - BIN no adherido ENA - Emisor no adherido Para venta extranjera, estos son algunos de los códigos: TSYS (Autenticación exitosa Sin fricción. Resultado autenticación: Autenticación Existosa) TSAS (Intento, tarjeta no enrolada / emisor no disponible. Resultado autenticación: Autenticación Exitosa) TSNS (Fallido, no autenticado, denegado / no permite intentos. Resultado autenticación: Autenticación denegada) TSRS (Autenticación rechazada - sin fricción. Resultado autenticación: Autenticación rechazada) TSUS (Autenticación no se pudo realizar por problema técnico u otro motivo. Resultado autenticación: Autenticación fallida) TSCF (Autenticación con fricción (No aceptada por el comercio). Resultado autenticación: Autenticación incompleta) TSYF (Autenticación exitosa con fricción. Resultado autenticación: Autenticación exitosa) TSNF (No autenticado. Transacción denegada con fricción. Resultado autenticación: Autenticación denegada) TSUF (Autenticación con fricción no se pudo realizar por problema técnico u otro. Resultado autenticación: Autenticación fallida) NPC (Comercio no Participa. Resultado autenticación: Comercio/BIN no participa) NPB (BIN no participa. Resultado autenticación: Comercio/BIN no participa) NPCB (Comercio y BIN no participan. Resultado autenticación: Comercio/BIN no participa) SPCB (Comercio y BIN sí participan. Resultado autenticación: Autorización incompleta) Este campo es información adicional suplementaria al responseCode pero el comercio no debe validar este campo porque constantemente se agregan nuevos mecanismos de autenticación que se traducen en nuevos valores para este campo que no están necesariamente documentados. |
| details Array |
Lista con resultado de cada una de las transacciones enviados en Transaction.create() . |
| details [].authorization_code String |
Código de autorización de la transacción Largo máximo: 6 |
| details [].payment_type_code String |
VD = Venta Débito. VN = Venta Normal. VC = Venta en cuotas. SI = 3 cuotas sin interés. S2 = 2 cuotas sin interés. NC = N Cuotas sin interés VP = Venta Prepago. |
Number
0 = Transacción aprobada
Puedes revisar los códigos de respuesta de rechazo en el siguiente
[link](https://www.transbankdevelopers.cl/producto/webpay#codigos-de-respuesta-de-autorizacion)Formato número entero para transacciones en peso y decimal para transacciones en dólares.
Number
Number
String
String
String
Number
Obtener estado de una transacción mall
Puedes revisar más detalles de esta operación en [su documentación](https://www.transbankdevelopers.cl/documentacion/webpay-plus#obtener-estado-de-una-transaccion-mall)
Esta operación permite obtener el estado de la transacción en cualquier momento. En condiciones normales es probable que no se requiera ejecutar, pero en caso de ocurrir un error inesperado permite conocer el estado y tomar las acciones que correspondan.
Transaction.status() Mall
Obtiene resultado de transacción a partir de un token.
WebpayPlus.MallTransaction mallTransaction = WebpayPlus.MallTransaction.buildForIntegration("commerceCode", "APIKey");
final WebpayPlusMallTransactionStatusResponse response = mallTransaction.status(token);
$mallTransaction = MallTransaction::buildForIntegration($apiKey, $commerceCode);
$response = $mallTransaction->status($token);
MallTransaction mallTransaction = MallTransaction.buildForIntegration("commerceCode", "APIKey");
var response = mallTransaction.Status(token);
@mall_transaction = Transbank::Webpay::WebpayPlus::MallTransaction.build_for_integration("commerceCode", "APIKey");
@resp = @mall_transaction.status(token: @token);
mall_tx = MallTransaction.build_for_integration("commerceCode", "APIKey")
resp = mall_tx.status(token)
const mallTransaction = WebpayPlus.MallTransaction.buildForIntegration(
"commerceCode",
"APIKey"
);
const response = await mallTransaction.status(token);
GET /rswebpaytransaction/api/webpay/v1.2/transactions/{token}
Tbk-Api-Key-Id: 597055555535
Tbk-Api-Key-Secret: 579B532A7440BB0C9079DED94D31EA1615BACEB56610332264630D42D0A36B1C
Content-Type: application/json
Parámetros Transaction.status Mall
| Nombre tipo |
Descripción |
|---|---|
| token String |
Token de la transacción. Largo: 64. (Se envía en la URL, no en el body) |
Respuesta Transaction.status Mall
response.getAccountingDate();
response.getBuyOrder();
final CardDetail cardDetail = response.getCardDetail();
cardDetail.getCardNumber();
response.getSessionId();
response.getTransactionDate();
response.getVci();
final List<Detail> details = response.getDetails();
for (Detail detail : details) {
detail.getAmount();
detail.getAuthorizationCode();
detail.getBuyOrder();
detail.getCommerceCode();
detail.getInstallmentsNumber();
detail.getPaymentTypeCode();
detail.getResponseCode();
detail.getStatus();
}
$response->getAccountingDate();
$response->getBuyOrder();
$response->getCardDetail();
$response->getCardNumber(); // Solo en SDK 2.x
$response->getSessionId();
$response->getTransactionDate();
$response->getVci();
$details = $response->getDetails();
foreach($details as $detail){ // En SDk 2.x cada $detail es un Objeto TransactionDetails
$detail->getAmount();
$detail->getAuthorizationCode();
$detail->getBuyOrder();
$detail->getCommerceCode();
$detail->getInstallmentsNumber();
$detail->getPaymentTypeCode();
$detail->getResponseCode();
$detail->getStatus();
$detail->isApproved(); // Solo en SDK 2.x - Indica si esta sub transacción puede ser considerada como aprobada
}
$response->isApproved(); // Solo en SDK 2.x - Devuelve true si al menos una de las subtransacciones fue autorizada.
response.AccountingDate;
response.BuyOrder;
var cardDetail = response.CardDetail;
cardDetail.CardNumber;
response.SessionId;
response.TransactionDate;
response.Vci;
var details = response.Details;
foreach (var detail in details) {
detail.Amount;
detail.AuthorizationCode;
detail.BuyOrder;
detail.CommerceCode;
detail.InstallmentsNumber;
detail.PaymentTypeCode;
detail.ResponseCode;
detail.Status;
}
response.accounting_date
response.buy_order
card_detail = response.card_detail
card_detail.card_number
response.session_id
response.transaction_date
response.vci
details = response.details
details.each do |detail|
detail.amount
detail.authorization_code
detail.buy_order
detail.commerce_code
detail.installments_number
detail.payment_type_code
detail.response_code
detail.status
end
## Versión 3.x del SDK
response['accounting_date']
response['buy_order']
response['card_detail']
response['session_id']
response['transaction_date']
response['vci']
## Versión 2.x del SDK
response.accounting_date
response.buy_order
card_detail = response.card_detail
card_detail.card_number
response.session_id
response.transaction_date
response.vci
details = response.details
for detail in details:
detail.amount
detail.authorization_code
detail.buy_order
detail.commerce_code
detail.installments_number
detail.payment_type_code
detail.response_code
detail.status
response.accounting_date
response.buy_order
cardDetail = response.card_detail
cardDetail.card_number
response.session_id
response.transaction_date
response.vci
details = response.details
details.forEach(detail => {
detail.amount
detail.authorization_code
detail.buy_order
detail.commerce_code
detail.installments_number
detail.payment_type_code
detail.response_code
detail.status
});
200 OK
Content-Type: application/json
{
"buy_order": "415034240",
"card_detail": {
"card_number": "6623"
},
"accounting_date": "0321",
"transaction_date": "2019-03-21T15:43:48.523Z",
"vci": "TSY",
"details": [
{
"amount": 10000,
"status": "AUTHORIZED",
"authorization_code": "1213",
"payment_type_code": "VN",
"response_code": 0,
"installments_number": 0,
"commerce_code": "597055555536",
"buy_order": "505479072",
"status": "AUTHORIZED"
}]
}
| Nombre tipo |
Descripción |
|---|---|
| buy_order String |
Orden de compra del mall. Largo máximo: 26 |
| session_id String |
Identificador de sesión, el mismo enviado originalmente por el comercio en Transaction.create() . Largo máximo: 61. |
| card_detail carddetails |
Objeto que representa los datos de la tarjeta de crédito del tarjeta habiente. |
| card_detail.card_number String |
4 últimos números de la tarjeta de crédito del tarjetahabiente. Largo máximo: 16. |
| accouting_date String |
Fecha de la autorización. Largo: 4, formato MMDD |
| transaction_date String |
Fecha y hora de la autorización. Largo: 24, formato: ISO 8601 (Ej: yyyy-mm-ddTHH:mm:ss.xxxZ) |
| vci String |
Resultado de la autenticación del tarjetahabiente. Algunos de ellos son: TSY - Autenticación Exitosa TSN - Autenticación Rechazada NP - No Participa, sin autenticación U3 - Falla conexión, Autenticación Rechazada INV - Datos Inválidos A - Intentó CNP1 - Comercio no participa EOP - Error operacional BNA - BIN no adherido ENA - Emisor no adherido Para venta extranjera, estos son algunos de los códigos: TSYS (Autenticación exitosa Sin fricción. Resultado autenticación: Autenticación Existosa) TSAS (Intento, tarjeta no enrolada / emisor no disponible. Resultado autenticación: Autenticación Exitosa) TSNS (Fallido, no autenticado, denegado / no permite intentos. Resultado autenticación: Autenticación denegada) TSRS (Autenticación rechazada - sin fricción. Resultado autenticación: Autenticación rechazada) TSUS (Autenticación no se pudo realizar por problema técnico u otro motivo. Resultado autenticación: Autenticación fallida) TSCF (Autenticación con fricción (No aceptada por el comercio). Resultado autenticación: Autenticación incompleta) TSYF (Autenticación exitosa con fricción. Resultado autenticación: Autenticación exitosa) TSNF (No autenticado. Transacción denegada con fricción. Resultado autenticación: Autenticación denegada) TSUF (Autenticación con fricción no se pudo realizar por problema técnico u otro. Resultado autenticación: Autenticación fallida) NPC (Comercio no Participa. Resultado autenticación: Comercio/BIN no participa) NPB (BIN no participa. Resultado autenticación: Comercio/BIN no participa) NPCB (Comercio y BIN no participan. Resultado autenticación: Comercio/BIN no participa) SPCB (Comercio y BIN sí participan. Resultado autenticación: Autorización incompleta) Este campo es información adicional suplementaria al responseCode pero el comercio no debe validar este campo porque constantemente se agregan nuevos mecanismos de autenticación que se traducen en nuevos valores para este campo que no están necesariamente documentados. |
| details Array |
Lista con resultado de cada una de las transacciones enviados en Transaction.create() . |
| details [].authorization_code String |
Código de autorización de la transacción Largo máximo: 6 |
| details [].payment_type_code String |
VD = Venta Débito. VN = Venta Normal. VC = Venta en cuotas. SI = 3 cuotas sin interés. S2 = 2 cuotas sin interés. NC = N Cuotas sin interés VP = Venta Prepago. |
Number
0 = Transacción aprobada
Puedes revisar los códigos de respuesta de rechazo en el siguiente
[link](https://www.transbankdevelopers.cl/producto/webpay#codigos-de-respuesta-de-autorizacion)Formato número entero para transacciones en peso y decimal para transacciones en dólares.
Number
Number
String
String
String
Number
Reversar o anular una transaccion mall
Puedes revisar más detalles de esta operación en [su documentación](https://www.transbankdevelopers.cl/documentacion/webpay-plus#reversar-o-anular-una-transaccion-mall)
Este método permite a todo comercio habilitado reversar o anular una transacción que fue generada en Webpay Plus Mall.
Para anular una transacción se debe invocar al método Transaction.refund()
.
Transaction.refund() Mall
WebpayPlus.MallTransaction mallTransaction = WebpayPlus.MallTransaction.buildForIntegration("commerceCode", "APIKey");
final WebpayPlusTransactionRefundResponse response = mallTransaction.refund(token, childBuyOrder, commerceCodeStoreOne, amount);
$mallTransaction = MallTransaction::buildForIntegration($apiKey, $commerceCode);
$response = $mallTransaction->refund($token, $buy_order, $commerce_code, $amount);
MallTransaction mallTransaction = MallTransaction.buildForIntegration("commerceCode", "APIKey");
var response = mallTransaction.Refund(token, buyOrder, commerceCode, amount);
@mall_transaction = Transbank::Webpay::WebpayPlus::MallTransaction.build_for_integration("commerceCode", "APIKey");
@resp = @mall_transaction.refund(token: @token, buy_order: @child_buy_order, child_commerce_code: @commerce_store_1, amount: @amount);
mall_tx = MallTransaction.build_for_integration("commerceCode", "APIKey")
resp = mall_tx.refund(token, child_buy_order, commerce_store_1, amount)
const mallTransaction = WebpayPlus.MallTransaction.buildForIntegration(
"commerceCode",
"APIKey"
);
const response = await mallTransaction.refund(
token,
buyOrder,
commerceCodeStoreOne,
amount
);
POST /rswebpaytransaction/api/webpay/v1.2/transactions/{token}/refunds
Tbk-Api-Key-Id: 597055555535
Tbk-Api-Key-Secret: 579B532A7440BB0C9079DED94D31EA1615BACEB56610332264630D42D0A36B1C
Content-Type: application/json
{
"commerce_code": "597055555536",
"buy_order": "ordenCompra12345678",
"amount": 1000
}
Parámetros Transaction.refund Mall
| Nombre tipo |
Descripción |
|---|---|
| token String |
Token de la transacción. Largo: 64. (Se envía en la URL, no en el body) |
| buy_order String |
Orden de compra de la transacción que se requiere anular. Largo máximo: 26. |
| amount Formato número entero para transacciones en peso. Sólo en caso de dólar acepta dos decimales. |
Monto que se desea anular o reversar de la transacción. Largo máximo: 17. |
| commerce_code Number |
Código de comercio de la tienda mall que realizó la transacción. Largo: 12. |
Respuesta Transaction.refund Mall
En el caso de que la transacción corresponda a una Reversa solo se retorna el parámetro type (REVERSED).
response.getAuthorizationCode();
response.getAuthorizationDate();
response.getBalance();
response.getNullifiedAmount();
response.getResponseCode();
response.getType();
$response->getAuthorizationCode();
$response->getAuthorizationDate();
$response->getBalance();
$response->getNullifiedAmount();
$response->getResponseCode();
$response->getType();
response.AuthorizationCode;
response.AuthorizationDate;
response.Balance;
response.NullifiedAmount;
response.ResponseCode;
response.Type;
response.authorization_code
response.authorization_date
response.balance
response.nullified_amount
response.response_code
response.type
## Versión 3.x del SDK
response['authorization_code']
response['authorization_date']
response['balance']
response['nullified_amount']
response['response_code']
response['type']
## Versión 2.x del SDK
response.authorization_code
response.authorization_date
response.balance
response.nullified_amount
response.response_code
response.type
response.authorization_code
response.authorization_date
response.balance
response.nullified_amount
response.response_code
response.type
200 OK
Content-Type: application/json
{
"type": "NULLIFIED",
"authorization_code": "123456",
"authorization_date": "2019-03-20T20:18:20Z",
"nullified_amount": 1000.00,
"balance": 0.00,
"response_code": 0
}
| Nombre tipo |
Descripción |
|---|---|
| type String |
Tipo de reembolso (REVERSED o NULLIFIED). Si es REVERSED no se devolverán datos de la transacción (authorization code, etc). Largo máximo: 10 |
| authorization_code String |
(Solo si es NULLIFIED) Código de autorización de la anulación. Largo máximo: 6 |
| authorization_date String |
(Solo si es NULLIFIED) Fecha y hora de la autorización. |
| balance Decimal |
(Solo si es NULLIFIED) Saldo actualizado de la transacción (considera la venta menos el monto anulado). Largo máximo: 17 |
| nullified_amount Decimal |
(Solo si es NULLIFIED) Monto anulado. Largo máximo: 17 |
| response_code Number |
(Solo si es NULLIFIED) Código de resultado de la reversa/anulación. Si es exitoso es 0, de lo contrario la reversa/anulación no fue realizada. Largo máximo: 2 |
En caso de error pueden aparecer los siguientes códigos de error comunes para el método Transaction.refund()
:
| Código | Descripción |
|---|---|
| 304 | Validación de campos de entrada nulos |
| 245 | Código de comercio no existe |
| 22 | El comercio no se encuentra activo |
| 316 | El comercio indicado no corresponde al certificado o no es hijo del comercio MALL en caso de transacciones MALL |
| 308 | Operación no permitida |
| 274 | Transacción no encontrada |
| 16 | La transacción no permite anulación |
| 292 | La transacción no está autorizada |
| 284 | Periodo de anulación excedido |
| 310 | Transacción anulada previamente |
| 311 | Monto a anular excede el saldo disponible para anular |
| 312 | Error genérico para anulaciones |
| 315 | Error del autorizador |
| 53 | La transacción no permite anulación parcial de transacciones con cuotas |
Capturar una transacción mall
Puedes revisar más detalles de esta operación en [su documentación](https://www.transbankdevelopers.cl/documentacion/webpay-plus#capturar-una-transaccion-mall)
Permite solicitar a Webpay la captura diferida de una transacción con autorización y sin captura simultánea.
Transaction.capture()
WebpayPlus.MallTransaction mallTransaction = WebpayPlus.MallTransaction.buildForIntegration("commerceCode", "APIKey");
final WebpayPlusMallTransactionCaptureResponse response = mallTransaction.capture(token, commerceCodeStoreOne, childBuyOrder, authorizationCode, amount);
$mallTransaction = MallTransaction::buildForIntegration($apiKey, $commerceCode);
$response = $mallTransaction->capture($commerceCodeStoreOne, $token, $buyOrder, $authorizationCode, $captureAmount);
MallTransaction mallTransaction = MallTransaction.buildForIntegration("commerceCode", "APIKey");
var response = mallTransaction.Capture(token, commerceCodeStoreOne, buyOrder, authorizationCode, captureAmount);
@mall_transaction = Transbank::Webpay::WebpayPlus::MallTransaction.build_for_integration("commerceCode", "APIKey");
@resp = @mall_transaction.capture(child_commerce_code: @commerce_store_1, token: @token, buy_order: @buy_order, authorization_code: @authorization_code, capture_amount: @capture_amount);
mall_tx = MallTransaction.build_for_integration("commerceCode", "APIKey") resp = mall_tx.capture( token=token, capture_amount=amount, commerce_code=commerce_store_1, buy_order=buy_order, authorization_code=authorization_code )
const mallTransaction = WebpayPlus.MallTransaction.buildForIntegration(
"commerceCode",
"APIKey"
);
const response = await mallTransaction.capture(
token,
commerceCodeStoreOne,
buyOrder,
authorizationCode,
captureAmount
);
PUT /rswebpaytransaction/api/webpay/v1.2/transactions/{token}/capture
Tbk-Api-Key-Id: 597055555581
Tbk-Api-Key-Secret: 579B532A7440BB0C9079DED94D31EA1615BACEB56610332264630D42D0A36B1C
Content-Type: application/json
{
"commerce_code": "597055555582",
"buy_order": "your_buy_order_here",
"authorization_code": "your_authorization_code_here",
"capture_amount": 1000
}
Parámetros Transaction.capture
| Nombre tipo |
Descripción |
|---|---|
| token String |
Token de la transacción. Largo: 64. (Se envía en la URL, no en el body) |
| commerce_code Number |
Tienda hija (no usar el código de comercio mall) que realizó la transacción. Largo: 12. |
| buy_order String |
Orden de compra de la transacción que se requiere capturar. Largo máximo: 26. La orden de compra puede tener: Números, letras, mayúsculas y minúsculas, y los signos |_=&%.,~:/?[+!@()>- . Los caracteres con signos no están soportados, como los acentos o signos no especificados. |
| authorization_code String |
Código de autorización de la transacción que se requiere capturar Largo máximo: 6. |
| capture_amount Decimal |
Monto que se desea capturar. Largo máximo: 17. |
Respuesta Transaction.capture
response.getAuthorizationCode();
response.getAuthorizationDate();
response.getCapturedAmount();
response.getResponseCode();
$response->getAuthorizationCode();
$response->getAuthorizationCode();
$response->getAuthorizationDate();
$response->getCapturedAmount();
$response->getResponseCode();
response.AuthorizationCode;
response.AuthorizationDate;
response.CapturedAmount;
response.ResponseCode;
response.authorization_code
response.authorization_date
response.captured_amount
response.response_code
## Versión 3.x del SDK
response['authorization_code']
response['authorization_date']
response['captured_amount']
response['response_code']
## Versión 2.x del SDK
response.authorization_code
response.authorization_date
response.captured_amount
response.response_code
200 OK
Content-Type: application/json
{
"token": "e074d38c628122c63e5c0986368ece22974d6fee1440617d85873b7b4efa48a3",
"authorization_code": "123456",
"authorization_date": "2019-03-20T20:18:20Z",
"captured_amount": 1000,
"response_code": 0
}
| Nombre tipo |
Descripción |
|---|---|
| token String |
Token de la transacción. Largo máximo: 64 |
| authorization_code String |
Código de autorización de la captura diferida. Largo máximo: 6 |
| authorization_date String |
Fecha y hora de la autorización. |
| captured_amount Decimal |
Monto capturado. Largo máximo: 6 |
| response_code Number |
Código de resultado de la captura. Si es exitoso es 0,de lo contrario la captura no fue realizada. Largo máximo: 2 |
En caso de error pueden aparecer los siguientes códigos exclusivos del método
Transaction.capture()
:
| Código | Descripción |
|---|---|
| 304 | Validación de campos de entrada nulos |
| 245 | Código de comercio no existe |
| 22 | El comercio no se encuentra activo |
| 316 | El comercio indicado no corresponde al certificado o no es hijo del comercio Mall en caso de transacciones MALL |
| 308 | Operación no permitida |
| 274 | Transacción no encontrada |
| 16 | La transacción no es de captura diferida |
| 292 | La transacción no está autorizada |
| 284 | Periodo de captura excedido |
| 310 | Transacción reversada previamente |
| 309 | Transacción capturada previamente |
| 311 | Monto a capturar excede el monto autorizado |
| 315 | Error del autorizador |
Códigos y mensajes de error
Al realizar cualquier solicitud al API REST, además de los datos de respuesta, se incluirá uno de los siguientes códigos de estado de respuesta HTTP dependiendo del resultado obtenido:
Solicitud exitosa
Cuando la operación solicitada es ejecutada correctamente, se pueden recibir estos status HTTP:
| Código de estado HTTP | Descripción |
|---|---|
| 200 | La operación se ha ejecutado exitosamente |
| 204 | La operación DELETE se ha ejecutado exitosamente |
Códigos de error
Todos los errores reportados por la API REST de Webpay despliegan un mensaje JSON con una descripción del error.
{
"error_message": "token is required"
}
| Código de estado HTTP | Descripción |
|---|---|
| 400 | El mensaje JSON es inválido. Puedes ser que no corresponda a un mensaje bien estructurado o que contenga un campo no esperado. |
| 401 | No autorizado. API Key y/o API Secret inválidos |
| 404 | La transacción no ha sido encontrada. |
| 405 | Método no permitido. |
| 406 | No fue posible procesar la respuesta en el formato que el cliente indica. |
| 415 | Tipo de mensaje no permitido. |
| 422 | El requerimiento no ha podido ser procesado ya sea por validaciones de datos o por lógica de negocios. |
| 500 | Ha ocurrido un error inesperado. |
Puesta en Producción
Puedes revisar el proceso necesario para operar en el ambiente de producción en [la documentación](https://www.transbankdevelopers.cl/documentacion/como_empezar#puesta-en-produccion)
Configuración SDK
Los SDK deben configurarse explícitamente para apuntar al ambiente que quieras utilizar (producción / integración). Para esto puedes crear los objetos de 2 maneras:
-
Utilizar los métodos definidos para ello (
buildForIntegration
obuildForProduction
). -
Utilizar un objeto
Options
que contenga la configuración y pasarlo en el constructor de cada objeto.
Puede encontrar más información al respecto [en este link](https://www.transbankdevelopers.cl/documentacion/como_empezar#b-utilizando-los-sdk)
Configuración para producción utilizando los SDK
Si estas utilizando algún SDK oficial de Transbank, entonces debes seguir los siguientes pasos.
Revisa la [esta sección](https://www.transbankdevelopers.cl/documentacion/como_empezar#b-utilizando-los-sdk) de la documentación para ver el código necesario para configurar tu propio código de comercio y Api Key Secret.

# termino-y-condiciones.md

Source: https://www.transbankdevelopers.cl/termino-y-condiciones

Aviso de Término de Operación SOAP Webpay - Migración a REST
Si aún mantienes tu integración de Webpay en la modalidad SOAP, te recordamos que en septiembre del presente año, esta modalidad será deprecada, por lo cual es necesario que realices la migración a la metodología REST para continuar operando posterior a dicha fecha.
¿Cuáles son los principales beneficios de REST para tu comercio?
- Es un upgrade tecnológico.
- Se elimina el concepto de reversa realizada por Webpay, por lo que el control de la transacción pasa por completo al Comercio.
- Permite consultar los estados de la transacción.
- Permite acceder a nuevas funcionalidades como anulaciones débito y prepago, reintento y detalle de rechazos.
- Desarrollo sobre versiones: se puede ir evolucionando en la medida que el Comercio lo necesite.
- Integración más simple y rápida de implementar.
¿Cómo realizar la integración Rest?
Puedes contactar a tu Integrador o revisar la información disponible [en este link.](https://www.transbankdevelopers.cl/documentacion/como_empezar#)
Si necesitas asistencia puedes contactar a tu Integrador o puedes contactarnos a Servicio al Cliente al 600 638 6380 desde teléfonos fijos o desde celulares al +562 2661 2700, casilla [soporteweb@transbank.cl.](mailto:soporteweb@transbank.cl)
Cambios en los equipos POS INTEGRADO VERIFONE
Siempre en la búsqueda de entregar un mejor servicio y optimizar la experiencia para los comercios y tarjetahabientes, queremos contarte sobre algunos importantes cambios que serán habilitados en los equipos POS INTEGRADOS VERIFONE, para simplificar el proceso de compra, reducir los tiempos de atención y entregar una mejor experiencia de compra. A partir de las próximas semanas y en forma paulatina los equipos ya mencionados, serán habilitados con una nueva versión de nuestra solución de pago que incorpora las siguientes mejoras:
- Eliminación del menú de selección del medio de pago: al momento de realizar la venta, el tarjetahabiente sólo deberá confirma el monto y operar su tarjeta ya que automáticamente se identificará si el medio de pago corresponde a una con tarjeta de crédito o débito.
- Desagregación de cargos para pagos con tarjetas internacionales: para aquellos pagos con tarjeta internacional, se identificarán claramente el monto de la venta y las comisiones internacionales exigidas por las marcas de los medios de pago. Así su cliente contará con información más detallada de la venta.
- Simplificación menú pago con cuotas para tarjetas de crédito: se modifica la pantalla para seleccionar el número de cuotas cuando su cliente opta por esta modalidad. Facilitando la operación y disminuyendo el tiempo de atención.

