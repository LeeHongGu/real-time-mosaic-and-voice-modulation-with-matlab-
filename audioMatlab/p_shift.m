%[audioIn,fs] = audioread('audiorec_001.flac');
[audioIn,fs] = audioDeviceReader;
win = kbdwin(512);
overlapLength = 0.75*numel(win);

S = stft(audioIn, ...
    "Window",win, ...
    "OverlapLength",overlapLength, ...
    "Centered",false);

nsemitones = 0;
lockPhase = false;
audioOut = shiftPitch(S,nsemitones, ...
                     "Window",win, ...
                     "OverlapLength",overlapLength, ...
                     "LockPhase",lockPhase);

sound(audioOut,fs)