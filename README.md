# PREFINALS_DANGARAN_FERDINANDII
 
Conceptual Understanding:
Onion Architecture (Yes): Yes.
MVC Pattern (Yes): Yes, I understand the Model-View-Controller (MVC) pattern.
Web API (Yes): No.

Application & Bottlenecks:
Onion Architecture:

Benefits: Onion Architecture promotes clean separation of concerns by isolating the core domain logic from external dependencies. This makes code easier to test and maintain, with loose coupling allowing for independent development and deployment of different layers.

Bottlenecks: It might require more upfront planning and understanding compared to simpler architectures.

MVC:

Components (Model, View, Controller):

Model: Represents the application data and business logic.
View: Handles how data is presented to the user (e.g., web page).
Controller: Receives user input, interacts with the Model, and updates the View.
Bottlenecks: Tight coupling between Model and Controller can occur. Changes in business logic (Model) might ripple through the Controller, making testing and maintenance harder.

Web API:

Differences from MVC (Yes): Both involve handling user requests, but:

MVC Applications: Designed for full web pages with user interaction and frequent refreshes.
Web APIs: Provide lightweight, data-centric services for other applications to consume (e.g., mobile apps, other web services).
Bottlenecks (Yes, Performance Overhead): Traditional MVC applications with frequent page refreshes can have performance overhead. Web APIs offer a more efficient approach for complex data exchange.
