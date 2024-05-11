import librosa
import music21
import sys

def frequency_to_note_name(frequency):
    note = music21.pitch.Pitch()
    note.frequency = frequency
    note_name = note.nameWithOctave
    note_name = note_name.replace('-', '').replace('`', '').replace('~','')
    return note_name

def time_to_note_duration(duration, qtrN, wholeN, halfN, eighthN, sixteenN, thirtyTwoN, sixtyFourN, sixN, twelveN, twentyFourN):
    durations = {
        "wholeN": abs(duration - wholeN),
        "halfN": abs(duration - halfN),
        "qtrN": abs(duration - qtrN),
        "eighthN": abs(duration - eighthN),
        "sixteenN": abs(duration - sixteenN),
        "thirtyTwoN": abs(duration - thirtyTwoN),
        "sixtyFourN": abs(duration - sixtyFourN),
        "sixN": abs(duration - sixN),
        "twelveN": abs(duration - twelveN),
        "twentyFourN": abs(duration - twentyFourN)
    }
    closest_note = min(durations, key=durations.get)
    return closest_note

def process_audio(file_path, tempo):
    y, sr = librosa.load(file_path)
    pitches, magnitudes = librosa.piptrack(y=y, sr=sr)
    onset_frames = librosa.onset.onset_detect(y=y, sr=sr)
    onset_times = librosa.frames_to_time(onset_frames, sr=sr)

    qtrN = 60000 / tempo #nốt đen
    wholeN = qtrN * 4 #Nốt tròn
    halfN = qtrN * 2 #Nốt trắng
    eighthN = qtrN / 2 #Nốt móc đơn
    sixteenN = qtrN / 4 #Nốt móc kép
    thirtyTwoN = qtrN / 8
    sixtyFourN = qtrN / 16
    sixN = wholeN / 6
    twelveN = wholeN / 12
    twentyFourN = wholeN / 24

    notes = []
    for i in range(len(onset_times) - 1):
        start_time = onset_times[i]
        end_time = onset_times[i + 1]
        duration = (end_time - start_time) * 1000  # Convert to milliseconds

        index = magnitudes[:, onset_frames[i]].argmax()
        frequency = pitches[index, onset_frames[i]]
        if frequency > 0:
            note = frequency_to_note_name(frequency)
            note_duration = time_to_note_duration(duration, qtrN, wholeN, halfN, eighthN, sixteenN, thirtyTwoN, sixtyFourN, sixN, twelveN, twentyFourN)
            notes.append((note, note_duration))

    output_file_path = r'D:\Study\STUdied\Kien truc may tinh\CUOI_Ky_Thuc_Tap\CUOI_KY\notes_Music.txt'

    with open(output_file_path, 'w') as f:
        f.write("bai1, phat\n")
        for note, duration in notes:
            
            f.write(f"{note}, {duration}\n")

    print(f"Notes saved to {output_file_path}")

def main():
    if len(sys.argv) > 1:
        file_path = sys.argv[1]
        process_audio(file_path, tempo=110)  # Giả sử tempo là 120 BPM

if __name__ == "__main__":
    main()



