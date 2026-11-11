# Cool Posing

Ferramenta de poses VRChat com posturas elegantes, utilizável com rastreamento de 3 pontos ou desktop. Inclui 50 poses: 11 em pé, 9 agachadas, 14 sentadas, 9 de costas e 7 de bruços.

Este README refere-se a v1.2.0 em desenvolvimento. A data oficial não está definida. A versão instalada aparece no topo do Inspector.

- [Página na BOOTH](https://yunisaki.booth.pm/items/8797334)
- [Histórico](CHANGELOG.md)

## Idioma de apresentação e documentos offline

Escolha o idioma em «Language / 言語», no topo do Inspector. Uma única escolha aplica-se ao Inspector e aos menus VRChat gerados. Envie novamente o avatar para mudar o idioma dentro do jogo.

Sem escolha explícita, é usado o idioma do computador; idiomas não suportados utilizam inglês. São suportados Windows, macOS e Linux. A última escolha é salva em EditorPrefs e reutilizada em outros projetos do mesmo usuário do sistema neste computador. Todas as ferramentas de poses e todos os avatares usam o mesmo idioma. Alterá-lo no Inspector de qualquer ferramenta atualiza a preferência compartilhada; as escolhas de idioma por avatar são ignoradas. Não existe sincronização com outros computadores. O armazenamento da licença não é alterado. O botão de idioma aparece apenas na confirmação inicial da instalação quando não há um idioma salvo. As alterações posteriores são feitas no Inspector.

Escolha o idioma do README, histórico e manual na [lista de idiomas](../index.html) incluída. Os atalhos do Inspector para manual e alterações seguem a seleção. Os termos originais e as traduções de referência continuam disponíveis em separado.

## Principais funções

- IK automática ajusta posição e direção dos membros conforme proporções em 43 poses.

- Modo foto avança até 3m e muda direção: 0 bit local, 16 bit para mostrar aos outros.
- Cabeça visível só no Modo foto evita ocultar o próprio avatar próximo.
- Altura chão move corpo e cabeça 3m acima/abaixo, separada dos pés com cabeça fixa.
- Virar utiliza movimentos compatíveis que atribuir; não vêm incluídos nas poses.
- Respiração no peito e outras partes: Nenhum, Fraco, Médio, Forte, Rápido ou Personalizado por categoria.
- Desativar balanço em repouso do VRChat mantém respiração e movimentos próprios.
- Reduzir deformação por rotação da cabeça limita diferenças do pescoço desbloqueado.
- Funções selecionáveis e consumo ExpressionParameters no Inspector.
- Pesquisa transversal, vários clips e posição de destino.
- Prévia Scene diretamente na lista.

- Ícones dedicados às novas funções, incluindo respiração, Virar, chão e Modo foto, no estilo do produto.

### Configurar Virar

Ative Ativar Virar nos Detalhes e atribua Pose lateral para virar. MotionTime normal fica indisponível. Ative também Funções > Funções do menu > Virar, envie e escolha pose/função no VRChat. Desbloqueie o pescoço.

As poses incluídas não têm movimentos para Virar. Atribua animações adequadas às poses desejadas.

## Predefinições compatíveis e ajuste

Inclui predefinições ajustadas para トネール, 狛乃, 士堂 e 真央.

- [トネール](https://booth.pm/ja/items/5236104)
- [狛乃](https://booth.pm/ja/items/5260363)
- [士堂](https://booth.pm/ja/items/8086741)
- [真央](https://booth.pm/ja/items/6846646)

Também suporta outros avatares. Adapte poses às proporções e alterações em Ajuste de animação. Configuração do avatar tem prevenção de joelhos invertidos e Flexão mínima do joelho (graus).

IK automática está ativa inicialmente. Das 50 poses, 43 usam IK e as restantes 7 os ajustes individuais anteriores.

## Instalação

1. Baixe arquivos da loja de compra.
2. Importe «カッコいいポーズツール.unitypackage» no Unity e registre licença/origem dos pacotes.
3. Adicione Cool Posing e Modular Avatar em VCC/ALCOM; Unisaki Posing System e NDMF são dependências.
4. Botão direito no avatar da Hierarchy, Unisaki Studio > Adicionar Cool Posing.
5. Selecione Cool Posing no avatar e configure funções/poses.
6. Envie normalmente.

Requisitos: Unity 2022.3, VRChat Avatars SDK 3.10.4 ou posterior, Modular Avatar 1.x desde 1.15.1 e NDMF 1.x desde 1.14.0. Atualize os pacotes necessários em conjunto com VCC ou ALCOM.

## Atualizar versões anteriores

Atualize produto e Unisaki Posing System juntos. Configurações existentes são mantidas. Reveja funções e ExpressionParameters; se usava pré-cálculo, atualize-o antes de enviar novamente.

Desde v1.1.0, novas instalações usam o Prefab normal 「カッコいいポーズ」. Sem funções desnecessárias, seleção mínima 8 bit; muitas poses podem exigir mais bits.

Prefabs 8bit antigos ficam em Editor/Legacy para preservar avatares e predefinições. Não é necessário eliminar ou substituir. O menu de adição já não mostra 8bit.

## Onde configurar

| Separador | Utilização |
| --- | --- |
| Funções | Menus, funções práticas, respiração, ícones e ExpressionParameters |
| Poses | Seleção, detalhes, pesquisa, importação múltipla, ordem, prévia e ajuste |
| Configuração do avatar | Correções próprias e de joelhos, movimentos originais/próprios e predefinições |

Abra as configurações para mostrar detalhes sob a opção. Respiração fica em Funções > Funções práticas > Animar respiração.

Usar poses originais em pé, agachado e de bruços importa automaticamente as posturas do avatar. Para movimentos próprios, abra importação separada e atribua por tipo: em pé, agachado (Crouching), de bruços (Prone), etc.

Predefinições estão no fim de Configuração do avatar. Aplicar esta predefinição substitui poses atuais; salve os ajustes primeiro.

### Consumo por função

- Respiração 0 bit; menu para parar/reiniciar usa 1 bit sincronizado.
- Modo foto local 0 bit, Sincronizar Modo foto 16 bit, cabeça visível 0 bit.
- Pés e chão 8 bit cada. Afastar do centro move todo o corpo; perto de 50% termina.
- Virar 10 bit e compartilha 1 bit com a correção da cabeça: ambas 10 bit no total.
- Espelhar e Sem gestos 1 bit cada.

O total do Inspector refere-se às ferramentas de poses, sem roupa ou outros sistemas. Funções comuns de várias ferramentas não se repetem no consumo.

### Prévia e edição

Prévia mostra a pose na Scene. Para corrigir detalhes abra Ajuste de animação, edite vendo o resultado e salve.

A visualização simples não executa MA/NDMF. Verifique também o resultado da compilação antes de enviar, incluindo roupa e correção do chão.

A lupa pesquisa nomes. Ordene em Detalhes > Ordem ou nos botões cima/baixo. Importe vários clips arrastando ou com Importar clips selecionados em Project.

Atualizar miniaturas das poses gera imagens após confirmar. Gerar ícones das poses facilita a seleção mas demora mais na compilação. Reduzir tamanho dos ícones poupa espaço. Android não gera ícones.

## Controles básicos no jogo

- Escolha poses por categoria em Expressions; altura da cabeça muda em pé/agachado/sentado/deitado em VR.
- Direção do rosto decide costas/bruços. Com ambas pode saltar, desativável em Funções → Funções práticas → Trocar poses deitadas pulando. Limiares do menu regulam alturas.
- C e Z no desktop; se Z não deitar aumente o limiar.
- Sem gestos usa mãos da pose em vez dos controladores.
- Altura pés mantém cabeça, Altura chão move tudo; aparecem nessa ordem.
- Distância do Modo foto avança e olha para você; Direção gira. Fixe pés quando quiser; Sair da foto restaura distância/direção e libera pés.
- Respiração disponível com movimento ativo; intensidade no Unity e ativação no jogo.

## Pré-cálculo e avisos

Atualizar pré-cálculo reutiliza dados para acelerar compilação. Sem ele, a compilação normal gera o necessário.

Verificar configurações e símbolos Hierarchy avisam atualizações após alterações. Configurações de exibição dos avisos estão no mesmo painel. Ocultar não corrige nem regenera.

## Notas de utilização

- Sem fixação durante rastreamento de corpo inteiro.
- Proporções, roupa e alterações podem exigir ajustes.
- Base especial e outras ferramentas podem não integrar bem; veja Configuração do avatar > Integrar bloqueios de rastreamento com outras ferramentas.
- Modo foto e chão corrigem poses e movimentos padrão/próprios sem seleção. Verifique vista final e movimentos substituídos no cliente VRChat.
- Suprimir balanço só afeta repouso padrão, não todas as causas.

## Manual e assistência

Ajuda / Alterações no topo abre manual, assistência e histórico. Funções comuns também estão em Packages > Unisaki Posing System > README no Project.

- [Manual oficial](https://docs.unisakistudio.jp/coolposing/manual/)
- [Assistência](https://help.unisakistudio.jp/)

Comunique versões do produto, sistema comum, Unity, VRChat SDK, Modular Avatar e NDMF, avatar utilizado, passos de reprodução e erros da Console.

## Termos de uso

Inclui «ゆにさきスタジオ販売・配布データ利用規約（日本語版）Ver1.0.0.pdf», termos VN3 comuns aos dados vendidos/distribuídos pelo Unisaki Studio. Leia-os antes de utilizar.

Código e recursos não são de código aberto. Compradores legítimos podem utilizá-los dentro dos termos incluídos.
