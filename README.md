# Payment Processing System with SOLID Principles in C#

This repository contains a simple payment processing system implemented in C# that demonstrates the application of SOLID principles. The payment system supports multiple payment methods and follows key design principles to ensure maintainability, flexibility, and ease of extension.

## SOLID Principles Applied

### Single Responsibility Principle (SRP)
The Single Responsibility Principle suggests that a class should have only one reason to change. In our payment processing system, each payment method adheres to this principle by encapsulating its own logic and responsibility for processing payments. For instance, the `CreditCardPayment` class is responsible for credit card payment processing, while the `PayPalPayment` class handles PayPal payments. The `PaymentProcessor` class respects SRP by focusing on coordinating payments without being responsible for the specific details of each payment method.

### Open/Closed Principle (OCP)
The Open/Closed Principle encourages software entities to be open for extension but closed for modification. Our design exemplifies this principle by allowing the addition of new payment methods without altering existing classes. When a new payment method is introduced (e.g., `BankTransferPayment`), it can extend the base `PaymentMethod` class or interface and be seamlessly integrated into the system without changing existing payment processing logic. The `Program` class showcases this by demonstrating the addition of new payment methods to the existing payment processing flow without any changes.

### Liskov Substitution Principle (LSP)
The Liskov Substitution Principle states that objects of a superclass should be replaceable with objects of its subclasses without affecting program correctness. Our payment processing system adheres to this principle by ensuring that derived payment methods (e.g., `CreditCardPayment`, `PayPalPayment`) can be used interchangeably with the base `PaymentMethod` class. This property facilitates the extension of the system with new payment methods without introducing unexpected behavior.

### Interface Segregation Principle (ISP)
The Interface Segregation Principle asserts that clients should not be forced to depend on interfaces they do not use. In our design, each payment method interface (e.g., `IPaymentGateway`) contains methods relevant only to that specific payment method. This approach allows classes to implement only the interfaces necessary for their functionality, preventing unnecessary dependencies. For instance, the `CreditCardPayment` class implements only the `IPaymentGateway` methods related to credit card payments.

### Dependency Inversion Principle (DIP)
The Dependency Inversion Principle emphasizes that high-level modules should not depend on low-level modules; both should depend on abstractions. In our payment system, the `PaymentProcessor` class depends on abstractions like `PaymentMethod` and `IPaymentGateway`, rather than concrete implementations. This promotes decoupling and ensures that changes to low-level modules (payment methods) do not affect the high-level module (payment processor). This abstraction facilitates extension and maintenance.

## Classes and Interfaces

- **IPaymentGateway**: Defines an interface for payment gateways, providing methods for processing payments.

- **PaymentMethod**: Provides a base class for payment methods to inherit from, encapsulating common behavior.

- **CreditCardPayment**, **PayPalPayment**: Implement the `IPaymentGateway` interface, representing specific payment methods with their own processing logic.

- **PaymentProcessor**: Coordinates the payment processing flow, accepting a list of payment methods and executing payments.

## Getting Started

1. Clone this repository to your local machine.

2. Open the solution in your preferred C# development environment (Visual Studio, Visual Studio Code, etc.).

3. Explore the codebase to understand the implementation of SOLID principles in the payment processing system.

4. Build and run the project to see the payment processing system in action.

## Usage

1. Create instances of payment methods, such as `CreditCardPayment` or `PayPalPayment`.

2. Create a `PaymentProcessor` instance, passing a list of payment methods.

3. Use the `PaymentProcessor`'s methods to process payments.

```csharp
var creditCardPayment = new CreditCardPayment("John Doe", "1234-5678-9012-3456", "123", DateTime.Now.AddYears(2));
var payPalPayment = new PayPalPayment("example@example.com", "password123");

var paymentMethods = new List<IPaymentGateway> { creditCardPayment, payPalPayment };
var paymentProcessor = new PaymentProcessor(paymentMethods);

paymentProcessor.ProcessPayments(100.00);
```

## Contributing

