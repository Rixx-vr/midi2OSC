## Initial commit

- Bridge between MIDI interface and OSC.
- Collects and transmits data over OSC.
- Originally created for Resonite but compatible with other platforms like VRC.
- Built with .NET 8, utilizing SharpOSC and NAudio.
- Creates and sends stats of the Midi messages to OSC like variance and frequency.
- Midi data is forwaeded to `/OSC/MIDI`
- Stats are send through `/OSC/MIDI_stats`