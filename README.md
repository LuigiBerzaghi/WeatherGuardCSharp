# 🌪️ WeatherGuard – Sistema de Alerta Climático Inteligente

:cloud_tornado: WeatherGuard – Sistema de Alerta Climático Inteligente
WeatherGuard é um sistema de alerta climático projetado para proteger a população diante de eventos naturais extremos, com foco especial em chuvas intensas, ventos fortes e altas temperaturas, fenômenos que têm afetado gravemente diversas regiões do Brasil.

O sistema identifica condições críticas e gera alertas automáticos personalizados para cada usuário, promovendo uma resposta rápida e eficaz.

Esses alertas são exibidos por meio de um aplicativo mobile intuitivo, acessível a qualquer pessoa, fortalecendo a prevenção de desastres e a segurança das comunidades.

Mais do que uma aplicação técnica, o WeatherGuard é uma iniciativa de impacto social, que visa informar, prevenir e salvar vidas através da tecnologia.

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
http://localhost:53805/swagger/index.html
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

## 👨‍💻 Autores

**Luigi Berzaghi** - RM555516

**Guilherme Pelissari** - RM

**Cauã dos Santos** - RM

---