Contributions to enhance the example or improve the README are welcome! Please follow standard GitHub practices and guidelines when contributing.

## License

This project is licensed under the [MIT License](LICENSE.txt).

---

Feel free to use and modify this repository as a learning resource for SOLID principles and their application in C#. If you have any questions or suggestions, please feel free to [open an issue](https://github.com/JCGaytan/SOLIDConcepts/issues).

# Spanish
---

# Sistema de Procesamiento de Pagos con Principios SOLID en C#

Este repositorio contiene un sistema simple de procesamiento de pagos implementado en C# que demuestra la aplicación de los principios SOLID. El sistema de pagos admite múltiples métodos de pago y sigue principios de diseño clave para garantizar la mantenibilidad, flexibilidad y facilidad de extensión.

## Principios SOLID Aplicados

### Principio de Responsabilidad Única (SRP)
El Principio de Responsabilidad Única sugiere que una clase debe tener solo una razón para cambiar. En nuestro sistema de procesamiento de pagos, cada método de pago se adhiere a este principio encapsulando su propia lógica y responsabilidad para procesar los pagos. Por ejemplo, la clase `CreditCardPayment` es responsable del procesamiento de pagos con tarjeta de crédito, mientras que la clase `PayPalPayment` maneja los pagos de PayPal. La clase `PaymentProcessor` respeta el SRP al enfocarse en coordinar los pagos sin ser responsable de los detalles específicos de cada método de pago.

### Principio de Abierto/Cerrado (OCP)
El Principio de Abierto/Cerrado anima a las entidades de software a estar abiertas para la extensión pero cerradas para la modificación. Nuestro diseño ejemplifica este principio al permitir la adición de nuevos métodos de pago sin alterar las clases existentes. Cuando se introduce un nuevo método de pago (por ejemplo, `BankTransferPayment`), puede extender la clase o interfaz base `PaymentMethod` e integrarse perfectamente en el sistema sin cambiar la lógica existente de procesamiento de pagos. La clase `Program` muestra esto al demostrar la adición de nuevos métodos de pago al flujo existente de procesamiento de pagos sin realizar cambios.

### Principio de Sustitución de Liskov (LSP)
El Principio de Sustitución de Liskov establece que los objetos de una superclase deben ser reemplazables por objetos de sus subclases sin afectar la corrección del programa. Nuestro sistema de procesamiento de pagos cumple con este principio al garantizar que los métodos de pago derivados (por ejemplo, `CreditCardPayment`, `PayPalPayment`) puedan usarse de manera intercambiable con la clase base `PaymentMethod`. Esta propiedad facilita la extensión del sistema con nuevos métodos de pago sin introducir comportamientos inesperados.

### Principio de Segregación de Interfaces (ISP)
El Principio de Segregación de Interfaces afirma que los clientes no deben depender de interfaces que no utilizan. En nuestro diseño, cada interfaz de método de pago (por ejemplo, `IPaymentGateway`) contiene métodos relevantes solo para ese método de pago específico. Este enfoque permite que las clases implementen solo las interfaces necesarias para su funcionalidad, evitando dependencias innecesarias. Por ejemplo, la clase `CreditCardPayment` implementa solo los métodos de `IPaymentGateway` relacionados con los pagos con tarjeta de crédito.

### Principio de Inversión de Dependencia (DIP)
El Principio de Inversión de Dependencia enfatiza que los módulos de alto nivel no deben depender de los módulos de bajo nivel; ambos deben depender de abstracciones. En nuestro sistema de pagos, la clase `PaymentProcessor` depende de abstracciones como `PaymentMethod` e `IPaymentGateway`, en lugar de implementaciones concretas. Esto promueve el desacoplamiento y asegura que los cambios en los módulos de bajo nivel (métodos de pago) no afecten al módulo de alto nivel (procesador de pagos). Esta abstracción facilita la extensión y el mantenimiento.

## Clases e Interfaces

- **IPaymentGateway**: Define una interfaz para pasarelas de pago, proporcionando métodos para procesar pagos.

