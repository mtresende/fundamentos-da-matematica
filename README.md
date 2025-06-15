# Trabalho de Fundamentos da Matemática

Aplicativo de console desenvolvido em C# como trabalho da disciplina de **Fundamentos da Matemática** da **PUC Minas**. O sistema oferece um menu interativo para realizar operações matemáticas fundamentais com base em vetores e geometria analítica.

## Funcionalidades

### 1. Distância entre Dois Pontos

Calcula a **distância** entre dois pontos no plano cartesiano.

**Fórmula:**

$$d = \sqrt{(x_2 - x_1)^2 + (y_2 - y_1)^2}$$

### 2. Equação da Reta

Calcula a **equação da reta** que passa por dois pontos, no formato $y = ax + b$.

**Fórmulas:**

- **Coeficiente angular ($a$):**

$$a = \frac{y_2 - y_1}{x_2 - x_1}$$

- **Coeficiente linear ($b$):**

$$b = y_1 - a \cdot x_1$$

### 3. Produto Vetorial

Calcula o **vetor resultante** do produto vetorial entre dois vetores tridimensionais.

**Fórmula:**

$$\mathbf{A} \times \mathbf{B} = (A_y \cdot B_z - A_z \cdot B_y, A_z \cdot B_x - A_x \cdot B_z, A_x \cdot B_y - A_y \cdot B_x)$$

### 4. Produto Escalar + Ângulo entre Vetores

Calcula o **produto escalar** entre dois vetores e o **ângulo entre eles**, permitindo interpretar se são ortogonais, paralelos ou oblíquos.

**Fórmulas:**

- **Produto escalar:**

$$\mathbf{A} \cdot \mathbf{B} = A_x \cdot B_x + A_y \cdot B_y + A_z \cdot B_z$$

- **Módulo (norma) dos vetores:**

$$|\mathbf{A}| = \sqrt{A_x^2 + A_y^2 + A_z^2}$$
$$|\mathbf{B}| = \sqrt{B_x^2 + B_y^2 + B_z^2}$$

- **Cosseno do ângulo:**

$$\cos(\theta) = \frac{\mathbf{A} \cdot \mathbf{B}}{|\mathbf{A}| \cdot |\mathbf{B}|}$$

- **Conversão para graus:**

$$\theta = \arccos(\cos(\theta)) \times \left(\frac{180}{\pi}\right)$$

## Contribuidores

- Lucas Gabriel
- Luiz Felipe
- Maíra Mendes
- Matheus Assunção
- Pedro Selvatici

## Instituição

PUC Minas — Pontifícia Universidade Católica de Minas Gerais  
Análise e Desenvolvimento de Sistemas </br>
Disciplina: Fundamentos da Matemática
