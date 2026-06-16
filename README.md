# WPF Diagramming Samples (`wpf-diagram-samples`)

A comprehensive collection of C# WPF (Windows Presentation Foundation) sample applications demonstrating the features, capabilities, and layout algorithms of the **MindFusion.Diagramming for WPF** control suite.

All sample projects in this repository have been fully modernized to reference the official **[MindFusion.Diagramming.Wpf](https://www.nuget.org/packages/MindFusion.Diagramming.Wpf/) NuGet package** directly rather than referencing local files. This enables automatic package restore and seamless out-of-the-box building.

---

## 🚀 Key Features Demonstrated

This repository contains over **40 individual sample applications**, covering a wide array of diagramming and graphing use cases:

*   **Automatic Layouts:** Annealing, Layered, Hierarchical, Tree, Fractal, Spring, Decision, Process, and Cluster layout algorithms.
*   **Custom Templates & Styles:** Custom templated nodes, HTML-like text formatting, icon-based nodes, and comprehensive UI styling.
*   **WPF-Specific Enhancements:** Built-in Magnifier control, Zoom & Overview controls, Control Hosting, virtualization for high-performance diagrams, and interactive animations.
*   **Interactive Design:** Custom anchors, lane/swimlane diagrams, decision flowcharts, class diagram explorers, routing engines, sequence diagrams, and ternary/stress test setups.

---

## 🛠️ Getting Started

### Prerequisites
*   **IDE:** Visual Studio 2022, 2026, or newer.
*   **Framework:** .NET Framework 8 SDK/Runtime.
*   **Package Manager:** NuGet (integrated natively into Visual Studio).

### How to Build & Run
1.  **Clone the Repository:**
    ```bash
    git clone https://github.com/MindFusionComponents/wpf-diagram-samples.git
    cd wpf-diagram-samples
    ```
2.  **Open a Sample:**
    *   Navigate to any sample folder (e.g., `Routing`, `OrgChartEditor`, or `DecisionLayout`).
    *   Double-click the `.sln` or `.csproj` file to open it in Visual Studio.
3.  **Restore NuGet Packages:**
    *   When you build or debug the project, Visual Studio will automatically restore the missing `MindFusion.Diagramming.Wpf` package and its dependencies.
4.  **Run:**
    *   Press `F5` or click **Start** in Visual Studio to compile and run the sample!

---

## 📂 Repository Structure

Each sample is contained in its own folder:

*   📂 **`AnchorPoints/`** — Interactive custom connection points on nodes.
*   📂 **`DecisionLayout/`** — Decision trees and flowchart layout routing.
*   📂 **`Demo/`** — The comprehensive master demo showcase containing all core features.
*   📂 **`Lanes/`** — Multi-swimlane processes and timeline maps.
*   📂 **`OrgChartEditor/`** — Dynamic organizational charts with employee cards.
*   📂 **`TreeLayout/`** — Hierarchical parent-child organizational layouts.
*   *(And dozens of other specialized layout and functional folders!)*

---

## 📄 License and Product Info

*   These samples are designed to work with **MindFusion.Diagramming for WPF**.
*   For product documentation, licensing, or evaluation licenses, visit the [MindFusion Official Website](https://mindfusion.dev) and [WPF Diagram Product Page](https://mindfusion.dev/wpf-diagram.html).
