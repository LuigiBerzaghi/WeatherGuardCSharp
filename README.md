# 🌪️ WeatherGuard – Sistema de Alerta Climático Inteligente

O **WeatherGuard** é uma aplicação backend desenvolvida em **.NET 8** com **Entity Framework Core + SQLite**, criada como parte da *Global Solution FIAP 2025*. O sistema tem como foco a proteção da população diante de eventos climáticos extremos, como chuvas intensas, ventos fortes e calor excessivo.

> **Objetivo**: Criar uma API REST robusta para cadastro de usuários e geração de alertas de desastres naturais, com persistência em banco relacional e documentação via Swagger.

---

## ✅ Funcionalidades

* [x] CRUD de Usuários
* [x] CRUD de Alertas vinculados a usuários (relacionamento 1\:N)
* [x] Documentação Swagger (OpenAPI)
* [x] Razor Views com TagHelpers
* [x] Migrations com EF Core + SQLite
* [x] Projeto estruturado com boas práticas

---

## 🧱 Tecnologias Utilizadas

* ASP.NET Core 8
* Entity Framework Core 8.0.5
* SQLite
* Razor Pages + TagHelpers
* Swagger (Swashbuckle.AspNetCore)

---

## 🗃️ Modelo de Dados

### Usuario

| Campo  | Tipo   |
| ------ | ------ |
| Id     | int    |
| Nome   | string |
| Email  | string |
| Cidade | string |
| Alertas| Alerta |

### Alerta

| Campo       | Tipo     |
| ----------- | -------- |
| Id          | int      |
| Tipo        | string   |
| Descricao   | string   |
| DataCriacao | datetime |
| UsuarioId   | int      |
| Usuario     | Usuario  |

> Relacionamento: Um **Usuário** pode ter vários **Alertas**.

---

## 🚀 Como Rodar Localmente

1. Clone o repositório:

```bash
git clone https://github.com/LuigiBerzaghi/WeatherGuardCSharp.git
cd WeatherGuardCSharp/WeatherGuard
```

2. Restaure os pacotes:

```bash
dotnet restore
```

3. Gere as migrations e atualize o banco:

```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
```

4. Rode a aplicação:

```bash
dotnet run
```

5. Acesse no navegador:

```
https://localhost:5001/swagger
```

---

## 🧪 Exemplos de Requisição

### POST /api/Usuarios

```json
{
  "nome": "Luigi Berzaghi",
  "email": "luigi@example.com",
  "cidade": "Guarulhos"
}
```

### PUT /api/Usuarios/{id}

```json
{
  "id": 1,
  "nome": "Luigi Atualizado",
  "email": "novo@email.com",
  "cidade": "São Paulo"
}
```

### DELETE /api/Usuarios/{id}

* Sem corpo: apenas a URL com o ID do usuário

### GET /api/Usuarios

* Sem corpo: Retorna todos os usuários

---

## 📁 Estrutura de Pastas

```
WeatherGuard/
├── Controllers/
├── Models/
├── Data/
├── Views/
├── Migrations/
├── WeatherGuard.csproj
└── Program.cs
```

---

## 👨‍💻 Autor

**Luigi Berzaghi**
Projeto desenvolvido para a disciplina *Advanced Business Development with .NET*
FIAP - Análise e Desenvolvimento de Sistemas (2025)

---
