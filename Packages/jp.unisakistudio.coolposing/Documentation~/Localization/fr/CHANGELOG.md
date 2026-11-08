# Historique des modifications

## [1.2.0] - Non publié

### Ajouts

- Affichage de l’Inspector, des commandes d’édition, des dialogues d’installation, des noms de poses standards et des menus VRChat générés en 30 langues.
- Choix de langue unifié pour l’Inspector et les menus du jeu. La langue de l’ordinateur est utilisée initialement, puis le dernier choix est réutilisé dans les autres projets du même utilisateur du système.
- Ouverture du README, de l’historique et du guide hors ligne dans la langue choisie.
- Noms d’affichage des 128 poses standards et descriptions de toutes les fonctions harmonisés avec la terminologie existante.

### Compatibilité

- Conservation des réglages existants de l’avatar, des noms personnalisés, des références d’assets, des identifiants de paramètres et du stockage de la licence.

## [1.1.0] - 2026-11-07

- Ajustement IK automatique des membres selon la morphologie pour 43 des 50 poses fournies. Les 7 autres conservent les ajustements individuels précédents.
- Position et orientation réglables en Mode photo, avec choix de synchronisation et de maintien de votre tête visible.
- « Hauteur sol » déplace tout le corps jusqu’à 3m vers le haut ou le bas, indépendamment de « Hauteur pieds ».
- Ajout de la respiration, de la suppression du balancement d’attente standard et de la réduction des déformations liées à l’orientation du cou.
- Affichage des fonctions et de la consommation des paramètres dans l’Inspector ; recherche, ajout groupé, réordonnancement et aperçu simple des poses dans la Scene.
- Accélération des changements debout, accroupi et assis en mode bureau.
- Amélioration des avertissements de précalcul après modification, du défilement de l’Inspector et des longues pauses du nettoyage des données générées.
- Prise en charge de Unisaki Posing System 3.1.0.
- Les poses fournies ne comprennent pas de mouvements de retournement.

## [1.1.0-beta.2] - Bêta ouverte (2026-11-05)

- Ajustement automatique des membres (IK) configuré pour 43 des 50 poses fournies. Les 7 autres conservent leurs ajustements individuels précédents.
- Compatibilité avec le package commun 3.1.0-beta.2. Les poses fournies dans cette version ne comprennent pas de mouvements de retournement.

## [1.1.0-beta.1] - Bêta ouverte (2026-11-04)

- Prise en charge de Unisaki Posing System 3.1.0-beta.1.
- Changement de posture ordinaire en mode bureau traité en une seule évaluation, pour les builds ordinaires et le précalcul. La VR et les situations particulières gardent le traitement précédent.
- Reconnaissance des précalculs alpha.3 et antérieurs comme nécessitant une mise à jour.
- Conservation du point de vue lors des changements de hauteur du sol en Mode photo, puis retour à la dernière hauteur à sa sortie.
- Intégration des améliorations jusqu’à alpha.3 concernant l’importation automatique, les ajustements des mouvements importés et la gestion des Controllers générés.

## [1.1.0-alpha.1] - Avant publication

### Ajouts

- Ajout du retournement et de ses animations compatibles configurables par pose.
- Ajout d’icônes de menu spécifiques pour respiration, retournement, hauteur du sol, Mode photo, distance, direction et sortie du Mode photo.
- Ajout du Mode photo avec déplacement vers l’avant et rotation.
- Ajout du choix de synchronisation : 0 bit en local uniquement, 16 bit synchronisés.
- Ajout du maintien de votre tête visible pendant le Mode photo.
- Ajout de « Hauteur sol » pour élever tout le corps, tête comprise.
- Ajout de l’animation et de l’intensité de respiration ainsi que de son menu d’activation dans le jeu.
- Ajout de la suppression du balancement standard de VRChat.
- Ajout de la réduction des déformations liées à la différence d’orientation du cou.
- Ajout de la prévention de flexion inversée des genoux et de leur flexion minimale.
- Ajout de l’activation par fonction et de la consommation des ExpressionParameters.
- Ajout de l’aperçu simple dans la Scene, de la recherche de poses, de l’ajout groupé et du choix de destination dans la liste.
- Ajout de l’historique dans l’Inspector.

### Modifications

- Organisation de l’Inspector en 3 onglets : « Fonctions », « Poses » et « Configuration de l'avatar ».
- Réorganisation des détails de respiration, de l’importation des mouvements personnels et des préréglages.
- Réduction des doublons d’animations générées pour la hauteur des pieds.
- Ajout d’une confirmation avant de mettre à jour les images des poses et regroupement des avertissements dans « Vérifier les réglages ».
- Suppression du menu d’ajout de la version 8bit au profit des options du Prefab standard. Les références existantes sont préservées.
- Prise en charge de Unisaki Posing System 3.1.0-alpha.1 et version minimale du VRChat Avatars SDK portée à 3.10.4.

### Corrections

- Correction de la saisie des noms transférée vers une autre pose et de la fermeture des détails après réordonnancement.
- Correction du chevauchement des aperçus, des décalages de placement et des erreurs sur certains avatars.
- Correction de l’actualisation des avertissements et de l’état du précalcul après modification, ainsi que de certaines erreurs de build.

## [1.0.0] - 2026-09-06

- Publication officielle.
- Ajout de préréglages d’avatars (トネール, 狛乃, 士堂, 真央).

## [1.0.0-alpha.1] - 2026-09-06

- Publication.
