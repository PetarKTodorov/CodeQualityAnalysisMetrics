# CyclomaticComplexity

## Описание:
Цикломатичната сложност ни помага чрез измерване на сложността на кода. 
Показателят за цикломатична сложност е доста важен, защото ще бъде изчислен на ниво метод. 
Така разработчиците могат лесно да идентифицират сложността на кода и рисковите фактори на ниво метод.

## Причина:
С разписването на логиката в проверките сложността на метода ще се вдигне значително. 
SonarLint ни показва, че трябва да поддържаме нивото на CyclomaticComplexity ниско, за да бъде кодът ни по-лесен за поддръжка.
На снимката по-долу може да се види, че комплексността на метода без логиката в него е 8.

![alt-text](https://github.com/PetarKTodorov/CodeQualityAnalysisMetrics/blob/main/CodeQualityAnalysisMetrics/P05.CyclomaticComplexity/images/problem.png)

## Решение:
След като разпределим логиката в различни методи, можем да видим, че комплексността на конкретният метод "RegisterUser" е паднала до 2.

![alt-text](https://github.com/PetarKTodorov/CodeQualityAnalysisMetrics/blob/main/CodeQualityAnalysisMetrics/P05.CyclomaticComplexity/images/solution.png)