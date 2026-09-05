# カッコいいポーズツール

3点トラッキングやデスクトップモードでも、アバターをカッコいい姿勢に切り替えられるVRChat向けポーズ固定ツールです。

立ち姿勢から椅子・床での座り姿勢、うつ伏せ・仰向けまで、合計50姿勢を収録しています。アバターへPrefabを追加するだけで導入でき、ゲーム内のExpressionsメニューから姿勢や各種設定を切り替えられます。

- BOOTH価格：800円
- 商品ページ：https://yunisaki.booth.pm/items/8797334
- 詳しい導入・操作方法：https://docs.unisakistudio.jp/coolposing/manual/

## 主な機能

- カッコいいポーズを50姿勢収録
- 頭の高さに応じて、立ち・中腰・座り・寝姿勢を自動切り替え
- うつ伏せと仰向けを、顔の向きやジャンプで切り替え
- Expressionsメニューから使用する姿勢を選択
- 姿勢に合わせた手の形へ固定する「ジェスチャー無効」
- 頭・腕・足のトラッキング固定
- 左右反転、足の高さ調整
- アバターに合わせたアニメーション調整とプレビュー
- 好きなアニメーションへの差し替え
- Modular Avatar／NDMFを利用した非破壊導入

## 収録姿勢

| 種類 | 数 |
|---|---:|
| 立ち・中腰 | 11 |
| 椅子・浅座り | 9 |
| 床座り | 14 |
| 仰向け | 9 |
| うつ伏せ | 7 |
| 合計 | 50 |

商品には通常版と、足の高さ調整を省いた省メモリー版「カッコいいポーズ(8bit・足の高さなし)」の2種類のPrefabが含まれます。

## 動作環境・必要なもの

- Unity 2022.3.22f1
- VRChat Avatars SDK 3系のアバタープロジェクト
- VCCまたはALCOMなど、VPMパッケージを導入できる環境
- Modular Avatar

本ツールの利用にはModular Avatarが必要です。

## 導入方法

1. 購入ファイルをダウンロードします。
2. 同梱の「カッコいいポーズツール.unitypackage」を、Unityへインポートします。
3. Hierarchyで対象アバターを右クリックし、「ゆにさきスタジオ > カッコいいポーズツール追加」を選びます。
4. Prefabがアバター直下に追加されたことを確認し、通常どおりアップロードします。

詳しい使い方とトラブルシューティングは[公式マニュアル](https://docs.unisakistudio.jp/coolposing/manual/)を参照してください。

## 注意事項

- フルボディトラッキング使用中は、本ツールによる姿勢固定を想定していません。
- アバターの身長、手足の長さ、リグ構造によって姿勢が崩れる場合があります。その場合はアニメーション調整機能を使用してください。
- Playable LayersのBaseレイヤーに特殊な構成があるアバターでは、意図どおりに統合されない場合があります。
- Space Drag機能を併用すると、自分のアバターを第三者視点で確認・撮影しやすくなります。
- 不要な姿勢はPrefabのInspectorから無効化または削除できます。
- 同梱するアバター別プリセットはありません。対応プリセットはリリース後の追加を予定しています。

## 利用規約

本商品には、ゆにさきスタジオが販売・配布するデータに共通で適用されるVN3利用規約「ゆにさきスタジオ販売・配布データ利用規約（日本語版）Ver1.0.0.pdf」を同梱しています。利用前に必ず内容をご確認ください。

本リポジトリのソースコードおよびリソースはオープンソースではありません。正規購入者に対し、同梱の利用規約の範囲で使用を許諾します。

## サポート

不具合を報告する際は、Unityのバージョン、VRChat SDK・Modular Avatar・NDMFの各バージョン、使用アバター、再現手順、Consoleのエラー内容を添えてください。

お問い合わせ：[ゆにさきスタジオ サポート](https://help.unisakistudio.jp/)

## English

Cool Posing is a VRChat avatar pose tool for desktop and 3-point tracking users. It includes 50 poses and lets you select poses from the Expressions menu. Please use machine translation for this guide. The Japanese terms of use are authoritative; translated VN3 PDFs, when supplied, are for reference.
