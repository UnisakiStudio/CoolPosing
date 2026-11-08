# Cool Posing

Outil de poses pour VRChat permettant de prendre des postures stylées avec le suivi à 3 points ou en mode bureau. Il comprend 50 poses : 11 debout, 9 accroupies, 14 assises, 9 couchées sur le dos et 7 sur le ventre.

Ce README concerne la version v1.2.0 en développement. La date de sortie officielle n’est pas encore fixée. La version installée apparaît en haut de l’Inspector.

- [Page du produit sur BOOTH](https://yunisaki.booth.pm/items/8797334)
- [Historique des modifications](CHANGELOG.md)

## Langue d’affichage et documentation hors ligne

Choisissez la langue d’affichage dans « Language / 言語 », tout en haut de l’Inspector. Ce choix s’applique à la fois à l’Inspector et aux menus VRChat générés. Renvoyez l’avatar pour modifier l’affichage dans le jeu.

Sans choix explicite, la langue de l’ordinateur est utilisée ; une langue non prise en charge est remplacée par l’anglais. Windows, macOS et Linux sont pris en charge. La dernière langue choisie est enregistrée dans EditorPrefs et réutilisée dans les autres projets du même utilisateur du système sur cet ordinateur. Un choix explicite déjà enregistré dans l’avatar est conservé. Ce réglage n’est pas synchronisé avec d’autres ordinateurs. Le stockage de la licence reste inchangé.

Choisissez la langue du README, de l’historique et du guide dans la [liste des langues](../index.html) fournie. Les liens du guide et de l’historique dans l’Inspector suivent également la langue sélectionnée. Les conditions d’utilisation originales et leurs traductions de référence restent disponibles séparément.

## Fonctions principales

- Ajustement automatique des membres (IK) : adapte la position et l’orientation des membres à la morphologie de l’avatar dans 43 poses.

- Mode photo : déplacez l’avatar jusqu’à 3m vers l’avant et réglez sa direction. 0 bit pour votre vue seulement, 16 bit pour montrer sa position et son orientation aux autres.
- Tête visible pendant les photos : empêche votre propre tête de disparaître à proximité, uniquement en Mode photo.
- Hauteur sol : déplace le corps entier, tête comprise, jusqu’à 3m vers le haut ou le bas. Ce réglage est distinct de « Hauteur pieds », qui déplace le côté des pieds en conservant la position de la tête.
- Se retourner : fonctionne avec les poses auxquelles vous affectez vous-même des mouvements compatibles. Les poses fournies n’incluent pas de mouvements de retournement.
- Respiration : anime la poitrine et d’autres parties du corps. Choisissez Aucun, Faible, Moyenne, Forte, Rapide ou Personnalisé pour chaque catégorie.
- Désactiver le balancement au repos de VRChat : réduit le balancement standard tout en conservant la respiration de l’outil et les autres mouvements personnalisés.
- Réduire les déformations liées à la rotation de la tête : limite les déformations après libération du cou lorsque son orientation diffère de la pose d’origine.
- Choix des fonctions : ajoutez uniquement les menus voulus et consultez la consommation des ExpressionParameters dans l’Inspector.
- Recherche, ajout groupé et réordonnancement des poses : recherche transversale, importation de plusieurs clips et choix de destination dans la liste.
- Aperçu simple dans la Scene : vérifiez immédiatement une pose avec « Aperçu » dans la liste.

- Icônes des nouvelles fonctions : des images spécifiques, assorties aux icônes existantes du produit, sont fournies notamment pour la respiration, le retournement, la hauteur du sol et le Mode photo.

### Configurer le retournement

Dans les « Détails » de la pose allongée voulue, activez « Activer le retournement » et affectez une animation à « Pose latérale de retournement ». Le réglage MotionTime ordinaire devient indisponible. Activez aussi « Fonctions > Fonctions du menu > Se retourner », envoyez l’avatar, puis choisissez la pose compatible et « Se retourner » dans VRChat. Laissez le verrouillage du cou désactivé.

Les poses fournies dans cette version ne comprennent pas de mouvements de retournement. Affectez des animations adaptées aux poses que vous souhaitez utiliser.

## Préréglages d’avatars compatibles et ajustements

Des préréglages ajustés pour トネール, 狛乃, 士堂 et 真央 sont fournis.

- [トネール](https://booth.pm/ja/items/5236104)
- [狛乃](https://booth.pm/ja/items/5260363)
- [士堂](https://booth.pm/ja/items/8086741)
- [真央](https://booth.pm/ja/items/6846646)

Vous pouvez aussi utiliser d’autres avatars. Adaptez les poses à la morphologie et aux modifications avec « Ajustement de l'animation ». « Configuration de l'avatar » propose aussi « Empêcher les genoux de se plier à l'envers » et le réglage détaillé « Flexion minimale du genou (degrés) ».

L’ajustement automatique des membres (IK) est actif par défaut. Parmi les 50 poses fournies, 43 utilisent l’IK ; les 7 autres conservent les ajustements individuels précédents.

## Installation

1. Téléchargez les fichiers depuis la page du produit dans la boutique où vous l’avez acheté.
2. Importez « カッコいいポーズツール.unitypackage » dans Unity et enregistrez la licence ainsi que le dépôt de packages.
3. Dans VCC ou ALCOM, ajoutez Cool Posing et Modular Avatar au projet Unity utilisé. Unisaki Posing System et NDMF sont aussi installés comme dépendances.
4. Dans la Hierarchy, faites un clic droit sur l’avatar cible et choisissez « Unisaki Studio > Ajouter Cool Posing ».
5. Sélectionnez Cool Posing ajouté dans l’avatar et réglez les fonctions et poses voulues dans l’Inspector.
6. Envoyez l’avatar normalement.

Environnement requis : Unity 2022.3, VRChat Avatars SDK 3.10.4 ou ultérieur, Modular Avatar 1.x à partir de 1.15.1 et NDMF 1.x à partir de 1.14.0. Mettez également à jour les dépendances nécessaires dans VCC ou ALCOM.

## Mise à jour depuis une ancienne version

Mettez à jour ensemble ce produit et Unisaki Posing System. Les réglages des outils déjà placés sont conservés. Vérifiez les fonctions et la consommation des ExpressionParameters dans l’Inspector ; si vous utilisiez le précalcul, cliquez sur « Actualiser le précalcul » avant de renvoyer l’avatar.

Depuis v1.1.0, les nouveaux ajouts utilisent tous le Prefab 「カッコいいポーズ」 standard. En désactivant les options inutiles dans « Fonctions », une configuration minimale limitée au choix des poses utilise 8 bit. Un grand nombre de poses peut nécessiter des bits de sélection supplémentaires.

Les anciens Prefabs 8bit restent dans « Editor/Legacy » pour conserver les références des avatars et préréglages existants. Ne supprimez ni ne remplacez vos Prefabs existants. Le menu d’ajout de Unity n’affiche plus de version 8bit.

## Où trouver les réglages

| Onglet | Possibilités |
| --- | --- |
| Fonctions | Ajouts au menu du jeu, fonctions pratiques, réglages de respiration, icônes et consommation des ExpressionParameters |
| Poses | Choix des poses, détails, recherche, ajout groupé, réordonnancement, aperçu et ajustement de l’animation |
| Configuration de l'avatar | Corrections propres à l’avatar, genoux, importation des poses d’origine ou mouvements personnels et changement de préréglage |

Le lien d’ouverture des réglages déploie les détails sous la fonction concernée. La respiration se règle dans « Fonctions > Fonctions pratiques > Animer la respiration ».

« Utiliser les poses debout, accroupies et sur le ventre d'origine » importe automatiquement les poses déjà présentes dans l’avatar. Pour vos propres mouvements, ouvrez séparément les réglages d’importation et affectez chaque type, par exemple debout, accroupi (Crouching) ou couché sur le ventre (Prone).

Les préréglages sont au bas de « Configuration de l'avatar ». « Appliquer ce préréglage » remplace la configuration actuelle des poses : enregistrez vos ajustements avant de changer de préréglage.

### Consommation par fonction

- L’animation de respiration utilise 0 bit. Seul « Fonctions du menu > Respiration », qui permet de l’arrêter et de la relancer dans le jeu, utilise 1 bit pour synchroniser l’activation.
- Le Mode photo utilise 0 bit en vue locale uniquement. « Fonctions pratiques > Synchroniser le Mode photo » utilise 16 bit. « Garder la tête visible en Mode photo » utilise 0 bit.
- « Hauteur pieds » et « Hauteur sol » utilisent chacun 8 bit. Éloigner la hauteur du sol du centre déplace tout le corps verticalement ; revenir près de 50% termine le décalage.
- « Se retourner » seul utilise 10 bit. Il partage 1 bit avec « Réduire les déformations liées à la rotation de la tête » : les deux ensemble utilisent donc aussi 10 bit.
- « Miroir » et « Sans gestes » utilisent chacun 1 bit.

Le total de l’Inspector concerne les outils de poses installés sur l’avatar. Il n’inclut pas les autres systèmes, comme les vêtements. Les réglages communs ne sont pas comptés plusieurs fois lorsque plusieurs outils de poses sont utilisés.

### Aperçu et édition des poses

« Aperçu » sur chaque entrée de « Poses » affiche la posture dans la Scene. Pour la modifier précisément, ouvrez « Ajustement de l'animation », ajustez-la avec l’aperçu, puis enregistrez.

L’aperçu simple n’exécute pas le build MA ou NDMF. Vérifiez aussi dans le résultat du build avant envoi les vêtements intégrés à ce moment et les corrections de contact avec le sol.

La loupe à gauche permet de chercher les poses par nom. Réordonnez-les en choisissant la destination dans « Détails > Ordre » ou avec les boutons haut et bas. Ajoutez plusieurs animations en les glissant dans la zone d’ajout ou avec « Importer les clips sélectionnés dans Project ».

« Actualiser les vignettes des poses » génère les images après une confirmation. « Générer les icônes des poses » rend les poses plus faciles à reconnaître dans le menu du jeu, mais augmente le temps de build à cause de la génération des images. Choisissez « Réduire la taille des icônes » pour limiter leur taille. Les icônes de poses ne sont pas générées pour Android.

## Commandes de base dans le jeu

- Choisissez les poses de chaque catégorie dans le menu Expressions. En VR, la hauteur de votre tête détermine le passage entre debout, accroupi, assis et allongé.
- En position allongée, l’orientation du visage fait passer du dos au ventre. Si les deux sont sélectionnés, un saut peut aussi les permuter ; désactivez cette fonction dans « Fonctions → Fonctions pratiques → Changer de pose allongée en sautant » si nécessaire. Les seuils des réglages déterminent les hauteurs de changement de catégorie.
- En mode bureau, utilisez C et Z pour changer de posture. Si Z ne vous allonge pas, augmentez le seuil de hauteur allongée dans les réglages.
- « Sans gestes » utilise les mains définies dans la pose à la place des gestes des contrôleurs.
- « Hauteur pieds » ajuste le côté des pieds en conservant la position de la tête. « Hauteur sol » déplace tout le corps verticalement, tête comprise. Ils apparaissent dans cet ordre dans les réglages.
- Avancez avec « Mode photo > Distance » pour que l’avatar vous fasse face. Faites-le pivoter avec « Direction », puis activez « Pieds fixes » au moment voulu. « Quitter photo » réinitialise distance et direction et déverrouille les pieds.
- « Respiration » est disponible si son animation est active. L’intensité se règle dans Unity ; le jeu permet de l’activer ou de la désactiver.

## Précalcul et avertissements

« Actualiser le précalcul » réutilise les données générées pour accélérer le build de l’avatar. Sans précalcul, le build ordinaire génère lui-même les données nécessaires.

Après une modification, « Vérifier les réglages » en haut de l’Inspector et les marques de la Hierarchy signalent les mises à jour nécessaires. « Réglages d'affichage des avertissements » se trouve dans « Vérifier les réglages ». Masquer ces messages ne corrige pas les problèmes et n’actualise pas les données générées.

## Précautions d’utilisation

- Le verrouillage de pose avec suivi du corps entier n’est pas pris en charge.
- La morphologie, les vêtements et les modifications de l’avatar peuvent nécessiter des ajustements supplémentaires.
- L’intégration peut être incorrecte avec des couches Base particulières ou d’autres systèmes de posture. Si les verrouillages fonctionnent mal, vérifiez aussi « Configuration de l'avatar > Intégrer les verrouillages de suivi aux autres outils ».
- Le déplacement et la rotation du Mode photo ainsi que la hauteur du sol corrigent les poses de l’outil et les mouvements standards ou personnels sans sélection. Vérifiez le point de vue final et le comportement après remplacement des mouvements dans le client VRChat.
- « Désactiver le balancement au repos de VRChat » agit sur l’attente standard, sans arrêter les mouvements provenant de toutes les autres sources.

## Guide et assistance

Ouvrez le guide, l’assistance et l’historique dans « Aide / Historique » en haut de l’Inspector. Les fonctions communes sont aussi expliquées dans « Packages > Unisaki Posing System > README » de la fenêtre Project de Unity.

- [Manuel officiel](https://docs.unisakistudio.jp/coolposing/manual/)
- [Assistance](https://help.unisakistudio.jp/)

Pour signaler un problème, fournissez les versions de ce produit et de Unisaki Posing System, celles de Unity, VRChat SDK, Modular Avatar et NDMF, l’avatar utilisé, les étapes de reproduction et les erreurs de la Console.

## Conditions d’utilisation

Le produit comprend « ゆにさきスタジオ販売・配布データ利用規約（日本語版）Ver1.0.0.pdf », les conditions VN3 communes aux données vendues ou distribuées par Unisaki Studio. Lisez-les impérativement avant utilisation.

Le code source et les ressources de ce dépôt ne sont pas open source. Les acheteurs légitimes sont autorisés à les utiliser dans les limites des conditions fournies.
