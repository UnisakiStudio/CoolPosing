# Cool Posing

Strumento per bloccare pose eleganti in VRChat anche con tracciamento a 3 punti o in desktop. Include 50 pose: 11 in piedi, 9 accovacciate, 14 sedute, 9 supine e 7 prone.

Questo README riguarda la versione v1.2.0 in sviluppo. La data di uscita ufficiale non è stabilita. La versione installata compare in alto nell’Inspector.

- [Pagina del prodotto su BOOTH](https://yunisaki.booth.pm/items/8797334)
- [Cronologia delle modifiche](CHANGELOG.md)

## Lingua dell’interfaccia e documentazione offline

Scegli la lingua in «Language / 言語», in cima all’Inspector. Una sola scelta si applica sia all’Inspector sia ai menu VRChat generati. Carica nuovamente l’avatar per cambiare la lingua nel gioco.

Senza una scelta esplicita viene usata la lingua del computer; se non è supportata, viene usato l’inglese. Sono supportati Windows, macOS e Linux. L’ultima scelta è salvata in EditorPrefs e riutilizzata negli altri progetti dello stesso utente del sistema su questo computer. Tutti gli strumenti di posa e gli avatar usano la stessa lingua. Cambiarla nell’Inspector di qualsiasi strumento aggiorna la preferenza comune; le scelte di lingua dei singoli avatar vengono ignorate. Non viene sincronizzata con altri computer. Il sistema di archiviazione della licenza rimane invariato. Il pulsante della lingua appare solo nella conferma iniziale di installazione se non è stata salvata una lingua. Le modifiche successive si effettuano nell’Inspector.

Scegli la lingua di README, cronologia e guida dall’[elenco delle lingue](../index.html) incluso. Anche i collegamenti alla guida e alle novità nell’Inspector seguono la lingua scelta. Le condizioni d’uso originali e le traduzioni di riferimento restano disponibili separatamente.

## Funzioni principali

- Regolazione automatica degli arti (IK): adatta posizione e direzione degli arti alla corporatura dell’avatar in 43 pose.

- Modalità foto: sposta l’avatar fino a 3m in avanti e cambia la direzione. 0 bit solo nella tua vista, 16 bit per mostrare posizione e direzione agli altri.
- Testa visibile nelle foto: impedisce che la testa del tuo avatar vicino scompaia, solo in Modalità foto.
- Altezza suolo: muove tutto il corpo, testa inclusa, fino a 3m sopra o sotto, separatamente da «Altezza piedi», che mantiene la testa ferma.
- Girarsi: usabile nelle pose cui assegni personalmente movimenti compatibili. Le pose incluse non comprendono movimenti di rotolamento.
- Respiro: anima petto e altre parti. Scegli Nessuno, Debole, Medio, Forte, Rapido o Personalizzato per categoria.
- Disattivare l'oscillazione da fermo di VRChat: riduce il movimento standard conservando il respiro e gli altri movimenti personali.
- Ridurre le deformazioni dovute alla rotazione della testa: limita le deformazioni sbloccando il collo quando la sua direzione differisce dall’originale.
- Scelta delle funzioni: aggiungi solo i menu desiderati e controlla il consumo di ExpressionParameters.
- Ricerca, aggiunta in gruppo e riordino delle pose: ricerca tra categorie, importazione di più clip e destinazione nell’ordine.
- Anteprima semplice nella Scene: usa «Anteprima» nell’elenco per vedere subito la postura.

- Icone dei nuovi menu: immagini dedicate a respiro, Girarsi, altezza suolo, Modalità foto e altre funzioni, coerenti con le icone esistenti del prodotto.

### Configurare Girarsi

Nei «Dettagli» della posa sdraiata attiva «Abilita Girarsi» e assegna un’animazione a «Posa laterale per girarsi». Il normale MotionTime non sarà disponibile. Attiva anche «Funzioni > Funzioni del menu > Girarsi» e carica; in VRChat scegli la posa compatibile e «Girarsi». Lascia il collo sbloccato.

Le pose incluse in questa versione non comprendono movimenti per Girarsi. Assegna animazioni adatte alle pose desiderate.

## Preset avatar compatibili e regolazioni

Sono inclusi preset regolati per トネール, 狛乃, 士堂 e 真央.

- [トネール](https://booth.pm/ja/items/5236104)
- [狛乃](https://booth.pm/ja/items/5260363)
- [士堂](https://booth.pm/ja/items/8086741)
- [真央](https://booth.pm/ja/items/6846646)

Puoi usare anche altri avatar. Adatta le pose a corporatura e modifiche con «Regolazione animazione». «Configurazione avatar» offre «Impedire la piegatura inversa delle ginocchia» e il dettaglio «Flessione minima del ginocchio (gradi)».

La regolazione automatica degli arti (IK) è attiva inizialmente. Delle 50 pose, 43 usano IK e le altre 7 usano le regolazioni individuali precedenti.

## Installazione

1. Scarica i file dalla pagina del prodotto nel negozio d’acquisto.
2. Importa «カッコいいポーズツール.unitypackage» in Unity e registra licenza e repository.
3. In VCC o ALCOM aggiungi Cool Posing e Modular Avatar al progetto. Unisaki Posing System e NDMF vengono installati come dipendenze.
4. Nella Hierarchy fai clic destro sull’avatar e scegli «Unisaki Studio > Aggiungi Cool Posing».
5. Seleziona Cool Posing aggiunto nell’avatar e configura funzioni e pose nell’Inspector.
6. Carica l’avatar normalmente.

Requisiti: Unity 2022.3, VRChat Avatars SDK 3.10.4 o successivo, Modular Avatar 1.x dalla versione 1.15.1 e NDMF 1.x dalla versione 1.14.0. Aggiorna insieme i pacchetti necessari con VCC o ALCOM.

## Aggiornare da una versione precedente

Aggiorna insieme il prodotto e Unisaki Posing System. Le impostazioni degli strumenti già presenti vengono conservate. Controlla funzioni e consumo di ExpressionParameters nell’Inspector; se usavi il precalcolo, premi «Aggiorna precalcolo» prima di ricaricare l’avatar.

Da v1.1.0 i nuovi inserimenti usano soltanto il Prefab normale 「カッコいいポーズ」. Disattivando le opzioni inutili in «Funzioni», la configurazione minima di sola selezione delle pose richiede 8 bit. Molte pose possono richiedere bit di selezione aggiuntivi.

I vecchi Prefab 8bit restano in «Editor/Legacy» per conservare i riferimenti di avatar e preset esistenti. Non occorre eliminarli o sostituirli. Il menu per i nuovi inserimenti non mostra la versione 8bit.

## Dove configurare le opzioni

| Scheda | Possibilità |
| --- | --- |
| Funzioni | Menu nel gioco, funzioni pratiche, respiro, icone e consumo di ExpressionParameters |
| Pose | Scelta delle pose, dettagli, ricerca, aggiunta in gruppo, ordine, anteprima e regolazione animazione |
| Configurazione avatar | Correzioni dell’avatar e delle ginocchia, importazione di pose originali o movimenti personali e cambio preset |

Il comando per aprire le impostazioni mostra i dettagli sotto la voce. Il respiro si configura in «Funzioni > Funzioni pratiche > Animare il respiro».

«Usare le pose originali in piedi, accovacciate e prone» importa automaticamente le pose dell’avatar. Per movimenti personali, apri separatamente le impostazioni d’importazione e assegna ciascun tipo, come in piedi, accovacciato (Crouching) o prono (Prone).

I preset si trovano in fondo a «Configurazione avatar». «Applica questo preset» sostituisce le impostazioni attuali delle pose: salva le regolazioni prima di cambiarlo.

### Consumo per funzione

- Il movimento del respiro richiede 0 bit. Soltanto «Funzioni del menu > Respiro», per fermarlo e riprenderlo nel gioco, richiede 1 bit di sincronizzazione.
- La Modalità foto richiede 0 bit solo locale. «Funzioni pratiche > Sincronizzare la Modalità foto» usa 16 bit. «Tenere visibile la testa in Modalità foto» usa 0 bit.
- «Altezza piedi» e «Altezza suolo» usano 8 bit ciascuna. Spostando Altezza suolo dal centro muovi tutto il corpo verticalmente; tornando vicino a 50% termini lo spostamento.
- «Girarsi» usa 10 bit da solo. Condivide 1 bit con «Ridurre le deformazioni dovute alla rotazione della testa», quindi entrambe usano ancora 10 bit totali.
- «Specchio» e «Blocca gesti» usano 1 bit ciascuna.

Il totale dell’Inspector riguarda gli strumenti per pose sull’avatar, senza includere abiti e altri sistemi. Le impostazioni comuni non vengono contate due volte usando più strumenti.

### Anteprima e modifica delle pose

«Anteprima» su ogni voce di «Pose» mostra la posa nella Scene. Per correzioni dettagliate apri «Regolazione animazione», modifica con l’anteprima e salva.

L’anteprima semplice non esegue la build MA o NDMF. Controlla anche il risultato della build prima del caricamento per abiti integrati e correzioni del pavimento applicate in quella fase.

La lente a sinistra cerca le pose per nome. Riordinale scegliendo la destinazione in «Dettagli > Ordine» o con i pulsanti su e giù. Aggiungi più animazioni trascinandole nella zona di aggiunta o con «Importa clip selezionati in Project».

«Aggiorna miniature delle pose» genera le immagini dopo una conferma. «Generare le icone delle pose» aiuta a riconoscerle nei menu del gioco, ma la generazione allunga la build. Seleziona «Ridurre le dimensioni delle icone» per risparmiare spazio. Android non genera icone delle pose.

## Comandi di base nel gioco

- Scegli le pose di ogni categoria nel menu Expressions. In VR l’altezza della testa determina il passaggio tra in piedi, accovacciato, seduto e sdraiato.
- Da sdraiato, la direzione del viso alterna supino e prono. Se entrambi sono selezionati puoi usare anche il salto, disattivabile in «Funzioni → Funzioni pratiche → Cambiare posa sdraiata saltando». Le soglie del menu regolano le altezze del cambio categoria.
- In desktop usa C e Z. Se Z non ti fa sdraiare, aumenta la soglia di altezza per sdraiarsi nelle impostazioni.
- «Blocca gesti» usa le mani della posa invece dei gesti dei controller.
- «Altezza piedi» regola il lato dei piedi mantenendo la testa ferma. «Altezza suolo» muove tutto il corpo, testa inclusa. Compaiono in questo ordine.
- Avanza con «Modalità foto > Distanza» per rivolgere l’avatar verso di te. Ruotalo con «Direzione» e attiva «Blocca piedi» quando vuoi. «Esci da foto» ripristina distanza e direzione e sblocca i piedi.
- «Respiro» è disponibile con l’animazione attiva; intensità impostata in Unity e attivazione nel gioco.

## Precalcolo e avvisi

«Aggiorna precalcolo» riutilizza i dati generati per velocizzare la build dell’avatar. Senza precalcolo, la normale build genera comunque i dati necessari.

Dopo una modifica, «Controlla impostazioni» in alto nell’Inspector e i simboli della Hierarchy segnalano gli aggiornamenti necessari. «Impostazioni di visualizzazione avvisi» si trova in «Controlla impostazioni». Nascondere gli avvisi non risolve i problemi né aggiorna i dati generati.

## Note d’uso

- Il blocco delle pose con tracciamento completo del corpo non è supportato.
- Corporatura, abiti e modifiche possono richiedere altre regolazioni.
- Livelli Base particolari o altri sistemi di postura possono non integrarsi correttamente. Se i blocchi non funzionano, verifica «Configurazione avatar > Integrare i blocchi del tracciamento con altri strumenti».
- Movimento e rotazione della Modalità foto e altezza suolo correggono le pose dello strumento e i movimenti standard o personali senza selezione. Verifica nel client VRChat vista finale e comportamento dopo le sostituzioni dei movimenti.
- «Disattivare l'oscillazione da fermo di VRChat» agisce sull’attesa standard, non su tutte le altre cause di oscillazione.

## Guida e assistenza

Apri guida, assistenza e cronologia da «Aiuto / Novità» in alto nell’Inspector. La spiegazione delle funzioni comuni è anche in «Packages > Unisaki Posing System > README» nella finestra Project di Unity.

- [Manuale ufficiale](https://docs.unisakistudio.jp/coolposing/manual/)
- [Assistenza](https://help.unisakistudio.jp/)

Per segnalare un problema, indica le versioni del prodotto e di Unisaki Posing System, quelle di Unity, VRChat SDK, Modular Avatar e NDMF, l’avatar usato, i passaggi per riprodurlo e gli errori della Console.

## Condizioni d’uso

Il prodotto include «ゆにさきスタジオ販売・配布データ利用規約（日本語版）Ver1.0.0.pdf», le condizioni VN3 comuni ai dati venduti o distribuiti da Unisaki Studio. Leggile prima dell’uso.

Codice sorgente e risorse di questo repository non sono open source. Agli acquirenti regolari è concesso usarli entro le condizioni incluse.