- **PaymentMethod**: Proporciona una clase base para que los métodos de pago hereden, encapsulando comportamientos comunes.

- **CreditCardPayment**, **PayPalPayment**: Implementan la interfaz `IPaymentGateway`, representando métodos de pago específicos con su propia lógica de procesamiento.

- **PaymentProcessor**: Coordina el flujo de procesamiento de pagos, acepta una lista de métodos de pago y ejecuta los pagos.

## Comenzando

1. Clona este repositorio en tu máquina local.

2. Abre la solución en tu entorno de desarrollo C# preferido (Visual Studio, Visual Studio Code, etc.).

3. Explora el código para entender la implementación de los principios SOLID en el sistema de procesamiento de pagos.

4. Compila y ejecuta el proyecto para ver el sistema de procesamiento de pagos en acción.

## Uso

1. Crea instancias de métodos de pago, como `CreditCardPayment` o `PayPalPayment`.

2. Crea una instancia de `PaymentProcessor`, pasando una lista de métodos de pago.

3. Usa los métodos de `PaymentProcessor` para procesar pagos.

```csharp
var creditCardPayment = new CreditCardPayment("John Doe", "1234-5678-9012-3456", "123", DateTime.Now.AddYears(2));
var payPalPayment = new PayPalPayment("example@example.com", "password123");

var paymentMethods = new List<IPaymentGateway> { creditCardPayment, payPalPayment };
var paymentProcessor = new PaymentProcessor(paymentMethods);

paymentProcessor.ProcessPayments(100.00);
```

## Contribuciones

¡Se aceptan contribuciones para mejorar el ejemplo o el README! Por favor, sigue las prácticas y pautas estándar de GitHub al contribuir.

## Licencia

Este proyecto está bajo la [Licencia MIT](LICENSE.txt).

---

Siéntete libre de usar y modificar este repositorio como recurso de aprendizaje para los principios SOLID y su aplicación en C#. Si tienes preguntas o sugerencias, no dudes en [abrir un problema](https://github.com/JCGaytan/SOLIDConcepts/issues).

# Français
---

# Système de Traitement des Paiements avec les Principes SOLID en C#

Ce référentiel contient un système simple de traitement des paiements implémenté en C# qui démontre l'application des principes SOLID. Le système de paiement prend en charge plusieurs méthodes de paiement et suit des principes de conception clés pour assurer la maintenabilité, la flexibilité et la facilité d'extension.

## Principes SOLID Appliqués

### Principe de Responsabilité Unique (SRP)
Le Principe de Responsabilité Unique suggère qu'une classe ne doit avoir qu'une seule raison de changer. Dans notre système de traitement des paiements, chaque méthode de paiement adhère à ce principe en encapsulant sa propre logique et sa responsabilité pour le traitement des paiements. Par exemple, la classe `CreditCardPayment` est responsable du traitement des paiements par carte de crédit, tandis que la classe `PayPalPayment` gère les paiements PayPal. La classe `PaymentProcessor` respecte le SRP en se concentrant sur la coordination des paiements sans être responsable des détails spécifiques de chaque méthode de paiement.

### Principe Ouvert/Fermé (OCP)
Le Principe Ouvert/Fermé encourage les entités logicielles à être ouvertes à l'extension mais fermées à la modification. Notre conception illustre ce principe en permettant l'ajout de nouvelles méthodes de paiement sans altérer les classes existantes. Lorsqu'une nouvelle méthode de paiement est introduite (par exemple, `BankTransferPayment`), elle peut étendre la classe ou l'interface de base `PaymentMethod` et s'intégrer parfaitement dans le système sans modifier la logique existante de traitement des paiements. La classe `Program` montre cela en démontrant l'ajout de nouvelles méthodes de paiement au flux existant de traitement des paiements sans effectuer de modifications.

