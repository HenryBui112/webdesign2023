export default function LoginModal({ type, onClose }) {
    const isSignIn = type === 'signin'

    return (
        <div className="modal-backdrop" onClick={onClose}>
            <div className="modal" onClick={(event) => event.stopPropagation()}>
                <button className="modal-close" onClick={onClose} aria-label="Close">×</button>
                <div className="modal-logo"><span>FPT</span> Aptech</div>
                <h2>{isSignIn ? 'Sign In' : 'Sign Up'}</h2>
                <p>{isSignIn ? 'Welcome back.' : 'Create your demo account.'}</p>

                {!isSignIn && <input type="text" placeholder="Full name" />}
                <input type="email" placeholder="Email address" />
                <input type="password" placeholder="Password" />

                <button className="modal-submit">
                    {isSignIn ? 'SIGN IN' : 'CREATE ACCOUNT'}
                </button>
            </div>
        </div>
    )
}