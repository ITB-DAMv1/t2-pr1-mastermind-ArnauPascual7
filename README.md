# Mastermind

Per: **Arnau Pascual**

![Portada](Img/Portada.png)

## Instruccions

Mastermind és un joc en el que has d'endevinar un codi de 4 nombres.

Per a jugar introduïeix 4 nombres del 1 al 6, un per un. Cada cop que introdueixis 4 nombres el programa et respondrà amb una pista sobre el **Codi Secret**. A través de la pista has d'intentar endevinar el **Codi Secret**.

Aquest joc té 4 dificultats establertes, a més d'una diifcultat personalitzada:
- Dificultat novell: 10 intents
- Dificultat aficionat: 6 intents
- Dificultat expert: 4 intents
- Dificultat Màster: 3 intents
- Dificultat personalitzada: Tú esculls els intents

### Pistes:
- És en el Codi i en la seva posició -> O
- És en el Codi, però no en la posició -> Ø
- El nombre no és en el Codi -> ×

## Explicació del funcionament del programa

### Elecció de dificultat

Al seleccionar una dificultat nomès podrem escriure nombres del 1 al 5, que són les opcions de dificultat que hi ha. Si introduïm un altre valor, ja sigui una lletra o un nombre o espai, retornarà un error i tornarà a demanar el valor.

![ErrorDificultat](Img/ErrorDificultat.png)

Aquests errors apareixen sempre que l'usuri introdueixi un nombre erroni.

![ErrorCodi](Img/ErrorCodi.png)

Si escollim qualsevol de les dificultats establertes jugarem amb el nombre d'intents que tenen aquestes, però si seleccionem la dificultat personalitzada haurem de posar el nombre d'intents amb els que volem jugar.

![DificultatPersonalitzada](Img/DificultatPersonalitzada.png)

### Endevinar el codi

Un cop tinguem els intents comença el joc de veritat. El programa demanarà 4 nombres, un per un, corresponents a cada una de les posicions del Codi Secret.

![CodiUsuari](Img/CodiUsuari.png)

El programa contenstarà amb una pista sobre el Codi Secret.

![Pista](Img/Pista.png)

Si endevinem el codi abans que s'acabin els intents el programa ens felicita, en cas contrari haurem perdut. El programa sepre dona el Codi Secret al final del joc.

![Victoria](Img/Victoria.png)
![Derrota](Img/Derrota.png)

## Joc de proves amb codis

### Codi Secret **6543**

Un codi qualsevol, per a provar una victoria i la derrota en el joc.

#### Victoria

![Codi1](Img/JocProves/Codi1.png)

#### Derrota amb la dificultat personalitzada a 1:

![Codi2-1](Img/JocProves/Codi2-1.png)

#### Derrota amb la dificultat Expert:

![Codi2-21](Img/JocProves/Codi2-21.png)

![Codi2-22](Img/JocProves/Codi2-22.png)

### Codi Secret **1346**

Amb el Codi Secret **1346** comprovem els nombres mínim i màxim possibles del codi.

![Codi3](Img/JocProves/Codi3.png)

### Codi Secret **6421**

Amb el Codi Secret **6421** comprovem els nombres mínim i màxim possibles del codi.

![Codi4](Img/JocProves/Codi4.png)

### Codi Secret **2526**

Amb el Codi Secret **2526** comprovem dos nombres iguals en el codi separats.

![Codi5](Img/JocProves/Codi5.png)

### Codi Secret **3411**

Amb el Codi Secret **3411** comprovem dos nombres iguals en el codi en posicions seguides.

![Codi6](Img/JocProves/Codi6.png)

### Codi Secret **4444**

Amb el Codi Secret **4444** comprovem tots els nombres iguals en el codi.

![Codi7](Img/JocProves/Codi7.png)

### Codi Secret **6666**

Amb el Codi Secret **6666** comprovem tots els nombres iguals en el codi i el valor màxim que pot tenir el codi.

![Codi8](Img/JocProves/Codi8.png)

## Punts entregats

### Robust

El programa s'executa sense errors i no apareix cap tracer per pantalla i fa el que es demana.

Dins del programa pots seleccionar una dificultat, cada una té un nombre d'intents diferent, a més d'una dificultat personalitzada per a seleccionar els intents personalment. Un cop definits els intents el programa compara un codi introduït per l'usuari amb el que té guardat el programa, això es repeteix fins que els intents de l'usuari s'acabin, en aquest cas, si els no l'ha endevinat en l'últim intent el programa s'acaba amb una derrota.

![Robust](Img/Criteris/Robust.png)

### Claredat i ordre

El programa es segueix amb claredat, de dalt a baix, cada ordre va seguida d'una altra. Les instruccions són suficients clares com per entendre-les.

Tot el codi utilitzat per al programa l'hem treballat a classe.

![Claredat1](Img/Criteris/Claredat1.png)

Les funcions es criden de dalt a baix, qui la crida a dalt, i la funció abaix. També aquestes només realitzen una funció.

![Claredat2](Img/Criteris/Claredat2.png)

Els comentaris està col·locats per a explicar el funcionament d'algunes parts del codi.

![Claredat3](Img/Criteris/Claredat3.png)

### Variables i constants

Totes les variables i constats del programa tenen noms que nomès en saber el seu nom es pot deduïr per a que serveixen, a més de que tot està escrit en anglès.

![Variables1](Img/Criteris/Variables1.png)

Tots els textos que utilitza el programa està declarats en constats, no hi ha cap text que s'utilitzu que no estigui dintre d'una.

![Variables2](Img/Criteris/Variables2.png)

Totes les variables i constats està declarades al principi del codi.

![Variables3](Img/Criteris/Variables3.png)

### Estructures de control

Totes les condicions del codi són correctes i no provoquen errors en el programa. Aquestes sempre tenen algún ús dins del codi.

![Estructures](Img/Criteris/Estructures.png)

L'única sentència break que s'utilitza està en un switch.

### Gestió d'errors

Tots els errors que es pot produïr està controlats.

![Errors](Img/Criteris/Errors.png)

### Disseny modular

Els processos que es repeteixen més d'una vegada estàn dins de mètodes per a no haver de repetir el codi.

![Disseny](Img/Criteris/Disseny.png)

### UX/UI

Els missatges ajuden a entendre millor el joc, i encaminen a l'usuari a jugar correctament.

![UI](Img/Criteris/UI.png)

### Extra 3

El codi utilitza un títol gran i llegible per una major inmersió al joc, a més hi ha separacions per a llegirr millor cada part del programa.

![Extra1](Img/Criteris/Extra1.png)

![Extra2](Img/Criteris/Extra2.png)