export default function SubjectCard({ subject }) {
    return (
        <article className="subject-card">
            <div className={`subject-icon ${subject.className}`}>
                <span>{subject.icon}</span>
            </div>
            <h3>{subject.name}</h3>
            <p>{subject.description}</p>
        </article>
    )
}