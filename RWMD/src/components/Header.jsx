export default function Header({ onSignIn, onSignUp }) {
    return (
        <header className="header">
            <div className="container nav">
                <a href="#top" className="brand" aria-label="FPT Aptech home">
                    <span className="fpt-logo">FPT</span>
                    <span className="aptech">Aptech</span>
                </a>

                <nav className="nav-menu">
                    <a href="#objects">About Us</a>
                    <a href="#subjects">Products</a>
                    <a href="#subjects">Booking</a>
                    <a href="#footer">Locations</a>
                </nav>

                <div className="nav-buttons">
                    <button className="btn btn-primary" onClick={onSignIn}>Sign In</button>
                    <button className="btn btn-outline" onClick={onSignUp}>Sign Up</button>
                </div>
            </div>
        </header>
    )
}