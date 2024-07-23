# Midi2OSC - a small MIDI to OSC Bridge

## Overview

This tool serves as a bridge between a MIDI interface and OSC (Open Sound Control), acting as an OSC sender. Originally designed for use with Resonite, it can also be utilized with other platforms such as VRC and more.

The primary feature of this tool is its ability to collect statistics and transmit them over OSC, enabling this data to drive various elements within the game.

## Features

- Bridge between MIDI interface and OSC.
- Collects and transmits data over OSC.
- Originally created for Resonite but compatible with other platforms like VRC.
- Built with .NET 8, utilizing SharpOSC and NAudio.
- Creates and sends stats of the Midi messages to OSC like variance and frequency.
- Midi data is forwaeded to `/OSC/MIDI`
- Stats are send through `/OSC/MIDI_stats`

## Requirements

- [.NET 8 runtime](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)


## Requirements for building

- .NET 8 SDK
- Visual Studio or any other compatible .NET development environment

## Used Libraries

- [SharpOSC](https://github.com/ValdemarOrn/SharpOSC) (included as a submodule)
- [NAudio](https://github.com/naudio/NAudio) (provided via NuGet)

## Building the Tool

To build the tool, follow these steps:

1. **Clone the Repository**
    ```sh
    git clone https://github.com/yourusername/midi-to-osc-bridge.git
    cd midi-to-osc-bridge
    git submodule update --init --recursive
    ```

2. **Restore NuGet Packages**
    ```sh
    dotnet restore
    ```

3. **Build the Application**
    ```sh
    dotnet build
    ```

## Download

You can download the latest release from the [Release Page](https://github.com/Rixx-vr/midi2OSC/releases).

## Outlook

We are actively working on supporting macOS and Linux. Stay tuned for future updates!

## License

This project is licensed under the MIT License. See the [LICENSE](https://github.com/Rixx-vr/midi2OSC/blob/main/LICENSE) file for details.

---

Feel free to reach out for any questions or contributions. Your feedback is appreciated!