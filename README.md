# VIVE-MR-Unity-Template

A Unity template for developing Mixed Reality (MR) applications on **VIVE Focus Vision** and **VIVE XR Elite** devices.

## Overview

This repository provides a ready-to-use Unity project template that includes all the necessary configurations, settings, and components for developing Mixed Reality applications targeting VIVE Focus Vision and VIVE XR Elite devices. The template is built with Unity 2023.3 (6000.0.48f1) and includes:

- **Universal Render Pipeline (URP)** configuration optimized for MR applications
- **VIVE OpenXR** integration for seamless XR functionality
- **Passthrough capability** for mixed reality experiences
- **GitHub Actions** for automated Android builds
- **Pre-configured XR settings** for VIVE devices

## Features

- ✅ **Mixed Reality Support**: Full passthrough functionality for AR/MR experiences
- ✅ **VIVE Device Optimization**: Specifically configured for VIVE Focus Vision and VIVE XR Elite
- ✅ **Universal Render Pipeline**: Optimized rendering for mobile XR platforms
- ✅ **OpenXR Integration**: Standards-based XR development
- ✅ **Automated Builds**: GitHub Actions workflow for continuous integration
- ✅ **Ready-to-Use**: Minimal setup required to start developing

## Setup Instructions

For detailed setup instructions, please refer to the comprehensive guide on Qiita:

📖 **[VIVE MR Unity Template Setup Guide](https://qiita.com/afjk/items/f723f6dd2101f9b85905)**

### Quick Start

1. **Clone or Use This Template**
   ```bash
   git clone https://github.com/afjk/VIVE-MR-Unity-Template.git
   cd VIVE-MR-Unity-Template
   ```

2. **Open in Unity**
   - Open Unity Hub
   - Add the project folder
   - Open with Unity 2023.3 (6000.0.48f1) or compatible version

3. **Configure Build Settings**
   - Switch platform to Android
   - Configure XR settings for your target device
   - Build and deploy to your VIVE device

## GitHub Actions Automated Builds

This template includes GitHub Actions workflow for automated Android builds. The workflow:

- Triggers on pushes to the `main` branch
- Can be manually triggered from the Actions tab
- Builds APK/AAB files for Android deployment
- Uploads build artifacts for download

### Setting Up Automated Builds

If you want to use the automated build feature:

1. **Fork this repository** to your GitHub account
2. **Set up the following GitHub Secrets** in your repository settings:
   - `UNITY_LICENSE`: Your Unity license file content (.ulf)
   - `UNITY_EMAIL`: Your Unity account email
   - `UNITY_PASSWORD`: Your Unity account password

### Unity License File (.ulf) Requirements

To run Unity builds on GitHub Actions, you need a Unity license file (.ulf), even for Personal licenses. 

**Finding your Unity license file:**

- **Windows**: `C:\ProgramData\Unity\Unity_lic.ulf`
- **Mac**: `/Library/Application Support/Unity/Unity_lic.ulf`
- **Linux**: `~/.local/share/unity3d/Unity/Unity_lic.ulf`

For detailed instructions on obtaining and using Unity license files in CI/CD, refer to the official GameCI documentation:

📖 **[GameCI Unity Activation Guide](https://game.ci/docs/github/activation/)**

## Project Structure

```
VIVE-MR-Unity-Template/
├── Assets/
│   ├── PassthroughSetting/     # MR passthrough configuration
│   ├── Scenes/                 # Sample scenes
│   ├── Settings/               # URP and rendering settings
│   ├── VIVE/                   # VIVE-specific OpenXR components
│   └── XR/                     # XR configuration files
├── ProjectSettings/            # Unity project settings
├── .github/workflows/          # GitHub Actions workflows
└── README.md                   # This file
```

## Key Components

### Passthrough System
The template includes a `PassthroughSetter` component that handles:
- Planar passthrough creation
- Layer type management (Underlay/Overlay)
- Automatic passthrough initialization

### XR Configuration
- Pre-configured for VIVE OpenXR provider
- Optimized settings for VIVE Focus Vision and VIVE XR Elite
- Support for hand tracking and controller input

### Rendering Pipeline
- Universal Render Pipeline (URP) setup
- Mobile-optimized rendering settings
- Separate profiles for PC and mobile platforms

## Development Requirements

- **Unity Version**: 2023.3 (6000.0.48f1) or compatible
- **Target Platform**: Android
- **XR SDK**: OpenXR
- **Render Pipeline**: Universal Render Pipeline (URP)

## Target Devices

- **VIVE Focus Vision**
- **VIVE XR Elite**

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Contributing

Contributions are welcome! Please feel free to submit issues, feature requests, or pull requests.

## Support

For questions and support:
- Check the [setup guide](https://qiita.com/afjk/items/f723f6dd2101f9b85905) for detailed instructions
- Open an issue in this repository for bug reports or feature requests
- Refer to the [VIVE Developer Documentation](https://developer.vive.com/) for device-specific information

---

**Happy MR Development! 🥽✨**