### Principe de Substitution de Liskov (LSP)
Le Principe de Substitution de Liskov stipule que les objets d'une superclasse doivent pouvoir être remplacés par des objets de ses sous-classes sans affecter la correction du programme. Notre système de traitement des paiements respecte ce principe en veillant à ce que les méthodes de paiement dérivées (par exemple, `CreditCardPayment`, `PayPalPayment`) puissent être utilisées de manière interchangeable avec la classe de base `PaymentMethod`. Cette propriété facilite l'extension du système avec de nouvelles méthodes de paiement sans introduire de comportement inattendu.

### Principe de Ségrégation des Interfaces (ISP)
Le Principe de Ségrégation des Interfaces affirme que les clients ne doivent pas être contraints de dépendre d'interfaces qu'ils n'utilisent pas. Dans notre conception, chaque interface de méthode de paiement (par exemple, `IPaymentGateway`) contient des méthodes pertinentes uniquement pour cette méthode de paiement spécifique. Cette approche permet aux classes d'implémenter uniquement les interfaces nécessaires à leur fonctionnalité, évitant ainsi les dépendances inutiles. Par exemple, la classe `CreditCardPayment` implémente uniquement les méthodes de `IPaymentGateway` liées aux paiements par carte de crédit.

### Principe d'Inversion de Dépendance (DIP)
Le Principe d'Inversion de Dépendance met l'accent sur le fait que les modules de haut niveau ne doivent pas dépendre des modules de bas niveau ; les deux doivent dépendre d'abstractions. Dans notre système de paiement, la classe `PaymentProcessor` dépend d'abstractions telles que `PaymentMethod` et `IPaymentGateway`, plutôt que d'implémentations concrètes. Cela favorise le découplage et garantit que les modifications apportées aux modules de bas niveau (méthodes de paiement) n'affectent pas le module de haut niveau (processeur de paiement). Cette abstraction facilite l'extension et la maintenance.

## Classes et Interfaces

- **IPaymentGateway** : Définit une interface pour les passerelles de paiement, fournissant des méthodes pour le traitement des paiements.

- **PaymentMethod** : Fournit une classe de base à partir de laquelle les méthodes de paiement peuvent hériter, encapsulant les comportements communs.

- **CreditCardPayment**, **PayPalPayment** : Implémentent l'interface `IPaymentGateway`, représentant des méthodes de paiement spécifiques avec leur propre logique de traitement.

- **PaymentProcessor** : Coordonne le flux de traitement des paiements, accepte une liste de méthodes de paiement et exécute les paiements.

## Pour Commencer

1. Clonez ce référentiel sur votre machine locale.

2. Ouvrez la solution dans votre environnement de développement C# préféré (Visual Studio, Visual Studio Code, etc.).

3. Explorez le code pour comprendre la mise en œuvre des principes SOLID dans le système de traitement des paiements.

4. Compilez et exécutez le projet pour voir le système de traitement des paiements en action.

## Utilisation

1. Créez des instances de méthodes de paiement, telles que `CreditCardPayment` ou `PayPalPayment`.

2. Créez une instance de `PaymentProcessor`, en passant une liste de méthodes de paiement.

3. Utilisez les méthodes de `PaymentProcessor` pour traiter les paiements.

```csharp
var creditCardPayment = new CreditCardPayment("John Doe", "1234-5678-9012-3456", "123", DateTime.Now.AddYears(2));
var payPalPayment = new PayPalPayment("example@example.com", "password123");

var paymentMethods = new List<IPaymentGateway> { creditCardPayment, payPalPayment };
var paymentProcessor = new PaymentProcessor(paymentMethods);

paymentProcessor.ProcessPayments(100.00);
```

## Contribution

Les contributions visant à améliorer l'exemple ou le README sont les bienvenues ! Veuillez suivre les pratiques et directives standard de GitHub pour contribuer.

## Licence

Ce projet est sous licence [Licence MIT](LICENSE).

---

N'hésitez pas à utiliser et à modifier ce référentiel comme ressource d'apprentissage pour les principes SOLID et leur application en C#. Si vous avez des questions ou des suggestions, n'hésitez pas à [ouvrir un problème](https://github.com/JCGaytan/SOLIDConcepts/issues).
