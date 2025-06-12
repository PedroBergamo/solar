# Solar – Newtonian Solar System Simulation in Unity

**Solar** is a real-time 3D simulation of the Solar System built with Unity, showcasing planetary motion using Newtonian gravity and basic N-body dynamics. This educational and interactive project emphasizes physical accuracy and modular design, making it suitable for both learning and scientific exploration.

## Controls

- **WASD** — Move the camera  
- **Q / E** — Speed boost up/down  
- **Mouse** — Look/rotate

## Features

- Simulates the Sun, Moon, and all major planets using Newtonian gravity
- Real-world parameters: mass, distance, orbital velocity, and scaling
- Stable time integration (velocity-based)
- Modular system architecture, designed for easy extension (e.g., moons, asteroids)
- Intuitive 3D camera navigation and scaling
- Clean, well-organized C# code separating physics and visualization logic

## Download

🔗 [Download Solar.zip (Windows Build)](https://drive.google.com/file/d/1IDQ_uGrbEmyiUIKClvzYYTf1DLAR1tKI/view?usp=sharing)

Unzip and run `Solar.exe` to launch the simulation. No installation required.

>  Built and tested on **Windows 10** using **Unity 6000.040f1**

## Technical Stack

- **Unity 6000.040f1**
- **C#** with MonoBehaviour-based physics loop
- Newtonian gravitational physics with distance scaling
- Lightweight, extensible structure for experimentation or research applications

## Future Work

- **Moons**: Not yet included due to their complex perturbative effects on orbital stability  
- **Mercury**: Its orbit currently breaks due to lack of relativistic corrections (required for accurate precession modeling)

## Contact

For questions, feedback, or collaboration:

**Pedro Bergamo**  
📧 pedrobergamo89(at)gmail.com  