## Architectural Patterns & Design Patterns

This project demonstrates and/or references several software patterns commonly used in Unity and C# development:

- **Model-View-Presenter (MVP):** Separates presentation logic from UI. The Presenter mediates between the View (UI) and the Model (data/business logic).
- **Model-View-ViewModel (MVVM):** Uses a ViewModel to expose data and commands from the Model to the View, enabling two-way data binding and a reactive UI.
- **Observer:** Allows objects (observers) to subscribe to and receive updates from another object (subject) when its state changes (e.g., events for health changes).
- **Repository:** Provides a layer for data access, abstracting the data source and centralizing data logic.
- **Factory:** Encapsulates object creation logic, allowing for flexible instantiation of objects without specifying exact classes.
- **Builder:** Separates the construction of a complex object from its representation, allowing step-by-step creation.
- **Visitor:** Lets you define new operations on objects without changing their classes, by passing a visitor object to elements.
- **Chain of Responsibility (COR):** Passes requests along a chain of handlers, where each handler can process or pass the request further.

Each pattern is implemented or referenced in its own folder under `Assets/Scripts/`, with clear separation of concerns and example usage where applicable.