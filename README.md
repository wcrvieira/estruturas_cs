# Estruturas de repetição
Algoritmos com estruturas de repetição .Net e C Sharp no modo console
<img width="1291" height="615" alt="image" src="https://github.com/user-attachments/assets/6acebe0d-7ad8-47ed-b663-a0eceff2672b" />

graph TD
    Centro((🧠 ESTRUTURAS DE<br>CONTROLE EM C#))
    
    %% RAMO CONDICIONAIS
    Centro --> Condicionais[⚡ TOMADA DE DECISÃO<br>Condicionais]
    
    Condicionais --> IF["🟢 IF (Se...)"]
    IF -->|True| B1[Executa o Bloco Principal]
    
    Condicionais --> ELSE["🔴 ELSE (Senão...)"]
    ELSE -->|False| B2[Plano B / Caminho Padrão]
    
    Condicionais --> SWITCH["🎮 SWITCH (Escolha...)"]
    SWITCH -->|Casos Fixos| B3[Menus, Teclas W-A-S-D, Inventário]

    %% RAMO REPETIÇÕES
    Centro --> Repeticoes[🔄 AUTOMAÇÃO DE TAREFAS<br>Loops / Laços]
    
    Repeticoes --> FOR["🎯 FOR (Para...)"]
    FOR -->|Variável Controladora| R1[Sabe o limite exato<br>Ex: Carregar 5 posts]
    
    Repeticoes --> WHILE["⏳ WHILE (Enquanto...)"]
    WHILE -->|Condição Inicial| R2[Fim indeterminado<br>Ex: Game Loop ativo]
    
    Repeticoes --> DOWHILE["🔁 DO... WHILE (Faça...)"]
    DOWHILE -->|Validação Tardia| R3[Roda pelo menos 1 vez<br>Ex: Menu de Opções]

    %% ESTILOS NEON (Moderna/Dev)
    style Centro fill:#22d3ee,stroke:#0f172a,stroke-width:3px,color:#0f172a,font-weight:bold
    style Condicionais fill:#c026d3,stroke:#fff,color:#fff,font-weight:bold
    style Repeticoes fill:#34d399,stroke:#fff,color:#fff,font-weight:bold
    style IF fill:#1e293b,stroke:#34d399,color:#34d399
    style ELSE fill:#1e293b,stroke:#f43f5e,color:#f43f5e
    style SWITCH fill:#1e293b,stroke:#22d3ee,color:#22d3ee
    style FOR fill:#1e293b,stroke:#a855f7,color:#a855f7
    style WHILE fill:#1e293b,stroke:#eab308,color:#eab308
    style DOWHILE fill:#1e293b,stroke:#3b82f6,color:#3b82f6
