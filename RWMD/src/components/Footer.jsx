export default function Footer() {
    return (
        <footer className="footer" id="footer">
            <div className="container footer-main">
                <div>
                    <a href="#top" className="footer-logo">
                        <span>FPT</span> Aptech
                    </a>
                    <p>Learn programming. Build your future.</p>
                </div>

                <div className="footer-column">
                    <h4>PROGRAMS</h4>
                    <a href="#subjects">ReactJS</a>
                    <a href="#subjects">PHP</a>
                    <a href="#subjects">Python</a>
                </div>

                <div className="footer-column">
                    <h4>SUPPORT</h4>
                    <a href="#objects">Learning paths</a>
                    <a href="#subjects">Courses</a>
                    <a href="#top">Back to top ↑</a>
                </div>
            </div>

            <div className="copyright">
                © 2026 FPT Aptech Demo — ReactJS Assignment
            </div>
        </footer>
    )
}