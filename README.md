# TryBank – Sistema Bancário em Console (Versão Refatorada) -> ENGLISH VERSION BELOW

Este projeto é uma versão refatorada e ampliada do exercício original **TryBank** da Trybe.  
O objetivo é simular operações bancárias básicas usando **C#** e um **array multidimensional em memória**, sem persistência de dados.

Este repositório contém **modificações importantes** em relação ao template original da Trybe, com foco em tornar o projeto executável no console e com fluxo completo para o usuário.

---

## 🚀 Funcionalidades

### ✔ Requisitos implementados (projeto original)
- **Cadastrar contas**  
- **Login / Logout**  
- **Consultar saldo**  
- **Depositar dinheiro**  
- **Sacar dinheiro**  
- **Transferir entre contas**  
- Todas as operações possuem validações e lançam exceções conforme especificado nos requisitos

---

## 🔧 Principais modificações em relação ao repositório original da Trybe

### 🟩 1. **Aplicação de console completa**
- O repositório original trazia apenas a classe `Trybank` para os testes automáticos.  
- Adicionei um **`Program.cs` completo** com menu interativo, leitura de entradas, parse e mensagens ao usuário, permitindo rodar o sistema pelo terminal.

### 🟩 2. **Correção da lógica de cadastro de contas**
- Ajustei a iteração sobre o array multidimensional:
  - Antes o código varria todas as 50 posições mesmo quando havia menos contas cadastradas.
  - Agora a busca por duplicatas usa `registeredAccounts` para limitar as iterações.
- Validação de conta duplicada corrigida.
- Inclusão correta dos dados na próxima linha livre do array.

### 🟩 3. **Melhorias na lógica de transferência**
- Validações implementadas:
  - Usuário logado
  - Saldo suficiente
  - Conta destino existente
- Atualização atômica do saldo (debita origem e credita destino).

### 🟩 4. **Melhorias gerais de código**
- Mensagens de menu mais claras.
- Mensagens de sucesso/erro mais informativas.
- Tratamento de entradas inválidas para evitar crashes.
- Nomes de variáveis e comentários para melhor manutenção.# TryBank – Console Banking System (Refactored Version)

This project is a refactored and expanded version of Trybe’s original **TryBank** assignment.  
The goal of the project is to simulate core banking operations using **C#** and an **in-memory multidimensional array**, without any data persistence.

This repository contains **significant modifications** compared to the original Trybe template, focusing on making the project fully executable in the console with a complete user flow.

---
ENGLISH VERSION
## 🚀 Features

### ✔ Implemented Requirements (Original Project)
- **Register accounts**  
- **Login / Logout system**  
- **Check balance**  
- **Deposit money**  
- **Withdraw money**  
- **Transfer to another account**  
- All operations validated with exceptions as required by the project specs

---

## 🔧 Major Modifications Compared to the Original Trybe Repository

### 🟩 1. **Full Console Application Added**
- The original project had no executable program — only the `Trybank` class for automated tests.  
- I created a **complete `Program.cs` with menu, prompts, input parsing, and user interactions**, allowing the whole banking system to run from the terminal.

### 🟩 2. **Corrected Account Registration Logic**
- Fixed the iteration over the multidimensional array:
  - Originally the loop scanned all 50 rows regardless of how many accounts existed.
  - Now it iterates only up to `registeredAccounts`.
- Ensured proper validation of **duplicate accounts**.
- Ensured new accounts are correctly inserted into the next available row.

### 🟩 3. **Transfer Logic Improved**
- Validation for:
  - Logged user  
  - Insufficient balance  
  - Destination account existence  
- Ensures atomic updates (value leaves origin and enters destination).

### 🟩 4. **General Code Improvements**
- Better menu text
- Clear success/error messages
- Ensured program doesn't crash on invalid input
- More readable variable names
