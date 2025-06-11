# 🐾 Galeria de Imagens de Animais - Blazor (.NET 9 + MudBlazor)

Este projeto é uma aplicação interativa desenvolvida em **Blazor Server** com **.NET 9** e a biblioteca **MudBlazor**, que exibe uma galeria de imagens de animais (cães, patos e raposas) obtidas de **APIs públicas**. Os usuários podem navegar pelas categorias, visualizar imagens aleatórias e realizar o **download** da imagem desejada.

---

# 📸 Capturas de Tela
## Página Inicial

## Galeria de Imagens

## Dialog com Imagem

---

## 🚀 Tecnologias Utilizadas

- C# .NET 9
- Blazor Server
- MudBlazor
- APIs Públicas

## 🖼️ Funcionalidades

- ✅ Selecionar uma categoria: Cachorros, Patos ou Raposas
- ✅ Carregar uma galeria com imagens aleatórias da categoria escolhida
- ✅ Visualizar a imagem em destaque em um `Dialog`
- ✅ Baixar a imagem escolhida com apenas um clique
- ✅ UI responsiva com componentes do MudBlazor

## 🌐 APIs Consumidas

| Animal  | API                                           | Exemplo de Retorno                                              |
|---------|-----------------------------------------------|-----------------------------------------------------------------|
| Cães    | https://dog.ceo/api/breeds/image/random       | `{ "message": "url", "status": "success" }`                     |
| Patos   | https://random-d.uk/api/v2/random             | `{ "url": "image_url", ... }`                                   |
| Raposas | https://randomfox.ca/floof/                   | `{ "image": "image_url", ... }`                                 |


## 🛠️ Configuração

Siga os passos abaixo para executar o projeto localmente:

### 🔧 Pré-requisitos

- [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0) instalado
- Editor como [Visual Studio 2022+](https://visualstudio.microsoft.com/) ou [Visual Studio Code](https://code.visualstudio.com/)
- Acesso à internet (para consumo das APIs)

### 🚀 Executando o projeto

1. Clone o repositório:

```bash
git clone https://github.com/seu-usuario/AnimalsBlazor.git
cd AnimalsBlazor 
```

2. Restaure os pacotes::

```bash
dotnet restore
```

3. Execute a aplicação:

```bash
dotnet run
```

